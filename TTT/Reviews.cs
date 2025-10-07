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
    public partial class Reviews : Form
    {
        private string loggedInUsername;
        private TextBox[] reviewDisplayBoxes;

        public Reviews(string username)
        {
            InitializeComponent();
            this.loggedInUsername = username;

            reviewDisplayBoxes = new TextBox[]
            {
                textBoxreview1,
                textBoxreview2,
                textBoxreview3,
                textBoxreview4
            };

            foreach (var tb in reviewDisplayBoxes)
            {
                if (tb != null) tb.ReadOnly = true;
            }

            LoadUserData();
            LoadReviews();
        }

        private SqlConnection GetConnection()
        {
            string connectionString = @"Data Source=RASEL\SQLEXPRESS;Initial Catalog=TMS;Integrated Security=True;";
            return new SqlConnection(connectionString);
        }

        private void LoadUserData()
        {
            using (SqlConnection conn = GetConnection())
            {
                try
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

                            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                            {
                                string givenName = ds.Tables[0].Rows[0]["givenname"].ToString();
                                string surName = ds.Tables[0].Rows[0]["surname"].ToString();
                                labelbooked.Text = givenName + " " + surName;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading user data: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private string FormatReviewText(string givenName, string surName, string comment)
        {
            string formattedText =
                $"👤  {givenName} {surName}" + Environment.NewLine +
                $"✍️ {comment}";

            return formattedText;
        }

        private void LoadReviews()
        {
            using (SqlConnection conn = GetConnection())
            {
                try
                {
                    conn.Open();

                    // ✅ UPDATED: Order by star DESC (used as time indicator)
                    string query = "SELECT TOP 4 givenname, surname, comment, star FROM Reviews ORDER BY star DESC";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            int i = 0;
                            foreach (var tb in reviewDisplayBoxes)
                            {
                                if (tb != null) tb.Text = string.Empty;
                            }

                            while (reader.Read() && i < reviewDisplayBoxes.Length)
                            {
                                string givenName = reader["givenname"].ToString();
                                string surName = reader["surname"].ToString();
                                string comment = reader["comment"].ToString();

                                reviewDisplayBoxes[i].Text = FormatReviewText(givenName, surName, comment);
                                i++;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading reviews: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // ✅ FIXED: Update old comment if user already has one
        private void button_submit_Click_1(object sender, EventArgs e)
        {
            string newComment = textBoxyour_review.Text.Trim();

            if (string.IsNullOrEmpty(newComment))
            {
                MessageBox.Show("Please enter a comment before submitting.", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string givenName = string.Empty;
            string surName = string.Empty;
            string[] parts = labelbooked.Text.Split(new char[] { ' ' }, 2);
            givenName = parts.Length > 0 ? parts[0] : "";
            surName = parts.Length > 1 ? parts[1] : "";

            if (string.IsNullOrEmpty(givenName))
            {
                MessageBox.Show("User name could not be retrieved. Please try logging in again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection conn = GetConnection())
            {
                try
                {
                    conn.Open();

                    // ✅ UPDATED: Check if user already commented
                    string checkQuery = "SELECT COUNT(*) FROM Reviews WHERE username = @username";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@username", loggedInUsername);
                        int count = (int)checkCmd.ExecuteScalar();

                        // ✅ Use star column to store the latest timestamp (as integer)
                        int currentTimeValue = (int)DateTimeOffset.UtcNow.ToUnixTimeSeconds() % 1000000;

                        if (count > 0)
                        {
                            // ✅ Update existing comment
                            string updateQuery = @"UPDATE Reviews 
                                                   SET comment = @comment, star = @star 
                                                   WHERE username = @username";
                            using (SqlCommand updateCmd = new SqlCommand(updateQuery, conn))
                            {
                                updateCmd.Parameters.AddWithValue("@username", loggedInUsername);
                                updateCmd.Parameters.AddWithValue("@comment", newComment);
                                updateCmd.Parameters.AddWithValue("@star", currentTimeValue);
                                updateCmd.ExecuteNonQuery();

                                MessageBox.Show("Your previous comment has been updated!", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            // ✅ Insert new comment
                            string insertQuery = @"INSERT INTO Reviews (username, givenname, surname, comment, star)
                                                   VALUES (@username, @givenname, @surname, @comment, @star)";
                            using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
                            {
                                insertCmd.Parameters.AddWithValue("@username", loggedInUsername);
                                insertCmd.Parameters.AddWithValue("@givenname", givenName);
                                insertCmd.Parameters.AddWithValue("@surname", surName);
                                insertCmd.Parameters.AddWithValue("@comment", newComment);
                                insertCmd.Parameters.AddWithValue("@star", currentTimeValue);
                                insertCmd.ExecuteNonQuery();

                                MessageBox.Show("Your review has been submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }

                    textBoxyour_review.Clear();
                    LoadReviews();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error submitting review: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // --- Keep All Original Code Below ---

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

        private void breviewsbooked_Click(object sender, EventArgs e)
        {
            change_color_by_click(breviewsbooked, bhomebooked, bbookticketbooked, btransportsbooked, breportsbooked, bsettingsbooked, bulogoutbooked);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Reviews_Load(object sender, EventArgs e)
        {
            change_color_by_click(breviewsbooked, bhomebooked, bbookticketbooked, btransportsbooked, breportsbooked, bsettingsbooked, bulogoutbooked);
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

        private void textBoxreview1_TextChanged(object sender, EventArgs e) { }
        private void textBoxreview2_TextChanged(object sender, EventArgs e) { }
        private void textBoxreview3_TextChanged(object sender, EventArgs e) { }
        private void textBoxreview4_TextChanged(object sender, EventArgs e) { }
        private void textBoxyour_review_TextChanged(object sender, EventArgs e) { }
        private void pictureBoxbooked_Click(object sender, EventArgs e) { }
        private void textBoxyour_review_TextChanged_1(object sender, EventArgs e) { }

        private void label_customer_review_Click(object sender, EventArgs e)
        {

        }
    }
}
