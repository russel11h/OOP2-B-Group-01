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
            this.lblusername_email = new System.Windows.Forms.Label();
            this.lblregistration = new System.Windows.Forms.Label();
            this.tb_username_email = new System.Windows.Forms.TextBox();
            this.bsend = new System.Windows.Forms.Button();
            this.breg_to_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblusername_email
            // 
            this.lblusername_email.AutoSize = true;
            this.lblusername_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername_email.Location = new System.Drawing.Point(114, 211);
            this.lblusername_email.Name = "lblusername_email";
            this.lblusername_email.Size = new System.Drawing.Size(187, 20);
            this.lblusername_email.TabIndex = 21;
            this.lblusername_email.Text = "User Name / E-Mail :";
            // 
            // lblregistration
            // 
            this.lblregistration.AutoSize = true;
            this.lblregistration.BackColor = System.Drawing.SystemColors.Control;
            this.lblregistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblregistration.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblregistration.Location = new System.Drawing.Point(246, 74);
            this.lblregistration.Name = "lblregistration";
            this.lblregistration.Size = new System.Drawing.Size(473, 51);
            this.lblregistration.TabIndex = 22;
            this.lblregistration.Text = "Recover Your Account";
            // 
            // tb_username_email
            // 
            this.tb_username_email.Location = new System.Drawing.Point(314, 211);
            this.tb_username_email.Name = "tb_username_email";
            this.tb_username_email.Size = new System.Drawing.Size(350, 22);
            this.tb_username_email.TabIndex = 23;
            // 
            // bsend
            // 
            this.bsend.BackColor = System.Drawing.SystemColors.HotTrack;
            this.bsend.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bsend.ForeColor = System.Drawing.Color.Transparent;
            this.bsend.Location = new System.Drawing.Point(314, 323);
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
            this.breg_to_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.breg_to_login.Location = new System.Drawing.Point(42, 577);
            this.breg_to_login.Name = "breg_to_login";
            this.breg_to_login.Size = new System.Drawing.Size(75, 42);
            this.breg_to_login.TabIndex = 26;
            this.breg_to_login.Text = "<";
            this.breg_to_login.UseVisualStyleBackColor = false;
            this.breg_to_login.Click += new System.EventHandler(this.breg_to_login_Click);
            // 
            // forget_pass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 691);
            this.Controls.Add(this.breg_to_login);
            this.Controls.Add(this.bsend);
            this.Controls.Add(this.tb_username_email);
            this.Controls.Add(this.lblregistration);
            this.Controls.Add(this.lblusername_email);
            this.Name = "forget_pass";
            this.Text = "forget_pass";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblusername_email;
        private System.Windows.Forms.Label lblregistration;
        private System.Windows.Forms.TextBox tb_username_email;
        private System.Windows.Forms.Button bsend;
        private System.Windows.Forms.Button breg_to_login;
    }
}