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
            UserData.USERNAME = tbusername.Text;
            UserData.PASSWORD = tbpassword.Text;
            UserData.EMAIL = tbemail.Text;


            string SUR_NAME;
            string GIVEN_NAME;            
            string GENDER = "Not Selected ";
            string PASSPORT;
            string PHONE;
            string ADDRESS;
            
            

            SUR_NAME = tbsurname.Text;
            GIVEN_NAME = tbgivenname.Text;
            

            if (rbmale.Checked)
            {
                GENDER = "Male";
            }
            else if (rbfemale.Checked)
            {
                GENDER = "Female";
            }

            PASSPORT = tbpassportnumber.Text;
            PHONE = tbphonenumber.Text;
            ADDRESS = comboboxaddress.Text;
            

            MessageBox.Show(
                "Registration Successful!\n\n" +
                "Surname: " + SUR_NAME + "\n" +
                "Given Name: " + GIVEN_NAME + "\n" + "\n" +
                "Gender: " + GENDER + "\n" +
                "Passport No: " + PASSPORT + "\n" +
                "Phone: " + PHONE + "\n" +
                "Address: " + ADDRESS + "\n"                ,
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
            connect();// hefuwhediugiudgu;hkjshegksuedhgvui;hdsiu

            Form1 f = new Form1();
            f.Show();
            Visible = false;

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

        }

        private void tbsurname_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbgivenname_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblgeneralinfo_Click(object sender, EventArgs e)
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
