namespace DentalClinic
{
    partial class about
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(about));
            sideBar = new Panel();
            aboutButton = new Button();
            logoPanel = new Panel();
            logoImage = new PictureBox();
            paymentPanelButton = new Panel();
            paymentsButton = new Button();
            logoutPanelButton = new Panel();
            logoutButton = new Button();
            reportsPanelButton = new Panel();
            reportsButton = new Button();
            patientsPanelButton = new Panel();
            patientsButton = new Button();
            appointmentsPanelButton = new Panel();
            appointmentsButton = new Button();
            dashboardPanelButton = new Panel();
            dashboardButton = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel2 = new Panel();
            button3 = new Button();
            button1 = new Button();
            panel1 = new Panel();
            label1 = new Label();
            richTextBox1 = new RichTextBox();
            label2 = new Label();
            richTextBox2 = new RichTextBox();
            sideBar.SuspendLayout();
            logoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoImage).BeginInit();
            paymentPanelButton.SuspendLayout();
            logoutPanelButton.SuspendLayout();
            reportsPanelButton.SuspendLayout();
            patientsPanelButton.SuspendLayout();
            appointmentsPanelButton.SuspendLayout();
            dashboardPanelButton.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // sideBar
            // 
            sideBar.BackColor = Color.White;
            sideBar.Controls.Add(aboutButton);
            sideBar.Controls.Add(logoPanel);
            sideBar.Controls.Add(paymentPanelButton);
            sideBar.Controls.Add(logoutPanelButton);
            sideBar.Controls.Add(reportsPanelButton);
            sideBar.Controls.Add(patientsPanelButton);
            sideBar.Controls.Add(appointmentsPanelButton);
            sideBar.Controls.Add(dashboardPanelButton);
            sideBar.Dock = DockStyle.Left;
            sideBar.Location = new Point(0, 0);
            sideBar.Name = "sideBar";
            sideBar.Size = new Size(211, 650);
            sideBar.TabIndex = 1;
            // 
            // aboutButton
            // 
            aboutButton.Image = (Image)resources.GetObject("aboutButton.Image");
            aboutButton.ImageAlign = ContentAlignment.MiddleLeft;
            aboutButton.Location = new Point(0, 478);
            aboutButton.Name = "aboutButton";
            aboutButton.Padding = new Padding(20, 0, 0, 0);
            aboutButton.Size = new Size(211, 64);
            aboutButton.TabIndex = 4;
            aboutButton.Text = "About";
            aboutButton.UseVisualStyleBackColor = true;
            // 
            // logoPanel
            // 
            logoPanel.Controls.Add(logoImage);
            logoPanel.Location = new Point(0, 3);
            logoPanel.Name = "logoPanel";
            logoPanel.Size = new Size(211, 92);
            logoPanel.TabIndex = 8;
            logoPanel.Tag = "logoImage";
            // 
            // logoImage
            // 
            logoImage.Image = (Image)resources.GetObject("logoImage.Image");
            logoImage.Location = new Point(12, 9);
            logoImage.Name = "logoImage";
            logoImage.Size = new Size(177, 81);
            logoImage.SizeMode = PictureBoxSizeMode.Zoom;
            logoImage.TabIndex = 2;
            logoImage.TabStop = false;
            // 
            // paymentPanelButton
            // 
            paymentPanelButton.Controls.Add(paymentsButton);
            paymentPanelButton.Location = new Point(2, 411);
            paymentPanelButton.Name = "paymentPanelButton";
            paymentPanelButton.Size = new Size(250, 52);
            paymentPanelButton.TabIndex = 7;
            paymentPanelButton.Tag = "paymentsButton";
            // 
            // paymentsButton
            // 
            paymentsButton.Image = (Image)resources.GetObject("paymentsButton.Image");
            paymentsButton.ImageAlign = ContentAlignment.MiddleLeft;
            paymentsButton.Location = new Point(-2, -3);
            paymentsButton.Name = "paymentsButton";
            paymentsButton.Padding = new Padding(20, 0, 0, 0);
            paymentsButton.Size = new Size(215, 64);
            paymentsButton.TabIndex = 3;
            paymentsButton.Text = "Payments";
            paymentsButton.UseVisualStyleBackColor = true;
            // 
            // logoutPanelButton
            // 
            logoutPanelButton.Controls.Add(logoutButton);
            logoutPanelButton.Location = new Point(2, 587);
            logoutPanelButton.Name = "logoutPanelButton";
            logoutPanelButton.Size = new Size(250, 52);
            logoutPanelButton.TabIndex = 7;
            logoutPanelButton.Tag = "logoutButton";
            // 
            // logoutButton
            // 
            logoutButton.Image = (Image)resources.GetObject("logoutButton.Image");
            logoutButton.ImageAlign = ContentAlignment.MiddleLeft;
            logoutButton.Location = new Point(-2, -12);
            logoutButton.Name = "logoutButton";
            logoutButton.Padding = new Padding(10, 0, 0, 0);
            logoutButton.Size = new Size(231, 75);
            logoutButton.TabIndex = 3;
            logoutButton.Text = "Logout";
            logoutButton.UseVisualStyleBackColor = true;
            // 
            // reportsPanelButton
            // 
            reportsPanelButton.Controls.Add(reportsButton);
            reportsPanelButton.Location = new Point(0, 337);
            reportsPanelButton.Name = "reportsPanelButton";
            reportsPanelButton.Size = new Size(250, 52);
            reportsPanelButton.TabIndex = 6;
            reportsPanelButton.Tag = "reportsButton";
            // 
            // reportsButton
            // 
            reportsButton.Image = (Image)resources.GetObject("reportsButton.Image");
            reportsButton.ImageAlign = ContentAlignment.MiddleLeft;
            reportsButton.Location = new Point(-16, -14);
            reportsButton.Name = "reportsButton";
            reportsButton.Padding = new Padding(35, 0, 0, 0);
            reportsButton.Size = new Size(231, 79);
            reportsButton.TabIndex = 3;
            reportsButton.Text = "Dentists";
            reportsButton.UseVisualStyleBackColor = true;
            // 
            // patientsPanelButton
            // 
            patientsPanelButton.Controls.Add(patientsButton);
            patientsPanelButton.Location = new Point(0, 265);
            patientsPanelButton.Name = "patientsPanelButton";
            patientsPanelButton.Size = new Size(250, 52);
            patientsPanelButton.TabIndex = 5;
            patientsPanelButton.Tag = "patientsButton";
            // 
            // patientsButton
            // 
            patientsButton.Image = (Image)resources.GetObject("patientsButton.Image");
            patientsButton.ImageAlign = ContentAlignment.MiddleLeft;
            patientsButton.Location = new Point(-13, -16);
            patientsButton.Name = "patientsButton";
            patientsButton.Padding = new Padding(30, 0, 0, 0);
            patientsButton.Size = new Size(231, 82);
            patientsButton.TabIndex = 3;
            patientsButton.Text = "Patients";
            patientsButton.UseVisualStyleBackColor = true;
            // 
            // appointmentsPanelButton
            // 
            appointmentsPanelButton.Controls.Add(appointmentsButton);
            appointmentsPanelButton.Location = new Point(0, 191);
            appointmentsPanelButton.Name = "appointmentsPanelButton";
            appointmentsPanelButton.Size = new Size(250, 52);
            appointmentsPanelButton.TabIndex = 4;
            appointmentsPanelButton.Tag = "appointmentsButton";
            // 
            // appointmentsButton
            // 
            appointmentsButton.Image = (Image)resources.GetObject("appointmentsButton.Image");
            appointmentsButton.ImageAlign = ContentAlignment.MiddleLeft;
            appointmentsButton.Location = new Point(-13, -16);
            appointmentsButton.Name = "appointmentsButton";
            appointmentsButton.Padding = new Padding(30, 0, 0, 0);
            appointmentsButton.Size = new Size(231, 81);
            appointmentsButton.TabIndex = 2;
            appointmentsButton.Text = "Appointments";
            appointmentsButton.UseVisualStyleBackColor = true;
            // 
            // dashboardPanelButton
            // 
            dashboardPanelButton.Controls.Add(dashboardButton);
            dashboardPanelButton.Location = new Point(0, 117);
            dashboardPanelButton.Name = "dashboardPanelButton";
            dashboardPanelButton.Size = new Size(250, 46);
            dashboardPanelButton.TabIndex = 3;
            dashboardPanelButton.Tag = "dashboardButton";
            // 
            // dashboardButton
            // 
            dashboardButton.Image = (Image)resources.GetObject("dashboardButton.Image");
            dashboardButton.ImageAlign = ContentAlignment.MiddleLeft;
            dashboardButton.Location = new Point(-13, -5);
            dashboardButton.Name = "dashboardButton";
            dashboardButton.Padding = new Padding(30, 0, 0, 0);
            dashboardButton.Size = new Size(233, 57);
            dashboardButton.TabIndex = 1;
            dashboardButton.Text = "Dashboard";
            dashboardButton.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Location = new Point(217, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(730, 650);
            flowLayoutPanel1.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(729, 57);
            panel2.TabIndex = 5;
            // 
            // button3
            // 
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(596, 9);
            button3.Name = "button3";
            button3.Size = new Size(43, 43);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(656, 9);
            button1.Name = "button1";
            button1.Size = new Size(43, 43);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(richTextBox2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(richTextBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 66);
            panel1.Name = "panel1";
            panel1.Size = new Size(727, 571);
            panel1.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(16, 7);
            label1.Name = "label1";
            label1.Size = new Size(282, 41);
            label1.TabIndex = 3;
            label1.Text = "About the Program";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(16, 54);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(702, 80);
            richTextBox1.TabIndex = 4;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(16, 149);
            label2.Name = "label2";
            label2.Size = new Size(227, 41);
            label2.TabIndex = 5;
            label2.Text = "Contact Details";
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(16, 202);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(702, 118);
            richTextBox2.TabIndex = 6;
            richTextBox2.Text = "Email: dentalclinic.support@example.com\n\nPhone: (02) 1234-5678\n\nAddress: Bicol Region, Philippines";
            // 
            // about
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 650);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(sideBar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "about";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "about";
            sideBar.ResumeLayout(false);
            logoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logoImage).EndInit();
            paymentPanelButton.ResumeLayout(false);
            logoutPanelButton.ResumeLayout(false);
            reportsPanelButton.ResumeLayout(false);
            patientsPanelButton.ResumeLayout(false);
            appointmentsPanelButton.ResumeLayout(false);
            dashboardPanelButton.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel sideBar;
        private Button aboutButton;
        private Panel logoPanel;
        private PictureBox logoImage;
        private Panel paymentPanelButton;
        private Button paymentsButton;
        private Panel logoutPanelButton;
        private Button logoutButton;
        private Panel reportsPanelButton;
        private Button reportsButton;
        private Panel patientsPanelButton;
        private Button patientsButton;
        private Panel appointmentsPanelButton;
        private Button appointmentsButton;
        private Panel dashboardPanelButton;
        private Button dashboardButton;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel2;
        private Button button3;
        private Button button1;
        private Panel panel1;
        private Label label1;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private Label label2;
    }
}