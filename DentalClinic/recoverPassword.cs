using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DentalClinic
{
    public partial class recoverPassword : Form
    {

        public recoverPassword()
        {
            InitializeComponent();
        }

        private void backLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login recoverPassword = new Login();

            // Show the recover password form
            recoverPassword.Show();

            // Hide or close the login form
            this.Hide();   // hides the login form but keeps it in memory
                           // this.Close(); // closes the login form completely
        }

        // Declare at class level
        private int verifiedUserId = -1;

        private void emailButton_Click(object sender, EventArgs e)
        {
            string email = reset_email_box.Text.Trim();
            string license = licenseID.Text.Trim();

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(license))
            {
                MessageBox.Show("Please enter both Email and License ID.",
                                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DBConnection db = new DBConnection();

            try
            {
                db.conn.Open();

                string query = @"SELECT u.user_id 
                         FROM users u
                         INNER JOIN dentist d ON u.user_id = d.user_id
                         WHERE u.email = @Email AND d.licenseID = @LicenseID";

                using (MySqlCommand cmd = new MySqlCommand(query, db.conn))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@LicenseID", license);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        verifiedUserId = Convert.ToInt32(result);

                        MessageBox.Show("Verification successful. Email and License match.",
                                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        forgotPanel.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("No matching record found. Please check your Email and License ID.",
                                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message,
                                "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.conn.Close();
            }
        }




        private void resetButton_Click(object sender, EventArgs e)
        {
            string newPass = reset_password.Text.Trim();
            string confirmPass = reset_confirm_password.Text.Trim();

            if (string.IsNullOrWhiteSpace(newPass) || string.IsNullOrWhiteSpace(confirmPass))
            {
                MessageBox.Show("Please enter and confirm your new password.",
                                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (newPass != confirmPass)
            {
                MessageBox.Show("Passwords do not match. Please re-enter.",
                                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (verifiedUserId == -1)
            {
                MessageBox.Show("No verified user. Please complete email + license verification first.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DBConnection db = new DBConnection();

            try
            {
                db.conn.Open();

                // ⚠️ Hash password before saving in production
                string query = "UPDATE users SET password=@Password WHERE user_id=@UserId";

                using (MySqlCommand cmd = new MySqlCommand(query, db.conn))
                {
                    cmd.Parameters.AddWithValue("@Password", newPass);
                    cmd.Parameters.AddWithValue("@UserId", verifiedUserId);

                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        MessageBox.Show("Password reset successful!",
                                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Login recoverPassword = new Login();

                        recoverPassword.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Failed to reset password.",
                                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message,
                                "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.conn.Close();
            }
        }


        private void verifyButton_Click_1(object sender, EventArgs e)
        {
            resetPanel.Visible = true;
            forgotPanel.Visible = false;

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login recoverPassword = new Login();

            // Show the recover password form
            recoverPassword.Show();

            // Hide or close the login form
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
