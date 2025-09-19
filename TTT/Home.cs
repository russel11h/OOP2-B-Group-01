using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            lhname.Text = this.loggedInUsername; // Assuming 'lhname' is the label for the username
        }

        private void bhx_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void change_color_by_click(Button b1,Button b2,Button b3,Button b4,Button b5,Button b6)
        {
            b1.BackColor = Color.FromArgb(0, 122, 204);
            b2.BackColor = Color.FromArgb(215, 228, 242);
            b3.BackColor = Color.FromArgb(215, 228, 242);
            b4.BackColor = Color.FromArgb(215, 228, 242);
            b5.BackColor = Color.FromArgb(215, 228, 242);
            b6.BackColor = Color.FromArgb(215, 228, 242);

        }

        private void bnhome_Click(object sender, EventArgs e)
        {
            change_color_by_click(bnhome, bnbookticket, bnCustomers, bnTransport, bnReports, bnSettings);

        }

        private void bnbookticket_Click(object sender, EventArgs e)
        {
            change_color_by_click(bnbookticket, bnhome, bnCustomers, bnTransport, bnReports, bnSettings);
        }

        private void bnCustomers_Click(object sender, EventArgs e)
        {
            change_color_by_click(bnCustomers, bnhome, bnbookticket, bnTransport, bnReports, bnSettings);
        }

        private void bnTransport_Click(object sender, EventArgs e)
        {
            change_color_by_click(bnTransport, bnhome, bnbookticket, bnCustomers, bnReports, bnSettings);
        }

        private void bnReports_Click(object sender, EventArgs e)
        {
            change_color_by_click(bnReports, bnhome, bnbookticket, bnCustomers, bnTransport, bnSettings);
        }

        private void bnSettings_Click(object sender, EventArgs e)
        {
            change_color_by_click(bnSettings, bnhome, bnbookticket, bnCustomers, bnTransport, bnReports);
        }

        private void Home_Load(object sender, EventArgs e)
        {
            change_color_by_click(bnhome, bnbookticket, bnCustomers, bnTransport, bnReports, bnSettings);
            //lhname.Text = USERNAME.USERname;
        }

        private void lhname_Click(object sender, EventArgs e)
        {

        }
    }
}
