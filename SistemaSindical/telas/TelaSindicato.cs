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
    public partial class TelaSindicato : Form
    {
        public Federacao _fed;
        public Sindicato _sind;
        public TelaSindicato()
        {
            InitializeComponent();
        }

        private void btnAdicionarSind_Click(object sender, EventArgs e)
        {
            TelaCadastroSindicato tela = new TelaCadastroSindicato();
            tela.ShowDialog();
        }
        private void TelaSindicato_Load(object sender, EventArgs e)
        {
            cmbSind.SelectedIndex = 0;
            List<Sindicato> lista = new SindicatoRepositorio().Selecionar();
            //List<Regionais> listareg = new RegionaisRepositorio().SelecionarTodos();
            PreencherGrid(lista);
            //PreencherGrinReg(listareg);
        }
        public void PreencherGrid(List<Sindicato> sind)
        {
            listViewSindicatos.Items.Clear();
           
            foreach (var item in sind)
            {
                ListViewItem it = new ListViewItem();
                it.Tag = item;
                it.Text = item.id.ToString();
                it.SubItems.Add(item.nome.ToString());
                listViewSindicatos.Items.Add(it);             
            }
        }
        public void PreencherGrinReg(List<Regionais> reg)
        {
            listViewSindicatos.Items.Clear();
            foreach (var items in reg)
            {
                ListViewItem its = new ListViewItem();
                its.Tag = items;
                //its.Text = items.nome.ToString();   
                its.SubItems.Add(items.nome.ToString());
                listViewSindicatos.Items.Add(its);
            }
        }
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPesquisa.Text))
            {
                MessageBox.Show("Você não pesquisou nenhum Sindicato ou regional", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            int tipoPesquisa = cmbSind.SelectedIndex;
            List<Sindicato> lista = new SindicatoRepositorio().Pesquisar(tipoPesquisa, txtPesquisa.Text.Trim());
            List<Regionais> listareg = new RegionaisRepositorio().Pesquisar(tipoPesquisa, txtPesquisa.Text.Trim());
            PreencherGrid(lista);
            PreencherGrinReg(listareg);
        }
        private void btnVerSocio_Click(object sender, EventArgs e)
        {
            try
            {

                if (listViewSindicatos.SelectedItems.Count > 0)
                {
                    Sindicato sind = (Sindicato)listViewSindicatos.SelectedItems[0].Tag;
                    TelaSocio tela = new TelaSocio();
                    tela._sind = sind;
                    tela.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Você não escolheu a federação\n Escolha a federação para prosseguir!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                
            }
        }
        private void btnAdicionarSocio_Click(object sender, EventArgs e)
        {

        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewSindicatos.SelectedItems.Count > 0)
                {
                    Sindicato sind = (Sindicato)listViewSindicatos.SelectedItems[0].Tag;
                    TelaCadastroSindicato tela = new TelaCadastroSindicato();
                    tela._sind = sind;
                    tela.ShowDialog();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Nenhum sindicato foi selecionado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (listViewSindicatos.SelectedItems.Count > 0)
            {
                DialogResult result = MessageBox.Show("Deseja excluir mesmo esse sindicato? ", "Exluir sindicato", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Sindicato sind = (Sindicato)listViewSindicatos.SelectedItems[0].Tag;
                    new SindicatoRepositorio().Delete(sind.id);
                    List<Sindicato> lista = new SindicatoRepositorio().Selecionar();
                    PreencherGrid(lista);
                }
            }
            else
            {
                MessageBox.Show("Selecione um sindicato para excluir");
            }
        }
    }
}
