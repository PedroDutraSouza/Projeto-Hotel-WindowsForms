using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hotel.Front
{
    public partial class Form3 : Form
    {
        private MySqlConnection con = new MySqlConnection(conexao.stringConexao);
        private DataTable tabela = new DataTable();
        public Form3()
        {
            InitializeComponent();
            Listar();
        }

        
        private void button5_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void cadastrarQuarto_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO quartos (numero_quarto, tipo_quarto, preco_diaria, status_quarto) " +
                "VALUES (@numero, @tipo, @diaria, @status)";

            MySqlCommand cmd = new MySqlCommand(sql, con);

            cmd.Parameters.AddWithValue("@numero", numeroQuarto.Text);
            cmd.Parameters.AddWithValue("@tipo", tipoQuarto.Text);
            cmd.Parameters.AddWithValue("@diaria", diariaQuarto.Text.Replace("R$", "").Trim());
            cmd.Parameters.AddWithValue("@status", statusQuarto.Text.ToLower());

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Quarto cadastrado com sucesso!");
            Listar();
        }

        private void editarQuarto_Click(object sender, EventArgs e)
        {
            if (dgvQuartos.CurrentRow == null)
            {
                MessageBox.Show("Selecione um quarto para editar.");
                return;
            }

            int id = Convert.ToInt32(dgvQuartos.CurrentRow.Cells["id_quarto"].Value);

            string sql = "UPDATE quartos SET numero_quarto = @numero, tipo_quarto = @tipo, preco_diaria = @diaria, status_quarto = @status WHERE id_quarto = @id";
            MySqlCommand cmd = new MySqlCommand(sql, con);

            cmd.Parameters.AddWithValue("@numero", numeroQuarto.Text);
            cmd.Parameters.AddWithValue("@tipo", tipoQuarto.Text);
            cmd.Parameters.AddWithValue("@diaria", diariaQuarto.Text.Replace("R$", "").Trim());
            cmd.Parameters.AddWithValue("@status", statusQuarto.Text);
            cmd.Parameters.AddWithValue("@id", id);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Quarto atualizado!");
            Listar();
        }

        private void excluirQuarto_Click(object sender, EventArgs e)
        {
            if (dgvQuartos.CurrentRow == null)
            {
                MessageBox.Show("Selecione um quarto para excluir.");
                return;
            }

            int id = Convert.ToInt32(dgvQuartos.CurrentRow.Cells["id_quarto"].Value);

            string sql = "DELETE FROM quartos WHERE id_quarto=@id";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@id", id);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Quarto excluído!");
            Listar();
        }

        private void listarQuarto_Click(object sender, EventArgs e)
        {
            Listar();
        }

        void Listar()
        {
            string sql = "SELECT numero_quarto, tipo_quarto, preco_diaria, status_quarto FROM quartos";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, con);
            tabela.Clear();
            da.Fill(tabela);
            dgvQuartos.DataSource = tabela;
        }
    }
}
