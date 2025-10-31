namespace Hotel.Front
{
    partial class Form2
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
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridViewHospedes = new System.Windows.Forms.DataGridView();
            this.cadastrarHospede = new System.Windows.Forms.Button();
            this.editarHospede = new System.Windows.Forms.Button();
            this.listarHospedes = new System.Windows.Forms.Button();
            this.excluirHospede = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cpfHospede = new System.Windows.Forms.MaskedTextBox();
            this.celularHospede = new System.Windows.Forms.MaskedTextBox();
            this.nomeHospede = new System.Windows.Forms.TextBox();
            this.emailHospede = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHospedes)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(158)))), ((int)(((byte)(77)))));
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(76)))), ((int)(((byte)(94)))));
            this.button5.Location = new System.Drawing.Point(9, 10);
            this.button5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(70, 25);
            this.button5.TabIndex = 4;
            this.button5.Text = "Voltar";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dataGridViewHospedes
            // 
            this.dataGridViewHospedes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(243)))), ((int)(((byte)(232)))));
            this.dataGridViewHospedes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewHospedes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHospedes.Location = new System.Drawing.Point(89, 223);
            this.dataGridViewHospedes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewHospedes.Name = "dataGridViewHospedes";
            this.dataGridViewHospedes.RowHeadersWidth = 51;
            this.dataGridViewHospedes.RowTemplate.Height = 24;
            this.dataGridViewHospedes.Size = new System.Drawing.Size(418, 133);
            this.dataGridViewHospedes.TabIndex = 13;
            this.dataGridViewHospedes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHospedes_CellContentClick);
            // 
            // cadastrarHospede
            // 
            this.cadastrarHospede.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(158)))), ((int)(((byte)(77)))));
            this.cadastrarHospede.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cadastrarHospede.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cadastrarHospede.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastrarHospede.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(76)))), ((int)(((byte)(94)))));
            this.cadastrarHospede.Location = new System.Drawing.Point(38, 162);
            this.cadastrarHospede.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cadastrarHospede.Name = "cadastrarHospede";
            this.cadastrarHospede.Size = new System.Drawing.Size(70, 25);
            this.cadastrarHospede.TabIndex = 0;
            this.cadastrarHospede.Text = "Cadastrar";
            this.cadastrarHospede.UseVisualStyleBackColor = false;
            this.cadastrarHospede.Click += new System.EventHandler(this.cadastrarHospede_Click);
            // 
            // editarHospede
            // 
            this.editarHospede.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(158)))), ((int)(((byte)(77)))));
            this.editarHospede.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editarHospede.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editarHospede.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editarHospede.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(76)))), ((int)(((byte)(94)))));
            this.editarHospede.Location = new System.Drawing.Point(125, 162);
            this.editarHospede.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.editarHospede.Name = "editarHospede";
            this.editarHospede.Size = new System.Drawing.Size(70, 26);
            this.editarHospede.TabIndex = 1;
            this.editarHospede.Text = "Editar";
            this.editarHospede.UseVisualStyleBackColor = false;
            this.editarHospede.Click += new System.EventHandler(this.editarHospede_Click);
            // 
            // listarHospedes
            // 
            this.listarHospedes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(158)))), ((int)(((byte)(77)))));
            this.listarHospedes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listarHospedes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.listarHospedes.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listarHospedes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(76)))), ((int)(((byte)(94)))));
            this.listarHospedes.Location = new System.Drawing.Point(297, 163);
            this.listarHospedes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listarHospedes.Name = "listarHospedes";
            this.listarHospedes.Size = new System.Drawing.Size(70, 25);
            this.listarHospedes.TabIndex = 2;
            this.listarHospedes.Text = "Listar";
            this.listarHospedes.UseVisualStyleBackColor = false;
            this.listarHospedes.Click += new System.EventHandler(this.listarHospedes_Click);
            // 
            // excluirHospede
            // 
            this.excluirHospede.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(158)))), ((int)(((byte)(77)))));
            this.excluirHospede.Cursor = System.Windows.Forms.Cursors.Hand;
            this.excluirHospede.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.excluirHospede.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.excluirHospede.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(76)))), ((int)(((byte)(94)))));
            this.excluirHospede.Location = new System.Drawing.Point(211, 163);
            this.excluirHospede.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.excluirHospede.Name = "excluirHospede";
            this.excluirHospede.Size = new System.Drawing.Size(70, 25);
            this.excluirHospede.TabIndex = 3;
            this.excluirHospede.Text = "Excluir";
            this.excluirHospede.UseVisualStyleBackColor = false;
            this.excluirHospede.Click += new System.EventHandler(this.excluirHospede_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(162)))), ((int)(((byte)(59)))));
            this.label1.Location = new System.Drawing.Point(14, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 14);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(162)))), ((int)(((byte)(59)))));
            this.label2.Location = new System.Drawing.Point(311, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 14);
            this.label2.TabIndex = 6;
            this.label2.Text = "CPF:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(162)))), ((int)(((byte)(59)))));
            this.label3.Location = new System.Drawing.Point(311, 103);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 14);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tel/Cel:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(162)))), ((int)(((byte)(59)))));
            this.label4.Location = new System.Drawing.Point(14, 103);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 14);
            this.label4.TabIndex = 8;
            this.label4.Text = "RG:";
            // 
            // cpfHospede
            // 
            this.cpfHospede.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cpfHospede.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpfHospede.Location = new System.Drawing.Point(314, 72);
            this.cpfHospede.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cpfHospede.Mask = "000.000.000-00";
            this.cpfHospede.Name = "cpfHospede";
            this.cpfHospede.Size = new System.Drawing.Size(76, 19);
            this.cpfHospede.TabIndex = 9;
            // 
            // celularHospede
            // 
            this.celularHospede.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.celularHospede.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.celularHospede.Location = new System.Drawing.Point(314, 119);
            this.celularHospede.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.celularHospede.Mask = "(00) 00000-0000";
            this.celularHospede.Name = "celularHospede";
            this.celularHospede.Size = new System.Drawing.Size(78, 19);
            this.celularHospede.TabIndex = 10;
            // 
            // nomeHospede
            // 
            this.nomeHospede.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nomeHospede.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeHospede.Location = new System.Drawing.Point(16, 72);
            this.nomeHospede.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nomeHospede.Name = "nomeHospede";
            this.nomeHospede.Size = new System.Drawing.Size(279, 19);
            this.nomeHospede.TabIndex = 11;
            // 
            // emailHospede
            // 
            this.emailHospede.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailHospede.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailHospede.Location = new System.Drawing.Point(16, 119);
            this.emailHospede.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.emailHospede.Name = "emailHospede";
            this.emailHospede.Size = new System.Drawing.Size(279, 19);
            this.emailHospede.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(243)))), ((int)(((byte)(232)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(162)))), ((int)(((byte)(59)))));
            this.label5.Location = new System.Drawing.Point(95, 15);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(211, 26);
            this.label5.TabIndex = 14;
            this.label5.Text = "Gerenciar Hóspedes";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(243)))), ((int)(((byte)(232)))));
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.emailHospede);
            this.groupBox1.Controls.Add(this.nomeHospede);
            this.groupBox1.Controls.Add(this.celularHospede);
            this.groupBox1.Controls.Add(this.cpfHospede);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.excluirHospede);
            this.groupBox1.Controls.Add(this.listarHospedes);
            this.groupBox1.Controls.Add(this.editarHospede);
            this.groupBox1.Controls.Add(this.cadastrarHospede);
            this.groupBox1.Location = new System.Drawing.Point(89, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(418, 208);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hotel.Front.Properties.Resources.Recepção;
            this.pictureBox1.Location = new System.Drawing.Point(-4, -43);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(609, 444);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewHospedes);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hóspedes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHospedes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dataGridViewHospedes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button cadastrarHospede;
        private System.Windows.Forms.Button editarHospede;
        private System.Windows.Forms.Button listarHospedes;
        private System.Windows.Forms.Button excluirHospede;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox cpfHospede;
        private System.Windows.Forms.MaskedTextBox celularHospede;
        private System.Windows.Forms.TextBox nomeHospede;
        private System.Windows.Forms.TextBox emailHospede;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}