namespace TTT
{
    partial class Home_page
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
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.breg_to_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_welcome.Location = new System.Drawing.Point(390, 219);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(166, 32);
            this.lbl_welcome.TabIndex = 0;
            this.lbl_welcome.Text = "WELCOME";
            // 
            // breg_to_login
            // 
            this.breg_to_login.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.breg_to_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.breg_to_login.Location = new System.Drawing.Point(54, 603);
            this.breg_to_login.Name = "breg_to_login";
            this.breg_to_login.Size = new System.Drawing.Size(75, 42);
            this.breg_to_login.TabIndex = 28;
            this.breg_to_login.Text = "<";
            this.breg_to_login.UseVisualStyleBackColor = false;
            this.breg_to_login.Click += new System.EventHandler(this.breg_to_login_Click);
            // 
            // Home_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 696);
            this.Controls.Add(this.breg_to_login);
            this.Controls.Add(this.lbl_welcome);
            this.Name = "Home_page";
            this.Text = "Home_page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_welcome;
        private System.Windows.Forms.Button breg_to_login;
    }
}