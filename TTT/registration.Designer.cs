namespace TTT
{
    partial class registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registration));
            this.lblregistration = new System.Windows.Forms.Label();
            this.lblsurname = new System.Windows.Forms.Label();
            this.lblgivenname = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblpassportnumber = new System.Windows.Forms.Label();
            this.rbmale = new System.Windows.Forms.RadioButton();
            this.lblgender = new System.Windows.Forms.Label();
            this.rbfemale = new System.Windows.Forms.RadioButton();
            this.lblphonenumber = new System.Windows.Forms.Label();
            this.lbladdress = new System.Windows.Forms.Label();
            this.tbsurname = new System.Windows.Forms.TextBox();
            this.tbgivenname = new System.Windows.Forms.TextBox();
            this.tbemail = new System.Windows.Forms.TextBox();
            this.tbpassportnumber = new System.Windows.Forms.TextBox();
            this.tbphonenumber = new System.Windows.Forms.TextBox();
            this.comboboxaddress = new System.Windows.Forms.ComboBox();
            this.bsubmit = new System.Windows.Forms.Button();
            this.lblusername = new System.Windows.Forms.Label();
            this.lblpassword = new System.Windows.Forms.Label();
            this.tbusername = new System.Windows.Forms.TextBox();
            this.tbpassword = new System.Windows.Forms.TextBox();
            this.lblgeneralinfo = new System.Windows.Forms.Label();
            this.breg_to_login = new System.Windows.Forms.Button();
            this.panel_registration = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_registration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblregistration
            // 
            this.lblregistration.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblregistration.AutoSize = true;
            this.lblregistration.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblregistration.Font = new System.Drawing.Font("Monospac821 BT", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblregistration.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblregistration.Location = new System.Drawing.Point(359, 33);
            this.lblregistration.Name = "lblregistration";
            this.lblregistration.Size = new System.Drawing.Size(334, 51);
            this.lblregistration.TabIndex = 0;
            this.lblregistration.Text = "Registration";
            this.lblregistration.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblsurname
            // 
            this.lblsurname.AutoSize = true;
            this.lblsurname.Font = new System.Drawing.Font("Monospac821 BT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsurname.Location = new System.Drawing.Point(75, 151);
            this.lblsurname.Name = "lblsurname";
            this.lblsurname.Size = new System.Drawing.Size(109, 20);
            this.lblsurname.TabIndex = 1;
            this.lblsurname.Text = "Sur name :";
            // 
            // lblgivenname
            // 
            this.lblgivenname.AutoSize = true;
            this.lblgivenname.Font = new System.Drawing.Font("Monospac821 BT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgivenname.Location = new System.Drawing.Point(56, 186);
            this.lblgivenname.Name = "lblgivenname";
            this.lblgivenname.Size = new System.Drawing.Size(129, 20);
            this.lblgivenname.TabIndex = 2;
            this.lblgivenname.Text = "Given name :";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Monospac821 BT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.Location = new System.Drawing.Point(101, 221);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(89, 20);
            this.lblemail.TabIndex = 3;
            this.lblemail.Text = "E-Mail :";
            // 
            // lblpassportnumber
            // 
            this.lblpassportnumber.AutoSize = true;
            this.lblpassportnumber.Font = new System.Drawing.Font("Monospac821 BT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpassportnumber.Location = new System.Drawing.Point(9, 302);
            this.lblpassportnumber.Name = "lblpassportnumber";
            this.lblpassportnumber.Size = new System.Drawing.Size(179, 20);
            this.lblpassportnumber.TabIndex = 4;
            this.lblpassportnumber.Text = "Passport Number :";
            // 
            // rbmale
            // 
            this.rbmale.AutoSize = true;
            this.rbmale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbmale.Location = new System.Drawing.Point(194, 260);
            this.rbmale.Name = "rbmale";
            this.rbmale.Size = new System.Drawing.Size(58, 20);
            this.rbmale.TabIndex = 5;
            this.rbmale.TabStop = true;
            this.rbmale.Text = "Male";
            this.rbmale.UseVisualStyleBackColor = true;
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.Font = new System.Drawing.Font("Monospac821 BT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgender.Location = new System.Drawing.Point(94, 259);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(89, 20);
            this.lblgender.TabIndex = 6;
            this.lblgender.Text = "Gender :";
            // 
            // rbfemale
            // 
            this.rbfemale.AutoSize = true;
            this.rbfemale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbfemale.Location = new System.Drawing.Point(292, 260);
            this.rbfemale.Name = "rbfemale";
            this.rbfemale.Size = new System.Drawing.Size(74, 20);
            this.rbfemale.TabIndex = 7;
            this.rbfemale.TabStop = true;
            this.rbfemale.Text = "Female";
            this.rbfemale.UseVisualStyleBackColor = true;
            // 
            // lblphonenumber
            // 
            this.lblphonenumber.AutoSize = true;
            this.lblphonenumber.Font = new System.Drawing.Font("Monospac821 BT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblphonenumber.Location = new System.Drawing.Point(32, 353);
            this.lblphonenumber.Name = "lblphonenumber";
            this.lblphonenumber.Size = new System.Drawing.Size(149, 20);
            this.lblphonenumber.TabIndex = 9;
            this.lblphonenumber.Text = "Phone Number :";
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.Font = new System.Drawing.Font("Monospac821 BT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdress.Location = new System.Drawing.Point(86, 395);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(99, 20);
            this.lbladdress.TabIndex = 10;
            this.lbladdress.Text = "Address :";
            // 
            // tbsurname
            // 
            this.tbsurname.Location = new System.Drawing.Point(194, 151);
            this.tbsurname.Name = "tbsurname";
            this.tbsurname.Size = new System.Drawing.Size(174, 22);
            this.tbsurname.TabIndex = 11;
            this.tbsurname.TextChanged += new System.EventHandler(this.tbsurname_TextChanged);
            // 
            // tbgivenname
            // 
            this.tbgivenname.Location = new System.Drawing.Point(194, 186);
            this.tbgivenname.Name = "tbgivenname";
            this.tbgivenname.Size = new System.Drawing.Size(174, 22);
            this.tbgivenname.TabIndex = 12;
            this.tbgivenname.TextChanged += new System.EventHandler(this.tbgivenname_TextChanged);
            // 
            // tbemail
            // 
            this.tbemail.Location = new System.Drawing.Point(194, 221);
            this.tbemail.Name = "tbemail";
            this.tbemail.Size = new System.Drawing.Size(174, 22);
            this.tbemail.TabIndex = 13;
            this.tbemail.TextChanged += new System.EventHandler(this.tbemail_TextChanged);
            // 
            // tbpassportnumber
            // 
            this.tbpassportnumber.Location = new System.Drawing.Point(194, 300);
            this.tbpassportnumber.Name = "tbpassportnumber";
            this.tbpassportnumber.Size = new System.Drawing.Size(174, 22);
            this.tbpassportnumber.TabIndex = 14;
            // 
            // tbphonenumber
            // 
            this.tbphonenumber.Location = new System.Drawing.Point(194, 351);
            this.tbphonenumber.Name = "tbphonenumber";
            this.tbphonenumber.Size = new System.Drawing.Size(174, 22);
            this.tbphonenumber.TabIndex = 15;
            // 
            // comboboxaddress
            // 
            this.comboboxaddress.FormattingEnabled = true;
            this.comboboxaddress.Items.AddRange(new object[] {
            "Dhaka",
            "Chattogram",
            "Rajshahi",
            "Barisal",
            "Rangpur",
            "Mamymansingh",
            "Khulna",
            "Sylhet"});
            this.comboboxaddress.Location = new System.Drawing.Point(194, 395);
            this.comboboxaddress.Name = "comboboxaddress";
            this.comboboxaddress.Size = new System.Drawing.Size(174, 24);
            this.comboboxaddress.TabIndex = 16;
            this.comboboxaddress.Text = "--- Select Your Area ---";
            // 
            // bsubmit
            // 
            this.bsubmit.BackColor = System.Drawing.Color.Purple;
            this.bsubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bsubmit.Font = new System.Drawing.Font("Monospac821 BT", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bsubmit.ForeColor = System.Drawing.Color.Transparent;
            this.bsubmit.Location = new System.Drawing.Point(181, 456);
            this.bsubmit.Name = "bsubmit";
            this.bsubmit.Size = new System.Drawing.Size(159, 43);
            this.bsubmit.TabIndex = 19;
            this.bsubmit.Text = "Submit";
            this.bsubmit.UseVisualStyleBackColor = false;
            this.bsubmit.Click += new System.EventHandler(this.bsubmit_Click);
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Font = new System.Drawing.Font("Monospac821 BT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.Location = new System.Drawing.Point(67, 45);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(109, 20);
            this.lblusername.TabIndex = 20;
            this.lblusername.Text = "User Name:";
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Font = new System.Drawing.Font("Monospac821 BT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpassword.Location = new System.Drawing.Point(79, 80);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(99, 20);
            this.lblpassword.TabIndex = 21;
            this.lblpassword.Text = "Password:";
            // 
            // tbusername
            // 
            this.tbusername.Location = new System.Drawing.Point(194, 45);
            this.tbusername.Name = "tbusername";
            this.tbusername.Size = new System.Drawing.Size(174, 22);
            this.tbusername.TabIndex = 22;
            this.tbusername.TextChanged += new System.EventHandler(this.tbusername_TextChanged);
            // 
            // tbpassword
            // 
            this.tbpassword.Location = new System.Drawing.Point(194, 80);
            this.tbpassword.Name = "tbpassword";
            this.tbpassword.Size = new System.Drawing.Size(174, 22);
            this.tbpassword.TabIndex = 23;
            this.tbpassword.TextChanged += new System.EventHandler(this.tbpassword_TextChanged);
            // 
            // lblgeneralinfo
            // 
            this.lblgeneralinfo.AutoSize = true;
            this.lblgeneralinfo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblgeneralinfo.Font = new System.Drawing.Font("Monospac821 BT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgeneralinfo.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblgeneralinfo.Location = new System.Drawing.Point(167, 118);
            this.lblgeneralinfo.Name = "lblgeneralinfo";
            this.lblgeneralinfo.Size = new System.Drawing.Size(199, 20);
            this.lblgeneralinfo.TabIndex = 24;
            this.lblgeneralinfo.Text = "General Information";
            this.lblgeneralinfo.Click += new System.EventHandler(this.lblgeneralinfo_Click);
            // 
            // breg_to_login
            // 
            this.breg_to_login.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.breg_to_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.breg_to_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.breg_to_login.Location = new System.Drawing.Point(3, 457);
            this.breg_to_login.Name = "breg_to_login";
            this.breg_to_login.Size = new System.Drawing.Size(75, 42);
            this.breg_to_login.TabIndex = 25;
            this.breg_to_login.Text = "<";
            this.breg_to_login.UseVisualStyleBackColor = false;
            this.breg_to_login.Click += new System.EventHandler(this.breg_to_login_Click);
            // 
            // panel_registration
            // 
            this.panel_registration.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_registration.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel_registration.Controls.Add(this.bsubmit);
            this.panel_registration.Controls.Add(this.lblusername);
            this.panel_registration.Controls.Add(this.breg_to_login);
            this.panel_registration.Controls.Add(this.lblsurname);
            this.panel_registration.Controls.Add(this.lblgeneralinfo);
            this.panel_registration.Controls.Add(this.lblgivenname);
            this.panel_registration.Controls.Add(this.tbpassword);
            this.panel_registration.Controls.Add(this.lblemail);
            this.panel_registration.Controls.Add(this.tbusername);
            this.panel_registration.Controls.Add(this.lblpassportnumber);
            this.panel_registration.Controls.Add(this.lblpassword);
            this.panel_registration.Controls.Add(this.rbmale);
            this.panel_registration.Controls.Add(this.lblgender);
            this.panel_registration.Controls.Add(this.rbfemale);
            this.panel_registration.Controls.Add(this.comboboxaddress);
            this.panel_registration.Controls.Add(this.lblphonenumber);
            this.panel_registration.Controls.Add(this.tbphonenumber);
            this.panel_registration.Controls.Add(this.lbladdress);
            this.panel_registration.Controls.Add(this.tbpassportnumber);
            this.panel_registration.Controls.Add(this.tbsurname);
            this.panel_registration.Controls.Add(this.tbemail);
            this.panel_registration.Controls.Add(this.tbgivenname);
            this.panel_registration.Location = new System.Drawing.Point(12, 42);
            this.panel_registration.Name = "panel_registration";
            this.panel_registration.Size = new System.Drawing.Size(389, 512);
            this.panel_registration.TabIndex = 26;
            this.panel_registration.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 9);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(1000, 600);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(1000, 600);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1000, 600);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.lblregistration);
            this.Controls.Add(this.panel_registration);
            this.Controls.Add(this.pictureBox1);
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "registration";
            this.Text = "registration";
            this.panel_registration.ResumeLayout(false);
            this.panel_registration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblregistration;
        private System.Windows.Forms.Label lblsurname;
        private System.Windows.Forms.Label lblgivenname;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblpassportnumber;
        private System.Windows.Forms.RadioButton rbmale;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.RadioButton rbfemale;
        private System.Windows.Forms.Label lblphonenumber;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.TextBox tbsurname;
        private System.Windows.Forms.TextBox tbgivenname;
        private System.Windows.Forms.TextBox tbemail;
        private System.Windows.Forms.TextBox tbpassportnumber;
        private System.Windows.Forms.TextBox tbphonenumber;
        private System.Windows.Forms.ComboBox comboboxaddress;
        private System.Windows.Forms.Button bsubmit;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.TextBox tbusername;
        private System.Windows.Forms.TextBox tbpassword;
        private System.Windows.Forms.Label lblgeneralinfo;
        private System.Windows.Forms.Button breg_to_login;
        private System.Windows.Forms.Panel panel_registration;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}