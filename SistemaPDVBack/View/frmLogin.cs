using SistemaPDVBack.Controller;
using SistemaPDVBack.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaPDVBack.View
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void lineShape1_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

      
        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txbUsuario_Enter(object sender, EventArgs e)
        {
            if(txbUsuario.Text == "USUARIO")
            {
                txbUsuario.Text = "";
                txbUsuario.ForeColor = Color.LightGray;
            }
        }

        private void txbUsuario_Leave(object sender, EventArgs e)
        {
            if (txbUsuario.Text == "")
            {
                txbUsuario.Text = "USUARIO";
                txbUsuario.ForeColor = Color.DimGray;
            }
        }

        private void txbSenha_Enter(object sender, EventArgs e)
        {
            if (txbSenha.Text == "SENHA")
            {
                txbSenha.Text = "";
                txbSenha.ForeColor = Color.LightGray;
                txbSenha.UseSystemPasswordChar = true;
            }
        }

        private void txbSenha_Leave(object sender, EventArgs e)
        {
            if (txbSenha.Text == "")
            {
                txbSenha.Text = "SENHA";
                txbSenha.ForeColor = Color.DimGray;
                txbSenha.UseSystemPasswordChar = false;


            }
        }

        private void frmLogin_MouseDown(object sender, MouseEventArgs e)
        {
         
            MoverForm.ReleaseCapture();
            MoverForm.SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string cargo = "";
            ControllerUsuario controllerUsuario = new ControllerUsuario(txbUsuario.Text , txbSenha.Text);
          
            if(controllerUsuario.Login() == false)
            {
                MessageBox.Show("Login ou senha inválidos!");
            }
            else
            {
                cargo = controllerUsuario.VerificaCargo();

                if(cargo  == "Admin")
                {
                    frmMenuTeste frmMenu = new frmMenuTeste();
                                      
                    frmMenu.Show();
                    frmMenu.FormClosed += LogOut;
                    this.Hide();
                }
                else
                {
                    frmTelaPdv frmPdv = new frmTelaPdv();

                    frmPdv.Show();
                    frmPdv.FormClosed += LogOut;
                    this.Hide();

                }

            }
        }

        private void LogOut(object sender, FormClosedEventArgs e)
        {
            txbSenha.Text = "SENHA";
            txbSenha.UseSystemPasswordChar = false;

            txbUsuario.Text = "USUARIO";

            this.Show();
            txbUsuario.Focus();

        }
    }
}
