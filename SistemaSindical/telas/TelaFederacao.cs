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
    public partial class TelaFederacao : Form
    {
        public Federacao _fed;
        public TelaFederacao()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrEmpty(txtNome.Text))
                {
                    throw new Exception("Infome o nome da Federação");
                }
                if (string.IsNullOrEmpty(txtEstado.Text))
                {
                    throw new Exception("Infome o estado da Federação");
                }

                Federacao fed = new Federacao();
                fed.nome = txtNome.Text.Trim();
                fed.estado = txtEstado.Text.Trim();
                fed.endereco = txtEndereco.Text.Trim();
                fed.cnpj = txtCnpj.Text.Trim();
                fed.telefone = txtTelefone.Text.Trim();

                FederacaoRepositorio repositorio = new FederacaoRepositorio();
                if(_fed.id < 1)
                {
                    repositorio.Insert(fed);
                }
                else
                {
                    fed.id = _fed.id;
                    repositorio.Atualizar(fed);
                }

                DialogResult yes = MessageBox.Show("Você tem certeza que deseja salvar essa federeção?", "Salvar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(DialogResult.Yes == yes )
                {
                    MessageBox.Show("Sua federação foi salva com sucesso!", "Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void TelaFederacao_Load(object sender, EventArgs e)
        {
            if(_fed == null)
            {
                _fed = new Federacao();
            }
            else
            {
                PreencherFed(_fed);
            }
        }   
        public void PreencherFed(Federacao fed)
        {
            txtNome.Text = fed.nome;
            txtCnpj.Text = fed.cnpj;
            txtEstado.Text = fed.estado;
            txtEndereco.Text = fed.endereco;
            txtTelefone.Text = fed.telefone;
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
