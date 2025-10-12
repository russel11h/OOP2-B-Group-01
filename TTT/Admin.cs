using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace TTT
{
    public partial class Admin : Form
    {
        private string loggedInUsername;

        // Class-level fields
        private SqlDataAdapter adapter;
        private DataTable currentDataTable;
        private string currentQuery;
        private string currentTableName;

        // Class-level SqlConnection to keep it open during editing
        private SqlConnection sqlConnection;

        // Connection String defined once
        private readonly string connectionString = @"Data Source=RASEL\SQLEXPRESS;Initial Catalog=TMS;Integrated Security=True;";

        public Admin(string username)
        {
            InitializeComponent();
            this.loggedInUsername = username;

            // Initialize the class-level connection object
            sqlConnection = new SqlConnection(connectionString);

            LoadUserData();
            dataGridView_admin.ReadOnly = true;
            dataGridView_admin.AllowUserToAddRows = false;

            // Ensure the connection is closed when the form closes
            this.FormClosed += (s, e) => { if (sqlConnection != null && sqlConnection.State == ConnectionState.Open) sqlConnection.Close(); };
        }

        // Helper method to ensure connection is open
        private bool InitializeConnection()
        {
            try
            {
                if (sqlConnection.State != ConnectionState.Open)
                {
                    sqlConnection.Open();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to open database connection: " + ex.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void LoadUserData()
        {
            // Use a local connection scope for simple read operations
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

        // LoadData uses a local connection scope for simple read operations
        private void LoadData(string query, string tableName)
        {
            currentQuery = query;
            currentTableName = tableName;

            // Dispose previous adapter and table
            if (adapter != null) adapter.Dispose();
            if (currentDataTable != null) currentDataTable.Dispose();

            currentDataTable = new DataTable();
            try
            {
                // Use a local connection for safe, read-only display
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    adapter = new SqlDataAdapter(query, conn);
                    adapter.Fill(currentDataTable);
                    dataGridView_admin.DataSource = currentDataTable;

                    // Reset to read-only state after loading
                    dataGridView_admin.ReadOnly = true;
                    dataGridView_admin.AllowUserToAddRows = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data for table " + tableName + ": " + ex.Message, "Database Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataGridView_admin.DataSource = null;
            }
        }

        // --- BUTTON HANDLERS ---

        private void bhomebooked_Click(object sender, EventArgs e)
        {
            change_color_by_click(bhomebooked, bbookticketbooked, breviewsbooked, btransportsbooked, breportsbooked, bsettingsbooked, bulogoutbooked);
            string query = @"SELECT [Transport_No], [Price_eco], [Price_busine], [From_City], [To_City],
                                     [Departure_Date], [Departure_Only_Time], [Arrival_Date], [Arrival_Only_Time],
                                     [Econo_Available_Seats], [Busine_Available_Seats]
                                 FROM [TMS].[dbo].[plane_details]";
            LoadData(query, "plane_details");
        }

        private void bbookticketbooked_Click(object sender, EventArgs e)
        {
            change_color_by_click(bbookticketbooked, bhomebooked, breviewsbooked, btransportsbooked, breportsbooked, bsettingsbooked, bulogoutbooked);
            dataGridView_admin.DataSource = null;
            if (currentDataTable != null) currentDataTable.Clear();
            currentTableName = null;

            MessageBox.Show("Enter a keyword in the search box and click Search to find table data. Search results are read-only.",
                "Search Mode", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void breviewsbooked_Click(object sender, EventArgs e)
        {
            change_color_by_click(breviewsbooked, bhomebooked, bbookticketbooked, btransportsbooked, breportsbooked, bsettingsbooked, bulogoutbooked);
            string query = @"SELECT [username], [givenname], [surname], [comment], [star] FROM [TMS].[dbo].[Reviews]";
            LoadData(query, "Reviews");
        }

        private void btransportsbooked_Click(object sender, EventArgs e)
        {
            change_color_by_click(btransportsbooked, bhomebooked, bbookticketbooked, breviewsbooked, breportsbooked, bsettingsbooked, bulogoutbooked);
            string query = @"SELECT [place1], [place2], [price] FROM [TMS].[dbo].[Transports]";
            LoadData(query, "Transports");
        }

        private void breportsbooked_Click(object sender, EventArgs e)
        {
            change_color_by_click(breportsbooked, bhomebooked, bbookticketbooked, breviewsbooked, btransportsbooked, bsettingsbooked, bulogoutbooked);
            string query = @"SELECT [Id], [rasel], [jitu] FROM [TMS].[dbo].[Reports]";
            LoadData(query, "Reports");
        }

        private void bsettingsbooked_Click(object sender, EventArgs e)
        {
            change_color_by_click(bsettingsbooked, bhomebooked, bbookticketbooked, breviewsbooked, btransportsbooked, breportsbooked, bulogoutbooked);
            //MessageBox.Show("Settings form is pending.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Settings s = new Settings(loggedInUsername);
            s.Show();
            this.Hide();

        }

        private void bulogoutbooked_Click(object sender, EventArgs e)
        {
            change_color_by_click(bulogoutbooked, bhomebooked, bbookticketbooked, breviewsbooked, btransportsbooked, breportsbooked, bsettingsbooked);
            DialogResult result = MessageBox.Show("Log out?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                // Close the active connection before switching forms
                if (sqlConnection.State == ConnectionState.Open) sqlConnection.Close();

                // Assuming Form1 is your login/initial form
                Form1 f = new Form1();
                f.Show();
                this.Hide();
            }
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            // Initial load of the default view (plane_details)
            bhomebooked_Click(sender, e);
        }

        // 🔍 SMART SEARCH FUNCTION - REVISED
        private void button_search_Click(object sender, EventArgs e)
        {
            string searchValue = textBox_searchfrom.Text.Trim();

            if (string.IsNullOrEmpty(searchValue))
            {
                MessageBox.Show("Please enter something to search.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string[] possibleTables = { "plane_details", "Transports", "Reviews", "Reports", "regst" };

            bool tableFound = false;

            // *** FIX: Clear the state regardless of what button was previously clicked ***
            dataGridView_admin.DataSource = null;
            if (adapter != null) adapter.Dispose();
            if (currentDataTable != null) currentDataTable.Dispose();
            currentTableName = null;
            currentQuery = null;
            // *************************************************************************

            currentDataTable = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                foreach (string table in possibleTables)
                {
                    try
                    {
                        // Dynamic SQL search query
                        string searchQuery = $@"
                            DECLARE @sql NVARCHAR(MAX) = N'';
                            SELECT @sql = STRING_AGG(
                                'SELECT * FROM [{table}] WHERE ' + 
                                STRING_AGG('CONVERT([' + COLUMN_NAME + '], NVARCHAR(100)) LIKE ''%{searchValue.Replace("'", "''")}%''', ' OR ')
                            , '')
                            FROM INFORMATION_SCHEMA.COLUMNS
                            WHERE TABLE_NAME = '{table}';
                            EXEC sp_executesql @sql;";

                        SqlDataAdapter da = new SqlDataAdapter(searchQuery, conn);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            currentTableName = table;
                            currentDataTable = dt;
                            currentQuery = $"SELECT * FROM [{table}]";

                            dataGridView_admin.DataSource = dt;
                            dataGridView_admin.ReadOnly = true;
                            dataGridView_admin.AllowUserToAddRows = false;

                            MessageBox.Show($"✅ Data found in table '{table}'. Search results are read-only. Click 'Edit Data' to enable editing on this table.",
                                "Search Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            tableFound = true;
                            break;
                        }
                    }
                    catch
                    {
                        // Ignore tables that fail the dynamic search query
                        continue;
                    }
                }

                if (!tableFound)
                {
                    MessageBox.Show("❌ No table found containing your searched value.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView_admin.DataSource = null;
                }
            }
        }

        // ✏️ EDIT DATA - Unchanged logic (relies on InitializeConnection())
        private void bdata_edit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentTableName))
            {
                MessageBox.Show("Please load data (e.g., click 'Home') or perform a search first.", "Edit Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Only allow editing/saving for configured tables
            if (currentTableName != "plane_details" && currentTableName != "Reviews" && currentTableName != "Transports" && currentTableName != "Reports" && currentTableName != "regst")
            {
                MessageBox.Show($"Editing is not allowed for the current view ('{currentTableName}').", "Edit Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Ensure the connection is open
            if (!InitializeConnection()) return;

            // Reload the data using the base SELECT query to ensure a clean adapter setup 
            string baseQuery = $"SELECT * FROM [{currentTableName}]";
            try
            {
                // Dispose previous adapter and table
                if (adapter != null) adapter.Dispose();
                if (currentDataTable != null) currentDataTable.Dispose();
                currentDataTable = new DataTable();

                // Create the adapter using the OPEN class-level connection
                adapter = new SqlDataAdapter(baseQuery, sqlConnection);
                adapter.Fill(currentDataTable);
                dataGridView_admin.DataSource = currentDataTable;

                // Enable editing
                dataGridView_admin.ReadOnly = false;
                dataGridView_admin.AllowUserToAddRows = true;

                MessageBox.Show($"Data Grid View for table '{currentTableName}' is now editable. Click 'Save' to commit changes.",
                    "Editing Enabled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error preparing data for editing. Ensure the table exists: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dataGridView_admin.ReadOnly = true;
                dataGridView_admin.AllowUserToAddRows = false;
            }
        }

        // 💾 SAVE DATA - Unchanged logic (relies on InitializeConnection())
        private void button_save_Click(object sender, EventArgs e)
        {
            if (currentDataTable == null || adapter == null || string.IsNullOrEmpty(currentTableName) || dataGridView_admin.ReadOnly == true)
            {
                MessageBox.Show("No active editable data loaded. Click 'Edit Data' first.", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (currentTableName != "plane_details" && currentTableName != "Reviews" && currentTableName != "Transports" && currentTableName != "Reports" && currentTableName != "regst")
            {
                MessageBox.Show($"Saving is not configured for the current view ('{currentTableName}').", "Save Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Ensure connection is open just before update
            if (!InitializeConnection()) return;

            try
            {
                // 1. Generate commands (these commands will be automatically assigned the class-level connection)
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);

                // 2. Execute the update using the open connection
                int rowsAffected = adapter.Update(currentDataTable);

                // 3. Commit changes to the DataTable itself
                currentDataTable.AcceptChanges();

                // 4. Disable editing after successful save
                dataGridView_admin.ReadOnly = true;
                dataGridView_admin.AllowUserToAddRows = false;

                MessageBox.Show($"{rowsAffected} row(s) updated/inserted/deleted and saved successfully.", "Save Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving data. Ensure the table has a Primary Key and all data types are valid: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Keep editing enabled so the user can fix the error
                dataGridView_admin.ReadOnly = false;
                dataGridView_admin.AllowUserToAddRows = true;
            }
        }

        // ❌ DELETE DATA - Unchanged logic (relies on InitializeConnection())
        private void bdata_delete_Click(object sender, EventArgs e)
        {
            if (dataGridView_admin.SelectedRows.Count == 0 || currentDataTable == null || dataGridView_admin.ReadOnly == true)
            {
                MessageBox.Show("Please click 'Edit Data' and select one or more rows to delete.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (currentTableName != "plane_details" && currentTableName != "Reviews" && currentTableName != "Transports" && currentTableName != "Reports" && currentTableName != "regst")
            {
                MessageBox.Show("Deletion is not configured for the current view.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dialogResult = MessageBox.Show($"Are you sure you want to delete {dataGridView_admin.SelectedRows.Count} selected row(s)? This change will be saved immediately.", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                // Ensure connection is open just before update
                if (!InitializeConnection()) return;

                try
                {
                    // Mark rows for deletion in the DataTable
                    int deletedCount = 0;
                    for (int i = dataGridView_admin.SelectedRows.Count - 1; i >= 0; i--)
                    {
                        DataRowView drv = dataGridView_admin.SelectedRows[i].DataBoundItem as DataRowView;
                        if (drv != null)
                        {
                            drv.Row.Delete();
                            deletedCount++;
                        }
                    }

                    // 1. Generate the DELETE command (relies on Primary Key and open connection)
                    SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);

                    // 2. Update the database with the deletions
                    int rowsAffected = adapter.Update(currentDataTable);
                    currentDataTable.AcceptChanges();

                    // 3. Revert to read-only state
                    dataGridView_admin.ReadOnly = true;
                    dataGridView_admin.AllowUserToAddRows = false;

                    MessageBox.Show($"{rowsAffected} row(s) deleted successfully and saved to database.", "Delete Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting data. Ensure the table has a Primary Key: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}