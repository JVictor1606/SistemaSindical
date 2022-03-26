namespace SistemaSindical.telas
{
    partial class TelaSocio
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.cmbSocio = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listViewSocio = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
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
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sócios";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPesquisar);
            this.groupBox1.Controls.Add(this.txtPesquisa);
            this.groupBox1.Controls.Add(this.cmbSocio);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 58);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(423, 19);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(97, 23);
            this.btnPesquisar.TabIndex = 9;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(251, 19);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(166, 20);
            this.txtPesquisa.TabIndex = 8;
            // 
            // cmbSocio
            // 
            this.cmbSocio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSocio.FormattingEnabled = true;
            this.cmbSocio.Items.AddRange(new object[] {
            "Nome",
            "CPF",
            "Data Nascimento"});
            this.cmbSocio.Location = new System.Drawing.Point(123, 18);
            this.cmbSocio.Name = "cmbSocio";
            this.cmbSocio.Size = new System.Drawing.Size(121, 21);
            this.cmbSocio.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Pesquise o sócio";
            // 
            // listViewSocio
            // 
            this.listViewSocio.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listViewSocio.FullRowSelect = true;
            this.listViewSocio.GridLines = true;
            this.listViewSocio.HideSelection = false;
            this.listViewSocio.Location = new System.Drawing.Point(12, 112);
            this.listViewSocio.MultiSelect = false;
            this.listViewSocio.Name = "listViewSocio";
            this.listViewSocio.Size = new System.Drawing.Size(619, 326);
            this.listViewSocio.TabIndex = 2;
            this.listViewSocio.UseCompatibleStateImageBehavior = false;
            this.listViewSocio.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nome";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "CPF";
            this.columnHeader2.Width = 125;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Data Nascimento";
            this.columnHeader3.Width = 130;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Sexo";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Telefone";
            this.columnHeader5.Width = 150;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(637, 112);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(96, 23);
            this.btnAdicionar.TabIndex = 3;
            this.btnAdicionar.Text = "Adicionar Sócio";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(637, 141);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(96, 23);
            this.btnDeletar.TabIndex = 4;
            this.btnDeletar.Text = "Excluir Sócio";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(637, 170);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(96, 23);
            this.btnEditar.TabIndex = 5;
            this.btnEditar.Text = "Editar Sócio";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // TelaSocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.listViewSocio);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "TelaSocio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Socios";
            this.Load += new System.EventHandler(this.TelaSocio_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.ComboBox cmbSocio;
        private System.Windows.Forms.ListView listViewSocio;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnEditar;
    }
}