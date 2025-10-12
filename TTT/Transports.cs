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
    public partial class Transports : Form
    {
        private string loggedInUsername;
        private DataTable transportData;
        private int currentIndex = 0; 

        public Transports(string username)
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
                labelbooked.Text = givenName + " " + surName;
            }

            conn.Close();
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

        private void Transports_Load(object sender, EventArgs e)
        {
            change_color_by_click(btransportsbooked, bhomebooked, bbookticketbooked, breviewsbooked, breportsbooked, bsettingsbooked, bulogoutbooked);
            LoadTransportData();
        }

        private void LoadTransportData()
        {
            string connectionString = @"Data Source=RASEL\SQLEXPRESS;Initial Catalog=TMS;Integrated Security=True;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT place1, place2, price FROM Transports";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                transportData = new DataTable();
                adapter.Fill(transportData);
            }

            if (transportData.Rows.Count > 0)
            {
                currentIndex = 0;
                ShowNextFour();
            }
        }

        private void ShowNextFour()
        {
            if (transportData == null || transportData.Rows.Count == 0) return;

            
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();

            
            for (int i = 0; i < 4; i++)
            {
                int index = (currentIndex + i) % transportData.Rows.Count;
                DataRow row = transportData.Rows[index];
                string text = $"From {row["place1"]} To {row["place2"]} Price {row["price"]} BDT";

                switch (i)
                {
                    case 0: textBox1.Text = text; break;
                    case 1: textBox2.Text = text; break;
                    case 2: textBox3.Text = text; break;
                    case 3: textBox4.Text = text; break;
                }

                
                if (index == transportData.Rows.Count - 1 && i < 3)
                    break;
            }

           
            currentIndex = (currentIndex + 4) % transportData.Rows.Count;
        }

        private void button_more_Click(object sender, EventArgs e)
        {
            ShowNextFour();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            string from = textBox_searchfrom.Text.Trim();
            string to = textBox_searchto.Text.Trim();

            if (from == "" || to == "")
            {
                MessageBox.Show("Please enter both From and To places.");
                return;
            }

            string connectionString = @"Data Source=RASEL\SQLEXPRESS;Initial Catalog=TMS;Integrated Security=True;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT place1, place2, price FROM Transports WHERE place1 LIKE @from AND place2 LIKE @to";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@from", "%" + from + "%");
                cmd.Parameters.AddWithValue("@to", "%" + to + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

               
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();

                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count && i < 4; i++)
                    {
                        DataRow row = dt.Rows[i];
                        string text = $"From {row["place1"]} To {row["place2"]} Price {row["price"]} BDT";

                        switch (i)
                        {
                            case 0: textBox1.Text = text; break;
                            case 1: textBox2.Text = text; break;
                            case 2: textBox3.Text = text; break;
                            case 3: textBox4.Text = text; break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No matching routes found.");
                }
            }
        }
    }
}
