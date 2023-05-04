namespace Proje
{
    partial class Client
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
            this.txtCliNom = new System.Windows.Forms.TextBox();
            this.txtCliApe = new System.Windows.Forms.TextBox();
            this.txtCliCedu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTelef = new System.Windows.Forms.TextBox();
            this.btnOkCli = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Close)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCliNom
            // 
            this.txtCliNom.Location = new System.Drawing.Point(169, 128);
            this.txtCliNom.Name = "txtCliNom";
            this.txtCliNom.Size = new System.Drawing.Size(139, 20);
            this.txtCliNom.TabIndex = 2;
            // 
            // txtCliApe
            // 
            this.txtCliApe.Location = new System.Drawing.Point(169, 178);
            this.txtCliApe.Name = "txtCliApe";
            this.txtCliApe.Size = new System.Drawing.Size(139, 20);
            this.txtCliApe.TabIndex = 3;
            // 
            // txtCliCedu
            // 
            this.txtCliCedu.Location = new System.Drawing.Point(169, 79);
            this.txtCliCedu.Name = "txtCliCedu";
            this.txtCliCedu.Size = new System.Drawing.Size(139, 20);
            this.txtCliCedu.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cedula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefono";
            // 
            // txtTelef
            // 
            this.txtTelef.Location = new System.Drawing.Point(169, 224);
            this.txtTelef.Name = "txtTelef";
            this.txtTelef.Size = new System.Drawing.Size(139, 20);
            this.txtTelef.TabIndex = 4;
            // 
            // btnOkCli
            // 
            this.btnOkCli.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnOkCli.Location = new System.Drawing.Point(286, 271);
            this.btnOkCli.Name = "btnOkCli";
            this.btnOkCli.Size = new System.Drawing.Size(87, 26);
            this.btnOkCli.TabIndex = 6;
            this.btnOkCli.Text = "OK";
            this.btnOkCli.UseVisualStyleBackColor = true;
            // 
            // Close
            // 
            this.Close.Image = global::Proje.Properties.Resources.icons8_close_window_50;
            this.Close.Location = new System.Drawing.Point(12, 12);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(47, 31);
            this.Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Close.TabIndex = 5;
            this.Close.TabStop = false;
            this.Close.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(649, 342);
            this.Controls.Add(this.btnOkCli);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.txtTelef);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCliCedu);
            this.Controls.Add(this.txtCliApe);
            this.Controls.Add(this.txtCliNom);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Client";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client";
            ((System.ComponentModel.ISupportInitialize)(this.Close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCliNom;
        private System.Windows.Forms.TextBox txtCliApe;
        private System.Windows.Forms.TextBox txtCliCedu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTelef;
        private System.Windows.Forms.PictureBox Close;
        private System.Windows.Forms.Button btnOkCli;
    }
}