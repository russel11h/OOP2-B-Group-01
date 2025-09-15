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
using System.Xml.Linq;
using TTT.TTT;

namespace TTT
{

    public partial class registration : Form
    {
        public void connect()
        {
            string Connectionstring = @"Data Source=RASEL\SQLEXPRESS;Initial Catalog=TMS;Integrated Security=True;";
            SqlConnection conn = new SqlConnection(Connectionstring);
            conn.Open();

            //string query = "insert into reg(user_name,pass) values('rrrrrrr','123456789')";
            string query = "insert into regst (user_name, password, surname, givenname, email, gender, passport, phone, address) " +
               "VALUES ('" + tbusername.Text + "','" + tbpassword.Text + "','" + tbsurname.Text + "','" + tbgivenname.Text + "','" + tbemail.Text + "','" + (rbmale.Checked ? "Male" : (rbfemale.Checked ? "Female" : "Not Selected")) + "','" + tbpassportnumber.Text + "','" + tbphonenumber.Text + "','" + comboboxaddress.Text + "')";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();


        }

        public registration()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bsubmit_Click(object sender, EventArgs e)
        {
            lblerrorusername.Text = "";
            lblerrorpass.Text = "";
            lblerrorsurname.Text = "";
            lblerrorgivenname.Text = "";
            lblerroremail.Text = "";
            lblerrorpassport.Text = "";
            lblerrornumber.Text = "";


            if (tbusername.Text =="")
            {
                lblerrorusername.Text = "please enter username";
            }
            if(tbpassword.Text=="")
            {
                lblerrorpass.Text = "please enter Password";
            }
            if (tbsurname.Text == "")
            {
                lblerrorsurname.Text = "please enter surname";
            }
            if (tbgivenname.Text == "")
                lblerrorgivenname.Text = "Please enter Given name";

            if (tbemail.Text=="")
                lblerroremail.Text = "Please enter Email";

            if (tbpassportnumber.Text=="")
            {
                lblerrorpassport.Text= "Please enter Passport number";
            }
            if(tbphonenumber.Text=="")
                lblerrornumber.Text = "Please enter Phone Number";
            

            if (tbusername.Text !="" && tbpassword.Text !="" && tbsurname.Text !="" && tbgivenname.Text !="" && tbemail.Text != "" && tbpassportnumber.Text !="" && tbphonenumber.Text !="" && comboboxaddress.Text !="")
            {
                string gender = "Not Selected ";
                if (rbmale.Checked)
                {
                    gender = "Male";
                }
                else if (rbfemale.Checked)
                {
                    gender = "Female";
                }

                MessageBox.Show(
                "Registration Successful!\n\n" +
                "Surname: " + tbsurname.Text + "\n" +
                "Given Name: " + tbgivenname.Text + "\n" +
                "Email:"   + tbemail.Text +  "\n" +
                "Gender: " + gender + "\n" +
                "Passport No: " + tbpassportnumber.Text + "\n" +
                "Phone: " + tbphonenumber.Text + "\n" +
                "Address: " + comboboxaddress.Text + "\n",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

               connect();// hefuwhediugiudgu;hkjshegksuedhgvui;hdsiu

                Form1 f = new Form1();
                f.Show();
                Visible = false;

            }







            UserData.USERNAME = tbusername.Text;
            UserData.PASSWORD = tbpassword.Text;
            UserData.EMAIL = tbemail.Text;



        }

        private void breg_to_login_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            Visible = false;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tbpassword_TextChanged(object sender, EventArgs e)
        {
            lblerrorpass.Text = "";
        }

        private void tbsurname_TextChanged(object sender, EventArgs e)
        {
            lblerrorusername.Text = "";

        }

        private void tbgivenname_TextChanged(object sender, EventArgs e)
        {
            lblerrorgivenname.Text = "";
        }

        private void tbusername_TextChanged(object sender, EventArgs e)
        {
            lblerrorsurname.Text = "";
        }

        private void tbemail_TextChanged(object sender, EventArgs e)
        {
            lblerroremail.Text = "";
        }

        private void lblgeneralinfo_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void lblerrorpassport_Click(object sender, EventArgs e)
        {
            lblerrorpassport.Text = "";
        }

        private void lblerrornumber_Click(object sender, EventArgs e)
        {
            lblerrornumber.Text = "";
        }

        private void lblerrorusername_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
    namespace TTT
    {
        public static class UserData
        {
            public static string USERNAME { get; set; }
            public static string PASSWORD { get; set; }
            public static string EMAIL { get; set; }
        }
    }
}