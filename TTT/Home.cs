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
    public partial class Home : Form
    {
        private string loggedInUsername; // Field to store the username

        public Home(string username) // Updated constructor to accept a username
        {
            InitializeComponent();
            this.loggedInUsername = username; // Store the username
            LoadUserData(); 
        }
        private void LoadUserData()
        {
            string connectionString = @"Data Source=RASEL\SQLEXPRESS;Initial Catalog=TMS;Integrated Security=True;";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            // Construct the query to select the givenname and surname
            string query = "SELECT givenname, surname FROM regst WHERE user_name = @username";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", loggedInUsername);

            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);

            if (ds.Tables[0].Rows.Count > 0)
            {
                // Get the givenname and surname from the first row of the DataTable
                string givenName = ds.Tables[0].Rows[0]["givenname"].ToString();
                string surName = ds.Tables[0].Rows[0]["surname"].ToString();

                // Concatenate and display the full name in the label
                lhname.Text = givenName + " " + surName;
            }

            conn.Close();
        }

        private void bhx_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void change_color_by_click(Button b1,Button b2,Button b3,Button b4,Button b5,Button b6)
        {
            b1.BackColor = Color.FromArgb(0, 122, 204);
            b2.BackColor = Color.FromArgb(215, 228, 242);
            b3.BackColor = Color.FromArgb(215, 228, 242);
            b4.BackColor = Color.FromArgb(215, 228, 242);
            b5.BackColor = Color.FromArgb(215, 228, 242);
            b6.BackColor = Color.FromArgb(215, 228, 242);

        }

        private void bnhome_Click(object sender, EventArgs e)
        {
            change_color_by_click(bnhome, bnbookticket, bnCustomers, bnTransport, bnReports, bnSettings);

        }

        private void bnbookticket_Click(object sender, EventArgs e)
        {
            change_color_by_click(bnbookticket, bnhome, bnCustomers, bnTransport, bnReports, bnSettings);
        }

        private void bnCustomers_Click(object sender, EventArgs e)
        {
            change_color_by_click(bnCustomers, bnhome, bnbookticket, bnTransport, bnReports, bnSettings);
        }

        private void bnTransport_Click(object sender, EventArgs e)
        {
            change_color_by_click(bnTransport, bnhome, bnbookticket, bnCustomers, bnReports, bnSettings);
        }

        private void bnReports_Click(object sender, EventArgs e)
        {
            change_color_by_click(bnReports, bnhome, bnbookticket, bnCustomers, bnTransport, bnSettings);
        }

        private void bnSettings_Click(object sender, EventArgs e)
        {
            change_color_by_click(bnSettings, bnhome, bnbookticket, bnCustomers, bnTransport, bnReports);
        }

        private void Home_Load(object sender, EventArgs e)
        {
            change_color_by_click(bnhome, bnbookticket, bnCustomers, bnTransport, bnReports, bnSettings);
            //lhname.Text = USERNAME.USERname;
        }

        private void lhname_Click(object sender, EventArgs e)
        {

        }
    }
}
