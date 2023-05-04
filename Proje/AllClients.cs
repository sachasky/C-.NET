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
    public partial class AllClients : Form
    {
        public AllClients()
        {
            InitializeComponent();
        }

        private static AllClients instance;
        public static AllClients GetInstance()
        {
            if (instance == null || instance.IsDisposed)          
                instance = new AllClients();          
            else
                instance.BringToFront();
                return instance;        
        }

        private void AllClients_Load(object sender, EventArgs e)
        {


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Client CE = new Client();
            CE.Show();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        
    }
}
