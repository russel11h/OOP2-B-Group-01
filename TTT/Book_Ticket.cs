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
    public partial class Book_Ticket : Form
    {
        public Book_Ticket()
        {
            InitializeComponent();
        }

        private void bhx_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
