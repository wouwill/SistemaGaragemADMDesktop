using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GaragemAdmDesktop
{
    public partial class frmGerenciarVendedores : Form
    {
        public frmGerenciarVendedores()
        {
            InitializeComponent();
        }

        private enum EstadoTela
        {
            Inicial,
            Edicao,
        }

        private void ControlarTela(EstadoTela estadoTela)
        {
            switch (estadoTela)
            {
                case EstadoTela.Inicial:
                    btnCadastrar.Visible = true;
                    btnAlterar.Visible = false;
                    btnExcluir.Visible = false;
            

                    break;
                case EstadoTela.Edicao:

                    btnCadastrar.Visible = false;
                    btnAlterar.Visible = true;
                    btnExcluir.Visible = true;
                    break;
            }
        }

        private void LimparCampos()
        {
            txtCod.Clear();
            txtNome.Clear();
            txtEmail.Clear();
            txtEndereco.Clear();
            txtTelefone.Clear();
            txtSenha.Clear();
            chkAtivo.Checked = false;
        }

        private bool ValidarCampos()
        {
            bool ret = true;
            string campos = "";

            if (txtNome.Text.Trim() == "")
            {
                ret = false;
                campos = "- Nome \n";
            }
            if (txtEmail.Text.Trim() == "")
            {
                ret = false;
                campos += "- E-mail \n";
            }
            if (txtEndereco.Text.Trim() == "")
            {
                ret = false;
                campos += "- Endereço \n";
            }

            if (txtTelefone.Text.Trim() == "")
            {
                ret = false;
                campos += "- Telefone \n";
            }
            if (txtSenha.Text.Trim() == "")
            {
                ret = false;
                campos += "- Senha\n";
            }

            if (!ret)
            {
                MessageBox.Show("Preencher o(s) campo(s): \n" + campos, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return ret;

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                ControlarTela(EstadoTela.Inicial);
            }
            

        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ControlarTela(EstadoTela.Inicial);
            LimparCampos();

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

            if (ValidarCampos())
            {
                ControlarTela(EstadoTela.Inicial);
                LimparCampos();
            }


        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            LimparCampos();
            ControlarTela(EstadoTela.Inicial);
        }

        private void frmGerenciarVendedores_Load(object sender, EventArgs e)
        {
            ControlarTela(EstadoTela.Inicial);
        }
    }
}
