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
            this.lblregistrationdate = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.bsubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblregistration
            // 
            this.lblregistration.AutoSize = true;
            this.lblregistration.BackColor = System.Drawing.SystemColors.Control;
            this.lblregistration.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblregistration.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblregistration.Location = new System.Drawing.Point(310, 36);
            this.lblregistration.Name = "lblregistration";
            this.lblregistration.Size = new System.Drawing.Size(267, 52);
            this.lblregistration.TabIndex = 0;
            this.lblregistration.Text = "Registration";
            this.lblregistration.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblsurname
            // 
            this.lblsurname.AutoSize = true;
            this.lblsurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsurname.Location = new System.Drawing.Point(167, 117);
            this.lblsurname.Name = "lblsurname";
            this.lblsurname.Size = new System.Drawing.Size(101, 20);
            this.lblsurname.TabIndex = 1;
            this.lblsurname.Text = "Sur name :";
            // 
            // lblgivenname
            // 
            this.lblgivenname.AutoSize = true;
            this.lblgivenname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgivenname.Location = new System.Drawing.Point(148, 152);
            this.lblgivenname.Name = "lblgivenname";
            this.lblgivenname.Size = new System.Drawing.Size(120, 20);
            this.lblgivenname.TabIndex = 2;
            this.lblgivenname.Text = "Given name :";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.Location = new System.Drawing.Point(193, 187);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(75, 20);
            this.lblemail.TabIndex = 3;
            this.lblemail.Text = "E-Mail :";
            // 
            // lblpassportnumber
            // 
            this.lblpassportnumber.AutoSize = true;
            this.lblpassportnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpassportnumber.Location = new System.Drawing.Point(101, 268);
            this.lblpassportnumber.Name = "lblpassportnumber";
            this.lblpassportnumber.Size = new System.Drawing.Size(167, 20);
            this.lblpassportnumber.TabIndex = 4;
            this.lblpassportnumber.Text = "Passport Number :";
            // 
            // rbmale
            // 
            this.rbmale.AutoSize = true;
            this.rbmale.Location = new System.Drawing.Point(286, 226);
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
            this.lblgender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgender.Location = new System.Drawing.Point(186, 225);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(82, 20);
            this.lblgender.TabIndex = 6;
            this.lblgender.Text = "Gender :";
            // 
            // rbfemale
            // 
            this.rbfemale.AutoSize = true;
            this.rbfemale.Location = new System.Drawing.Point(371, 226);
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
            this.lblphonenumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblphonenumber.Location = new System.Drawing.Point(124, 319);
            this.lblphonenumber.Name = "lblphonenumber";
            this.lblphonenumber.Size = new System.Drawing.Size(144, 20);
            this.lblphonenumber.TabIndex = 9;
            this.lblphonenumber.Text = "Phone Number :";
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdress.Location = new System.Drawing.Point(178, 361);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(90, 20);
            this.lbladdress.TabIndex = 10;
            this.lbladdress.Text = "Address :";
            // 
            // tbsurname
            // 
            this.tbsurname.Location = new System.Drawing.Point(286, 117);
            this.tbsurname.Name = "tbsurname";
            this.tbsurname.Size = new System.Drawing.Size(350, 22);
            this.tbsurname.TabIndex = 11;
            // 
            // tbgivenname
            // 
            this.tbgivenname.Location = new System.Drawing.Point(286, 152);
            this.tbgivenname.Name = "tbgivenname";
            this.tbgivenname.Size = new System.Drawing.Size(350, 22);
            this.tbgivenname.TabIndex = 12;
            // 
            // tbemail
            // 
            this.tbemail.Location = new System.Drawing.Point(286, 187);
            this.tbemail.Name = "tbemail";
            this.tbemail.Size = new System.Drawing.Size(350, 22);
            this.tbemail.TabIndex = 13;
            // 
            // tbpassportnumber
            // 
            this.tbpassportnumber.Location = new System.Drawing.Point(286, 266);
            this.tbpassportnumber.Name = "tbpassportnumber";
            this.tbpassportnumber.Size = new System.Drawing.Size(350, 22);
            this.tbpassportnumber.TabIndex = 14;
            // 
            // tbphonenumber
            // 
            this.tbphonenumber.Location = new System.Drawing.Point(286, 317);
            this.tbphonenumber.Name = "tbphonenumber";
            this.tbphonenumber.Size = new System.Drawing.Size(350, 22);
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
            this.comboboxaddress.Location = new System.Drawing.Point(286, 361);
            this.comboboxaddress.Name = "comboboxaddress";
            this.comboboxaddress.Size = new System.Drawing.Size(350, 24);
            this.comboboxaddress.TabIndex = 16;
            this.comboboxaddress.Text = "---Select Your Area---";
            // 
            // lblregistrationdate
            // 
            this.lblregistrationdate.AutoSize = true;
            this.lblregistrationdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblregistrationdate.Location = new System.Drawing.Point(99, 409);
            this.lblregistrationdate.Name = "lblregistrationdate";
            this.lblregistrationdate.Size = new System.Drawing.Size(169, 20);
            this.lblregistrationdate.TabIndex = 17;
            this.lblregistrationdate.Text = "Registration Date :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(286, 409);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(350, 22);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // bsubmit
            // 
            this.bsubmit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bsubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bsubmit.ForeColor = System.Drawing.Color.Blue;
            this.bsubmit.Location = new System.Drawing.Point(369, 487);
            this.bsubmit.Name = "bsubmit";
            this.bsubmit.Size = new System.Drawing.Size(208, 49);
            this.bsubmit.TabIndex = 19;
            this.bsubmit.Text = "Submit";
            this.bsubmit.UseVisualStyleBackColor = false;
            this.bsubmit.Click += new System.EventHandler(this.bsubmit_Click);
            // 
            // registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 600);
            this.Controls.Add(this.bsubmit);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblregistrationdate);
            this.Controls.Add(this.comboboxaddress);
            this.Controls.Add(this.tbphonenumber);
            this.Controls.Add(this.tbpassportnumber);
            this.Controls.Add(this.tbemail);
            this.Controls.Add(this.tbgivenname);
            this.Controls.Add(this.tbsurname);
            this.Controls.Add(this.lbladdress);
            this.Controls.Add(this.lblphonenumber);
            this.Controls.Add(this.rbfemale);
            this.Controls.Add(this.lblgender);
            this.Controls.Add(this.rbmale);
            this.Controls.Add(this.lblpassportnumber);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lblgivenname);
            this.Controls.Add(this.lblsurname);
            this.Controls.Add(this.lblregistration);
            this.Name = "registration";
            this.Text = "registration";
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
        private System.Windows.Forms.Label lblregistrationdate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button bsubmit;
    }
}