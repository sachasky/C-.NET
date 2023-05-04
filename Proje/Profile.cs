﻿using System;
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
    public partial class ProfileFrm : Form
    {

        public ProfileFrm()
        {
            InitializeComponent();
        }

        private void Profile_Load(object sender, EventArgs e)
        {
           
        }

        private static ProfileFrm instance;
        public static ProfileFrm GetInstance()
        {
            if (instance == null || instance.IsDisposed)
                instance = new ProfileFrm();
            else
                instance.BringToFront();
            return instance;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
           pnlEdit.Visible = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlEdit.Visible = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            pnlEdit.Visible = false;
        }
    }
}
