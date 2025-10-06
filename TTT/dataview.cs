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
    public partial class dataview : Form
    {
        public dataview()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tdata_username.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            tdata_number.Text = dataGridView1.Rows[e.RowIndex].Cells[7  ].Value.ToString();
        }

        private void show()
        {
            string connectionString = @"Data Source=RASEL\SQLEXPRESS;Initial Catalog=TMS;Integrated Security=True;";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string query = "select * from regst";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            DataTable dt = ds.Tables[0];
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = dt;
        }
        public void clear()
        {
            tdata_username.Text = "";
            tdata_number.Text = "";
        }
        private void btshow_Click(object sender, EventArgs e)
        {
           show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bdata_edit_Click(object sender, EventArgs e)
        {
         
            string Connectionstring = @"Data Source=RASEL\SQLEXPRESS;Initial Catalog=TMS;Integrated Security=True;";
            SqlConnection conn = new SqlConnection(Connectionstring);
            conn.Open();

            string query = "UPDATE regst SET phone = '" + tdata_number.Text + "' WHERE user_name = '" + tdata_username.Text + "'";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            show();
            clear();
        }

        private void bdata_refresh_Click(object sender, EventArgs e)
        {
            show();
            clear();
        }

        private void bdata_search_Click(object sender, EventArgs e)
        {
            string Connectionstring = @"Data Source=RASEL\SQLEXPRESS;Initial Catalog=TMS;Integrated Security=True;";
            SqlConnection conn = new SqlConnection(Connectionstring);
            conn.Open();

            string query = "SELECT user_name, password, surname, givenname, email, gender, passport, phone, address " +
                           "FROM regst WHERE user_name LIKE '%" + tdata_search.Text + "%'";

            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt;

            conn.Close();
        }

        private void tdata_search_TextChanged(object sender, EventArgs e)
        {
           // tdata_search.Text = "";
           // tdata_search.ForeColor = System.Drawing.Color.Black;
            //tdata_search.Font = default;

        }

        private void bdata_delete_Click(object sender, EventArgs e)
        {
            if (tdata_username.Text == "")
            {
                MessageBox.Show("Please select a row first:");
            }
            else
            {
                string connectionString = @"Data Source=RASEL\SQLEXPRESS;Initial Catalog=TMS;Integrated Security=True;";
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();

                string query = "DELETE FROM regst WHERE user_name = '" + tdata_username.Text + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();

                show();
                clear();
                conn.Close();
            }
        }

        private void dataview_Load(object sender, EventArgs e)
        {

        }

        private void tdata_username_TextChanged(object sender, EventArgs e)
        {

        }
    }


}

