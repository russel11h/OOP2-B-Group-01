using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TTT.TTT;

namespace TTT
{
    public partial class create_new_password : Form
    {
        private string userIdentifier; // will hold username or email
        public create_new_password(string userIdentifier)// catching forget_pass constractor
        {
            InitializeComponent();
            this.userIdentifier = userIdentifier; // save the value
        }

        private void lblregistration_Click(object sender, EventArgs e)
        {

        }

        private void breg_to_login_Click(object sender, EventArgs e)
        {
            forget_pass forget = new forget_pass();
            forget.Show();
            this.Hide();
        }



        private void b_newpass_confirm_Click(object sender, EventArgs e)
        {
            if (tb_newpassword.Text == tb_confirm_pass.Text)
            {
                string connectionString = @"Data Source=RASEL\SQLEXPRESS;Initial Catalog=TMS;Integrated Security=True;";
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
               

                    string query = "UPDATE regst SET password = @password WHERE user_name = @user OR email = @user";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@password", tb_newpassword.Text);
                    cmd.Parameters.AddWithValue("@user", userIdentifier); // use the saved username/email

                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        MessageBox.Show("Password Changed Successfully");
                        Form1 login = new Form1();
                        login.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Error: User not found");
                    }
                
            }
            else
            {
                MessageBox.Show("Password Did Not Match");
            }
        }


        private void create_new_password_Load(object sender, EventArgs e)
        {

        }
    }
}
