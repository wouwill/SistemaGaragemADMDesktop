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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void marcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMarca form = new frmMarca();
            form.ShowDialog();
        }

        private void modeloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModelo form = new frmModelo();
            form.ShowDialog();
        }

        private void vendedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGerenciarVendedores form = new frmGerenciarVendedores();
            form.ShowDialog();
        }

        private void veículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVeiculo form = new frmVeiculo();
            form.ShowDialog();

        }

        private void geralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAcompanharVendas form = new frmAcompanharVendas();
            form.ShowDialog();
        }

        private void vendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAcompanharVendasVendedor form = new frmAcompanharVendasVendedor();
            form.ShowDialog();
        }
    }
}
