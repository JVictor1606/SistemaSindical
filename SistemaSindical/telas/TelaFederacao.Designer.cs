namespace SistemaSindical.telas
{
    partial class TelaFederacao
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtCnpj = new System.Windows.Forms.MaskedTextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(12, 42);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(150, 20);
            this.txtNome.TabIndex = 1;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(12, 92);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(150, 20);
            this.txtEstado.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Estado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "CNPJ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Telefone";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(12, 222);
            this.txtTelefone.Mask = "(00) 00000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(150, 20);
            this.txtTelefone.TabIndex = 9;
            // 
            // txtCnpj
            // 
            this.txtCnpj.Location = new System.Drawing.Point(12, 140);
            this.txtCnpj.Mask = "00.000.000/0000 - 00";
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(150, 20);
            this.txtCnpj.TabIndex = 10;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(12, 258);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 11;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(12, 182);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(150, 20);
            this.txtEndereco.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Endereço";
            // 
            // TelaFederacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 293);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtCnpj);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Name = "TelaFederacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaFederacao";
            this.Load += new System.EventHandler(this.TelaFederacao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.MaskedTextBox txtCnpj;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label5;
    }
}