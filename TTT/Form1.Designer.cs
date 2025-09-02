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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblname = new System.Windows.Forms.Label();
            this.lblpass = new System.Windows.Forms.Label();
            this.tbname = new System.Windows.Forms.TextBox();
            this.tbpass = new System.Windows.Forms.TextBox();
            this.lblnameerror = new System.Windows.Forms.Label();
            this.lblpasserror = new System.Windows.Forms.Label();
            this.btnlogin = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblclick = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(116, 237);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(85, 27);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "Name :";
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpass.Location = new System.Drawing.Point(116, 330);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(120, 27);
            this.lblpass.TabIndex = 1;
            this.lblpass.Text = "Password :";
            // 
            // tbname
            // 
            this.tbname.Location = new System.Drawing.Point(242, 242);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(348, 22);
            this.tbname.TabIndex = 2;
            // 
            // tbpass
            // 
            this.tbpass.Location = new System.Drawing.Point(242, 335);
            this.tbpass.Name = "tbpass";
            this.tbpass.PasswordChar = '*';
            this.tbpass.Size = new System.Drawing.Size(348, 22);
            this.tbpass.TabIndex = 3;
            // 
            // lblnameerror
            // 
            this.lblnameerror.AutoSize = true;
            this.lblnameerror.Font = new System.Drawing.Font("Microsoft Yi Baiti", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnameerror.ForeColor = System.Drawing.Color.Firebrick;
            this.lblnameerror.Location = new System.Drawing.Point(239, 267);
            this.lblnameerror.Name = "lblnameerror";
            this.lblnameerror.Size = new System.Drawing.Size(0, 13);
            this.lblnameerror.TabIndex = 4;
            // 
            // lblpasserror
            // 
            this.lblpasserror.AutoSize = true;
            this.lblpasserror.Font = new System.Drawing.Font("Microsoft Yi Baiti", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpasserror.ForeColor = System.Drawing.Color.Firebrick;
            this.lblpasserror.Location = new System.Drawing.Point(239, 360);
            this.lblpasserror.Name = "lblpasserror";
            this.lblpasserror.Size = new System.Drawing.Size(0, 13);
            this.lblpasserror.TabIndex = 5;
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnlogin.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.Location = new System.Drawing.Point(360, 401);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(124, 37);
            this.btnlogin.TabIndex = 6;
            this.btnlogin.Text = "LOG IN";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(676, 218);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OliveDrab;
            this.label1.Location = new System.Drawing.Point(175, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(548, 37);
            this.label1.TabIndex = 8;
            this.label1.Text = "Travel and Ticket Mangement System";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Yi Baiti", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(313, 462);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "If you forget password please      here.";
            // 
            // lblclick
            // 
            this.lblclick.AutoSize = true;
            this.lblclick.Location = new System.Drawing.Point(450, 459);
            this.lblclick.Name = "lblclick";
            this.lblclick.Size = new System.Drawing.Size(34, 16);
            this.lblclick.TabIndex = 10;
            this.lblclick.TabStop = true;
            this.lblclick.Text = "click";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(875, 565);
            this.Controls.Add(this.lblclick);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.lblpasserror);
            this.Controls.Add(this.lblnameerror);
            this.Controls.Add(this.tbpass);
            this.Controls.Add(this.tbname);
            this.Controls.Add(this.lblpass);
            this.Controls.Add(this.lblname);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblpass;
        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.TextBox tbpass;
        private System.Windows.Forms.Label lblnameerror;
        private System.Windows.Forms.Label lblpasserror;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel lblclick;
    }
}

