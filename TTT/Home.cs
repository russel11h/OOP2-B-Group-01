using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
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

        private void change_color_by_click(Button b1, Button b2, Button b3, Button b4, Button b5, Button b6,Button b7)
        {
            b1.BackColor = Color.FromArgb(0, 122, 204);
            b2.BackColor = Color.FromArgb(215, 228, 242);
            b3.BackColor = Color.FromArgb(215, 228, 242);
            b4.BackColor = Color.FromArgb(215, 228, 242);
            b5.BackColor = Color.FromArgb(215, 228, 242);
            b6.BackColor = Color.FromArgb(215, 228, 242);
            b7.BackColor = Color.FromArgb(215, 228, 242);
        }

        private void bnhome_Click(object sender, EventArgs e)
        {
            change_color_by_click(bnhome, bnbookticket, bnreviews, bnTransport, bnReports, bnSettings,bulogout);

        }

        private void bnbookticket_Click(object sender, EventArgs e)
        {
            change_color_by_click(bnbookticket, bnhome, bnreviews, bnTransport, bnReports, bnSettings, bulogout);
            Book_Ticket book_Ticket = new Book_Ticket(loggedInUsername);
            book_Ticket.Show();
            this.Hide();
           
        }
        


        private void bnCustomers_Click(object sender, EventArgs e)
        {
            change_color_by_click(bnreviews, bnhome, bnbookticket, bnTransport, bnReports, bnSettings, bulogout);
            Reviews review = new Reviews(loggedInUsername);
            review.Show();
            this.Hide();
        }

        private void bnTransport_Click(object sender, EventArgs e)
        {
            change_color_by_click(bnTransport, bnhome, bnbookticket, bnreviews, bnReports, bnSettings, bulogout);
            Transports transports = new Transports(loggedInUsername);
            transports.Show();
            this.Hide();
        }

        private void bnReports_Click(object sender, EventArgs e)
        {
            change_color_by_click(bnReports, bnhome, bnbookticket, bnreviews, bnTransport, bnSettings, bulogout);
            Reports reports = new Reports(loggedInUsername);
            reports.Show();
            this.Hide();
        }

        private void bnSettings_Click(object sender, EventArgs e)
        {
            change_color_by_click(bnSettings, bnhome, bnbookticket, bnreviews, bnTransport, bnReports, bulogout);
            Settings settings = new Settings(loggedInUsername);
            settings.Show();
            this.Hide();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            change_color_by_click(bnhome, bnbookticket, bnreviews, bnTransport, bnReports, bnSettings, bulogout);
            //lhname.Text = USERNAME.USERname;
        }

        private void lhname_Click(object sender, EventArgs e)
        {

        }

        private void panel_Book_Hote_Paint(object sender, PaintEventArgs e)
        {
            Panel p = sender as Panel;
            int radius = 30;

            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);
            path.AddLine(radius, 0, p.Width - radius, 0);
            path.AddArc(new Rectangle(p.Width - radius, 0, radius, radius), 270, 90);
            path.AddLine(p.Width, radius, p.Width, p.Height - radius);
            path.AddArc(new Rectangle(p.Width - radius, p.Height - radius, radius, radius), 0, 90);
            path.AddLine(p.Width - radius, p.Height, radius, p.Height);
            path.AddArc(new Rectangle(0, p.Height - radius, radius, radius), 90, 90);
            path.CloseFigure();

            p.Region = new Region(path);
        }

        private void label_databasefrom_Click(object sender, EventArgs e)
        {

        }

        private void panel_Book_Transport_Paint(object sender, PaintEventArgs e)
        {
            string connectionString = @"Data Source=RASEL\SQLEXPRESS;Initial Catalog=TMS;Integrated Security=True;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"SELECT TOP 1 From_City, To_City, Departure_Date, Departure_Only_Time, Arrival_Date, Arrival_Only_Time, Price_eco 
                         FROM plane_details 
                         ORDER BY Transport_No";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        label_databasefrom.Text = reader["From_City"].ToString();
                        label_databaseto.Text = reader["To_City"].ToString();

                        // Parse departure and arrival dates and times
                        DateTime depDate = DateTime.Parse(reader["Departure_Date"].ToString());
                        DateTime depTime = DateTime.Parse(reader["Departure_Only_Time"].ToString());
                        DateTime arrDate = DateTime.Parse(reader["Arrival_Date"].ToString());
                        DateTime arrTime = DateTime.Parse(reader["Arrival_Only_Time"].ToString());

                        // Format and set the text with red color
                        label_databasetime.ForeColor = Color.Red;
                        label_databasetime.Text = $"Departure: {depDate:dd/MM/yyyy} Time: {depTime:hh:mm tt} → Arrival: {arrDate:dd/MM/yyyy} Time: {arrTime:hh:mm tt}";

                        label_databaseprice.Text = reader["Price_eco"].ToString();
                    }
                }
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel_Book_Ticket_Paint(object sender, PaintEventArgs e)
        {
            Panel p = sender as Panel;
            int radius = 30;

            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);
            path.AddLine(radius, 0, p.Width - radius, 0);
            path.AddArc(new Rectangle(p.Width - radius, 0, radius, radius), 270, 90);
            path.AddLine(p.Width, radius, p.Width, p.Height - radius);
            path.AddArc(new Rectangle(p.Width - radius, p.Height - radius, radius, radius), 0, 90);
            path.AddLine(p.Width - radius, p.Height, radius, p.Height);
            path.AddArc(new Rectangle(0, p.Height - radius, radius, radius), 90, 90);
            path.CloseFigure();

            p.Region = new Region(path);
        }

        private void panel_T1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_T2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_T3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_T4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bulogout_Click(object sender, EventArgs e)
        {
            change_color_by_click(bulogout,bnreviews, bnhome, bnbookticket, bnTransport, bnReports, bnSettings);
        }
    }
}
