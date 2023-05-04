using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje
{
    public partial class UserFrm : Form
    {
        public string usu { get; set; }

        public UserFrm(string UserNa)
        {
            InitializeComponent();

            //Login Type
            usu = UserNa;
        }

        private void User_Load(object sender, EventArgs e)
        {
            if(usu == "Admin")
            {
                btnMod.Enabled = false;
                txtType.Text = "Administrador";
            }
            if (usu == "Gerente")
            {
                txtType.Text = "Gerente";
            }
        }

        private void DashDock_Click(object sender, EventArgs e)
        {
           if (SideVer.Width == 190)
            {
                SideVer.Width = 54;
            }
            else
            {
                SideVer.Width = 190;
            }

            DashDock.Visible = false;
            DashDockR.Visible = true;
        }

        private void DashDockR_Click(object sender, EventArgs e)
        {
            if (SideVer.Width == 54)
            {
                SideVer.Width = 190;
            }
            else
            {
                SideVer.Width = 54;
            }

            DashDockR.Visible = false;
            DashDock.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
            this.lblDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void btnMod_Click(object sender, EventArgs e)
        {

        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            AllClients ACE = AllClients.GetInstance();
            ACE.TopLevel = false;
            ACE.Dock = DockStyle.Fill;
            this.Controls.Add(ACE);
            this.Tag = ACE;
            ACE.BringToFront();
            ACE.Show();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            ProfileFrm pro = ProfileFrm.GetInstance();
            pro.TopLevel = false;
            pro.Dock = DockStyle.Fill;
            this.Controls.Add(pro);
            this.Tag = pro;
            pro.BringToFront();
            pro.Show();
        }

        //---------------Color Animation
        private void btnCliente_MouseHover(object sender, EventArgs e)
        {
            btnCliente.BackColor = Color.DarkCyan;
        }

        private void btnCliente_MouseLeave(object sender, EventArgs e)
        {
            btnCliente.BackColor = Color.Transparent;
        }

        private void btnLogOut_MouseHover(object sender, EventArgs e)
        {
            btnLogOut.BackColor = Color.DarkCyan;

            if (btnLogOut.ForeColor == Color.Transparent)
            {
                btnLogOut.ForeColor = Color.Lime;
            }
        }

        private void btnLogOut_MouseLeave(object sender, EventArgs e)
        {
            btnLogOut.BackColor = Color.Transparent;

            if (btnLogOut.ForeColor == Color.Lime)
            {
                btnLogOut.ForeColor = Color.Transparent;
            }
        }

        private void btnMod_MouseHover(object sender, EventArgs e)
        {
            btnMod.BackColor = Color.DarkCyan;
        }

        private void btnMod_MouseLeave(object sender, EventArgs e)
        {
            btnMod.BackColor = Color.Transparent;
        }

        private void btnInfo_MouseHover(object sender, EventArgs e)
        {
            btnInfo.BackColor = Color.DarkCyan;
        }

        private void btnInfo_MouseLeave(object sender, EventArgs e)
        {
            btnInfo.BackColor = Color.Transparent;
        }

        private void btnSetting_MouseHover(object sender, EventArgs e)
        {
            btnSetting.BackColor = Color.DarkCyan;
        }

        private void btnSetting_MouseLeave(object sender, EventArgs e)
        {
            btnSetting.BackColor = Color.Transparent;
        }//---------------Color Animation


        //---------------Session
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está seguro de cerrar la secion?", "Precaucion", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                LoginFrm Out;
                Out = new LoginFrm();
                Out.Show();
                this.Hide();
            }
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está seguro de cerrar la applicaion?", "Precaucion", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }//---------------Session

        //--------------Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }//-------------Drag Form


        //--------------Windows State
        int Mx, My, sh, sw;
        private void btnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MaxOut_Click(object sender, EventArgs e)
        {       
            Mx = this.Location.X;
            My = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;

            MaxOut.Visible = false;
            BtnNormal.Visible = true;
        }

        private void BtnNormal_Click(object sender, EventArgs e)
        {           
            this.Size = new Size(sw, sh);
            this.Location = new Point(Mx, My);

            MaxOut.Visible = true;
            BtnNormal.Visible = false;
        }
    }
}
