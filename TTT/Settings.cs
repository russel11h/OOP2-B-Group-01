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

namespace TTT
{
    public partial class Settings : Form
    {
        private string loggedInUsername; // Field to store the username
        public Settings(string username)
        {
            InitializeComponent();
            this.loggedInUsername = username; // Store the username
            LoadUserData();
        }
        private void LoadUserData()
        {
            // Make sure to match the control names to your actual form controls.
            // The control for 'gender' is assumed to be 'textBox2' and 'address' is 'textBox_address'.
            // It's recommended to rename controls to be more descriptive (e.g., 'tbGender', 'tbAddress').

            string connectionString = @"Data Source=RASEL\SQLEXPRESS;Initial Catalog=TMS;Integrated Security=True;";
            using (SqlConnection conn = new SqlConnection(connectionString)) // Use 'using' for proper resource disposal
            {
                try
                {
                    conn.Open();

                    // Select all required columns based on the user_name
                    string query = "SELECT givenname, surname, email, gender, passport, phone,password, [address] FROM regst WHERE user_name = @username";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", loggedInUsername);

                    SqlDataReader reader = cmd.ExecuteReader(); // Use SqlDataReader for reading a single row

                    if (reader.Read())
                    {
                        // Get the data
                        string givenName = reader["givenname"].ToString();
                        string surName = reader["surname"].ToString();
                        string email = reader["email"].ToString();
                        string gender = reader["gender"].ToString();
                        string passport = reader["passport"].ToString();
                        string phone = reader["phone"].ToString();
                        string address = reader["address"].ToString();
                        string password = reader["password"].ToString();

                        // Populate the label for full name
                        labelbooked.Text = givenName + " " + surName;

                        // Populate the TextBoxes
                        tbgivenname.Text = givenName;
                        tbsurname.Text = surName;
                        tbemail.Text = email;
                        textBox2.Text = gender; // Assuming textBox2 is for gender
                        tbpassportnumber.Text = passport;
                        tbphonenumber.Text = phone;
                        textBox_address.Text = address;
                        tbpassword.Text = password;

                        // Disable the TextBoxes by default
                        SetTextBoxReadOnly(true);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading user data: " + ex.Message);
                }
            } // conn.Close() is called automatically by the 'using' block
        }

        // Helper method to set all edit-enabled textboxes ReadOnly state
        private void SetTextBoxReadOnly(bool isReadOnly)
        {
            tbgivenname.ReadOnly = isReadOnly;
            tbsurname.ReadOnly = isReadOnly;
            tbemail.ReadOnly = isReadOnly;
            textBox2.ReadOnly = isReadOnly;
            tbpassportnumber.ReadOnly = isReadOnly;
            tbphonenumber.ReadOnly = isReadOnly;
            textBox_address.ReadOnly = isReadOnly;
            tbpassword.ReadOnly = isReadOnly;

            // Optionally hide/show the Save button based on the state
            button_save.Visible = !isReadOnly;
        }
        private void change_color_by_click(Button b1, Button b2, Button b3, Button b4, Button b5, Button b6, Button b7)
        {
            b1.BackColor = Color.FromArgb(0, 122, 204);
            b2.BackColor = Color.FromArgb(215, 228, 242);
            b3.BackColor = Color.FromArgb(215, 228, 242);
            b4.BackColor = Color.FromArgb(215, 228, 242);
            b5.BackColor = Color.FromArgb(215, 228, 242);
            b6.BackColor = Color.FromArgb(215, 228, 242);
            b7.BackColor = Color.FromArgb(215, 228, 242);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bhomebooked_Click(object sender, EventArgs e)
        {
            change_color_by_click(bhomebooked, bbookticketbooked, breviewsbooked, btransportsbooked, breportsbooked, bsettingsbooked, bulogoutbooked);
            Home home = new Home(loggedInUsername);
            home.Show();
            this.Hide();
        }

        private void bbookticketbooked_Click(object sender, EventArgs e)
        {
            change_color_by_click(bbookticketbooked, bhomebooked, breviewsbooked, btransportsbooked, breportsbooked, bsettingsbooked, bulogoutbooked);
            Book_Ticket book_Ticket = new Book_Ticket(loggedInUsername);
            book_Ticket.Show();
            this.Hide();
        }

        private void breviewsbooked_Click(object sender, EventArgs e)
        {
            change_color_by_click(breviewsbooked, bhomebooked, bbookticketbooked, btransportsbooked, breportsbooked, bsettingsbooked, bulogoutbooked);
            Reviews review = new Reviews(loggedInUsername);
            review.Show();
            this.Hide();
        }

        private void btransportsbooked_Click(object sender, EventArgs e)
        {
            change_color_by_click(btransportsbooked, bhomebooked, bbookticketbooked, breviewsbooked, breportsbooked, bsettingsbooked, bulogoutbooked);
            Transports transports = new Transports(loggedInUsername);
            transports.Show();
            this.Hide();
        }

        private void breportsbooked_Click(object sender, EventArgs e)
        {
            change_color_by_click(breportsbooked, bhomebooked, bbookticketbooked, breviewsbooked, btransportsbooked, bsettingsbooked, bulogoutbooked);
            Reports reports = new Reports(loggedInUsername);
            reports.Show();
            this.Hide();
        }

        private void bsettingsbooked_Click(object sender, EventArgs e)
        {
            change_color_by_click(bsettingsbooked, bhomebooked, bbookticketbooked, breviewsbooked, btransportsbooked, breportsbooked, bulogoutbooked);

        }

        private void bulogoutbooked_Click(object sender, EventArgs e)
        {
            change_color_by_click(bulogoutbooked, bhomebooked, bbookticketbooked, breviewsbooked, btransportsbooked, breportsbooked, bsettingsbooked);
            DialogResult result = MessageBox.Show("Log out?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                Form1 f = new Form1();
                f.Show();
                this.Hide();
            }
            else
            {
                // Do nothing; stay on the current form
            }
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            change_color_by_click(bsettingsbooked, bhomebooked, bbookticketbooked, breviewsbooked, btransportsbooked, breportsbooked, bulogoutbooked);

        }




        // values

        private void button_editgivenname_Click(object sender, EventArgs e)
        {
            tbgivenname.ReadOnly = false;
            tbgivenname.Focus();
            button_save.Visible = true; // Show Save button
        }

        private void button_editsurname_Click(object sender, EventArgs e)
        {
            tbsurname.ReadOnly = false;
            tbsurname.Focus();
            button_save.Visible = true;
        }

        private void button_editemail_Click(object sender, EventArgs e)
        {
            tbemail.ReadOnly = false;
            tbemail.Focus();
            button_save.Visible = true;
        }

        private void button_editdender_Click(object sender, EventArgs e)
        {
            textBox2.ReadOnly = false; // Assuming textBox2 is gender
            textBox2.Focus();
            button_save.Visible = true;
        }

        private void button_editpassport_Click(object sender, EventArgs e)
        {
            tbpassportnumber.ReadOnly = false;
            tbpassportnumber.Focus();
            button_save.Visible = true;
        }

        private void button_editphone_Click(object sender, EventArgs e)
        {
            tbphonenumber.ReadOnly = false;
            tbphonenumber.Focus();
            button_save.Visible = true;
        }

        private void button_editaddress_Click(object sender, EventArgs e)
        {
            textBox_address.ReadOnly = false;
            textBox_address.Focus();
            button_save.Visible = true;
        }

        private void button_editpassword_Click(object sender, EventArgs e)
        {
            tbpassword.ReadOnly = false;
            tbpassword.Focus();
            button_save.Visible = true;
        }

        //button

        private void tbsurname_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void tbgivenname_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void tbemail_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void tbpassportnumber_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void tbphonenumber_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void textBox_address_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void tbpassword_TextChanged(object sender, EventArgs e)
        {

        }

        //save button

        private void button_save_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=RASEL\SQLEXPRESS;Initial Catalog=TMS;Integrated Security=True;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    // Use an UPDATE statement to change the user's details
                    string updateQuery = @"
                UPDATE regst SET 
                    surname = @surname, 
                    givenname = @givenname, 
                    email = @email, 
                    gender = @gender, 
                    passport = @passport, 
                    phone = @phone, 
                    [address] = @address,
                    [password] = @password 
                WHERE user_name = @username";

                    SqlCommand cmd = new SqlCommand(updateQuery, conn);

                    // Add parameters with values from the TextBoxes
                    cmd.Parameters.AddWithValue("@surname", tbsurname.Text);
                    cmd.Parameters.AddWithValue("@givenname", tbgivenname.Text);
                    cmd.Parameters.AddWithValue("@email", tbemail.Text);
                    cmd.Parameters.AddWithValue("@gender", textBox2.Text); // Assuming textBox2 is gender
                    cmd.Parameters.AddWithValue("@passport", tbpassportnumber.Text);
                    cmd.Parameters.AddWithValue("@phone", tbphonenumber.Text);
                    cmd.Parameters.AddWithValue("@address", textBox_address.Text);
                    cmd.Parameters.AddWithValue("@password", tbpassword.Text);
                    cmd.Parameters.AddWithValue("@username", loggedInUsername);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Your details have been successfully updated! 👍", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // Re-load data to ensure consistency and update the label
                        LoadUserData();
                        // Set textboxes back to read-only after saving
                        SetTextBoxReadOnly(true);
                    }
                    else
                    {
                        MessageBox.Show("Could not update details. User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database error during save: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void panel_registration_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label_givenname_Click(object sender, EventArgs e)
        {

        }

        private void lblemail_Click(object sender, EventArgs e)
        {

        }

        private void label_surname_Click(object sender, EventArgs e)
        {

        }
    }
}
