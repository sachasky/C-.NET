using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje
{
    public partial class LoginFrm : Form
    {
        UserFrm AdmFrm;
        
        public LoginFrm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //-----------------Winodw State
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minim_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }//-----------------Winodw State

        private void btnLogin_Click(object sender, EventArgs e)
        {

            String usu = txtUsuario.Text;
            String passwd = txtPassword.Text;

            if(usu == "Gerente" && passwd == "Gerente")
            {
                this.Hide();
                AdmFrm = new UserFrm(usu);
                AdmFrm.Show();
            }
            else if (usu == "Admin" && passwd == "Admin")
            {
                AdmFrm = new UserFrm(usu);
                this.Hide();
                AdmFrm.Show();
            }
            else
            {
                MessageBox.Show("Error Usuario y/o Contraseña mal ingresada");
            }
        }

        //----------------Login Action
        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if(txtUsuario.Text == "Usuario")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.White;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Usuario";
                txtUsuario.ForeColor = Color.LightGray;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Contraseña")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.White;
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Contraseña";
                txtPassword.ForeColor = Color.LightGray;
                txtPassword.UseSystemPasswordChar = false;
            }
        }//----------------Login Action

    }
}
