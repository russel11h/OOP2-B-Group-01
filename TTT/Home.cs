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
        private int currentOffset = 0; // Used for pagination (next 4 records per refresh)
        private const int PageSize = 4;

        // Structure to map panels to their Transport_No display TextBoxes for dynamic access
        private readonly (Panel panel, string transportTextBoxName)[] flightPanelsInfo;

        public Home(string username)
        {
            InitializeComponent();
            this.loggedInUsername = username;
            LoadUserData();

            // Initialize the array of flight panels/textboxes
            // NOTE: Assuming panel names are panel_T1, panel_T2, etc.
            flightPanelsInfo = new (Panel, string)[]
            {
                (this.Controls.Find("panel_T1", true).FirstOrDefault() as Panel, "textBoxplane_name"),
                (this.Controls.Find("panel_T2", true).FirstOrDefault() as Panel, "textBoxplane_name_T2"),
                (this.Controls.Find("panel_T3", true).FirstOrDefault() as Panel, "textBoxplane_name_T3"),
                (this.Controls.Find("panel_T4", true).FirstOrDefault() as Panel, "textBoxplane_name_T4")
            };

            // Attach a click event handler to the panels and their controls for navigation
            foreach (var item in flightPanelsInfo)
            {
                if (item.panel != null)
                {
                    item.panel.Click += FlightPanel_Click;
                    // Attach the handler to all controls within the panel to ensure clicks work
                    foreach (Control control in item.panel.Controls)
                    {
                        control.Click += FlightPanel_Click;
                    }
                }
            }
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

        // Helper method to clear all textboxes and hide panels
        private void ClearPlaneDetailsUI()
        {
            for (int i = 1; i <= PageSize; i++)
            {
                string suffix = i == 1 ? "" : "_T" + i;

                // Clear all associated textboxes (Transport_No, From, To, etc.)
                string[] textBoxNames = {
                    "textBoxplane_name", "textBoxfrom", "textBoxto",
                    "textBoxdeparture", "textBoxdeparturetime",
                    "textBoxarrival", "textBoxarrival_time", "textBoxeco_price"
                };

                foreach (string name in textBoxNames)
                {
                    TextBox tb = this.Controls.Find(name + suffix, true).FirstOrDefault() as TextBox;
                    if (tb != null) tb.Text = string.Empty;
                }

                // Hide the panel
                Panel p = this.Controls.Find("panel_T" + i, true).FirstOrDefault() as Panel;
                if (p != null) p.Visible = false;
            }
        }

        // MODIFIED: Loads flight details with optional search criteria
        private void LoadPlaneDetails(string fromCity = null, string toCity = null)
        {
            ClearPlaneDetailsUI(); // Clear the UI before loading new data

            string connectionString = @"Data Source=RASEL\SQLEXPRESS;Initial Catalog=TMS;Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Base query
                string baseQuery = @"
                    SELECT Transport_No, From_City, To_City, Departure_Date, Departure_Only_Time,
                           Arrival_Date, Arrival_Only_Time, Price_eco
                    FROM plane_details";

                // Add WHERE clause if searching
                string whereClause = "";
                bool isSearching = !string.IsNullOrWhiteSpace(fromCity) || !string.IsNullOrWhiteSpace(toCity);

                if (isSearching)
                {
                    whereClause = " WHERE 1=1 ";
                    if (!string.IsNullOrWhiteSpace(fromCity))
                    {
                        // Using LIKE for flexible searching (case-insensitive)
                        whereClause += " AND From_City LIKE @fromCity ";
                    }
                    if (!string.IsNullOrWhiteSpace(toCity))
                    {
                        whereClause += " AND To_City LIKE @toCity ";
                    }
                }

                // Determine offset: use 0 for search, use currentOffset for refresh
                int offset = isSearching ? 0 : currentOffset;
                string paginationClause = $@"
                    ORDER BY Transport_No
                    OFFSET {offset} ROWS FETCH NEXT {PageSize} ROWS ONLY;";

                string query = baseQuery + whereClause + paginationClause;

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Add parameters if searching
                    if (!string.IsNullOrWhiteSpace(fromCity))
                    {
                        // Wrap in % for partial matching
                        cmd.Parameters.AddWithValue("@fromCity", "%" + fromCity + "%");
                    }
                    if (!string.IsNullOrWhiteSpace(toCity))
                    {
                        cmd.Parameters.AddWithValue("@toCity", "%" + toCity + "%");
                    }

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        int panelIndex = 1;

                        while (reader.Read() && panelIndex <= PageSize)
                        {
                            string suffix = panelIndex == 1 ? "" : "_T" + panelIndex;
                            Panel panel = this.Controls.Find("panel_T" + panelIndex, true).FirstOrDefault() as Panel;

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

                            // Date formatting
                            if (tbDeparture != null) tbDeparture.Text = Convert.ToDateTime(reader["Departure_Date"]).ToString("dd/MM/yyyy");
                            if (tbArrival != null) tbArrival.Text = Convert.ToDateTime(reader["Arrival_Date"]).ToString("dd/MM/yyyy");

                            // Handle TimeSpan (time-only field) and format as 'hh:mm tt'
                            if (tbDepTime != null && reader["Departure_Only_Time"] is TimeSpan depTime)
                                tbDepTime.Text = (DateTime.Today + depTime).ToString("hh:mm tt");
                            if (tbArrTime != null && reader["Arrival_Only_Time"] is TimeSpan arrTime)
                                tbArrTime.Text = (DateTime.Today + arrTime).ToString("hh:mm tt");

                            if (tbPrice != null) tbPrice.Text = reader["Price_eco"].ToString();

                            // Make the panel visible
                            if (panel != null) panel.Visible = true;

                            panelIndex++;
                        }
                    }
                }
            }
        }

        // NEW: Event handler for clicking any flight panel
        private void FlightPanel_Click(object sender, EventArgs e)
        {
            Control clickedControl = sender as Control;

            // Find the parent panel that was clicked
            Panel clickedPanel = clickedControl as Panel ?? clickedControl.Parent as Panel;

            if (clickedPanel != null && clickedPanel.Visible)
            {
                var panelInfo = flightPanelsInfo.FirstOrDefault(info => info.panel == clickedPanel);

                if (panelInfo.panel != null)
                {
                    // Find the Transport_No TextBox inside the panel using the stored name
                    TextBox tbTransportNo = clickedPanel.Controls.Find(panelInfo.transportTextBoxName, true).FirstOrDefault() as TextBox;

                    if (tbTransportNo != null && !string.IsNullOrWhiteSpace(tbTransportNo.Text))
                    {
                        string transportNo = tbTransportNo.Text;

                        // Navigate to SelectPage, passing the username and Transport_No
                        try
                        {
                            // This requires SelectPage to have a constructor: SelectPage(string username, string transportNo)
                            Form selectPage = (Form)Activator.CreateInstance(typeof(SelectPage), loggedInUsername, transportNo);
                            selectPage.Show();
                            this.Hide();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error opening SelectPage. Ensure it has a constructor: SelectPage(string username, string transportNo). Details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
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
            // Initial load of the first 4 flights
            currentOffset = 0;
            LoadPlaneDetails();
        }

        private void lhname_Click(object sender, EventArgs e) { }

        // KEEPING ORIGINAL METHOD NAME TO PREVENT DESIGNER ISSUES
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

        private void panel_Book_Transport_Paint(object sender, PaintEventArgs e) { }

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

        // UPDATED: Refresh button: show next 4 flights
        private void button_refresh_Click(object sender, EventArgs e)
        {
            // Clear search fields when refreshing pagination
            TextBox tbSearchFrom = this.Controls.Find("textBox_searchfrom", true).FirstOrDefault() as TextBox;
            TextBox tbSearchTo = this.Controls.Find("textBox_searchto", true).FirstOrDefault() as TextBox;
            if (tbSearchFrom != null) tbSearchFrom.Text = string.Empty;
            if (tbSearchTo != null) tbSearchTo.Text = string.Empty;

            currentOffset += PageSize;
            LoadPlaneDetails();
        }

        // IMPLEMENTED: Search button logic
        private void button_search_Click(object sender, EventArgs e)
        {
            TextBox tbSearchFrom = this.Controls.Find("textBox_searchfrom", true).FirstOrDefault() as TextBox;
            TextBox tbSearchTo = this.Controls.Find("textBox_searchto", true).FirstOrDefault() as TextBox;

            string fromCity = tbSearchFrom?.Text.Trim();
            string toCity = tbSearchTo?.Text.Trim();

            // Reset offset to 0 to view the first page of search results
            currentOffset = 0;

            LoadPlaneDetails(fromCity, toCity);
        }
    }
}