using SistemaSindical.model;
using SistemaSindical.repositorio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaSindical.telas
{
    public partial class TelaSocio : Form
    {
        public Sindicato _sind;
        public TelaSocio()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            TelaCadastroSocio tela = new TelaCadastroSocio();
            tela.ShowDialog();
        }
        private void TelaSocio_Load(object sender, EventArgs e)
        {
            cmbSocio.SelectedIndex = 0;
            List<Socio> lista = new SocioRepositorio().SelecionarTodos();
            PreencherGrid(lista);
        }
        public void PreencherGrid(List<Socio> socio)
        {
            listViewSocio.Items.Clear();

            foreach (var item in socio)
            {
                ListViewItem it = new ListViewItem();
                it.Tag = item;
                it.Text = item.nome.ToString();
                it.SubItems.Add(item.cpf);
                it.SubItems.Add(item.dataNascimento.ToString("dd/MM/yyyy"));
                it.SubItems.Add(item.sexo.ToString());
                it.SubItems.Add(item.telefone);
                listViewSocio.Items.Add(it);
            }
        }
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPesquisa.Text))
            {
                MessageBox.Show("Você não pesquisou nenhum sócio", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            int tipoPesquisa = cmbSocio.SelectedIndex;
            List<Socio> lista = new SocioRepositorio().Pesquisar(tipoPesquisa, txtPesquisa.Text.Trim());
            PreencherGrid(lista);
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewSocio.SelectedItems.Count > 0)
                {
                    Socio socio = (Socio)listViewSocio.SelectedItems[0].Tag;
                    TelaCadastroSocio tela = new TelaCadastroSocio();
                    tela._socio = socio;
                    tela.ShowDialog();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Nenhum sócio foi selecionado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (listViewSocio.SelectedItems.Count > 0)
            {
                DialogResult result = MessageBox.Show("Deseja excluir mesmo esse sócio? ", "Exluir sócio", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Socio socio = (Socio)listViewSocio.SelectedItems[0].Tag;
                    new SocioRepositorio().Delete(socio.id);
                    List<Socio> lista = new SocioRepositorio().SelecionarTodos();
                    PreencherGrid(lista);
                }
            }
            else
            {
                MessageBox.Show("Selecione um sócio para excluir");
            }
        }
    }
}
