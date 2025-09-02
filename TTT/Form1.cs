using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            string NAME = "rasel";
            string PASS = "12345";

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
                if (NAME == tbname.Text && PASS == tbpass.Text)
                {
                    MessageBox.Show("Login Successful");
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
    }
}
