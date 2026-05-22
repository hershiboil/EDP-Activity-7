using MySql.Data.MySqlClient;

namespace DentalClinic
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        private void loginButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(emailBox.Text) || string.IsNullOrWhiteSpace(passwordBox.Text))
            {
                MessageBox.Show("Email and Password cannot be blank.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DBConnection db = new DBConnection();

            try
            {
                db.conn.Open();

                string query = "SELECT * FROM users WHERE email=@email AND password=@password";

                MySqlCommand cmd = new MySqlCommand(query, db.conn);

                cmd.Parameters.AddWithValue("@email", emailBox.Text);
                cmd.Parameters.AddWithValue("@password", passwordBox.Text);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    dashboard dashboard = new dashboard();
                    dashboard.Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Email or Password");
                }

                db.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void forgotButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            recoverPassword recoverPassword = new recoverPassword();

            // Show the recover password form
            recoverPassword.Show();

            // Hide or close the login form
            this.Hide();   
        }

        private void forgotButton_Click(object sender, EventArgs e)
        {
            recoverPassword recoverPassword = new recoverPassword();

            // Show the recover password form
            recoverPassword.Show();

            // Hide or close the login form
            this.Hide();  
        }


        private void showPassword_CheckedChanged_1(object sender, EventArgs e)
        {
            if (showPassword.Checked)
            {
                // Show password (remove asterisk)
                passwordBox.PasswordChar = '\0';
            }
            else
            {
                // Hide password (use asterisk)
                passwordBox.PasswordChar = '*';
            }
        }
    }
}