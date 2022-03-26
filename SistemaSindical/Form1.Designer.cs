namespace SistemaSindical
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnProcurarFed = new System.Windows.Forms.Button();
            this.txtPesquisaFed = new System.Windows.Forms.TextBox();
            this.cmbFed = new System.Windows.Forms.ComboBox();
            this.btnAdicionarFed = new System.Windows.Forms.Button();
            this.btnVerSindicatos = new System.Windows.Forms.Button();
            this.btnEditarFed = new System.Windows.Forms.Button();
            this.listViewFed = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Federação";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnProcurarFed);
            this.groupBox1.Controls.Add(this.txtPesquisaFed);
            this.groupBox1.Controls.Add(this.cmbFed);
            this.groupBox1.Location = new System.Drawing.Point(12, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 54);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Pesquise a Federação";
            // 
            // btnProcurarFed
            // 
            this.btnProcurarFed.Location = new System.Drawing.Point(465, 17);
            this.btnProcurarFed.Name = "btnProcurarFed";
            this.btnProcurarFed.Size = new System.Drawing.Size(96, 23);
            this.btnProcurarFed.TabIndex = 4;
            this.btnProcurarFed.Text = "Pesquisar";
            this.btnProcurarFed.UseVisualStyleBackColor = true;
            this.btnProcurarFed.Click += new System.EventHandler(this.btnProcurarFed_Click);
            // 
            // txtPesquisaFed
            // 
            this.txtPesquisaFed.Location = new System.Drawing.Point(291, 19);
            this.txtPesquisaFed.Name = "txtPesquisaFed";
            this.txtPesquisaFed.Size = new System.Drawing.Size(168, 20);
            this.txtPesquisaFed.TabIndex = 5;
            // 
            // cmbFed
            // 
            this.cmbFed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFed.FormattingEnabled = true;
            this.cmbFed.Items.AddRange(new object[] {
            "Nome",
            "Estado"});
            this.cmbFed.Location = new System.Drawing.Point(164, 19);
            this.cmbFed.Name = "cmbFed";
            this.cmbFed.Size = new System.Drawing.Size(121, 21);
            this.cmbFed.TabIndex = 3;
            this.cmbFed.SelectedIndexChanged += new System.EventHandler(this.cmbFed_SelectedIndexChanged);
            // 
            // btnAdicionarFed
            // 
            this.btnAdicionarFed.Location = new System.Drawing.Point(693, 107);
            this.btnAdicionarFed.Name = "btnAdicionarFed";
            this.btnAdicionarFed.Size = new System.Drawing.Size(94, 23);
            this.btnAdicionarFed.TabIndex = 16;
            this.btnAdicionarFed.Text = "Adicionar ";
            this.btnAdicionarFed.UseVisualStyleBackColor = true;
            this.btnAdicionarFed.Click += new System.EventHandler(this.btnAdicionarFed_Click);
            // 
            // btnVerSindicatos
            // 
            this.btnVerSindicatos.Location = new System.Drawing.Point(682, 165);
            this.btnVerSindicatos.Name = "btnVerSindicatos";
            this.btnVerSindicatos.Size = new System.Drawing.Size(105, 23);
            this.btnVerSindicatos.TabIndex = 4;
            this.btnVerSindicatos.Text = "Ver Sindicatos";
            this.btnVerSindicatos.UseVisualStyleBackColor = true;
            this.btnVerSindicatos.Click += new System.EventHandler(this.btnVerSindicatos_Click);
            // 
            // btnEditarFed
            // 
            this.btnEditarFed.Location = new System.Drawing.Point(712, 136);
            this.btnEditarFed.Name = "btnEditarFed";
            this.btnEditarFed.Size = new System.Drawing.Size(75, 23);
            this.btnEditarFed.TabIndex = 6;
            this.btnEditarFed.Text = "Editar";
            this.btnEditarFed.UseVisualStyleBackColor = true;
            this.btnEditarFed.Click += new System.EventHandler(this.btnEditarFed_Click);
            // 
            // listViewFed
            // 
            this.listViewFed.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listViewFed.FullRowSelect = true;
            this.listViewFed.GridLines = true;
            this.listViewFed.HideSelection = false;
            this.listViewFed.Location = new System.Drawing.Point(12, 107);
            this.listViewFed.MultiSelect = false;
            this.listViewFed.Name = "listViewFed";
            this.listViewFed.Size = new System.Drawing.Size(664, 246);
            this.listViewFed.TabIndex = 17;
            this.listViewFed.UseCompatibleStateImageBehavior = false;
            this.listViewFed.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nome da Federação";
            this.columnHeader1.Width = 155;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Estado";
            this.columnHeader2.Width = 85;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "CNPJ";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Endereço";
            this.columnHeader4.Width = 160;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Telefone";
            this.columnHeader5.Width = 120;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 398);
            this.Controls.Add(this.listViewFed);
            this.Controls.Add(this.btnAdicionarFed);
            this.Controls.Add(this.btnEditarFed);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnVerSindicatos);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Incial - Federações";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEditarFed;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbFed;
        private System.Windows.Forms.Button btnVerSindicatos;
        private System.Windows.Forms.Button btnProcurarFed;
        private System.Windows.Forms.Button btnAdicionarFed;
        private System.Windows.Forms.TextBox txtPesquisaFed;
        private System.Windows.Forms.ListView listViewFed;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}

