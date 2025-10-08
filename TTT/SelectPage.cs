using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TTT
{
    public partial class SelectPage : Form
    {
        private string loggedInUsername;
        private string selectedTransportNo; // New field to hold the flight ID

        // MODIFIED Constructor to accept the selected flight's Transport_No
        public SelectPage(string username, string transportNo)
        {
            InitializeComponent();
            this.loggedInUsername = username;
            this.selectedTransportNo = transportNo; // Store the Transport_No
            LoadUserData();
            // You can now use selectedTransportNo to load the specific flight's details
            // Example: LoadFlightDetails(selectedTransportNo);
        }

        private void LoadUserData()
        {
            string connectionString = @"Data Source=RASEL\SQLEXPRESS;Initial Catalog=TMS;Integrated Security=True;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT givenname, surname FROM regst WHERE user_name = @username";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", loggedInUsername);
                    using (SqlDataAdapter adp = new SqlDataAdapter(cmd))
                    {
                        DataSet ds = new DataSet();
                        adp.Fill(ds);
                        if (ds.Tables[0].Rows.Count > 0)
                        {
                            string givenName = ds.Tables[0].Rows[0]["givenname"].ToString();
                            string surName = ds.Tables[0].Rows[0]["surname"].ToString();
                            labelbooked.Text = givenName + " " + surName;
                        }
                    }
                }
            }
        }

        

        // Navigation buttons
        private void bhomebooked_Click(object sender, EventArgs e)
        {
            Home home = new Home(loggedInUsername);
            home.Show();
            this.Hide();
        }

        private void bbookticketbooked_Click(object sender, EventArgs e)
        {
            Book_Ticket book_Ticket = new Book_Ticket(loggedInUsername);
            book_Ticket.Show();
            this.Hide();
        }

        private void breviewsbooked_Click(object sender, EventArgs e)
        {
            Reviews review = new Reviews(loggedInUsername);
            review.Show();
            this.Hide();
        }

        private void btransportsbooked_Click(object sender, EventArgs e)
        {
            Transports transports = new Transports(loggedInUsername);
            transports.Show();
            this.Hide();
        }

        private void breportsbooked_Click(object sender, EventArgs e)
        {
            Reports reports = new Reports(loggedInUsername);
            reports.Show();
            this.Hide();
        }

        private void bsettingsbooked_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings(loggedInUsername);
            settings.Show();
            this.Hide();
        }

        private void bulogoutbooked_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Log out?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                Form1 f = new Form1();
                f.Show();
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
