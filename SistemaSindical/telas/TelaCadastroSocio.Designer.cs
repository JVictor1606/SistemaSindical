namespace SistemaSindical.telas
{
    partial class TelaCadastroSocio
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeSocio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIdSindicato = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.txtDataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.rdbFeminino = new System.Windows.Forms.RadioButton();
            this.rdbSexo = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Sócio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // txtNomeSocio
            // 
            this.txtNomeSocio.Location = new System.Drawing.Point(13, 80);
            this.txtNomeSocio.Name = "txtNomeSocio";
            this.txtNomeSocio.Size = new System.Drawing.Size(124, 20);
            this.txtNomeSocio.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "CPF";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Data de Nascimento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Sexo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Telefone";
            // 
            // txtIdSindicato
            // 
            this.txtIdSindicato.Location = new System.Drawing.Point(165, 171);
            this.txtIdSindicato.Name = "txtIdSindicato";
            this.txtIdSindicato.Size = new System.Drawing.Size(123, 20);
            this.txtIdSindicato.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(165, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Id do Sindicato";
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(13, 123);
            this.txtCpf.Mask = "000.000.000 - 00";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(124, 20);
            this.txtCpf.TabIndex = 13;
            // 
            // txtDataNascimento
            // 
            this.txtDataNascimento.Location = new System.Drawing.Point(13, 171);
            this.txtDataNascimento.Mask = "00/00/0000";
            this.txtDataNascimento.Name = "txtDataNascimento";
            this.txtDataNascimento.Size = new System.Drawing.Size(124, 20);
            this.txtDataNascimento.TabIndex = 14;
            this.txtDataNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(13, 215);
            this.txtTelefone.Mask = "(00) 00000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(124, 20);
            this.txtTelefone.TabIndex = 15;
            // 
            // rdbFeminino
            // 
            this.rdbFeminino.AutoSize = true;
            this.rdbFeminino.Location = new System.Drawing.Point(94, 31);
            this.rdbFeminino.Name = "rdbFeminino";
            this.rdbFeminino.Size = new System.Drawing.Size(67, 17);
            this.rdbFeminino.TabIndex = 16;
            this.rdbFeminino.Text = "Feminino";
            this.rdbFeminino.UseVisualStyleBackColor = true;
            // 
            // rdbSexo
            // 
            this.rdbSexo.AutoSize = true;
            this.rdbSexo.Checked = true;
            this.rdbSexo.Location = new System.Drawing.Point(3, 31);
            this.rdbSexo.Name = "rdbSexo";
            this.rdbSexo.Size = new System.Drawing.Size(73, 17);
            this.rdbSexo.TabIndex = 17;
            this.rdbSexo.TabStop = true;
            this.rdbSexo.Tag = "M";
            this.rdbSexo.Text = "Masculino";
            this.rdbSexo.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.rdbFeminino);
            this.groupBox1.Controls.Add(this.rdbSexo);
            this.groupBox1.Location = new System.Drawing.Point(159, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 61);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(13, 288);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 19;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // TelaCadastroSocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 352);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtDataNascimento);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.txtIdSindicato);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNomeSocio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TelaCadastroSocio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro do Sócio";
            this.Load += new System.EventHandler(this.TelaCadastroSocio_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeSocio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIdSindicato;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtCpf;
        private System.Windows.Forms.MaskedTextBox txtDataNascimento;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.RadioButton rdbFeminino;
        private System.Windows.Forms.RadioButton rdbSexo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSalvar;
    }
}