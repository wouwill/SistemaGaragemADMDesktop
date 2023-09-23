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
    public partial class frmMarca : Form
    {
        public frmMarca()
        {
            InitializeComponent();
        }
        private void frmMarca_Load(object sender, EventArgs e)
        {
            ControlarTela(EstadoTela.Inicial);

        }
        private enum EstadoTela
        {
            Inicial,
            Edicao
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
            txtCodigo.Clear();
            txtMarca.Clear();
            txtMarca.Focus();
        }
        private bool ValidarCampos()
        {
            bool ret = true;
            string campos = "";

            if (txtMarca.Text.Trim() == "")
            {
                ret = false;
                campos = "- Marca";
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

            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            ControlarTela(EstadoTela.Inicial);
        }
    }
}
