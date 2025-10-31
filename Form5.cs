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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void buscar_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            AtualizarGrid();
        }
        private void AtualizarGrid()
        {
            dgvPagamento.DataSource = null;
            dgvPagamento.DataSource = pay.Pague.ListarPagamentos();
            dgvPagamento.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrWhiteSpace(buscarQuarto.Text) ||
                    string.IsNullOrWhiteSpace(valorPagamento.Text) ||
                    comboBox1.SelectedItem == null)
                {
                    MessageBox.Show("Preencha todos os campos antes de confirmar o pagamento!");
                    return;
                }

                int idReserva = int.Parse(buscarQuarto.Text);
                decimal valor = decimal.Parse(valorPagamento.Text);
                string forma = comboBox1.SelectedItem.ToString();

                pay.Pague.ConfirmarPagamento(idReserva, forma, valor);

                MessageBox.Show("Pagamento confirmado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AtualizarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao confirmar pagamento: " + ex.Message);
            }


        }
    }
}
