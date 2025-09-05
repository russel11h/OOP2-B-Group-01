namespace TTT
{
    partial class create_new_password
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
            this.lbl_newpass = new System.Windows.Forms.Label();
            this.lblcreatepass_title = new System.Windows.Forms.Label();
            this.tb_newpassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_confirm_pass = new System.Windows.Forms.TextBox();
            this.breg_to_login = new System.Windows.Forms.Button();
            this.b_newpass_confirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_newpass
            // 
            this.lbl_newpass.AutoSize = true;
            this.lbl_newpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_newpass.Location = new System.Drawing.Point(139, 196);
            this.lbl_newpass.Name = "lbl_newpass";
            this.lbl_newpass.Size = new System.Drawing.Size(202, 20);
            this.lbl_newpass.TabIndex = 22;
            this.lbl_newpass.Text = "Create new password :";
            // 
            // lblcreatepass_title
            // 
            this.lblcreatepass_title.AutoSize = true;
            this.lblcreatepass_title.BackColor = System.Drawing.SystemColors.Control;
            this.lblcreatepass_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcreatepass_title.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblcreatepass_title.Location = new System.Drawing.Point(238, 54);
            this.lblcreatepass_title.Name = "lblcreatepass_title";
            this.lblcreatepass_title.Size = new System.Drawing.Size(468, 51);
            this.lblcreatepass_title.TabIndex = 23;
            this.lblcreatepass_title.Text = "Create New Password";
            this.lblcreatepass_title.Click += new System.EventHandler(this.lblregistration_Click);
            // 
            // tb_newpassword
            // 
            this.tb_newpassword.Location = new System.Drawing.Point(356, 196);
            this.tb_newpassword.Name = "tb_newpassword";
            this.tb_newpassword.Size = new System.Drawing.Size(350, 22);
            this.tb_newpassword.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(168, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Confirm password :";
            // 
            // tb_confirm_pass
            // 
            this.tb_confirm_pass.Location = new System.Drawing.Point(356, 250);
            this.tb_confirm_pass.Name = "tb_confirm_pass";
            this.tb_confirm_pass.Size = new System.Drawing.Size(350, 22);
            this.tb_confirm_pass.TabIndex = 26;
            // 
            // breg_to_login
            // 
            this.breg_to_login.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.breg_to_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.breg_to_login.Location = new System.Drawing.Point(46, 607);
            this.breg_to_login.Name = "breg_to_login";
            this.breg_to_login.Size = new System.Drawing.Size(75, 42);
            this.breg_to_login.TabIndex = 27;
            this.breg_to_login.Text = "<";
            this.breg_to_login.UseVisualStyleBackColor = false;
            this.breg_to_login.Click += new System.EventHandler(this.breg_to_login_Click);
            // 
            // b_newpass_confirm
            // 
            this.b_newpass_confirm.BackColor = System.Drawing.SystemColors.HotTrack;
            this.b_newpass_confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_newpass_confirm.ForeColor = System.Drawing.Color.Transparent;
            this.b_newpass_confirm.Location = new System.Drawing.Point(340, 322);
            this.b_newpass_confirm.Name = "b_newpass_confirm";
            this.b_newpass_confirm.Size = new System.Drawing.Size(208, 49);
            this.b_newpass_confirm.TabIndex = 28;
            this.b_newpass_confirm.Text = "Confirm";
            this.b_newpass_confirm.UseVisualStyleBackColor = false;
            this.b_newpass_confirm.Click += new System.EventHandler(this.b_newpass_confirm_Click);
            // 
            // create_new_password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 692);
            this.Controls.Add(this.b_newpass_confirm);
            this.Controls.Add(this.breg_to_login);
            this.Controls.Add(this.tb_confirm_pass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_newpassword);
            this.Controls.Add(this.lblcreatepass_title);
            this.Controls.Add(this.lbl_newpass);
            this.Name = "create_new_password";
            this.Text = "create_new_password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_newpass;
        private System.Windows.Forms.Label lblcreatepass_title;
        private System.Windows.Forms.TextBox tb_newpassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_confirm_pass;
        private System.Windows.Forms.Button breg_to_login;
        private System.Windows.Forms.Button b_newpass_confirm;
    }
}