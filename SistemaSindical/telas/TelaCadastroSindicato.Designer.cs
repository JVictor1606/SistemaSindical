namespace SistemaSindical.telas
{
    partial class TelaCadastroSindicato
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNomeSind = new System.Windows.Forms.TextBox();
            this.txtMunicipio = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnSalvarSind = new System.Windows.Forms.Button();
            this.txtCnpj = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtRegional = new System.Windows.Forms.TextBox();
            this.lblRegional = new System.Windows.Forms.Label();
            this.txtIdFederacao = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome do sindicato";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(8, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cadastro do Sindicato ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "CNPJ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Email p/ Contato";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Telefone p/ Contato";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Municipio";
            // 
            // txtNomeSind
            // 
            this.txtNomeSind.Location = new System.Drawing.Point(12, 59);
            this.txtNomeSind.Name = "txtNomeSind";
            this.txtNomeSind.Size = new System.Drawing.Size(150, 20);
            this.txtNomeSind.TabIndex = 11;
            // 
            // txtMunicipio
            // 
            this.txtMunicipio.Location = new System.Drawing.Point(12, 137);
            this.txtMunicipio.Name = "txtMunicipio";
            this.txtMunicipio.Size = new System.Drawing.Size(150, 20);
            this.txtMunicipio.TabIndex = 13;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(12, 260);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(147, 20);
            this.txtEmail.TabIndex = 15;
            // 
            // btnSalvarSind
            // 
            this.btnSalvarSind.Location = new System.Drawing.Point(12, 285);
            this.btnSalvarSind.Name = "btnSalvarSind";
            this.btnSalvarSind.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarSind.TabIndex = 16;
            this.btnSalvarSind.Text = "Salvar";
            this.btnSalvarSind.UseVisualStyleBackColor = true;
            this.btnSalvarSind.Click += new System.EventHandler(this.btnSalvarSind_Click);
            // 
            // txtCnpj
            // 
            this.txtCnpj.Location = new System.Drawing.Point(12, 98);
            this.txtCnpj.Mask = "00.000.000/0000 - 00";
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(150, 20);
            this.txtCnpj.TabIndex = 17;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(12, 221);
            this.txtTelefone.Mask = "(00) 00000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(150, 20);
            this.txtTelefone.TabIndex = 18;
            // 
            // txtRegional
            // 
            this.txtRegional.Location = new System.Drawing.Point(12, 177);
            this.txtRegional.Name = "txtRegional";
            this.txtRegional.Size = new System.Drawing.Size(150, 20);
            this.txtRegional.TabIndex = 20;
            // 
            // lblRegional
            // 
            this.lblRegional.AutoSize = true;
            this.lblRegional.Location = new System.Drawing.Point(12, 161);
            this.lblRegional.Name = "lblRegional";
            this.lblRegional.Size = new System.Drawing.Size(49, 13);
            this.lblRegional.TabIndex = 19;
            this.lblRegional.Text = "Regional";
            // 
            // txtIdFederacao
            // 
            this.txtIdFederacao.Location = new System.Drawing.Point(168, 59);
            this.txtIdFederacao.Name = "txtIdFederacao";
            this.txtIdFederacao.Size = new System.Drawing.Size(150, 20);
            this.txtIdFederacao.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(168, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "ID da Federação";
            // 
            // TelaCadastroSindicato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 331);
            this.Controls.Add(this.txtIdFederacao);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtRegional);
            this.Controls.Add(this.lblRegional);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtCnpj);
            this.Controls.Add(this.btnSalvarSind);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtMunicipio);
            this.Controls.Add(this.txtNomeSind);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TelaCadastroSindicato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaCadastroSindicato";
            this.Load += new System.EventHandler(this.TelaCadastroSindicato_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNomeSind;
        private System.Windows.Forms.TextBox txtMunicipio;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnSalvarSind;
        private System.Windows.Forms.MaskedTextBox txtCnpj;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.TextBox txtRegional;
        private System.Windows.Forms.Label lblRegional;
        private System.Windows.Forms.TextBox txtIdFederacao;
        private System.Windows.Forms.Label label7;
    }
}