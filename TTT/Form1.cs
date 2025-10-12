using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TTT.TTT;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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

            if (!hasError)
            {
                string connectionString = @"Data Source=RASEL\SQLEXPRESS;Initial Catalog=TMS;Integrated Security=True;";
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();

                string query = "SELECT * FROM regst WHERE user_name = @username AND password = @password";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", tbname.Text);
                cmd.Parameters.AddWithValue("@password", tbpass.Text);

                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    string username = tbname.Text;

                    
                    if (username.StartsWith("admin", StringComparison.OrdinalIgnoreCase))
                    {
                        Admin adminPage = new Admin(username);
                        adminPage.Show();
                        this.Hide();
                    }
                    else
                    {
                        Home home = new Home(username);
                        home.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password");
                }

                conn.Close();
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
            //Home home = new Home();
            //home.Show();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tbname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
