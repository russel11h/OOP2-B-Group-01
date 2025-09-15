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
    public partial class forget_pass : Form
    {
        public forget_pass()
        {
            InitializeComponent();
        }

        private void bsend_Click(object sender, EventArgs e)
{
               string connectionString = @"Data Source=RASEL\SQLEXPRESS;Initial Catalog=TMS;Integrated Security=True;";
               SqlConnection conn = new SqlConnection(connectionString);
               conn.Open();

               string query = "SELECT * FROM regst WHERE user_name = @username OR email = @mail";
               SqlCommand cmd = new SqlCommand(query, conn);
               cmd.Parameters.AddWithValue("@username", tb_username_email.Text);
               cmd.Parameters.AddWithValue("@mail", tb_username_email.Text);

               SqlDataAdapter adp = new SqlDataAdapter(cmd);
               DataSet ds = new DataSet();
               adp.Fill(ds);
  
                if (ds.Tables[0].Rows.Count > 0)
                {
       
                  create_new_password newpass = new create_new_password(tb_username_email.Text);
                  newpass.Show();
                  this.Hide();
                }
                else
                {
                   MessageBox.Show("Username or Email not found");
                }

                   conn.Close();
        }



        private void breg_to_login_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Hide();
        }

        private void tb_username_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void forget_pass_Load(object sender, EventArgs e)
        {

        }
    }
}
