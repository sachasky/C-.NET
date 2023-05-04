namespace Proje
{
    partial class UserFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserFrm));
            this.SideVer = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtType = new System.Windows.Forms.TextBox();
            this.pnlDesk = new System.Windows.Forms.Panel();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblDate = new System.Windows.Forms.Label();
            this.BtnNormal = new System.Windows.Forms.PictureBox();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.btnMini = new System.Windows.Forms.PictureBox();
            this.DashDockR = new System.Windows.Forms.PictureBox();
            this.DashDock = new System.Windows.Forms.PictureBox();
            this.MaxOut = new System.Windows.Forms.PictureBox();
            this.HomeLogo = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.SideVer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlDesk.SuspendLayout();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnNormal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DashDockR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DashDock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomeLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SideVer
            // 
            this.SideVer.BackColor = System.Drawing.Color.Gray;
            this.SideVer.Controls.Add(this.pictureBox2);
            this.SideVer.Controls.Add(this.panel1);
            this.SideVer.Controls.Add(this.btnLogOut);
            this.SideVer.Controls.Add(this.btnInfo);
            this.SideVer.Controls.Add(this.btnSetting);
            this.SideVer.Controls.Add(this.btnMod);
            this.SideVer.Controls.Add(this.btnCliente);
            this.SideVer.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideVer.ForeColor = System.Drawing.Color.Transparent;
            this.SideVer.Location = new System.Drawing.Point(0, 0);
            this.SideVer.Name = "SideVer";
            this.SideVer.Size = new System.Drawing.Size(190, 505);
            this.SideVer.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.txtType);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(193, 53);
            this.panel1.TabIndex = 6;
            // 
            // txtType
            // 
            this.txtType.BackColor = System.Drawing.Color.Silver;
            this.txtType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtType.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtType.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtType.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtType.HideSelection = false;
            this.txtType.Location = new System.Drawing.Point(65, 18);
            this.txtType.Multiline = true;
            this.txtType.Name = "txtType";
            this.txtType.ReadOnly = true;
            this.txtType.Size = new System.Drawing.Size(123, 34);
            this.txtType.TabIndex = 6;
            this.txtType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnlDesk
            // 
            this.pnlDesk.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlDesk.Controls.Add(this.lblDate);
            this.pnlDesk.Controls.Add(this.lblTime);
            this.pnlDesk.Controls.Add(this.HomeLogo);
            this.pnlDesk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDesk.Location = new System.Drawing.Point(190, 0);
            this.pnlDesk.Name = "pnlDesk";
            this.pnlDesk.Size = new System.Drawing.Size(844, 505);
            this.pnlDesk.TabIndex = 3;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.SystemColors.MenuBar;
            this.pnlTop.Controls.Add(this.BtnNormal);
            this.pnlTop.Controls.Add(this.pbClose);
            this.pnlTop.Controls.Add(this.btnMini);
            this.pnlTop.Controls.Add(this.DashDockR);
            this.pnlTop.Controls.Add(this.DashDock);
            this.pnlTop.Controls.Add(this.MaxOut);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(190, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(844, 36);
            this.pnlTop.TabIndex = 4;
            this.pnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseDown);
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Tai Le", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.Teal;
            this.lblTime.Location = new System.Drawing.Point(559, 356);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(273, 81);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "00:00:00";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Olive;
            this.lblDate.Location = new System.Drawing.Point(600, 452);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(198, 41);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "01/01/2001";
            // 
            // BtnNormal
            // 
            this.BtnNormal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNormal.Image = global::Proje.Properties.Resources.icons8_compress_64;
            this.BtnNormal.Location = new System.Drawing.Point(758, 0);
            this.BtnNormal.Name = "BtnNormal";
            this.BtnNormal.Size = new System.Drawing.Size(40, 36);
            this.BtnNormal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnNormal.TabIndex = 5;
            this.BtnNormal.TabStop = false;
            this.BtnNormal.Visible = false;
            this.BtnNormal.Click += new System.EventHandler(this.BtnNormal_Click);
            // 
            // pbClose
            // 
            this.pbClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbClose.Image = global::Proje.Properties.Resources.icons8_cancel_64;
            this.pbClose.Location = new System.Drawing.Point(804, 0);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(40, 36);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbClose.TabIndex = 0;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // btnMini
            // 
            this.btnMini.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMini.Image = global::Proje.Properties.Resources.icons8_minimize_window_64;
            this.btnMini.Location = new System.Drawing.Point(712, 0);
            this.btnMini.Name = "btnMini";
            this.btnMini.Size = new System.Drawing.Size(40, 36);
            this.btnMini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMini.TabIndex = 4;
            this.btnMini.TabStop = false;
            this.btnMini.Click += new System.EventHandler(this.btnMini_Click);
            // 
            // DashDockR
            // 
            this.DashDockR.Cursor = System.Windows.Forms.Cursors.Default;
            this.DashDockR.Image = global::Proje.Properties.Resources.icons8_double_right_30;
            this.DashDockR.Location = new System.Drawing.Point(0, 0);
            this.DashDockR.Name = "DashDockR";
            this.DashDockR.Size = new System.Drawing.Size(18, 36);
            this.DashDockR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DashDockR.TabIndex = 2;
            this.DashDockR.TabStop = false;
            this.DashDockR.Visible = false;
            this.DashDockR.Click += new System.EventHandler(this.DashDockR_Click);
            // 
            // DashDock
            // 
            this.DashDock.Image = global::Proje.Properties.Resources.icons8_double_left_30;
            this.DashDock.Location = new System.Drawing.Point(0, 0);
            this.DashDock.Name = "DashDock";
            this.DashDock.Size = new System.Drawing.Size(18, 36);
            this.DashDock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DashDock.TabIndex = 1;
            this.DashDock.TabStop = false;
            this.DashDock.Click += new System.EventHandler(this.DashDock_Click);
            // 
            // MaxOut
            // 
            this.MaxOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaxOut.BackColor = System.Drawing.Color.Transparent;
            this.MaxOut.Image = global::Proje.Properties.Resources.icons8_maximize_window_64;
            this.MaxOut.Location = new System.Drawing.Point(758, 0);
            this.MaxOut.Name = "MaxOut";
            this.MaxOut.Size = new System.Drawing.Size(40, 36);
            this.MaxOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MaxOut.TabIndex = 3;
            this.MaxOut.TabStop = false;
            this.MaxOut.Click += new System.EventHandler(this.MaxOut_Click);
            // 
            // HomeLogo
            // 
            this.HomeLogo.Image = ((System.Drawing.Image)(resources.GetObject("HomeLogo.Image")));
            this.HomeLogo.Location = new System.Drawing.Point(240, 60);
            this.HomeLogo.Name = "HomeLogo";
            this.HomeLogo.Size = new System.Drawing.Size(300, 300);
            this.HomeLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.HomeLogo.TabIndex = 0;
            this.HomeLogo.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Proje.Properties.Resources.SkyAA;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(190, 43);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proje.Properties.Resources.icons8_user_30;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Image = global::Proje.Properties.Resources.icons8_logout_rounded_left_50;
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Location = new System.Drawing.Point(-6, 456);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(199, 49);
            this.btnLogOut.TabIndex = 4;
            this.btnLogOut.Text = "Cerrar Secion";
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            this.btnLogOut.MouseLeave += new System.EventHandler(this.btnLogOut_MouseLeave);
            this.btnLogOut.MouseHover += new System.EventHandler(this.btnLogOut_MouseHover);
            // 
            // btnInfo
            // 
            this.btnInfo.FlatAppearance.BorderSize = 0;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo.Image = global::Proje.Properties.Resources.icons8_info_48;
            this.btnInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfo.Location = new System.Drawing.Point(0, 230);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(190, 45);
            this.btnInfo.TabIndex = 1;
            this.btnInfo.Text = "Informacion";
            this.btnInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.MouseLeave += new System.EventHandler(this.btnInfo_MouseLeave);
            this.btnInfo.MouseHover += new System.EventHandler(this.btnInfo_MouseHover);
            // 
            // btnSetting
            // 
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetting.ForeColor = System.Drawing.Color.White;
            this.btnSetting.Image = global::Proje.Properties.Resources.icons8_user_settings_48;
            this.btnSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.Location = new System.Drawing.Point(0, 281);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(193, 43);
            this.btnSetting.TabIndex = 3;
            this.btnSetting.Text = "Settings";
            this.btnSetting.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            this.btnSetting.MouseLeave += new System.EventHandler(this.btnSetting_MouseLeave);
            this.btnSetting.MouseHover += new System.EventHandler(this.btnSetting_MouseHover);
            // 
            // btnMod
            // 
            this.btnMod.FlatAppearance.BorderSize = 0;
            this.btnMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMod.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMod.ForeColor = System.Drawing.Color.White;
            this.btnMod.Image = global::Proje.Properties.Resources.icons8_dashboard_layout_481;
            this.btnMod.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMod.Location = new System.Drawing.Point(0, 179);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(190, 45);
            this.btnMod.TabIndex = 3;
            this.btnMod.Text = "Modificacion";
            this.btnMod.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMod.UseVisualStyleBackColor = true;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            this.btnMod.MouseLeave += new System.EventHandler(this.btnMod_MouseLeave);
            this.btnMod.MouseHover += new System.EventHandler(this.btnMod_MouseHover);
            // 
            // btnCliente
            // 
            this.btnCliente.BackColor = System.Drawing.Color.Transparent;
            this.btnCliente.FlatAppearance.BorderSize = 0;
            this.btnCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCliente.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.ForeColor = System.Drawing.Color.White;
            this.btnCliente.Image = global::Proje.Properties.Resources.icons8_search_client_48;
            this.btnCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCliente.Location = new System.Drawing.Point(0, 128);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(190, 45);
            this.btnCliente.TabIndex = 2;
            this.btnCliente.Text = "Clientes";
            this.btnCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCliente.UseVisualStyleBackColor = false;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            this.btnCliente.MouseLeave += new System.EventHandler(this.btnCliente_MouseLeave);
            this.btnCliente.MouseHover += new System.EventHandler(this.btnCliente_MouseHover);
            // 
            // UserFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1034, 505);
            this.ControlBox = false;
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlDesk);
            this.Controls.Add(this.SideVer);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(663, 330);
            this.Name = "UserFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spa Termal";
            this.TransparencyKey = System.Drawing.SystemColors.ActiveBorder;
            this.Load += new System.EventHandler(this.User_Load);
            this.SideVer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlDesk.ResumeLayout(false);
            this.pnlDesk.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnNormal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DashDockR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DashDock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomeLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox DashDock;
        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.Panel SideVer;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.PictureBox DashDockR;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.Panel pnlDesk;
        private System.Windows.Forms.PictureBox HomeLogo;
        private System.Windows.Forms.PictureBox MaxOut;
        private System.Windows.Forms.PictureBox btnMini;
        private System.Windows.Forms.PictureBox BtnNormal;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}