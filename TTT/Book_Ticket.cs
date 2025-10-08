using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace TTT
{
    public partial class Book_Ticket : Form
    {
        private string loggedInUsername;
        private string connectionString = @"Data Source=RASEL\SQLEXPRESS;Initial Catalog=TMS;Integrated Security=True;";

        public Book_Ticket(string username)
        {
            InitializeComponent();
            this.loggedInUsername = username;
            LoadUserData();
            LoadDataGrid(null); // Load all data initially
        }

        private void LoadUserData()
        {
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

        // Load data into DataGridView with optional search filter
        private void LoadDataGrid(string searchFilter)
        {
            string tableName = loggedInUsername;
            string query = $"SELECT * FROM [{tableName}]";
            string searchColumns = "[Transport_No], [From_City], [To_City], [Payment_Status]";

            if (!string.IsNullOrEmpty(searchFilter))
            {
                string whereClause = string.Join(" OR ",
                    searchColumns.Split(new[] { ", " }, StringSplitOptions.None)
                                 .Select(col => $"{col} LIKE @searchTerm"));
                query = $"SELECT * FROM [{tableName}] WHERE {whereClause}";
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (!string.IsNullOrEmpty(searchFilter))
                        {
                            cmd.Parameters.AddWithValue("@searchTerm", "%" + searchFilter + "%");
                        }

                        SqlDataAdapter adp = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adp.Fill(dt);

                        dataGridViewhistory.AutoGenerateColumns = true;
                        dataGridViewhistory.DataSource = dt;
                    }
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 208)
                    {
                        MessageBox.Show($"Booking history not found for user: '{tableName}'. Please confirm a booking first.", 
                                        "No History", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridViewhistory.DataSource = null;
                    }
                    else
                    {
                        MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // 🔍 Highlight matches in DataGridView
        private void HighlightMatches(string searchText)
        {
            if (string.IsNullOrWhiteSpace(searchText))
                return;

            foreach (DataGridViewRow row in dataGridViewhistory.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null)
                    {
                        string cellText = cell.Value.ToString();
                        int matchIndex = cellText.IndexOf(searchText, StringComparison.OrdinalIgnoreCase);

                        if (matchIndex >= 0)
                        {
                            cell.Style.BackColor = Color.Yellow;  // Highlight background
                            cell.Style.ForeColor = Color.Black;   // Keep text readable
                        }
                        else
                        {
                            // Reset color for non-matching cells
                            cell.Style.BackColor = Color.White;
                            cell.Style.ForeColor = Color.Black;
                        }
                    }
                }
            }
        }

        // Search button click event
        private void buttonserachhistory_Click_1(object sender, EventArgs e)
        {
            string searchTerm = textBoxhistory.Text.Trim();
            LoadDataGrid(null);           // Load all data (so all rows visible)
            HighlightMatches(searchTerm); // Highlight only matches
        }

        // Optional unused event
        private void buttonserachhistory_Click(object sender, EventArgs e)
        {
            // Not used, keep empty
        }

        // ---------------------- Navigation + Design ----------------------

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

        private void bhx_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bhomebooked_Click(object sender, EventArgs e)
        {
            change_color_by_click(bhomebooked, bbookticketbooked, breviewsbooked, btransportsbooked, breportsbooked, bsettingsbooked, bulogoutbooked);
            Home home = new Home(loggedInUsername);
            home.Show();
            this.Close();
        }

        private void bbookticketbooked_Click(object sender, EventArgs e)
        {
            change_color_by_click(bbookticketbooked, bhomebooked, breviewsbooked, btransportsbooked, breportsbooked, bsettingsbooked, bulogoutbooked);
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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Book_Ticket_Load(object sender, EventArgs e)
        {
            change_color_by_click(bbookticketbooked, bhomebooked, breviewsbooked, btransportsbooked, breportsbooked, bsettingsbooked, bulogoutbooked);
        }

        private void dataGridViewhistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Optional: Add behavior for clicking on a cell
        }
    }
}
