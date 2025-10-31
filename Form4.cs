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
using MySql.Data.MySqlClient;

namespace Hotel.Front
{
    public partial class Form4 : Form
    {
        private MySqlConnection con = new MySqlConnection(conexao.stringConexao);
        private DataTable tabela = new DataTable();
        public Form4()
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
            
                string sql = "INSERT INTO reservas (id_hospedes, id_quarto, data_checkin, data_checkout) VALUES (@id_hospede, @id_quarto, @checkin, @checkout)";
            MySqlCommand cmd = new MySqlCommand(sql, con);

            cmd.Parameters.AddWithValue("@id_hospede", idHospede.Text);
            cmd.Parameters.AddWithValue("@id_quarto", idQuarto.Text);
            cmd.Parameters.AddWithValue("@checkin", checkIn.Value.Date);
            cmd.Parameters.AddWithValue("@checkout", checkOut.Value.Date);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Reserva cadastrada!");
            Listar();
        }

        private void editarQuarto_Click(object sender, EventArgs e)
        {
            if (dgvReservas.CurrentRow == null)
            {
                MessageBox.Show("Selecione uma reserva!");
                return;
            }

            int id = Convert.ToInt32(dgvReservas.CurrentRow.Cells["id_reserva"].Value);

            string sql = "UPDATE reservas SET id_hospedes=@id_hospedes, id_quarto=@id_quarto, data_checkin=@checkin, data_checkout=@checkout WHERE id_reserva=@id";
            MySqlCommand cmd = new MySqlCommand(sql, con);

            cmd.Parameters.AddWithValue("@id_hospedes", idHospede.Text);
            cmd.Parameters.AddWithValue("@id_quarto", idQuarto.Text);
            cmd.Parameters.AddWithValue("@checkin", checkIn.Value.Date);
            cmd.Parameters.AddWithValue("@checkout", checkOut.Value.Date);
            cmd.Parameters.AddWithValue("@id", id);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Reserva atualizada!");
            Listar();
        }

        private void excluirQuarto_Click(object sender, EventArgs e)
        {
            if (dgvReservas.CurrentRow == null)
            {
                MessageBox.Show("Selecione uma reserva!");
                return;
            }

            int id = Convert.ToInt32(dgvReservas.CurrentRow.Cells["id_reserva"].Value);

            string sql = "DELETE FROM reservas WHERE id_reserva=@id";
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@id", id);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Reserva excluída!");
            Listar();
        }

        private void listarQuarto_Click(object sender, EventArgs e)
        {
            Listar();
        }

        void Listar()
        {
            string sql = "SELECT * FROM reservas";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, con);
            tabela.Clear();
            da.Fill(tabela);
            dgvReservas.DataSource = tabela;
        }

        private void dgvReservas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
