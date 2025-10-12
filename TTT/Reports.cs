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
    public partial class Reports : Form
    {
        private string loggedInUsername;
        public Reports(string username)
        {
            InitializeComponent();
            this.loggedInUsername = username; 
            LoadUserData();
        }
        private void LoadUserData()
        {
            string connectionString = @"Data Source=RASEL\SQLEXPRESS;Initial Catalog=TMS;Integrated Security=True;";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

           
            string query = "SELECT givenname, surname FROM regst WHERE user_name = @username";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", loggedInUsername);

            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);

            if (ds.Tables[0].Rows.Count > 0)
            {
               
                string givenName = ds.Tables[0].Rows[0]["givenname"].ToString();
                string surName = ds.Tables[0].Rows[0]["surname"].ToString();

                
                labelbooked.Text = givenName + " " + surName;
            }

            conn.Close();
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

        }

        private void bsettingsbooked_Click(object sender, EventArgs e)
        {
            change_color_by_click(bsettingsbooked, bhomebooked, bbookticketbooked, breviewsbooked, btransportsbooked, breportsbooked, bulogoutbooked);
            Settings settings = new Settings(loggedInUsername);
            settings.Show();
            this.Hide();
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

        private void Reports_Load(object sender, EventArgs e)
        {
            change_color_by_click(breportsbooked, bhomebooked, bbookticketbooked, breviewsbooked, btransportsbooked, bsettingsbooked, bulogoutbooked);

        }

        private void textBox_reports_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_reportssubmit_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=RASEL\SQLEXPRESS;Initial Catalog=TMS;Integrated Security=True;";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            string reportText = textBox_reports.Text.Trim();

            string checkColumnQuery = $@"
        IF COL_LENGTH('Reports', '{loggedInUsername}') IS NULL
        ALTER TABLE [Reports] ADD [{loggedInUsername}] NVARCHAR(MAX);";

            SqlCommand checkCmd = new SqlCommand(checkColumnQuery, conn);
            checkCmd.ExecuteNonQuery();

            string insertQuery = $"INSERT INTO [Reports] ([{loggedInUsername}]) VALUES (@reportText)";
            SqlCommand insertCmd = new SqlCommand(insertQuery, conn);
            insertCmd.Parameters.AddWithValue("@reportText", reportText);
            insertCmd.ExecuteNonQuery();

            MessageBox.Show("Report saved successfully!");
            textBox_reports.Clear();

            conn.Close();
        }



    }
}
