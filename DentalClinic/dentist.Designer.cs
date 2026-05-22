namespace DentalClinic
{
    partial class dentist
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
            lblPatient = new Label();
            PatientTextbox = new ComboBox();
            lblDentist = new Label();
            DentistTextbox = new ComboBox();
            lblDate = new Label();
            AppointmentDate = new DateTimePicker();
            lblTime = new Label();
            AppointmentTime = new DateTimePicker();
            lblReason = new Label();
            ReasonTextbox = new TextBox();
            lblStatus = new Label();
            StatusTextbox = new ComboBox();
            saveButton = new Button();
            updateButton = new Button();
            cancelAppointmentButton = new Button();
            clearButton = new Button();
            refreshButton = new Button();
            closeButton = new Button();
            SuspendLayout();
            // 
            // lblPatient
            // 
            lblPatient.Location = new Point(191, 232);
            lblPatient.Name = "lblPatient";
            lblPatient.Size = new Size(120, 25);
            lblPatient.TabIndex = 45;
            lblPatient.Text = "Patient:";
            // 
            // PatientTextbox
            // 
            PatientTextbox.DropDownStyle = ComboBoxStyle.DropDownList;
            PatientTextbox.Location = new Point(321, 229);
            PatientTextbox.Name = "PatientTextbox";
            PatientTextbox.Size = new Size(300, 28);
            PatientTextbox.TabIndex = 46;
            // 
            // lblDentist
            // 
            lblDentist.Location = new Point(191, 272);
            lblDentist.Name = "lblDentist";
            lblDentist.Size = new Size(120, 25);
            lblDentist.TabIndex = 47;
            lblDentist.Text = "Dentist:";
            // 
            // DentistTextbox
            // 
            DentistTextbox.DropDownStyle = ComboBoxStyle.DropDownList;
            DentistTextbox.Location = new Point(321, 269);
            DentistTextbox.Name = "DentistTextbox";
            DentistTextbox.Size = new Size(300, 28);
            DentistTextbox.TabIndex = 48;
            // 
            // lblDate
            // 
            lblDate.Location = new Point(191, 312);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(120, 25);
            lblDate.TabIndex = 49;
            lblDate.Text = "Appointment Date:";
            // 
            // AppointmentDate
            // 
            AppointmentDate.Format = DateTimePickerFormat.Short;
            AppointmentDate.Location = new Point(321, 309);
            AppointmentDate.Name = "AppointmentDate";
            AppointmentDate.Size = new Size(300, 27);
            AppointmentDate.TabIndex = 50;
            // 
            // lblTime
            // 
            lblTime.Location = new Point(191, 352);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(120, 25);
            lblTime.TabIndex = 51;
            lblTime.Text = "Appointment Time:";
            // 
            // AppointmentTime
            // 
            AppointmentTime.Format = DateTimePickerFormat.Time;
            AppointmentTime.Location = new Point(321, 349);
            AppointmentTime.Name = "AppointmentTime";
            AppointmentTime.ShowUpDown = true;
            AppointmentTime.Size = new Size(300, 27);
            AppointmentTime.TabIndex = 52;
            // 
            // lblReason
            // 
            lblReason.Location = new Point(191, 392);
            lblReason.Name = "lblReason";
            lblReason.Size = new Size(120, 25);
            lblReason.TabIndex = 53;
            lblReason.Text = "Reason:";
            // 
            // ReasonTextbox
            // 
            ReasonTextbox.Location = new Point(321, 389);
            ReasonTextbox.Multiline = true;
            ReasonTextbox.Name = "ReasonTextbox";
            ReasonTextbox.Size = new Size(300, 80);
            ReasonTextbox.TabIndex = 54;
            // 
            // lblStatus
            // 
            lblStatus.Location = new Point(191, 487);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(120, 25);
            lblStatus.TabIndex = 55;
            lblStatus.Text = "Status:";
            // 
            // StatusTextbox
            // 
            StatusTextbox.DropDownStyle = ComboBoxStyle.DropDownList;
            StatusTextbox.Location = new Point(321, 484);
            StatusTextbox.Name = "StatusTextbox";
            StatusTextbox.Size = new Size(300, 28);
            StatusTextbox.TabIndex = 56;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(661, 229);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(150, 35);
            saveButton.TabIndex = 57;
            saveButton.Text = "Save";
            // 
            // updateButton
            // 
            updateButton.Enabled = false;
            updateButton.Location = new Point(831, 229);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(150, 35);
            updateButton.TabIndex = 58;
            updateButton.Text = "Update";
            // 
            // cancelAppointmentButton
            // 
            cancelAppointmentButton.Location = new Point(1001, 229);
            cancelAppointmentButton.Name = "cancelAppointmentButton";
            cancelAppointmentButton.Size = new Size(180, 35);
            cancelAppointmentButton.TabIndex = 59;
            cancelAppointmentButton.Text = "Cancel Appointment";
            // 
            // clearButton
            // 
            clearButton.Location = new Point(661, 279);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(150, 35);
            clearButton.TabIndex = 60;
            clearButton.Text = "Clear";
            // 
            // refreshButton
            // 
            refreshButton.Location = new Point(831, 279);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(150, 35);
            refreshButton.TabIndex = 61;
            refreshButton.Text = "Refresh";
            // 
            // closeButton
            // 
            closeButton.Location = new Point(1001, 279);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(180, 35);
            closeButton.TabIndex = 62;
            closeButton.Text = "Close";
            // 
            // dentist
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1373, 740);
            Controls.Add(lblPatient);
            Controls.Add(PatientTextbox);
            Controls.Add(lblDentist);
            Controls.Add(DentistTextbox);
            Controls.Add(lblDate);
            Controls.Add(AppointmentDate);
            Controls.Add(lblTime);
            Controls.Add(AppointmentTime);
            Controls.Add(lblReason);
            Controls.Add(ReasonTextbox);
            Controls.Add(lblStatus);
            Controls.Add(StatusTextbox);
            Controls.Add(saveButton);
            Controls.Add(updateButton);
            Controls.Add(cancelAppointmentButton);
            Controls.Add(clearButton);
            Controls.Add(refreshButton);
            Controls.Add(closeButton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "dentist";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "dentist";
            ResumeLayout(false);
            PerformLayout();


        }

        #endregion

        private Label lblPatient;
        private ComboBox PatientTextbox;
        private Label lblDentist;
        private ComboBox DentistTextbox;
        private Label lblDate;
        private DateTimePicker AppointmentDate;
        private Label lblTime;
        private DateTimePicker AppointmentTime;
        private Label lblReason;
        private TextBox ReasonTextbox;
        private Label lblStatus;
        private ComboBox StatusTextbox;
        private Button saveButton;
        private Button updateButton;
        private Button cancelAppointmentButton;
        private Button clearButton;
        private Button refreshButton;
        private Button closeButton;
    }
}