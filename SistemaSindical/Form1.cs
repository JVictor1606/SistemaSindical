using SistemaSindical.model;
using SistemaSindical.repositorio;
using SistemaSindical.telas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaSindical
{
    public partial class Form1 : Form
    {
        public Federacao _fed;
        public Form1()
        {
            InitializeComponent();
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cmbFed.SelectedIndex = 0;
            List<Federacao> lista = new FederacaoRepositorio().SelecionarTodosFed();
            PreencherGrid(lista);
        }
        private void cmbFed_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void btnProcurarFed_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPesquisaFed.Text))
            {
                MessageBox.Show("Você não pesquisou nenhuma federação", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            int tipoPesquisa = cmbFed.SelectedIndex;
            List<Federacao> lista = new FederacaoRepositorio().Pesquisar(tipoPesquisa, txtPesquisaFed.Text.Trim());
            PreencherGrid(lista);     
        }
        public void PreencherGrid(List<Federacao> fed)
        {
            listViewFed.Items.Clear();

            foreach (var item in fed)
            {
                ListViewItem it = new ListViewItem();
                it.Tag = item;
                it.Text = item.nome.ToString();
                it.SubItems.Add(item.estado);
                it.SubItems.Add(item.cnpj);
                it.SubItems.Add(item.endereco);
                it.SubItems.Add(item.telefone);
                listViewFed.Items.Add(it);
            }
        }
        private void btnEditarFed_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewFed.SelectedItems.Count > 0)
                {
                    Federacao fed = (Federacao)listViewFed.SelectedItems[0].Tag;
                    TelaFederacao tela = new TelaFederacao();
                    tela._fed = fed;
                    tela.ShowDialog();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Nenhuma federacão foi selecionada", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }          
        }
        private void btnAdicionarFed_Click(object sender, EventArgs e)
        {
            TelaFederacao tela = new TelaFederacao();
            tela.ShowDialog();
        }
        private void btnVerSindicatos_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewFed.SelectedItems.Count > 0)
                {
                    Federacao fed = (Federacao)listViewFed.SelectedItems[0].Tag;
                    TelaSindicato tela = new TelaSindicato();
                    tela._fed = fed;
                    tela.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Você não escolheu a federação\n Escolha a federação para prosseguir!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
