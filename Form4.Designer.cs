namespace Hotel.Front
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label5 = new System.Windows.Forms.Label();
            this.idQuarto = new System.Windows.Forms.TextBox();
            this.idHospede = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvReservas = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.excluirQuarto = new System.Windows.Forms.Button();
            this.listarQuarto = new System.Windows.Forms.Button();
            this.editarQuarto = new System.Windows.Forms.Button();
            this.cadastrarQuarto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkIn = new System.Windows.Forms.DateTimePicker();
            this.checkOut = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Elephant", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(162)))), ((int)(((byte)(59)))));
            this.label5.Location = new System.Drawing.Point(92, 14);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(250, 29);
            this.label5.TabIndex = 39;
            this.label5.Text = "Gerenciar Reservas";
            // 
            // idQuarto
            // 
            this.idQuarto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idQuarto.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idQuarto.Location = new System.Drawing.Point(224, 90);
            this.idQuarto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.idQuarto.Name = "idQuarto";
            this.idQuarto.Size = new System.Drawing.Size(115, 19);
            this.idQuarto.TabIndex = 38;
            // 
            // idHospede
            // 
            this.idHospede.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idHospede.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idHospede.Location = new System.Drawing.Point(58, 90);
            this.idHospede.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.idHospede.Name = "idHospede";
            this.idHospede.Size = new System.Drawing.Size(115, 19);
            this.idHospede.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(162)))), ((int)(((byte)(59)))));
            this.label4.Location = new System.Drawing.Point(207, 128);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 14);
            this.label4.TabIndex = 33;
            this.label4.Text = "Check-out:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(162)))), ((int)(((byte)(59)))));
            this.label2.Location = new System.Drawing.Point(42, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 14);
            this.label2.TabIndex = 31;
            this.label2.Text = "Check-in:";
            // 
            // dgvReservas
            // 
            this.dgvReservas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(243)))), ((int)(((byte)(232)))));
            this.dgvReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservas.Location = new System.Drawing.Point(108, 242);
            this.dgvReservas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvReservas.Name = "dgvReservas";
            this.dgvReservas.RowHeadersWidth = 51;
            this.dgvReservas.RowTemplate.Height = 24;
            this.dgvReservas.Size = new System.Drawing.Size(404, 111);
            this.dgvReservas.TabIndex = 30;
            this.dgvReservas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReservas_CellContentClick);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(168)))), ((int)(((byte)(77)))));
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(76)))), ((int)(((byte)(94)))));
            this.button5.Location = new System.Drawing.Point(9, 10);
            this.button5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(70, 25);
            this.button5.TabIndex = 29;
            this.button5.Text = "Voltar";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // excluirQuarto
            // 
            this.excluirQuarto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(168)))), ((int)(((byte)(77)))));
            this.excluirQuarto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.excluirQuarto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.excluirQuarto.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.excluirQuarto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(76)))), ((int)(((byte)(94)))));
            this.excluirQuarto.Location = new System.Drawing.Point(209, 189);
            this.excluirQuarto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.excluirQuarto.Name = "excluirQuarto";
            this.excluirQuarto.Size = new System.Drawing.Size(70, 25);
            this.excluirQuarto.TabIndex = 28;
            this.excluirQuarto.Text = "Excluir";
            this.excluirQuarto.UseVisualStyleBackColor = false;
            this.excluirQuarto.Click += new System.EventHandler(this.excluirQuarto_Click);
            // 
            // listarQuarto
            // 
            this.listarQuarto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(168)))), ((int)(((byte)(77)))));
            this.listarQuarto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listarQuarto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.listarQuarto.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listarQuarto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(76)))), ((int)(((byte)(94)))));
            this.listarQuarto.Location = new System.Drawing.Point(296, 189);
            this.listarQuarto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listarQuarto.Name = "listarQuarto";
            this.listarQuarto.Size = new System.Drawing.Size(70, 25);
            this.listarQuarto.TabIndex = 27;
            this.listarQuarto.Text = "Listar";
            this.listarQuarto.UseVisualStyleBackColor = false;
            this.listarQuarto.Click += new System.EventHandler(this.listarQuarto_Click);
            // 
            // editarQuarto
            // 
            this.editarQuarto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(168)))), ((int)(((byte)(77)))));
            this.editarQuarto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editarQuarto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editarQuarto.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editarQuarto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(76)))), ((int)(((byte)(94)))));
            this.editarQuarto.Location = new System.Drawing.Point(124, 188);
            this.editarQuarto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.editarQuarto.Name = "editarQuarto";
            this.editarQuarto.Size = new System.Drawing.Size(70, 26);
            this.editarQuarto.TabIndex = 26;
            this.editarQuarto.Text = "Editar";
            this.editarQuarto.UseVisualStyleBackColor = false;
            this.editarQuarto.Click += new System.EventHandler(this.editarQuarto_Click);
            // 
            // cadastrarQuarto
            // 
            this.cadastrarQuarto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(168)))), ((int)(((byte)(77)))));
            this.cadastrarQuarto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cadastrarQuarto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cadastrarQuarto.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastrarQuarto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(76)))), ((int)(((byte)(94)))));
            this.cadastrarQuarto.Location = new System.Drawing.Point(36, 188);
            this.cadastrarQuarto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cadastrarQuarto.Name = "cadastrarQuarto";
            this.cadastrarQuarto.Size = new System.Drawing.Size(70, 25);
            this.cadastrarQuarto.TabIndex = 25;
            this.cadastrarQuarto.Text = "Cadastrar";
            this.cadastrarQuarto.UseVisualStyleBackColor = false;
            this.cadastrarQuarto.Click += new System.EventHandler(this.cadastrarQuarto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(162)))), ((int)(((byte)(59)))));
            this.label1.Location = new System.Drawing.Point(58, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 14);
            this.label1.TabIndex = 40;
            this.label1.Text = "ID Hóspede:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(162)))), ((int)(((byte)(59)))));
            this.label3.Location = new System.Drawing.Point(221, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 14);
            this.label3.TabIndex = 41;
            this.label3.Text = "ID Quarto:";
            // 
            // checkIn
            // 
            this.checkIn.Location = new System.Drawing.Point(44, 144);
            this.checkIn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkIn.Name = "checkIn";
            this.checkIn.Size = new System.Drawing.Size(151, 20);
            this.checkIn.TabIndex = 42;
            // 
            // checkOut
            // 
            this.checkOut.Location = new System.Drawing.Point(209, 144);
            this.checkOut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkOut.Name = "checkOut";
            this.checkOut.Size = new System.Drawing.Size(151, 20);
            this.checkOut.TabIndex = 43;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(243)))), ((int)(((byte)(232)))));
            this.groupBox1.Controls.Add(this.checkOut);
            this.groupBox1.Controls.Add(this.checkIn);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.idQuarto);
            this.groupBox1.Controls.Add(this.idHospede);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.excluirQuarto);
            this.groupBox1.Controls.Add(this.listarQuarto);
            this.groupBox1.Controls.Add(this.editarQuarto);
            this.groupBox1.Controls.Add(this.cadastrarQuarto);
            this.groupBox1.Location = new System.Drawing.Point(108, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(404, 223);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hotel.Front.Properties.Resources.Restaurante;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -54);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(606, 437);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvReservas);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reservas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox idQuarto;
        private System.Windows.Forms.TextBox idHospede;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvReservas;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button excluirQuarto;
        private System.Windows.Forms.Button listarQuarto;
        private System.Windows.Forms.Button editarQuarto;
        private System.Windows.Forms.Button cadastrarQuarto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker checkIn;
        private System.Windows.Forms.DateTimePicker checkOut;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}