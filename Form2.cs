using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel.Front
{
    public partial class Form2 : Form
    {
        private MySqlConnection con = new MySqlConnection(conexao.stringConexao);
        private DataTable tabela = new DataTable();
        public Form2()
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
        void LimparCampos()
        {
            nomeHospede.Text = "";
            cpfHospede.Text = "";
            celularHospede.Text = "";
            emailHospede.Text = "";
           
            nomeHospede.Focus();
        }
        void Listar()
        {
            string sql = "SELECT * FROM hospedes";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, con);
            tabela.Clear();
            da.Fill(tabela);
            dataGridViewHospedes.DataSource = tabela;
            
            dataGridViewHospedes.Columns["id_hospedes"].HeaderText = "ID";
            dataGridViewHospedes.Columns["nome"].HeaderText = "Nome";
            dataGridViewHospedes.Columns["telefone"].HeaderText = "Telefone";
            dataGridViewHospedes.Columns["cpf"].HeaderText = "CPF";
            dataGridViewHospedes.Columns["rg"].HeaderText = "RG"; 
            dataGridViewHospedes.Columns["id_hospedes"].Visible = false; 
        }

        private void cadastrarHospede_Click(object sender, EventArgs e)
        {
            if (nomeHospede.Text.Trim() == "" || cpfHospede.Text.Replace(".", ",").Replace("-", "").Trim() == "" || celularHospede.Text.Replace("(", "").Replace(")", "").Replace("-", "").Trim() == "")
            {
                MessageBox.Show("Preencha todos os campos obrigatórios (Nome, CPF e Telefone).");
                return;
            }

            
            string sql = "INSERT INTO hospedes (nome, telefone, cpf, rg) " +
                "VALUES (@nome, @telefone, @cpf, @rg)";

            MySqlCommand cmd = new MySqlCommand(sql, con);

            cmd.Parameters.AddWithValue("@nome", nomeHospede.Text);
           
            cmd.Parameters.AddWithValue("@telefone", celularHospede.Text);
            
            cmd.Parameters.AddWithValue("@cpf", cpfHospede.Text);
            
            cmd.Parameters.AddWithValue("@rg", emailHospede.Text);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Hóspede cadastrado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar hóspede: " + ex.Message);
            }
            finally
            {
                con.Close();
                Listar();
                LimparCampos();
            }
        }

        private void editarHospede_Click(object sender, EventArgs e)
        {
            if (dataGridViewHospedes.CurrentRow == null)
            {
                MessageBox.Show("Selecione um hóspede para editar.");
                return;
            }

            int id = Convert.ToInt32(dataGridViewHospedes.CurrentRow.Cells["id_hospedes"].Value); // Usa a coluna correta

            string sql = "UPDATE hospedes SET nome = @nome, telefone = @telefone, cpf = @cpf, rg = @rg WHERE id_hospedes = @id";
            MySqlCommand cmd = new MySqlCommand(sql, con);

            cmd.Parameters.AddWithValue("@nome", nomeHospede.Text);
            cmd.Parameters.AddWithValue("@telefone", celularHospede.Text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "").Trim());
            cmd.Parameters.AddWithValue("@cpf", cpfHospede.Text.Replace(".", "").Replace("-", "").Trim());
            cmd.Parameters.AddWithValue("@rg", emailHospede.Text); 
            cmd.Parameters.AddWithValue("@id", id);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Hóspede atualizado!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao editar hóspede: " + ex.Message);
            }
            finally
            {
                con.Close();
                Listar();
                LimparCampos();
            }
        }

        private void excluirHospede_Click(object sender, EventArgs e)
        {
            if (dataGridViewHospedes.CurrentRow == null)
            {
                MessageBox.Show("Selecione um hóspede para excluir.");
                return;
            }

            int id = Convert.ToInt32(dataGridViewHospedes.CurrentRow.Cells["id_hospedes"].Value); // Usa a coluna correta

            DialogResult resultado = MessageBox.Show("Deseja realmente excluir este hóspede?", "Excluir Hóspede", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                string sql = "DELETE FROM hospedes WHERE id_hospedes=@id";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@id", id);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Hóspede excluído!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir hóspede: " + ex.Message);
                }
                finally
                {
                    con.Close();
                    Listar();
                    LimparCampos();
                }
            }
        }

        private void listarHospedes_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void dataGridViewHospedes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                nomeHospede.Text = dataGridViewHospedes.CurrentRow.Cells["nome"].Value.ToString();
               
                string telefone = dataGridViewHospedes.CurrentRow.Cells["telefone"].Value.ToString();
                celularHospede.Text = telefone;

                
                string cpf = dataGridViewHospedes.CurrentRow.Cells["cpf"].Value.ToString();
                cpfHospede.Text = cpf;

                
                emailHospede.Text = dataGridViewHospedes.CurrentRow.Cells["rg"].Value.ToString(); 
            }
        }
    }
}
