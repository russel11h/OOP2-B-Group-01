using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public create_new_password()
        {
            InitializeComponent();
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
                UserData.PASSWORD = tb_newpassword.Text; // ✅ Updates password globally
                MessageBox.Show("Password Changed Successfully");
                Form1 login = new Form1();
                login.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Password Did Not Match");

            }
        }
    }
}
