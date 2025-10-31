using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Front
{
    internal class pay
    {
        public class Pague
        {
            public int IdPagamento { get; set; }
            public int id_reserva { get; set; }
            public string NomeHospede { get; set; }
            public decimal ValorTotal { get; set; }
            public string FormaPagamento { get; set; }
            public string StatusPagamento { get; set; }

            // Lista todos os pagamentos com dados da reserva e hóspede
            public static List<Pague> ListarPagamentos()
            {
                List<Pague> lista = new List<Pague>();

                using (MySqlConnection conexaoSQL = new MySqlConnection(conexao.stringConexao))
                {
                    conexaoSQL.Open();

                    string comSql = @"
                        SELECT 
                            pagamentos.id_pagamentos,
                            pagamentos.id_reserva,
                            hospedes.nome AS nome_hospede,
                            reservas.valor_total,
                            reservas.forma_pagamento,
                            pagamentos.status_pagamento
                        FROM pagamentos
                        INNER JOIN reservas ON pagamentos.id_reserva = reservas.id_reserva
                        INNER JOIN hospedes ON reservas.id_hospedes = hospedes.id_hospedes;";

                    using (MySqlCommand comando = new MySqlCommand(comSql, conexaoSQL))
                    using (MySqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Pague
                            {
                                IdPagamento = Convert.ToInt32(reader["id_pagamentos"]),
                                id_reserva = Convert.ToInt32(reader["id_reserva"]),
                                NomeHospede = reader["nome_hospede"].ToString(),
                                ValorTotal = Convert.ToDecimal(reader["valor_total"]),
                                FormaPagamento = reader["forma_pagamento"].ToString(),
                                StatusPagamento = reader["status_pagamento"].ToString()
                            });
                        }
                    }
                }

                return lista;
            }

            // Atualiza o status de pagamento e a forma de pagamento
            public static void ConfirmarPagamento(int idReserva, string formaPagamento, decimal valor)
            {
                using (MySqlConnection conexaoSQL = new MySqlConnection(conexao.stringConexao))
                {
                    conexaoSQL.Open();

                    // Atualiza reserva
                    string atualizarReserva = @"
                        UPDATE reservas 
                        SET forma_pagamento = @forma, valor_total = @valor 
                        WHERE id_reserva = @id;";

                    using (MySqlCommand comando = new MySqlCommand(atualizarReserva, conexaoSQL))
                    {
                        comando.Parameters.AddWithValue("@forma", formaPagamento);
                        comando.Parameters.AddWithValue("@valor", valor);
                        comando.Parameters.AddWithValue("@id", idReserva);
                        comando.ExecuteNonQuery();
                    }

                    // Atualiza status do pagamento
                    string atualizarPagamento = @"
                        UPDATE pagamentos 
                        SET status_pagamento = 'Pago' 
                        WHERE id_reserva = @id;";

                    using (MySqlCommand comando = new MySqlCommand(atualizarPagamento, conexaoSQL))
                    {
                        comando.Parameters.AddWithValue("@id", idReserva);
                        comando.ExecuteNonQuery();
                    }
                }
            }
        }
    }
    }

