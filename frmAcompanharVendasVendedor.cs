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
    public partial class frmAcompanharVendasVendedor : Form
    {
        public frmAcompanharVendasVendedor()
        {
            InitializeComponent();
        }

        private bool ValidarSelecao()
        {
            bool ret = true;

            if(cbVendedor.SelectedIndex == -1)
            {
                ret = false;
            }
            if (!ret)
            {
                MessageBox.Show("Selecione um vendedor para fazer a pesquisa", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return ret;
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {

        }
    }
}
