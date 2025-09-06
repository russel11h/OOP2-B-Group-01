namespace TTT
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_login_username = new System.Windows.Forms.Label();
            this.lblpass = new System.Windows.Forms.Label();
            this.tbpass = new System.Windows.Forms.TextBox();
            this.lblnameerror = new System.Windows.Forms.Label();
            this.lblpasserror = new System.Windows.Forms.Label();
            this.btnlogin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblregistration = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_login = new System.Windows.Forms.Panel();
            this.lblforgetpassword = new System.Windows.Forms.LinkLabel();
            this.tbname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel_login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_login_username
            // 
            this.lbl_login_username.AutoSize = true;
            this.lbl_login_username.BackColor = System.Drawing.Color.Transparent;
            this.lbl_login_username.Font = new System.Drawing.Font("Monospac821 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login_username.Location = new System.Drawing.Point(93, 44);
            this.lbl_login_username.Name = "lbl_login_username";
            this.lbl_login_username.Size = new System.Drawing.Size(130, 24);
            this.lbl_login_username.TabIndex = 0;
            this.lbl_login_username.Text = "Username :";
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblpass.Font = new System.Drawing.Font("Monospac821 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpass.Location = new System.Drawing.Point(93, 114);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(130, 24);
            this.lblpass.TabIndex = 1;
            this.lblpass.Text = "Password :";
            // 
            // tbpass
            // 
            this.tbpass.Location = new System.Drawing.Point(97, 141);
            this.tbpass.Name = "tbpass";
            this.tbpass.PasswordChar = '*';
            this.tbpass.Size = new System.Drawing.Size(262, 22);
            this.tbpass.TabIndex = 3;
            // 
            // lblnameerror
            // 
            this.lblnameerror.AutoSize = true;
            this.lblnameerror.Font = new System.Drawing.Font("Microsoft Yi Baiti", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnameerror.ForeColor = System.Drawing.Color.Firebrick;
            this.lblnameerror.Location = new System.Drawing.Point(95, 99);
            this.lblnameerror.Name = "lblnameerror";
            this.lblnameerror.Size = new System.Drawing.Size(0, 13);
            this.lblnameerror.TabIndex = 4;
            // 
            // lblpasserror
            // 
            this.lblpasserror.AutoSize = true;
            this.lblpasserror.Font = new System.Drawing.Font("Microsoft Yi Baiti", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpasserror.ForeColor = System.Drawing.Color.Firebrick;
            this.lblpasserror.Location = new System.Drawing.Point(95, 181);
            this.lblpasserror.Name = "lblpasserror";
            this.lblpasserror.Size = new System.Drawing.Size(0, 13);
            this.lblpasserror.TabIndex = 5;
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.Purple;
            this.btnlogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlogin.Font = new System.Drawing.Font("Monospac821 BT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnlogin.Location = new System.Drawing.Point(135, 215);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(124, 37);
            this.btnlogin.TabIndex = 6;
            this.btnlogin.Text = "LOG IN";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Yi Baiti", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "If you haven\'t id please go to ";
            // 
            // lblregistration
            // 
            this.lblregistration.AutoSize = true;
            this.lblregistration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblregistration.Location = new System.Drawing.Point(266, 279);
            this.lblregistration.Name = "lblregistration";
            this.lblregistration.Size = new System.Drawing.Size(79, 16);
            this.lblregistration.TabIndex = 10;
            this.lblregistration.TabStop = true;
            this.lblregistration.Text = "Registration";
            this.lblregistration.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblregistration_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Yi Baiti", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "or, If You forget your password go to ";
            // 
            // panel_login
            // 
            this.panel_login.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel_login.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel_login.Controls.Add(this.button1);
            this.panel_login.Controls.Add(this.lblforgetpassword);
            this.panel_login.Controls.Add(this.tbname);
            this.panel_login.Controls.Add(this.label3);
            this.panel_login.Controls.Add(this.lbl_login_username);
            this.panel_login.Controls.Add(this.lblregistration);
            this.panel_login.Controls.Add(this.lblpass);
            this.panel_login.Controls.Add(this.label2);
            this.panel_login.Controls.Add(this.tbpass);
            this.panel_login.Controls.Add(this.lblnameerror);
            this.panel_login.Controls.Add(this.btnlogin);
            this.panel_login.Controls.Add(this.lblpasserror);
            this.panel_login.Location = new System.Drawing.Point(3, 150);
            this.panel_login.Name = "panel_login";
            this.panel_login.Size = new System.Drawing.Size(391, 350);
            this.panel_login.TabIndex = 13;
            this.panel_login.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblforgetpassword
            // 
            this.lblforgetpassword.AutoSize = true;
            this.lblforgetpassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblforgetpassword.Location = new System.Drawing.Point(266, 309);
            this.lblforgetpassword.Name = "lblforgetpassword";
            this.lblforgetpassword.Size = new System.Drawing.Size(112, 16);
            this.lblforgetpassword.TabIndex = 12;
            this.lblforgetpassword.TabStop = true;
            this.lblforgetpassword.Text = "Forget_password";
            this.lblforgetpassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblforgetpassword_LinkClicked);
            // 
            // tbname
            // 
            this.tbname.Location = new System.Drawing.Point(98, 71);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(262, 22);
            this.tbname.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(189, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(714, 60);
            this.label1.TabIndex = 8;
            this.label1.Text = "Travel and Ticket Mangement System";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1001, 599);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(285, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Move";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel_login);
            this.Controls.Add(this.pictureBox1);
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel_login.ResumeLayout(false);
            this.panel_login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_login_username;
        private System.Windows.Forms.Label lblpass;
        private System.Windows.Forms.TextBox tbpass;
        private System.Windows.Forms.Label lblnameerror;
        private System.Windows.Forms.Label lblpasserror;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel lblregistration;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel_login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lblforgetpassword;
        private System.Windows.Forms.TextBox tbname;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}

