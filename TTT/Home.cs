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
        private string loggedInUsername;
        private int currentOffset = 0; // ✅ Used for pagination (next 4 records per refresh)
        private const int PageSize = 4;

        public Home(string username)
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
                lhname.Text = givenName + " " + surName;
            }

            conn.Close();
        }

        // ✅ Loads 4 flight details starting from currentOffset
        private void LoadPlaneDetails()
        {
            string connectionString = @"Data Source=RASEL\SQLEXPRESS;Initial Catalog=TMS;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = $@"
                    SELECT Transport_No, From_City, To_City, Departure_Date, Departure_Only_Time, 
                           Arrival_Date, Arrival_Only_Time, Price_eco
                    FROM plane_details
                    ORDER BY Transport_No
                    OFFSET {currentOffset} ROWS FETCH NEXT {PageSize} ROWS ONLY;";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    int panelIndex = 1;

                    while (reader.Read() && panelIndex <= 4)
                    {
                        string suffix = panelIndex == 1 ? "" : "_T" + panelIndex;

                        // Find TextBoxes dynamically
                        TextBox tbPlane = this.Controls.Find("textBoxplane_name" + suffix, true).FirstOrDefault() as TextBox;
                        TextBox tbFrom = this.Controls.Find("textBoxfrom" + suffix, true).FirstOrDefault() as TextBox;
                        TextBox tbDeparture = this.Controls.Find("textBoxdeparture" + suffix, true).FirstOrDefault() as TextBox;
                        TextBox tbDepTime = this.Controls.Find("textBoxdeparturetime" + suffix, true).FirstOrDefault() as TextBox;
                        TextBox tbTo = this.Controls.Find("textBoxto" + suffix, true).FirstOrDefault() as TextBox;
                        TextBox tbArrival = this.Controls.Find("textBoxarrival" + suffix, true).FirstOrDefault() as TextBox;
                        TextBox tbArrTime = this.Controls.Find("textBoxarrival_time" + suffix, true).FirstOrDefault() as TextBox;
                        TextBox tbPrice = this.Controls.Find("textBoxeco_price" + suffix, true).FirstOrDefault() as TextBox;

                        // Set values safely
                        if (tbPlane != null) tbPlane.Text = reader["Transport_No"].ToString();
                        if (tbFrom != null) tbFrom.Text = reader["From_City"].ToString();
                        if (tbTo != null) tbTo.Text = reader["To_City"].ToString();
                        if (tbDeparture != null) tbDeparture.Text = Convert.ToDateTime(reader["Departure_Date"]).ToString("dd/MM/yyyy");
                        if (tbArrival != null) tbArrival.Text = Convert.ToDateTime(reader["Arrival_Date"]).ToString("dd/MM/yyyy");

                        // ✅ Handle TimeSpan correctly
                        if (tbDepTime != null && reader["Departure_Only_Time"] is TimeSpan depTime)
                            tbDepTime.Text = (DateTime.Today + depTime).ToString("hh:mm tt");
                        if (tbArrTime != null && reader["Arrival_Only_Time"] is TimeSpan arrTime)
                            tbArrTime.Text = (DateTime.Today + arrTime).ToString("hh:mm tt");

                        if (tbPrice != null) tbPrice.Text = reader["Price_eco"].ToString();

                        panelIndex++;
                    }
                }
            }
        }

        private void bhx_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void bnhome_Click(object sender, EventArgs e)
        {
            change_color_by_click(bnhome, bnbookticket, bnreviews, bnTransport, bnReports, bnSettings, bulogout);
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
            LoadPlaneDetails();
        }

        private void lhname_Click(object sender, EventArgs e) { }

        private void panel_Book_Hote_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void panel_Book_Transport_Paint(object sender, PaintEventArgs e)
        {
            //
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel_Book_Ticket_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void panel_T1_Paint(object sender, PaintEventArgs e) { }
        private void panel_T2_Paint(object sender, PaintEventArgs e) { }
        private void panel_T3_Paint(object sender, PaintEventArgs e) { }
        private void panel_T4_Paint(object sender, PaintEventArgs e) { }

        private void bulogout_Click(object sender, EventArgs e)
        {
            change_color_by_click(bulogout, bnreviews, bnhome, bnbookticket, bnTransport, bnReports, bnSettings);

            DialogResult result = MessageBox.Show("Log out?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                Form1 f = new Form1();
                f.Show();
                this.Hide();
            }
        }

        // ✅ Refresh button: show next 4 flights
        private void button_refresh_Click(object sender, EventArgs e)
        {
            currentOffset += PageSize;
            LoadPlaneDetails();
        }

        private void button_search_Click(object sender, EventArgs e)
        {

        }
    }
}
