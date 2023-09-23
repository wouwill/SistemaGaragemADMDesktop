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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private bool ValidarCampos()
        {
            bool ret = true;
            string campos = "";

            if (txtEmail.Text.Trim() =="")
            {
                ret = false;
                campos = "- E-mail\n";

            }
            if(txtSenha.Text.Trim() == "")
            {
                ret = false;
                campos += "- Senha";
            }
            if (!ret)
            {
                MessageBox.Show("Preencher o(s) campo(s): \n" + campos, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return ret;


        }
        private void btnAcessar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {

            }

        }
    }
}
