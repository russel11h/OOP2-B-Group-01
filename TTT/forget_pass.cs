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
    public partial class forget_pass : Form
    {
        public forget_pass()
        {
            InitializeComponent();
        }

        private void bsend_Click(object sender, EventArgs e)
        {
            if (tb_username_email.Text == UserData.USERNAME || tb_username_email.Text == UserData.EMAIL)
            {
                create_new_password newpass = new create_new_password();
                newpass.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username or Email not found");
            }

        }

        private void breg_to_login_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Hide();
        }
    }
}
