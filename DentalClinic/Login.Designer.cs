namespace DentalClinic
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            label6 = new Label();
            showPassword = new CheckBox();
            label4 = new Label();
            label3 = new Label();
            forgotButton = new LinkLabel();
            label2 = new Label();
            label1 = new Label();
            loginButton = new Button();
            panel3 = new Panel();
            panel5 = new Panel();
            pictureBox2 = new PictureBox();
            passwordBox = new TextBox();
            panel2 = new Panel();
            panel4 = new Panel();
            pictureBox3 = new PictureBox();
            emailBox = new TextBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(showPassword);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(forgotButton);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(loginButton);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(263, 36);
            panel1.Name = "panel1";
            panel1.Size = new Size(431, 581);
            panel1.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(64, 383);
            label6.Name = "label6";
            label6.Size = new Size(123, 20);
            label6.TabIndex = 11;
            label6.Text = "Show Password";
            // 
            // showPassword
            // 
            showPassword.AutoSize = true;
            showPassword.Location = new Point(40, 386);
            showPassword.Name = "showPassword";
            showPassword.Size = new Size(18, 17);
            showPassword.TabIndex = 10;
            showPassword.UseVisualStyleBackColor = true;
            showPassword.CheckedChanged += showPassword_CheckedChanged_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 163);
            label4.Name = "label4";
            label4.Size = new Size(372, 20);
            label4.TabIndex = 9;
            label4.Text = "Enter your details for you to login to your account.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(92, 118);
            label3.Name = "label3";
            label3.Size = new Size(245, 34);
            label3.TabIndex = 8;
            label3.Text = "WELCOME BACK!";
            // 
            // forgotButton
            // 
            forgotButton.AutoSize = true;
            forgotButton.LinkBehavior = LinkBehavior.NeverUnderline;
            forgotButton.LinkColor = Color.Black;
            forgotButton.Location = new Point(149, 485);
            forgotButton.Name = "forgotButton";
            forgotButton.Size = new Size(139, 20);
            forgotButton.TabIndex = 7;
            forgotButton.TabStop = true;
            forgotButton.Text = "Forgot Password?";
            forgotButton.Click += forgotButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 308);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 6;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 222);
            label1.Name = "label1";
            label1.Size = new Size(48, 20);
            label1.TabIndex = 5;
            label1.Text = "email";
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.Blue;
            loginButton.ForeColor = Color.White;
            loginButton.Location = new Point(38, 436);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(372, 29);
            loginButton.TabIndex = 4;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(passwordBox);
            panel3.Location = new Point(25, 331);
            panel3.Name = "panel3";
            panel3.Size = new Size(384, 41);
            panel3.TabIndex = 3;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Blue;
            panel5.Location = new Point(13, 33);
            panel5.Name = "panel5";
            panel5.Size = new Size(368, 1);
            panel5.TabIndex = 9;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(352, 8);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(29, 26);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(12, 8);
            passwordBox.Name = "passwordBox";
            passwordBox.PasswordChar = '*';
            passwordBox.Size = new Size(334, 26);
            passwordBox.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(emailBox);
            panel2.Location = new Point(25, 245);
            panel2.Name = "panel2";
            panel2.Size = new Size(384, 41);
            panel2.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Blue;
            panel4.Location = new Point(13, 32);
            panel4.Name = "panel4";
            panel4.Size = new Size(368, 1);
            panel4.TabIndex = 10;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(352, 7);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(29, 26);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // emailBox
            // 
            emailBox.Location = new Point(13, 7);
            emailBox.Name = "emailBox";
            emailBox.Size = new Size(334, 26);
            emailBox.TabIndex = 10;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(126, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(184, 71);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 240, 241);
            ClientSize = new Size(950, 650);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Button loginButton;
        private Panel panel3;
        private Panel panel2;
        private TextBox passwordBox;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private LinkLabel forgotButton;
        private Panel panel5;
        private Panel panel4;
        private TextBox emailBox;
        private Label label3;
        private Label label4;
        private CheckBox showPassword;
        private Label label6;
        private Label label5;
    }
}
