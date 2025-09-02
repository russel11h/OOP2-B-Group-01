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
    public partial class registration : Form
    {
        public registration()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bsubmit_Click(object sender, EventArgs e)
        {
            string SUR_NAME;
            string GIVEN_NAME;
            string EMAIL;
            string GENDER = "Not Selected";
            string PASSPORT;
            string PHONE;
            string ADDRESS;
            string REG_DATE;

            SUR_NAME = tbsurname.Text;
            GIVEN_NAME = tbgivenname.Text;
            EMAIL = tbemail.Text;

            if (rbmale.Checked)
            {
                GENDER = "Male";
            }
            else if (rbfemale.Checked)
            {
                GENDER = "Female";
            }

            PASSPORT = tbpassportnumber.Text;
            PHONE = tbphonenumber.Text;
            ADDRESS = comboboxaddress.Text;
            REG_DATE = dateTimePicker1.Text;   // assuming your DateTimePicker name is dateTimePicker1

            MessageBox.Show(
                "Registration Successful!\n\n" +
                "Surname: " + SUR_NAME + "\n" +
                "Given Name: " + GIVEN_NAME + "\n" +
                "E-Mail: " + EMAIL + "\n" +
                "Gender: " + GENDER + "\n" +
                "Passport No: " + PASSPORT + "\n" +
                "Phone: " + PHONE + "\n" +
                "Address: " + ADDRESS + "\n" +
                "Registration Date: " + REG_DATE,
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}
