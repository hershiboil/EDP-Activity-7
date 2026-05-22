using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DentalClinic
{
    public partial class payments : Form
    {
        public payments()
        {
            InitializeComponent();
        }


        private void logoutButton_Click(object sender, EventArgs e)
        {
            Login recoverPassword = new Login();

            // Show the recover password form
            recoverPassword.Show();

            // Hide or close the login form
            this.Hide();   // hides the login form but keeps it in memory
                           // this.Close(); // closes the login form completely
        }


        private void paymentsButton_Click(object sender, EventArgs e)
        {
            payments payments = new payments();

            // Show the payments form
            payments.Show();
            // Hide or close the login form
            this.Hide();   // hides the login form but keeps it in memory
                           // this.Close(); // closes the login form completely
        }
    }
}
