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
    public partial class frmVeiculo : Form
    {
        private void LimparCampos()
        {
            txtCodigo.Clear();
            cbMarca.SelectedIndex = -1;
            cbModelo.SelectedIndex = -1;
            txtAno.Clear();
            txtQuilometragem.Clear();
            cbQtdPortas.SelectedIndex = -1;
            txtValorCompra.Clear();
            txtValorVenda.Clear();
            txtDescricao.Clear();
            cbSituacao.SelectedIndex = -1;

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
                    break;

                case EstadoTela.Edicao:
                    btnCadastrar.Visible = false;
                    btnAlterar.Visible = true;
                    break;
            }
                
        }

        private bool ValidarCampos()
        {
            bool ret = true;
            string campos = "";

            if(cbMarca.SelectedIndex == -1)
            {
                ret = false;
                campos = "- Marca\n";
            }
            if(cbModelo.SelectedIndex == -1)
            {
                ret = false;
                campos += "- Modelo\n";
            }
            if(txtAno.Text.Trim() == "")
            {
                ret = false;
                campos += "- Ano\n";
            }
            if (txtQuilometragem.Text.Trim() == "")
            {
                ret = false;
                campos += "- Quilometragem\n";
            }
            if (cbQtdPortas.SelectedIndex == -1)
            {
                ret = false;
                campos += "- Portas\n";

            }
            if (txtValorCompra.Text.Trim() == "")
            {
                ret = false;
                campos += "- Valor de compra\n";
            }
            if(txtValorVenda.Text.Trim() == "")
            {
                ret = false;
                campos += "- Valor de venda\n";
            }
            if (cbSituacao.SelectedIndex == -1)
            {
                ret = false;
                campos += "- Situação\n";
            }
            if (!ret)
            {
                MessageBox.Show("Preencha o(s) campo(s): \n" + campos, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            return ret;

        }

        public frmVeiculo()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                
            }


        }

        private void frmVeiculo_Load(object sender, EventArgs e)
        {
            ControlarTela(EstadoTela.Inicial);
        }
    }
}
