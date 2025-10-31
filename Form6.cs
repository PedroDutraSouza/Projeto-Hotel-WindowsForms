using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

// Usings necessários (do código anterior)
using Caribe_Pallace;
using QuestPDF.Fluent;
using QuestPDF.Infrastructure;
using System.IO;
using System.Diagnostics;

namespace Hotel.Front
{
    public partial class Form6 : Form
    {
        // Mantemos estes para o método Listar()
        private readonly MySqlConnection con = new MySqlConnection(conexao.stringConexao);
        private readonly DataTable tabela = new DataTable();

        public Form6()
        {
            InitializeComponent();
            QuestPDF.Settings.License = LicenseType.Community;
            Listar();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void dataGridViewComprovante_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // ...
        }

        // --- MÉTODO button1_Click ATUALIZADO ---
        private void button1_Click(object sender, EventArgs e)
        {
            // 1. Verificar se uma linha está selecionada
            if (dgvComprovante.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecione uma reserva na lista para gerar o comprovante.",
                                "Nenhuma Reserva Selecionada",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            RelatorioReservaModel model = null;
            int idReserva;

            try
            {
                // 2. Obter APENAS o ID da linha selecionada
                // [IMPORTANTE]: Certifique-se que o nome da coluna no DGV é "id_reserva"
                // Se o seu 'SELECT * FROM reservas' no Listar() mostrar 'IdReserva', mude abaixo.
                idReserva = Convert.ToInt32(dgvComprovante.SelectedRows[0].Cells["id_reserva"].Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao tentar ler o ID da reserva selecionada: {ex.Message}" +
                                "\n\nVerifique se o nome da coluna (ex: 'id_reserva') está correto.",
                                "Erro de Leitura",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            // 3. Usar o ID para buscar os dados completos do banco (seu código)
            try
            {
                // Assumindo que 'conexao.Abrir()' existe e retorna uma MySqlConnection aberta
                using (var con = conexao.Abrir())
                {
                    // A query que você forneceu
                    string query = @"
                    SELECT
                        r.id_reserva, r.data_reserva, r.data_checkin, r.data_checkout,
                        r.quantidade_pessoas, r.valor_diaria, r.valor_total,
                        r.forma_pagamento, r.status_reserva,
                        
                        h.nome, h.cpf, h.telefone,
                        
                        q.numero_quarto, q.tipo_quarto,
                        
                        p.status_pagamento
                    FROM reservas r
                    JOIN hospedes h ON r.id_hospedes = h.id_hospedes
                    JOIN quartos q ON r.id_quarto = q.id_quarto
                    LEFT JOIN pagamentos p ON r.id_reserva = p.id_reserva
                    WHERE r.id_reserva = @id";

                    using (var cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@id", idReserva);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                model = new RelatorioReservaModel
                                {
                                    // Lendo os dados com segurança (checando DBNull) - como no seu exemplo
                                    id_reserva = reader.GetInt32("id_reserva"),
                                    DataReserva = reader.GetDateTime("data_reserva"),
                                    DataCheckin = reader.GetDateTime("data_checkin"),
                                    DataCheckout = reader.GetDateTime("data_checkout"),
                                    QuantidadePessoas = reader.GetInt32("quantidade_pessoas"),
                                    StatusReserva = reader.GetString("status_reserva"),

                                    NomeHospede = reader.GetString("nome"),
                                    CpfHospede = reader.GetString("cpf"),
                                    TelefoneHospede = reader.GetString("telefone"),

                                    NumeroQuarto = reader.GetInt32("numero_quarto"),
                                    TipoQuarto = reader.GetString("tipo_quarto"),

                                    // Campos que podem ser NULOS
                                    ValorDiaria = reader.IsDBNull(reader.GetOrdinal("valor_diaria")) ? (decimal?)null : reader.GetDecimal("valor_diaria"),
                                    ValorTotal = reader.IsDBNull(reader.GetOrdinal("valor_total")) ? (decimal?)null : reader.GetDecimal("valor_total"),
                                    FormaPagamento = reader.IsDBNull(reader.GetOrdinal("forma_pagamento")) ? null : reader.GetString("forma_pagamento"),
                                    StatusPagamento = reader.IsDBNull(reader.GetOrdinal("status_pagamento")) ? null : reader.GetString("status_pagamento")
                                };
                            }
                        }
                    }
                } // A conexão é fechada aqui
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao buscar os dados da reserva no banco: {ex.Message}",
                                "Erro de Banco de Dados",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            // 4. Verificar se o modelo foi preenchido e gerar o PDF
            if (model != null)
            {
                try
                {
                    var document = new ComprovanteReservaDocument(model);
                    string filePath = Path.Combine(Path.GetTempPath(), $"Comprovante_Reserva_{model.id_reserva}.pdf");
                    document.GeneratePdf(filePath);

                    new Process
                    {
                        StartInfo = new ProcessStartInfo(filePath)
                        {
                            UseShellExecute = true
                        }
                    }.Start();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao gerar o arquivo PDF: {ex.Message}",
                                    "Erro de Geração de PDF",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show($"A reserva com ID {idReserva} foi selecionada, mas não foi encontrada no banco de dados.",
                                "Reserva Não Encontrada",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }

        // O método Listar() continua igual, usando a conexão 'con'
        void Listar()
        {
            string sql = "SELECT * FROM reservas"; // Este SELECT define os nomes das colunas no DGV
            MySqlDataAdapter da = new MySqlDataAdapter(sql, con);
            tabela.Clear();
            da.Fill(tabela);
            dgvComprovante.DataSource = tabela;
        }

        // --- FUNÇÕES AUXILIARES REMOVIDAS ---
        // Os métodos 'GetNullableString' e 'GetNullableDecimal'
        // não são mais necessários, pois a lógica de
        // 'reader.IsDBNull' já está a tratar isso.
    }
}