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
using System.Text.RegularExpressions; // Required for Regex validation

namespace TTT
{
    // The following classes (UserData and registration) are assumed to be in TTT namespace
    // as per your provided code structure, even though UserData is defined outside of it
    // in the original snippet. I'll keep the structure from your original code.

    public partial class registration : Form
    {
        public void connect()
        {
            // WARNING: The following SQL query is vulnerable to SQL Injection.
            // In a real application, you should use parameterized queries.
            string Connectionstring = @"Data Source=RASEL\SQLEXPRESS;Initial Catalog=TMS;Integrated Security=True;";
            SqlConnection conn = new SqlConnection(Connectionstring);
            conn.Open();

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
            // Event handler not relevant to the change
        }

        private void bsubmit_Click(object sender, EventArgs e)
        {
            // 1. Clear previous errors
            lblerrorusername.Text = "";
            lblerrorpass.Text = "";
            lblerrorsurname.Text = "";
            lblerrorgivenname.Text = "";
            lblerroremail.Text = "";
            lblerrorpassport.Text = "";
            lblerrornumber.Text = "";

            bool isValid = true; // Flag to track overall validation state

            // 2. Perform field validation
            if (tbusername.Text == "")
            {
                lblerrorusername.Text = "Please enter username";
                isValid = false;
            }
            if (tbpassword.Text == "")
            {
                lblerrorpass.Text = "Please enter Password";
                isValid = false;
            }
            if (tbsurname.Text == "")
            {
                lblerrorsurname.Text = "Please enter surname";
                isValid = false;
            }
            if (tbgivenname.Text == "")
            {
                lblerrorgivenname.Text = "Please enter Given name";
                isValid = false;
            }
            if (tbemail.Text == "")
            {
                lblerroremail.Text = "Please enter Email";
                isValid = false;
            }
            if (tbpassportnumber.Text == "")
            {
                lblerrorpassport.Text = "Please enter Passport number";
                isValid = false;
            }

            // Phone Number Validation
            if (tbphonenumber.Text == "")
            {
                lblerrornumber.Text = "Please enter Phone Number";
                isValid = false;
            }
            // Check if it contains ONLY digits (and maybe optional "+" at the start, if required)
            // The regex @"^\d+$" checks for one or more digits from start to end of the string.
            else if (!Regex.IsMatch(tbphonenumber.Text, @"^\d+$"))
            {
                lblerrornumber.Text = "Phone number must contain only digits.";
                isValid = false;
            }

            // Check if address is selected (assuming comboboxaddress is not null)
            if (comboboxaddress.Text == "")
            {
                // Assuming you have an error label for address, if not, you should add one.
                // For now, I'll update the isValid flag if this is a mandatory field.
                // This logic block isn't in your original code, but it's logically required 
                // for the successful block below to work correctly.
                isValid = false;
            }


            // 3. Process if all fields are valid
            // The original logic checked for every field being non-empty. Now we use the isValid flag.
            if (isValid)
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
                "Email:" + tbemail.Text + "\n" +
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

            // 4. Update static UserData
            UserData.USERNAME = tbusername.Text;
            UserData.PASSWORD = tbpassword.Text;
            UserData.EMAIL = tbemail.Text;
        }

        // --- Rest of your original methods ---

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
            // Note: This looks like a click handler for the label itself, which usually clears the error.
            // If the text box changes, the change handler should clear the error.
            lblerrorpassport.Text = "";
        }

        private void lblerrornumber_Click(object sender, EventArgs e)
        {
            // Note: This looks like a click handler for the label itself, which usually clears the error.
            // If the text box changes, the change handler should clear the error.
            lblerrornumber.Text = "";
        }

        // Add a TextChanged event handler for tbphonenumber to clear the error immediately
        private void tbphonenumber_TextChanged(object sender, EventArgs e)
        {
            lblerrornumber.Text = "";
        }

        private void lblerrorusername_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

    // --- Namespace and UserData Class ---
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