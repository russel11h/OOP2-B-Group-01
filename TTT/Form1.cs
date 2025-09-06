using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TTT.TTT;

namespace TTT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            

            // Clear previous error messages first
            lblnameerror.Text = "";
            lblpasserror.Text = "";

            bool hasError = false;

            if (tbname.Text == "")
            {
                lblnameerror.Text = "Name is required";
                hasError = true;
            }
            if (tbpass.Text == "")
            {
                lblpasserror.Text = "Password is required";
                hasError = true;
            }

            // If no error, then check credentials
            if (!hasError)
            {
                if (UserData.USERNAME == tbname.Text && UserData.PASSWORD == tbpass.Text)
                {
                    MessageBox.Show("Login Successful");
                    Home_page home = new Home_page();
                    home.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid");
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblregistration_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            registration reg = new registration();
            reg.Show();
            this.Hide();
        }

        private void lblforgetpassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            forget_pass forget = new forget_pass();
            forget.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            int radius = 30; // corner curve size
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();

            // Top left corner
            path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);

            // Top edge + top right corner
            path.AddArc(new Rectangle(panel_login.Width - radius, 0, radius, radius), 270, 90);

            // Right edge + bottom right corner
            path.AddArc(new Rectangle(panel_login.Width - radius, panel_login.Height - radius, radius, radius), 0, 90);

            // Bottom edge + bottom left corner
            path.AddArc(new Rectangle(0, panel_login.Height - radius, radius, radius), 90, 90);

            path.CloseFigure();

            panel_login.Region = new Region(path);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home_page h = new Home_page();
            h.Show();
            Visible = false;

            
        }
    }
}
