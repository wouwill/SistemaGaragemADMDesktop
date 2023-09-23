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
    public partial class frmModelo : Form
    {
        private void LimparCampos()
        {
            txtCodigo.Clear();
            txtModelo.Clear();
            cbMarca.SelectedIndex = -1;
            txtModelo.Focus();
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
                    btnCancelar.Visible = true;
                    btnAlterar.Visible = false;
                    btnExcluir.Visible = false;

                    break;
                case EstadoTela.Edicao:
                    btnCadastrar.Visible = false;
                    btnCancelar.Visible = true;
                    btnAlterar.Visible = true;
                    btnExcluir.Visible = true;
                    break;

            }


        }

        private bool ValidarCampos()
        {
            bool ret = true;
            string campos = "";

            if (txtModelo.Text.Trim() == "")
            {
                ret = false;
                campos = "- Modelo\n";
            }
            if (cbMarca.SelectedIndex == -1)
            {
                ret = false;
                campos += "- Marca";
            }

            if (!ret)
            {
                MessageBox.Show("Preencha o(s) campo(s): \n" + campos, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            return ret;

        }



        public frmModelo()
        {
            InitializeComponent();
        }

        private void frmModelo_Load(object sender, EventArgs e)
        {
            ControlarTela(EstadoTela.Inicial);
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
