namespace DentalClinic
{
    partial class appointments
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(appointments));
            panel2 = new Panel();
            button2 = new Button();
            button3 = new Button();
            sideBar = new Panel();
            aboutButton = new Button();
            logoPanel = new Panel();
            logoImage = new PictureBox();
            paymentPanelButton = new Panel();
            paymentsButton = new Button();
            logoutPanelButton = new Panel();
            logoutButton = new Button();
            reportsPanelButton = new Panel();
            dentistButton = new Button();
            patientsPanelButton = new Panel();
            patientsButton = new Button();
            appointmentsPanelButton = new Panel();
            appointmentsButton = new Button();
            dashboardPanelButton = new Panel();
            dashboardButton = new Button();
            panel1 = new Panel();
            lblSearch = new Label();
            searchTextBox = new TextBox();
            searchButton = new Button();
            lblTitle = new Label();
            appointmentsTable = new DataGridView();
            panel2.SuspendLayout();
            sideBar.SuspendLayout();
            logoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoImage).BeginInit();
            paymentPanelButton.SuspendLayout();
            logoutPanelButton.SuspendLayout();
            reportsPanelButton.SuspendLayout();
            patientsPanelButton.SuspendLayout();
            appointmentsPanelButton.SuspendLayout();
            dashboardPanelButton.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)appointmentsTable).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button3);
            panel2.Location = new Point(217, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1144, 57);
            panel2.TabIndex = 5;
            // 
            // button2
            // 
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(1047, 7);
            button2.Name = "button2";
            button2.Size = new Size(43, 43);
            button2.TabIndex = 3;
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(986, 6);
            button3.Name = "button3";
            button3.Size = new Size(43, 43);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = true;
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
            sideBar.Size = new Size(211, 694);
            sideBar.TabIndex = 23;
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
            aboutButton.Click += aboutButton_Click;
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
            paymentsButton.Click += paymentsButton_Click;
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
            logoutButton.Click += logoutButton_Click;
            // 
            // reportsPanelButton
            // 
            reportsPanelButton.Controls.Add(dentistButton);
            reportsPanelButton.Location = new Point(0, 337);
            reportsPanelButton.Name = "reportsPanelButton";
            reportsPanelButton.Size = new Size(250, 52);
            reportsPanelButton.TabIndex = 6;
            reportsPanelButton.Tag = "reportsButton";
            // 
            // dentistButton
            // 
            dentistButton.Image = (Image)resources.GetObject("dentistButton.Image");
            dentistButton.ImageAlign = ContentAlignment.MiddleLeft;
            dentistButton.Location = new Point(-16, -14);
            dentistButton.Name = "dentistButton";
            dentistButton.Padding = new Padding(35, 0, 0, 0);
            dentistButton.Size = new Size(231, 79);
            dentistButton.TabIndex = 3;
            dentistButton.Text = "Dentists";
            dentistButton.UseVisualStyleBackColor = true;
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
            patientsButton.Click += patientsButton_Click;
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
            appointmentsButton.Click += appointmentsButton_Click;
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
            dashboardButton.Click += dashboardButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lblSearch);
            panel1.Controls.Add(searchTextBox);
            panel1.Controls.Add(searchButton);
            panel1.Controls.Add(lblTitle);
            panel1.Controls.Add(appointmentsTable);
            panel1.Location = new Point(217, 63);
            panel1.Name = "panel1";
            panel1.Size = new Size(1144, 631);
            panel1.TabIndex = 24;
            // 
            // lblSearch
            // 
            lblSearch.Location = new Point(598, 101);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(80, 25);
            lblSearch.TabIndex = 66;
            lblSearch.Text = "Search:";
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(668, 98);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(290, 27);
            searchTextBox.TabIndex = 67;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(973, 94);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(145, 32);
            searchButton.TabIndex = 68;
            searchButton.Text = "Search";
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Black;
            lblTitle.Location = new Point(23, 16);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(600, 60);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Dental Clinic Appointment Transaction";
            // 
            // appointmentsTable
            // 
            appointmentsTable.AllowUserToAddRows = false;
            appointmentsTable.AllowUserToDeleteRows = false;
            appointmentsTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            appointmentsTable.ColumnHeadersHeight = 29;
            appointmentsTable.Location = new Point(23, 131);
            appointmentsTable.MultiSelect = false;
            appointmentsTable.Name = "appointmentsTable";
            appointmentsTable.ReadOnly = true;
            appointmentsTable.RowHeadersWidth = 51;
            appointmentsTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            appointmentsTable.Size = new Size(1093, 423);
            appointmentsTable.TabIndex = 45;
            // 
            // appointments
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1363, 694);
            Controls.Add(panel1);
            Controls.Add(sideBar);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "appointments";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Appointment Transaction";
            panel2.ResumeLayout(false);
            sideBar.ResumeLayout(false);
            logoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logoImage).EndInit();
            paymentPanelButton.ResumeLayout(false);
            logoutPanelButton.ResumeLayout(false);
            reportsPanelButton.ResumeLayout(false);
            patientsPanelButton.ResumeLayout(false);
            appointmentsPanelButton.ResumeLayout(false);
            dashboardPanelButton.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)appointmentsTable).EndInit();
            ResumeLayout(false);
        }

        private Panel panel2;
        private Button button3;
        private Panel sideBar;
        private Button aboutButton;
        private Panel logoPanel;
        private PictureBox logoImage;
        private Panel paymentPanelButton;
        private Button paymentsButton;
        private Panel logoutPanelButton;
        private Button logoutButton;
        private Panel reportsPanelButton;
        private Button dentistButton;
        private Panel patientsPanelButton;
        private Button patientsButton;
        private Panel appointmentsPanelButton;
        private Button appointmentsButton;
        private Panel dashboardPanelButton;
        private Button dashboardButton;
        private Button button2;
        private Panel panel1;
        private Panel pnlTop;
        private ComboBox cmbPatient;
        private ComboBox cmbDentist;
        private DateTimePicker dtpAppointmentDate;
        private DateTimePicker dtpAppointmentTime;
        private TextBox txtReason;
        private ComboBox cmbStatus;
        private Button btnCancelAppointment;
        private Button btnClear;
        private Button btnRefresh;
        private Button btnClose;
        private TextBox txtSearch;
        private Button btnSearch;
        private DataGridView appointmentsTable;
        private Label lblTitle;
        private Label lblSearch;
        private TextBox searchTextBox;
        private Button searchButton;
    }
}
