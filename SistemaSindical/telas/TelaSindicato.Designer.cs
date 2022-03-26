namespace SistemaSindical.telas
{
    partial class TelaSindicato
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
            this.listViewSindicatos = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.cmbSind = new System.Windows.Forms.ComboBox();
            this.btnAdicionarSind = new System.Windows.Forms.Button();
            this.btnVerSocio = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
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
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sindicatos";
            // 
            // listViewSindicatos
            // 
            this.listViewSindicatos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader1,
            this.columnHeader2});
            this.listViewSindicatos.FullRowSelect = true;
            this.listViewSindicatos.GridLines = true;
            this.listViewSindicatos.HideSelection = false;
            this.listViewSindicatos.Location = new System.Drawing.Point(16, 91);
            this.listViewSindicatos.MultiSelect = false;
            this.listViewSindicatos.Name = "listViewSindicatos";
            this.listViewSindicatos.Size = new System.Drawing.Size(541, 267);
            this.listViewSindicatos.TabIndex = 2;
            this.listViewSindicatos.UseCompatibleStateImageBehavior = false;
            this.listViewSindicatos.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "id";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Sindicatos";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Regionais";
            this.columnHeader2.Width = 275;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pesquise o sindicato";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPesquisar);
            this.groupBox1.Controls.Add(this.txtPesquisa);
            this.groupBox1.Controls.Add(this.cmbSind);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(16, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(730, 53);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(444, 16);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(97, 23);
            this.btnPesquisar.TabIndex = 6;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(272, 16);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(166, 20);
            this.txtPesquisa.TabIndex = 5;
            // 
            // cmbSind
            // 
            this.cmbSind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSind.FormattingEnabled = true;
            this.cmbSind.Items.AddRange(new object[] {
            "Nome",
            "Regionais"});
            this.cmbSind.Location = new System.Drawing.Point(144, 15);
            this.cmbSind.Name = "cmbSind";
            this.cmbSind.Size = new System.Drawing.Size(121, 21);
            this.cmbSind.TabIndex = 4;
            // 
            // btnAdicionarSind
            // 
            this.btnAdicionarSind.Location = new System.Drawing.Point(563, 91);
            this.btnAdicionarSind.Name = "btnAdicionarSind";
            this.btnAdicionarSind.Size = new System.Drawing.Size(114, 23);
            this.btnAdicionarSind.TabIndex = 5;
            this.btnAdicionarSind.Text = "Adicionar Sindicato";
            this.btnAdicionarSind.UseVisualStyleBackColor = true;
            this.btnAdicionarSind.Click += new System.EventHandler(this.btnAdicionarSind_Click);
            // 
            // btnVerSocio
            // 
            this.btnVerSocio.Location = new System.Drawing.Point(563, 178);
            this.btnVerSocio.Name = "btnVerSocio";
            this.btnVerSocio.Size = new System.Drawing.Size(113, 23);
            this.btnVerSocio.TabIndex = 7;
            this.btnVerSocio.Text = "Ver Sócios";
            this.btnVerSocio.UseVisualStyleBackColor = true;
            this.btnVerSocio.Click += new System.EventHandler(this.btnVerSocio_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(563, 120);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(114, 23);
            this.btnEditar.TabIndex = 8;
            this.btnEditar.Text = "Editar Sindicato";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(563, 149);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(114, 23);
            this.btnExcluir.TabIndex = 9;
            this.btnExcluir.Text = "Excluir Sindicato";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // TelaSindicato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 388);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnVerSocio);
            this.Controls.Add(this.btnAdicionarSind);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listViewSindicatos);
            this.Controls.Add(this.label1);
            this.Name = "TelaSindicato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaSindicato";
            this.Load += new System.EventHandler(this.TelaSindicato_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewSindicatos;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.ComboBox cmbSind;
        private System.Windows.Forms.Button btnAdicionarSind;
        private System.Windows.Forms.Button btnVerSocio;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
    }
}