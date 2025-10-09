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
    public partial class Admin : Form
    {
        private string loggedInUsername;

        // Class-level fields to manage the data source for editing/saving
        private SqlDataAdapter adapter;
        private DataTable currentDataTable;
        private string currentQuery;
        private string currentTableName; // Stores the name of the currently displayed table (e.g., "plane_details")

        // Assuming you have a TextBox named 'textBox_search'
        // If not, replace 'textBox_search' with the actual name of your search TextBox control.

        public Admin(string username)
        {
            InitializeComponent();
            this.loggedInUsername = username;
            LoadUserData();
            // Optional: Hide the save button and make DataGridView read-only on startup
            // if (button_save != null) button_save.Visible = false; 
            dataGridView_admin.ReadOnly = true;
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

                        if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                        {
                            string givenName = ds.Tables[0].Rows[0]["givenname"].ToString();
                            string surName = ds.Tables[0].Rows[0]["surname"].ToString();
                            labelbooked.Text = givenName + " " + surName;
                        }
                    }
                }
            }
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

        // UPDATED: Helper method to load data into DataGridView and initialize DataAdapter/DataTable
        private void LoadData(string query, string tableName)
        {
            currentQuery = query;
            currentTableName = tableName;
            string connectionString = @"Data Source=RASEL\SQLEXPRESS;Initial Catalog=TMS;Integrated Security=True;";

            // Dispose of previous objects
            if (adapter != null) adapter.Dispose();
            if (currentDataTable != null) currentDataTable.Dispose();

            currentDataTable = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    adapter = new SqlDataAdapter(query, conn);
                    adapter.Fill(currentDataTable);
                    dataGridView_admin.DataSource = currentDataTable;

                    // Set DataGridView to read-only until 'Edit' is clicked
                    dataGridView_admin.ReadOnly = true;
                }
                // Optional: Hide save button whenever new data is loaded
                // if (button_save != null) button_save.Visible = false; 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data for table " + tableName + ": " + ex.Message, "Database Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataGridView_admin.DataSource = null;
            }
        }

        private void bhomebooked_Click(object sender, EventArgs e)
        {
            change_color_by_click(bhomebooked, bbookticketbooked, breviewsbooked, btransportsbooked, breportsbooked, bsettingsbooked, bulogoutbooked);

            // ✅ Show plane_details table
            string query = @"SELECT [Transport_No],
                                     [Price_eco],
                                     [Price_busine],
                                     [From_City],
                                     [To_City],
                                     [Departure_Date],
                                     [Departure_Only_Time],
                                     [Arrival_Date],
                                     [Arrival_Only_Time],
                                     [Econo_Available_Seats],
                                     [Busine_Available_Seats]
                              FROM [TMS].[dbo].[plane_details]";
            LoadData(query, "plane_details");
        }

        private void bbookticketbooked_Click(object sender, EventArgs e)
        {
            change_color_by_click(bbookticketbooked, bhomebooked, breviewsbooked, btransportsbooked, breportsbooked, bsettingsbooked, bulogoutbooked);

            // ✅ Clear DataGridView
            dataGridView_admin.DataSource = null;
            if (currentDataTable != null) currentDataTable.Clear();
            currentTableName = null;
        }

        private void breviewsbooked_Click(object sender, EventArgs e)
        {
            change_color_by_click(breviewsbooked, bhomebooked, bbookticketbooked, btransportsbooked, breportsbooked, bsettingsbooked, bulogoutbooked);

            // ✅ Show Reviews table
            string query = @"SELECT [username],
                                     [givenname],
                                     [surname],
                                     [comment],
                                     [star]
                              FROM [TMS].[dbo].[Reviews]";
            LoadData(query, "Reviews");
        }

        private void btransportsbooked_Click(object sender, EventArgs e)
        {
            change_color_by_click(btransportsbooked, bhomebooked, bbookticketbooked, breviewsbooked, breportsbooked, bsettingsbooked, bulogoutbooked);

            // ✅ Show Transports table
            string query = @"SELECT [place1],
                                     [place2],
                                     [price]
                              FROM [TMS].[dbo].[Transports]";
            LoadData(query, "Transports");
        }

        private void breportsbooked_Click(object sender, EventArgs e)
        {
            change_color_by_click(breportsbooked, bhomebooked, bbookticketbooked, breviewsbooked, btransportsbooked, bsettingsbooked, bulogoutbooked);

            // ✅ Show Reports table
            string query = @"SELECT [Id],
                                     [rasel],
                                     [jitu]
                              FROM [TMS].[dbo].[Reports]";
            LoadData(query, "Reports");
        }

        private void bsettingsbooked_Click(object sender, EventArgs e)
        {
            change_color_by_click(bsettingsbooked, bhomebooked, bbookticketbooked, breviewsbooked, btransportsbooked, breportsbooked, bulogoutbooked);
            // Assuming Settings form exists
            // Settings s = new Settings(loggedInUsername);
            // s.Show();
            // this.Hide();
            MessageBox.Show("Settings form is pending.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void bulogoutbooked_Click(object sender, EventArgs e)
        {
            change_color_by_click(bulogoutbooked, bhomebooked, bbookticketbooked, breviewsbooked, btransportsbooked, breportsbooked, bsettingsbooked);
            DialogResult result = MessageBox.Show("Log out?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                // Assuming Form1 is the login form
                // Form1 f = new Form1();
                // f.Show();
                // this.Hide();
                MessageBox.Show("Logging out and showing Form1 is pending.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            // Initial load of the Home (plane_details) data
            bhomebooked_Click(sender, e);
        }

        // ---------------------------------------------
        //             CORE FUNCTIONALITY
        // ---------------------------------------------

        /// <summary>
        /// Searches and filters the data currently in the DataGridView based on the search TextBox.
        /// </summary>
        private void button_search_Click(object sender, EventArgs e)
        {
            if (currentDataTable == null || currentDataTable.Rows.Count == 0)
            {
                MessageBox.Show("No data loaded to search.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Assuming you have a TextBox named 'textBox_search'
            string searchValue = textBox_searchfrom.Text.Trim();

            if (string.IsNullOrEmpty(searchValue))
            {
                // If search box is empty, remove the filter to show all rows
                currentDataTable.DefaultView.RowFilter = string.Empty;
                return;
            }

            // Client-side filtering (on the loaded DataTable)
            try
            {
                StringBuilder filter = new StringBuilder();

                // Build a filter expression that searches all string-convertible columns
                foreach (DataColumn column in currentDataTable.Columns)
                {
                    if (filter.Length > 0)
                    {
                        filter.Append(" OR ");
                    }
                    // Filter uses LIKE for partial, case-insensitive matches on the string conversion of the column
                    filter.AppendFormat("CONVERT([{0}], 'System.String') LIKE '%{1}%'", column.ColumnName, searchValue.Replace("'", "''"));
                }

                currentDataTable.DefaultView.RowFilter = filter.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error filtering data: " + ex.Message, "Filter Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                currentDataTable.DefaultView.RowFilter = string.Empty; // Clear filter on error
            }
        }

        /// <summary>
        /// Makes the DataGridView editable and shows the Save button.
        /// </summary>
        private void bdata_edit_Click(object sender, EventArgs e)
        {
            if (dataGridView_admin.DataSource == null)
            {
                MessageBox.Show("No data loaded to edit.", "Edit Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if the current table is one we allow editing for (e.g., must have a Primary Key)
            if (string.IsNullOrEmpty(currentTableName))
            {
                MessageBox.Show("The current view cannot be edited. Load data (e.g., Home) first.", "Edit Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dataGridView_admin.ReadOnly = false;
            dataGridView_admin.AllowUserToAddRows = true;
            // if (button_save != null) button_save.Visible = true; // Show save button

            MessageBox.Show("Data Grid View is now editable. Click 'Save' to commit changes.", "Editing Enabled", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Saves changes (edits, new rows) from the DataGridView back to the database.
        /// </summary>
        private void button_save_Click(object sender, EventArgs e)
        {
            if (currentDataTable == null || adapter == null || string.IsNullOrEmpty(currentTableName))
            {
                MessageBox.Show("No data or adapter available to save.", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Optional: Limit saving to certain tables if command generation is complex for others
            if (currentTableName != "plane_details" && currentTableName != "Reviews" && currentTableName != "Transports" && currentTableName != "Reports")
            {
                MessageBox.Show($"Saving is not configured for the current view ('{currentTableName}').", "Save Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                // Crucial step: Generate SQL commands (Update, Insert, Delete). 
                // REQUIRES a Primary Key on the table!
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);

                // Commit changes: Sends SQL commands to the database
                int rowsAffected = adapter.Update(currentDataTable);

                // Finalize changes in the DataTable after successful commit
                currentDataTable.AcceptChanges();

                // Revert to ReadOnly
                dataGridView_admin.ReadOnly = true;
                // if (button_save != null) button_save.Visible = false;

                MessageBox.Show($"{rowsAffected} row(s) updated and saved successfully.", "Save Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // IMPORTANT: Show the detailed error, often reveals missing Primary Key issue.
                MessageBox.Show("Error saving data. Ensure the table has a Primary Key: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Keep it editable so the user can fix the data
                dataGridView_admin.ReadOnly = false;
            }
        }

        /// <summary>
        /// Deletes the selected row(s) from the DataGridView and immediately commits the change to the database.
        /// </summary>
        private void bdata_delete_Click(object sender, EventArgs e)
        {
            if (dataGridView_admin.SelectedRows.Count == 0 || currentDataTable == null)
            {
                MessageBox.Show("Please select one or more rows to delete.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if the current table is one we allow editing for
            if (string.IsNullOrEmpty(currentTableName))
            {
                MessageBox.Show("The current view cannot have rows deleted.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dialogResult = MessageBox.Show($"Are you sure you want to delete {dataGridView_admin.SelectedRows.Count} selected row(s)? This change will be saved immediately.", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    // 1. Mark rows for deletion in the DataTable
                    // Loop backwards to avoid issues with index changes after deletion
                    for (int i = dataGridView_admin.SelectedRows.Count - 1; i >= 0; i--)
                    {
                        DataGridViewRow row = dataGridView_admin.SelectedRows[i];
                        DataRowView drv = row.DataBoundItem as DataRowView;
                        if (drv != null)
                        {
                            drv.Row.Delete(); // Marks the row as Deleted
                        }
                    }

                    // 2. Generate the DELETE command and execute it
                    SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
                    int rowsAffected = adapter.Update(currentDataTable); // Sends the DELETE to the database

                    // 3. Finalize the change in the DataTable
                    currentDataTable.AcceptChanges();

                    MessageBox.Show($"{rowsAffected} row(s) deleted successfully and saved to database.", "Delete Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    // IMPORTANT: Show the detailed error
                    MessageBox.Show("Error deleting data. Ensure the table has a Primary Key: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}