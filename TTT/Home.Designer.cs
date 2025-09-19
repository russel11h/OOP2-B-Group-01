namespace TTT
{
    partial class Home
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
            this.phleft = new System.Windows.Forms.Panel();
            this.phtop = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bhx = new System.Windows.Forms.Button();
            this.picbox_profile = new System.Windows.Forms.PictureBox();
            this.bnSettings = new System.Windows.Forms.Button();
            this.bnReports = new System.Windows.Forms.Button();
            this.bnTransport = new System.Windows.Forms.Button();
            this.bnCustomers = new System.Windows.Forms.Button();
            this.bnbookticket = new System.Windows.Forms.Button();
            this.bnhome = new System.Windows.Forms.Button();
            this.lhname = new System.Windows.Forms.Label();
            this.phleft.SuspendLayout();
            this.phtop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_profile)).BeginInit();
            this.SuspendLayout();
            // 
            // phleft
            // 
            this.phleft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.phleft.Controls.Add(this.lhname);
            this.phleft.Controls.Add(this.picbox_profile);
            this.phleft.Controls.Add(this.bnSettings);
            this.phleft.Controls.Add(this.bnReports);
            this.phleft.Controls.Add(this.bnTransport);
            this.phleft.Controls.Add(this.bnCustomers);
            this.phleft.Controls.Add(this.bnbookticket);
            this.phleft.Controls.Add(this.bnhome);
            this.phleft.Dock = System.Windows.Forms.DockStyle.Left;
            this.phleft.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.phleft.Location = new System.Drawing.Point(0, 0);
            this.phleft.Name = "phleft";
            this.phleft.Size = new System.Drawing.Size(261, 664);
            this.phleft.TabIndex = 0;
            // 
            // phtop
            // 
            this.phtop.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.phtop.Controls.Add(this.panel1);
            this.phtop.Dock = System.Windows.Forms.DockStyle.Top;
            this.phtop.Location = new System.Drawing.Point(261, 0);
            this.phtop.Name = "phtop";
            this.phtop.Size = new System.Drawing.Size(848, 12);
            this.phtop.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Location = new System.Drawing.Point(111, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 23);
            this.panel1.TabIndex = 2;
            // 
            // bhx
            // 
            this.bhx.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bhx.FlatAppearance.BorderSize = 0;
            this.bhx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bhx.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bhx.Location = new System.Drawing.Point(1060, 18);
            this.bhx.Name = "bhx";
            this.bhx.Size = new System.Drawing.Size(37, 33);
            this.bhx.TabIndex = 2;
            this.bhx.Text = "X";
            this.bhx.UseVisualStyleBackColor = true;
            this.bhx.Click += new System.EventHandler(this.bhx_Click);
            // 
            // picbox_profile
            // 
            this.picbox_profile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picbox_profile.Image = global::TTT.Properties.Resources.Profile;
            this.picbox_profile.Location = new System.Drawing.Point(63, 29);
            this.picbox_profile.Name = "picbox_profile";
            this.picbox_profile.Size = new System.Drawing.Size(124, 93);
            this.picbox_profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbox_profile.TabIndex = 3;
            this.picbox_profile.TabStop = false;
            // 
            // bnSettings
            // 
            this.bnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnSettings.FlatAppearance.BorderSize = 0;
            this.bnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnSettings.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnSettings.ForeColor = System.Drawing.SystemColors.Desktop;
            this.bnSettings.Image = global::TTT.Properties.Resources.Settings;
            this.bnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bnSettings.Location = new System.Drawing.Point(0, 499);
            this.bnSettings.Name = "bnSettings";
            this.bnSettings.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.bnSettings.Size = new System.Drawing.Size(261, 54);
            this.bnSettings.TabIndex = 8;
            this.bnSettings.Text = "Settings";
            this.bnSettings.UseVisualStyleBackColor = true;
            this.bnSettings.Click += new System.EventHandler(this.bnSettings_Click);
            // 
            // bnReports
            // 
            this.bnReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnReports.FlatAppearance.BorderSize = 0;
            this.bnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnReports.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnReports.ForeColor = System.Drawing.SystemColors.Desktop;
            this.bnReports.Image = global::TTT.Properties.Resources.Statistics_Report;
            this.bnReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bnReports.Location = new System.Drawing.Point(0, 446);
            this.bnReports.Name = "bnReports";
            this.bnReports.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.bnReports.Size = new System.Drawing.Size(261, 47);
            this.bnReports.TabIndex = 7;
            this.bnReports.Text = "Reports";
            this.bnReports.UseVisualStyleBackColor = true;
            this.bnReports.Click += new System.EventHandler(this.bnReports_Click);
            // 
            // bnTransport
            // 
            this.bnTransport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnTransport.FlatAppearance.BorderSize = 0;
            this.bnTransport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnTransport.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnTransport.ForeColor = System.Drawing.SystemColors.Desktop;
            this.bnTransport.Image = global::TTT.Properties.Resources.Train;
            this.bnTransport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bnTransport.Location = new System.Drawing.Point(0, 386);
            this.bnTransport.Name = "bnTransport";
            this.bnTransport.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.bnTransport.Size = new System.Drawing.Size(261, 54);
            this.bnTransport.TabIndex = 6;
            this.bnTransport.Text = "Transport";
            this.bnTransport.UseVisualStyleBackColor = true;
            this.bnTransport.Click += new System.EventHandler(this.bnTransport_Click);
            // 
            // bnCustomers
            // 
            this.bnCustomers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnCustomers.FlatAppearance.BorderSize = 0;
            this.bnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnCustomers.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnCustomers.ForeColor = System.Drawing.SystemColors.Desktop;
            this.bnCustomers.Image = global::TTT.Properties.Resources.customers_black;
            this.bnCustomers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bnCustomers.Location = new System.Drawing.Point(0, 331);
            this.bnCustomers.Name = "bnCustomers";
            this.bnCustomers.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.bnCustomers.Size = new System.Drawing.Size(261, 49);
            this.bnCustomers.TabIndex = 5;
            this.bnCustomers.Text = "Customers";
            this.bnCustomers.UseVisualStyleBackColor = true;
            this.bnCustomers.Click += new System.EventHandler(this.bnCustomers_Click);
            // 
            // bnbookticket
            // 
            this.bnbookticket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnbookticket.FlatAppearance.BorderSize = 0;
            this.bnbookticket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnbookticket.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnbookticket.ForeColor = System.Drawing.SystemColors.Desktop;
            this.bnbookticket.Image = global::TTT.Properties.Resources.Airplane_Take_Off_black;
            this.bnbookticket.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bnbookticket.Location = new System.Drawing.Point(0, 274);
            this.bnbookticket.Name = "bnbookticket";
            this.bnbookticket.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.bnbookticket.Size = new System.Drawing.Size(261, 51);
            this.bnbookticket.TabIndex = 4;
            this.bnbookticket.Text = "Book Ticket";
            this.bnbookticket.UseVisualStyleBackColor = true;
            this.bnbookticket.Click += new System.EventHandler(this.bnbookticket_Click);
            // 
            // bnhome
            // 
            this.bnhome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bnhome.FlatAppearance.BorderSize = 0;
            this.bnhome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnhome.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnhome.ForeColor = System.Drawing.SystemColors.Desktop;
            this.bnhome.Image = global::TTT.Properties.Resources.Home_black;
            this.bnhome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bnhome.Location = new System.Drawing.Point(0, 216);
            this.bnhome.Name = "bnhome";
            this.bnhome.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.bnhome.Size = new System.Drawing.Size(261, 52);
            this.bnhome.TabIndex = 3;
            this.bnhome.Text = "Home";
            this.bnhome.UseVisualStyleBackColor = true;
            this.bnhome.Click += new System.EventHandler(this.bnhome_Click);
            // 
            // lhname
            // 
            this.lhname.AutoSize = true;
            this.lhname.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lhname.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lhname.Location = new System.Drawing.Point(12, 134);
            this.lhname.Name = "lhname";
            this.lhname.Size = new System.Drawing.Size(211, 27);
            this.lhname.TabIndex = 3;
            this.lhname.Text = "Md. Rasel Hossain";
            this.lhname.Click += new System.EventHandler(this.lhname_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1109, 664);
            this.Controls.Add(this.bhx);
            this.Controls.Add(this.phtop);
            this.Controls.Add(this.phleft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.phleft.ResumeLayout(false);
            this.phleft.PerformLayout();
            this.phtop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picbox_profile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel phleft;
        private System.Windows.Forms.Panel phtop;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bhx;
        private System.Windows.Forms.Button bnhome;
        private System.Windows.Forms.Button bnbookticket;
        private System.Windows.Forms.Button bnReports;
        private System.Windows.Forms.Button bnTransport;
        private System.Windows.Forms.Button bnCustomers;
        private System.Windows.Forms.Button bnSettings;
        private System.Windows.Forms.PictureBox picbox_profile;
        private System.Windows.Forms.Label lhname;
    }
}