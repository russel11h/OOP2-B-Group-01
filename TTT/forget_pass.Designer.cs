namespace TTT
{
    partial class forget_pass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(forget_pass));
            this.lblusername_email = new System.Windows.Forms.Label();
            this.lblregistration = new System.Windows.Forms.Label();
            this.tb_username_email = new System.Windows.Forms.TextBox();
            this.bsend = new System.Windows.Forms.Button();
            this.breg_to_login = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblusername_email
            // 
            this.lblusername_email.AutoSize = true;
            this.lblusername_email.BackColor = System.Drawing.Color.Transparent;
            this.lblusername_email.Font = new System.Drawing.Font("Monospac821 BT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername_email.Location = new System.Drawing.Point(3, 74);
            this.lblusername_email.Name = "lblusername_email";
            this.lblusername_email.Size = new System.Drawing.Size(209, 20);
            this.lblusername_email.TabIndex = 21;
            this.lblusername_email.Text = "User Name / E-Mail :";
            // 
            // lblregistration
            // 
            this.lblregistration.AutoSize = true;
            this.lblregistration.BackColor = System.Drawing.Color.White;
            this.lblregistration.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblregistration.ForeColor = System.Drawing.Color.Blue;
            this.lblregistration.Location = new System.Drawing.Point(187, 44);
            this.lblregistration.Name = "lblregistration";
            this.lblregistration.Size = new System.Drawing.Size(452, 43);
            this.lblregistration.TabIndex = 22;
            this.lblregistration.Text = "Recover Your Account";
            // 
            // tb_username_email
            // 
            this.tb_username_email.Location = new System.Drawing.Point(7, 108);
            this.tb_username_email.Name = "tb_username_email";
            this.tb_username_email.Size = new System.Drawing.Size(302, 22);
            this.tb_username_email.TabIndex = 23;
            this.tb_username_email.TextChanged += new System.EventHandler(this.tb_username_email_TextChanged);
            // 
            // bsend
            // 
            this.bsend.BackColor = System.Drawing.Color.Purple;
            this.bsend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bsend.Font = new System.Drawing.Font("Monospac821 BT", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bsend.ForeColor = System.Drawing.Color.Transparent;
            this.bsend.Location = new System.Drawing.Point(55, 192);
            this.bsend.Name = "bsend";
            this.bsend.Size = new System.Drawing.Size(208, 49);
            this.bsend.TabIndex = 24;
            this.bsend.Text = "Send";
            this.bsend.UseVisualStyleBackColor = false;
            this.bsend.Click += new System.EventHandler(this.bsend_Click);
            // 
            // breg_to_login
            // 
            this.breg_to_login.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.breg_to_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.breg_to_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.breg_to_login.Location = new System.Drawing.Point(7, 280);
            this.breg_to_login.Name = "breg_to_login";
            this.breg_to_login.Size = new System.Drawing.Size(75, 42);
            this.breg_to_login.TabIndex = 26;
            this.breg_to_login.Text = "<";
            this.breg_to_login.UseVisualStyleBackColor = false;
            this.breg_to_login.Click += new System.EventHandler(this.breg_to_login_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblusername_email);
            this.panel1.Controls.Add(this.breg_to_login);
            this.panel1.Controls.Add(this.tb_username_email);
            this.panel1.Controls.Add(this.bsend);
            this.panel1.Location = new System.Drawing.Point(50, 158);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(327, 349);
            this.panel1.TabIndex = 27;
            // 
            // forget_pass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblregistration);
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "forget_pass";
            this.Text = "forget_pass";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblusername_email;
        private System.Windows.Forms.Label lblregistration;
        private System.Windows.Forms.TextBox tb_username_email;
        private System.Windows.Forms.Button bsend;
        private System.Windows.Forms.Button breg_to_login;
        private System.Windows.Forms.Panel panel1;
    }
}