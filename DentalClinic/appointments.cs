using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DentalClinic
{
    public partial class appointments : Form
    {
        public appointments()
        {
            InitializeComponent();

        }


        private void dashboardButton_Click(object sender, EventArgs e)
        {
            dashboard dashboard = new dashboard();

            // Show the dashboard form
            dashboard.Show();
            // Hide or close the login form
            this.Hide();

        }

        private void appointmentsButton_Click(object sender, EventArgs e)
        {
            appointments appointments = new appointments();

            // Show the appointments form
            appointments.Show();
            // Hide or close the login form
            this.Hide();

        }

        private void patientsButton_Click(object sender, EventArgs e)
        {
            patients patients = new patients();

            // Show the patients form
            patients.Show();
            // Hide or close the login form
            this.Hide();

        }

        private void paymentsButton_Click(object sender, EventArgs e)
        {
            payments payments = new payments();

            // Show the payments form
            payments.Show();
            // Hide or close the login form
            this.Hide();
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            about about = new about();

            // Show the about form
            about.Show();
            // Hide or close the login form
            this.Hide();

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
    }
}
