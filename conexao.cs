using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace Hotel.Front
{
    internal class conexao
    {
        private const string servidor = "localhost";
        private const string banco = "caribe_pallace";
        private const string usuario = "root";
        private const string pwd = "";

        public static readonly string stringConexao = $"Server={servidor}; Database={banco}; Uid={usuario}; Pwd={pwd};";

        public static MySqlConnection Abrir()
        {
            try
            {
                var conn = new MySqlConnection(stringConexao);
                conn.Open();
                return conn;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"FATAL: Não foi possível conectar ao banco de dados: {ex.Message}");
                Console.ReadKey();
                Environment.Exit(1);
                return null;
            }
        }
    }
}
