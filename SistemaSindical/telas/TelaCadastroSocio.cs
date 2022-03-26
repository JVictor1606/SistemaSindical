using SistemaSindical.model;
using SistemaSindical.repositorio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaSindical.telas
{
    public partial class TelaCadastroSocio : Form
    {
        public Socio _socio;
        public TelaCadastroSocio()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime dtNascimento;
                if (string.IsNullOrEmpty(txtNomeSocio.Text))
                {
                    throw new Exception("Informe o nome do sócio");
                }
                if (!DateTime.TryParseExact(txtDataNascimento.Text, "dd/MM/yyyy",
                    CultureInfo.InvariantCulture, DateTimeStyles.None, out dtNascimento))
                {
                    throw new Exception("A data informada é invalida");
                }
                if(string.IsNullOrEmpty(txtIdSindicato.Text))
                {
                    throw new Exception("Informe o ID do sindicato do sócio");
                }
                Socio socio = new Socio();
                socio.nome = txtNomeSocio.Text.Trim();
                socio.cpf = txtCpf.Text.Trim();
                socio.dataNascimento = Convert.ToDateTime(txtDataNascimento.Text);
                socio.telefone = txtTelefone.Text.Trim();
                socio.idSindicato = txtIdSindicato.Text.Trim(); 
                socio.sexo = rdbSexo.Checked ? 'M' : 'F';
                if (rdbSexo.Checked)
                {
                    socio.sexo = 'M';
                }
                else
                {
                    socio.sexo = 'F';
                }

                SocioRepositorio repositorio = new SocioRepositorio();
                if (_socio.id < 1)
                {
                    repositorio.Insert(socio);
                }
                else
                {
                    socio.id = _socio.id;
                    repositorio.Update(socio);
                }

                DialogResult yes = MessageBox.Show("Você tem certeza que deseja salvar esse sócio?", "Salvar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.Yes == yes)
                {
                    MessageBox.Show("Seu registro foi salvo com sucesso!", "Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }  
            }
            catch (Exception ex)
            {
              MessageBox.Show(ex.Message,"Erro",MessageBoxButtons.OK, MessageBoxIcon.Error);  
            }
        }

        private void TelaCadastroSocio_Load(object sender, EventArgs e)
        {
            if(_socio == null)
            {
                _socio = new Socio();
            }
            else
            {
                PreencherSocio(_socio);
            }
        }
        public void PreencherSocio(Socio socio)
        {
            txtNomeSocio.Text = socio.nome;
            txtCpf.Text = socio.cpf;
            txtDataNascimento.Text = socio.dataNascimento.ToString("dd/MM/yyyy");
            txtTelefone.Text = socio.telefone;
            txtIdSindicato.Text = socio.idSindicato;
            rdbSexo.Checked = socio.sexo == 'M';
            rdbFeminino.Checked = socio.sexo == 'F';

        }
    }
}
