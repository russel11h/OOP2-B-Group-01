using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TTT
{
    public partial class SelectPage : Form
    {
        private string loggedInUsername;
        private string selectedTransportNo;
        
        private string connectionString = @"Data Source=RASEL\SQLEXPRESS;Initial Catalog=TMS;Integrated Security=True;";

        private decimal ecoPrice = 0;
        private decimal busPrice = 0;
        private int ecoSeats = 0;
        private int busSeats = 0;

        public SelectPage(string username, string transportNo)
        {
            InitializeComponent();
            this.loggedInUsername = username;
            this.selectedTransportNo = transportNo;

           
            bool isAgent = this.loggedInUsername.StartsWith("agent", StringComparison.OrdinalIgnoreCase);

            
            label_selectticketnumbers.Visible = isAgent;
            comboBox_ticketnumber.Visible = isAgent;

         
            if (isAgent)
            {
               
                LoadAvailableTickets();
            }
           
            textBox_plane.Text = this.selectedTransportNo;
            textBox_plane.ReadOnly = true; // It should be read-only
           
            checkBox_eco.CheckedChanged += CheckBox_eco_CheckedChanged;
            checkBox_busin.CheckedChanged += CheckBox_busin_CheckedChanged;

           
            button_save.Visible = false;

            
            SetUserFieldsReadOnly(true);
            SetFlightFieldsReadOnly(true);

            LoadUserData();
            LoadFlightDetails();

          
            InitializeSeatSelection();
        }

       
        private void SetUserFieldsReadOnly(bool isReadOnly)
        {
            tbname.ReadOnly = true;
            tbemail.ReadOnly = true;
            tbgender.ReadOnly = isReadOnly;
            tbpassport.ReadOnly = isReadOnly;
            tbphone.ReadOnly = isReadOnly;
            tbaddress.ReadOnly = isReadOnly;
        }

       
        private void SetFlightFieldsReadOnly(bool isReadOnly)
        {
            textBoxfrom.ReadOnly = isReadOnly;
            textBoxto.ReadOnly = isReadOnly;
            textBox_ddate.ReadOnly = isReadOnly;
            textBoxd_dtime.ReadOnly = isReadOnly;
            textBox_adate.ReadOnly = isReadOnly;
            textBox_atime.ReadOnly = isReadOnly;
            textBox_price.ReadOnly = true;
            
        }

      
        private void LoadUserData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(
                "SELECT givenname, surname, email, gender, passport, phone, address FROM regst WHERE user_name = @username", conn))
            {
                cmd.Parameters.AddWithValue("@username", loggedInUsername);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string given = reader["givenname"] == DBNull.Value ? "" : reader["givenname"].ToString();
                        string sur = reader["surname"] == DBNull.Value ? "" : reader["surname"].ToString();
                        tbname.Text = (given + " " + sur).Trim();

                        tbemail.Text = reader["email"] == DBNull.Value ? "" : reader["email"].ToString();
                        tbgender.Text = reader["gender"] == DBNull.Value ? "" : reader["gender"].ToString();
                        tbpassport.Text = reader["passport"] == DBNull.Value ? "" : reader["passport"].ToString();
                        tbphone.Text = reader["phone"] == DBNull.Value ? "" : reader["phone"].ToString();
                        tbaddress.Text = reader["address"] == DBNull.Value ? "" : reader["address"].ToString();
                    }
                }
            }
        }

       
        private void LoadFlightDetails()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(
                @"SELECT From_City, To_City, Departure_Date, Departure_Only_Time,
                         Arrival_Date, Arrival_Only_Time, Econo_Available_Seats, Busine_Available_Seats,
                         Price_eco, Price_busine
                     FROM plane_details
                     WHERE Transport_No = @tno", conn))
            {
                cmd.Parameters.AddWithValue("@tno", selectedTransportNo);
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        textBoxfrom.Text = reader["From_City"] == DBNull.Value ? "" : reader["From_City"].ToString();
                        textBoxto.Text = reader["To_City"] == DBNull.Value ? "" : reader["To_City"].ToString();

                        // Format dates/times gracefully
                        if (reader["Departure_Date"] != DBNull.Value)
                            textBox_ddate.Text = Convert.ToDateTime(reader["Departure_Date"]).ToString("yyyy-MM-dd");
                        else textBox_ddate.Text = "";

                        if (reader["Departure_Only_Time"] != DBNull.Value)
                        {
                            if (reader["Departure_Only_Time"] is TimeSpan depTs)
                                textBoxd_dtime.Text = (DateTime.Today + depTs).ToString("hh:mm tt");
                            else textBoxd_dtime.Text = reader["Departure_Only_Time"].ToString();
                        }

                        if (reader["Arrival_Date"] != DBNull.Value)
                            textBox_adate.Text = Convert.ToDateTime(reader["Arrival_Date"]).ToString("yyyy-MM-dd");
                        else textBox_adate.Text = "";

                        if (reader["Arrival_Only_Time"] != DBNull.Value)
                        {
                            if (reader["Arrival_Only_Time"] is TimeSpan arrTs)
                                textBox_atime.Text = (DateTime.Today + arrTs).ToString("hh:mm tt");
                            else textBox_atime.Text = reader["Arrival_Only_Time"].ToString();
                        }

                        
                        ecoSeats = reader["Econo_Available_Seats"] == DBNull.Value ? 0 : Convert.ToInt32(reader["Econo_Available_Seats"]);
                        busSeats = reader["Busine_Available_Seats"] == DBNull.Value ? 0 : Convert.ToInt32(reader["Busine_Available_Seats"]);

                        ecoPrice = reader["Price_eco"] == DBNull.Value ? 0 : Convert.ToDecimal(reader["Price_eco"]);
                        busPrice = reader["Price_busine"] == DBNull.Value ? 0 : Convert.ToDecimal(reader["Price_busine"]);
                    }
                }
            }
        }

        
        private void InitializeSeatSelection()
        {
           
            checkBox_eco.Checked = false;
            checkBox_busin.Checked = false;

            
            if (ecoSeats > 0)
            {
                
                checkBox_eco.Checked = true;
                checkBox_eco.Enabled = true;
                textBox_price.Text = ecoPrice.ToString("F2");
            }
            else
            {
                
                checkBox_eco.Enabled = false;
                if (busSeats > 0)
                {
                   
                    checkBox_busin.Checked = true;
                    checkBox_busin.Enabled = true;
                    textBox_price.Text = busPrice.ToString("F2");
                }
                else
                {
                    
                    checkBox_busin.Enabled = false;
                    textBox_price.Text = "No seats";
                }
            }

           
            if (ecoSeats > 0) checkBox_eco.Enabled = true; else checkBox_eco.Enabled = false;
            if (busSeats > 0) checkBox_busin.Enabled = true; else checkBox_busin.Enabled = false;

           
            checkBox_paylater.Checked = true;
        }

        
        private void CheckBox_eco_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_eco.Checked)
            {
                
                if (checkBox_busin.Checked) checkBox_busin.Checked = false;
                textBox_price.Text = ecoPrice.ToString("F2");
            }
            else if (!checkBox_busin.Checked)
            {
               
                textBox_price.Text = "0.00";
            }
        }

        private void CheckBox_busin_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_busin.Checked)
            {
                
                if (checkBox_eco.Checked) checkBox_eco.Checked = false;
                textBox_price.Text = busPrice.ToString("F2");
            }
            else if (!checkBox_eco.Checked)
            {
               
                textBox_price.Text = "0.00";
            }
        }

        
        private void button_edit_Click(object sender, EventArgs e)
        {
            
            SetUserFieldsReadOnly(false);

           
            button_save.Visible = true;
            button_edit.Visible = false;
        }

        
        private void button_save_Click_1(object sender, EventArgs e)
        {
            try
            {
               
                UpsertUserBookingRecord();

             
                SetUserFieldsReadOnly(true);

                
                button_save.Visible = false;
                button_edit.Visible = true;

                MessageBox.Show("Personal details saved successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Save failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


       
        private void button_confirm_Click(object sender, EventArgs e)
        {
            if (!checkBox_eco.Checked && !checkBox_busin.Checked)
            {
                MessageBox.Show("Please select a class (Economy or Business) to confirm your booking.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dr = MessageBox.Show("Confirm your booking? This will reserve a seat and finalize your selection.", "Confirm Booking", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr != DialogResult.OK) return;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlTransaction tx = conn.BeginTransaction())
                {
                    try
                    {
                       
                        string seatUpdate = null;
                        string selectedClass = "";

                        if (checkBox_eco.Checked)
                        {
                            seatUpdate = "UPDATE plane_details SET Econo_Available_Seats = Econo_Available_Seats - 1 WHERE Transport_No = @tno AND Econo_Available_Seats > 0";
                            selectedClass = "Economy";
                        }
                        else if (checkBox_busin.Checked)
                        {
                            seatUpdate = "UPDATE plane_details SET Busine_Available_Seats = Busine_Available_Seats - 1 WHERE Transport_No = @tno AND Busine_Available_Seats > 0";
                            selectedClass = "Business";
                        }

                        if (!string.IsNullOrEmpty(seatUpdate))
                        {
                            using (SqlCommand cmdSeat = new SqlCommand(seatUpdate, conn, tx))
                            {
                                cmdSeat.Parameters.AddWithValue("@tno", selectedTransportNo);
                                int rows = cmdSeat.ExecuteNonQuery();
                                if (rows == 0)
                                {
                                   
                                    tx.Rollback();
                                    MessageBox.Show($"Selected {selectedClass} seat is no longer available. Please try another class or flight.", "Booking Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                            }
                        }

                        
                        UpsertUserBookingRecord(conn, tx);

                        tx.Commit();
                        MessageBox.Show($"Booking confirmed for Flight {selectedTransportNo} ({selectedClass} Class)! The ticket number is: {comboBox_ticketnumber.Text}");
                    }
                    catch (Exception ex)
                    {
                        try { tx.Rollback(); } catch { }
                        
                        MessageBox.Show("Error during booking confirmation: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }

            
            Home home = new Home(loggedInUsername);
            home.Show();
            this.Hide();
        }

        
        private void UpsertUserBookingRecord()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlTransaction tx = conn.BeginTransaction())
                {
                    try
                    {
                        UpsertUserBookingRecord(conn, tx);
                        tx.Commit();
                    }
                    catch (Exception ex)
                    {
                        try { tx.Rollback(); } catch { }
                        throw; // Re-throw to be caught by button_Save_Click
                    }
                }
            }
        }

     
        private void UpsertUserBookingRecord(SqlConnection conn, SqlTransaction tx)
        {
          
            string createTableSql = $@"
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name = @tbl AND xtype='U')
BEGIN
    CREATE TABLE [{loggedInUsername}] (
        [name] NVARCHAR(200),
        [email] NVARCHAR(200),
        [gender] NVARCHAR(50),
        [passport] NVARCHAR(50),
        [phone] NVARCHAR(50),
        [address] NVARCHAR(500),
        [Transport_No] NVARCHAR(50) PRIMARY KEY,
        [Price_eco] DECIMAL(18,2),
        [Price_busine] DECIMAL(18,2),
        [From_City] NVARCHAR(200),
        [To_City] NVARCHAR(200),
        [Departure_Date] NVARCHAR(50),
        [Departure_Only_Time] NVARCHAR(50),
        [Arrival_Date] NVARCHAR(50),
        [Arrival_Only_Time] NVARCHAR(50),
        [Payment_Status] NVARCHAR(50),
        [ticketnumber] NVARCHAR(50) -- <<< ADDED NEW COLUMN
    )
END";
            using (SqlCommand cmdCreate = new SqlCommand(createTableSql, conn, tx))
            {
                cmdCreate.Parameters.AddWithValue("@tbl", loggedInUsername);
                cmdCreate.ExecuteNonQuery();
            }

           
            string existsSql = $"SELECT COUNT(1) FROM [{loggedInUsername}] WHERE [Transport_No] = @tno";
            using (SqlCommand cmdExists = new SqlCommand(existsSql, conn, tx))
            {
                cmdExists.Parameters.AddWithValue("@tno", selectedTransportNo);
                int count = Convert.ToInt32(cmdExists.ExecuteScalar());

                if (count > 0)
                {
                    
                    string updateSql = $@"
UPDATE [{loggedInUsername}]
SET
    [name] = @name,
    [email] = @email,
    [gender] = @gender,
    [passport] = @passport,
    [phone] = @phone,
    [address] = @address,
    [Price_eco] = @priceeco,
    [Price_busine] = @pricebus,
    [From_City] = @fromcity,
    [To_City] = @tocity,
    [Departure_Date] = @ddate,
    [Departure_Only_Time] = @dtime,
    [Arrival_Date] = @adate,
    [Arrival_Only_Time] = @atime,
    [Payment_Status] = @paymentstatus,
    [ticketnumber] = @ticketnumber -- <<< ADDED TO UPDATE
WHERE [Transport_No] = @tno";
                    using (SqlCommand cmdUpd = new SqlCommand(updateSql, conn, tx))
                    {
                        AddCommonParametersToCommand(cmdUpd);
                       
                        cmdUpd.ExecuteNonQuery();
                    }
                }
                else
                {
                    
                    string insertSql = $@"
INSERT INTO [{loggedInUsername}] (
    [name],[email],[gender],[passport],[phone],[address],
    [Transport_No],[Price_eco],[Price_busine],[From_City],[To_City],
    [Departure_Date],[Departure_Only_Time],[Arrival_Date],[Arrival_Only_Time], [Payment_Status], [ticketnumber] -- <<< ADDED TO INSERT
) VALUES (@name,@email,@gender,@passport,@phone,@address,
          @tno,@priceeco,@pricebus,@fromcity,@tocity,@ddate,@dtime,@adate,@atime, @paymentstatus, @ticketnumber)"; // <<< ADDED VALUE
                    using (SqlCommand cmdIns = new SqlCommand(insertSql, conn, tx))
                    {
                        AddCommonParametersToCommand(cmdIns);
                      
                        cmdIns.ExecuteNonQuery();
                    }
                }
            }
        }

       
        private void AddCommonParametersToCommand(SqlCommand cmd)
        {
            cmd.Parameters.AddWithValue("@name", tbname.Text);
            cmd.Parameters.AddWithValue("@email", tbemail.Text);
            cmd.Parameters.AddWithValue("@gender", tbgender.Text);
            cmd.Parameters.AddWithValue("@passport", tbpassport.Text);
            cmd.Parameters.AddWithValue("@phone", tbphone.Text);
            cmd.Parameters.AddWithValue("@address", tbaddress.Text);

            
            cmd.Parameters.AddWithValue("@tno", textBox_plane.Text);
           
            cmd.Parameters.AddWithValue("@priceeco", ecoPrice);
            cmd.Parameters.AddWithValue("@pricebus", busPrice);

            cmd.Parameters.AddWithValue("@fromcity", textBoxfrom.Text);
            cmd.Parameters.AddWithValue("@tocity", textBoxto.Text);
            cmd.Parameters.AddWithValue("@ddate", textBox_ddate.Text);
            cmd.Parameters.AddWithValue("@dtime", textBoxd_dtime.Text);
            cmd.Parameters.AddWithValue("@adate", textBox_adate.Text);
            cmd.Parameters.AddWithValue("@atime", textBox_atime.Text);

           
            string paymentStatus = checkBox_paylater.Checked ? "Unpaid" : "Paid";
            cmd.Parameters.AddWithValue("@paymentstatus", paymentStatus);

            
            string ticketNumberValue = string.Empty;
            if (comboBox_ticketnumber.Visible && comboBox_ticketnumber.SelectedItem != null)
            {
                ticketNumberValue = comboBox_ticketnumber.SelectedItem.ToString();
            }
            
            cmd.Parameters.AddWithValue("@ticketnumber", ticketNumberValue);
           
        }

       
        private void LoadAvailableTickets()
        {
            comboBox_ticketnumber.Items.Clear();

           
            for (int i = 1; i <= 10; i++)
            {
                
                string ticketNumber = i.ToString("D2");
                comboBox_ticketnumber.Items.Add(ticketNumber);
            }

            
            if (comboBox_ticketnumber.Items.Count > 0)
            {
                comboBox_ticketnumber.SelectedIndex = 0;
            }
        }
       


        
        private void bhomebooked_Click(object sender, EventArgs e) { new Home(loggedInUsername).Show(); this.Hide(); }
        private void bbookticketbooked_Click(object sender, EventArgs e) { new Book_Ticket(loggedInUsername).Show(); this.Hide(); }
        private void breviewsbooked_Click(object sender, EventArgs e) { new Reviews(loggedInUsername).Show(); this.Hide(); }
        private void btransportsbooked_Click(object sender, EventArgs e) { new Transports(loggedInUsername).Show(); this.Hide(); }
        private void breportsbooked_Click(object sender, EventArgs e) { new Reports(loggedInUsername).Show(); this.Hide(); }
        private void bsettingsbooked_Click(object sender, EventArgs e) { new Settings(loggedInUsername).Show(); this.Hide(); }

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

        private void button2_Click(object sender, EventArgs e) => Application.Exit();


    }
}