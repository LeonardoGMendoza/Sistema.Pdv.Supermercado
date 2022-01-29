using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaPDVBack.Controller;

namespace SistemaPDVBack.View
{
    public partial class frmVerificaLogin : Form
    {
        public frmVerificaLogin()
        {
            InitializeComponent();
        }

        bool validadodor;

        public bool Validador { get {return validadodor; } set { validadodor = value; } }
        

        private void btnOk_Click(object sender, EventArgs e)
        {
            string cargo = "";
            ControllerUsuario controllerUsuario = new ControllerUsuario(txbUsuario.Text, txbSenha.Text);

            if (controllerUsuario.Login() == false)
            {
                MessageBox.Show("Login ou senha inválidos!");
                txbUsuario.Clear();
                txbSenha.Clear();
                txbUsuario.Focus();
            }
            else
            {
                cargo = controllerUsuario.VerificaCargo();

                if (cargo == "Admin")
                {

                    validadodor = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuario não tem autorizacao para fazer esta ação!!");
                    txbUsuario.Clear();
                    txbSenha.Clear();
                    txbUsuario.Focus();

                }

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            validadodor = false;

            this.Close();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Enter:
                    btnOk.Focus();
                    break;
                case Keys.Escape:
                    btnCancelar.Focus();
                    break;

            }
            return base.ProcessCmdKey(ref msg, keyData);

        }
    }
}
