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
    public partial class TelaCadastroSindicato : Form
    {
        public Sindicato _sind;
        public Regionais _reg;
        public TelaCadastroSindicato()
        {
            InitializeComponent();
        }

        private void btnSalvarSind_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNomeSind.Text))
                {
                    throw new Exception("Infome o nome do Sindicato");
                }
                if (string.IsNullOrEmpty(txtRegional.Text))
                {
                    throw new Exception("Infome o regional do sindicato");
                }

                Sindicato sind = new Sindicato();
                Regionais regi = new Regionais(); 
                sind.nome = txtNomeSind.Text.Trim();
                sind.cnpj = txtCnpj.Text.Trim();
                sind.municipio = txtMunicipio.Text.Trim();
                regi.nome = txtRegional.Text.Trim();
                sind.telefone = txtTelefone.Text.Trim();
                sind.email = txtEmail.Text.Trim();
                sind.idFederacao = txtIdFederacao.Text.Trim();

                SindicatoRepositorio repositorio = new SindicatoRepositorio();
                RegionaisRepositorio repositorioreg = new RegionaisRepositorio();
                if (_sind.id < 1 && _reg.id <1)
                {
                    repositorio.Insert(sind);
                    repositorioreg.Insert(regi);
                }
                else
                {
                    sind.id = _sind.id;
                    regi.id = _reg.id;
                    repositorio.Update(sind);
                    repositorioreg.Atualizar(regi);
                }

                DialogResult yes = MessageBox.Show("Você tem certeza que deseja salvar esse Sindicato?", "Salvar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.Yes == yes)
                {
                    MessageBox.Show("Seu Sindicato foi salvo com sucesso!", "Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TelaCadastroSindicato_Load(object sender, EventArgs e)
        {
            if (_sind == null)
            {
                _sind = new Sindicato();
            }
            if(_reg == null)
            {
                _reg = new Regionais();
            }
            else
            {
                PreencherSind(_sind, _reg);
            }
        }

        public void PreencherSind(Sindicato sind, Regionais reg)
        {
            txtNomeSind.Text = sind.nome;
            txtCnpj.Text = sind.cnpj;
            txtMunicipio.Text = sind.municipio;
            txtRegional.Text = reg.nome;
            txtTelefone.Text = sind.telefone;
            txtEmail.Text = sind.email;
        }
    }
    
}
