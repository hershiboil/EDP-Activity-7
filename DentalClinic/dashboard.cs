using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Core;
using System.Runtime.InteropServices;
using System.IO;
using System.Linq;


namespace DentalClinic
{
    public partial class dashboard : Form
    {
        private int selectedUserId;
        public dashboard()
        {
            InitializeComponent();
            dentistPanel.Visible = false;
            AddDentist.Visible = false;
            cancelButton.Visible = false;
            saveButton.Visible = false;
            searchBox.Visible = false;
            editDentistPanel.Visible = false;
            dentistImage.Visible = false;
            Activelist.Visible = false;
            searchButton.Visible = false;
            addUserPanel.Visible = false;
            create_new_user.Visible = false;

        }



        private void exportButton_Click(object sender, EventArgs e)
        {
            if (dentistGrid.Rows.Count == 0)
            {
                MessageBox.Show("No data available to export.", "Export", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Workbook (*.xlsx)|*.xlsx";
            saveFileDialog.FileName = "Dentist_Report.xlsx";

            if (saveFileDialog.ShowDialog() != DialogResult.OK)
                return;

            Excel.Application excelApp = null;
            Excel.Workbook workbook = null;

            try
            {
                excelApp = new Excel.Application();
                workbook = excelApp.Workbooks.Add();

                Excel.Worksheet sheet1 = workbook.Sheets[1];
                sheet1.Name = "Dentist Report";

                Excel.Worksheet sheet2 = workbook.Sheets.Add(After: sheet1);
                sheet2.Name = "Graph";

                Excel.Worksheet sheet3 = workbook.Sheets.Add(After: sheet2);
                sheet3.Name = "Summary";

                string companyName = "Dental Clinic";
                string logoPath = @"C:\Users\Hershey\source\repos\DentalClinic\DentalClinic\Images\logo.jpg"; 
                string signedBy = Environment.UserName;

                CreateHeader(sheet1, companyName, logoPath);
                CreateHeader(sheet2, companyName, logoPath);
                CreateHeader(sheet3, companyName, logoPath);

                ExportGridToSheet(sheet1, dentistGrid, startRow: 6);
                CreateSignaturePlaceholder(sheet1, signedBy, dentistGrid.Rows.Count + 10);

                CreateGraphSheet(sheet2, dentistGrid);
                CreateSignaturePlaceholder(sheet2, signedBy, 24);

                CreateSummarySheet(sheet3, dentistGrid);
                CreateSignaturePlaceholder(sheet3, signedBy, 14);

                workbook.SaveAs(saveFileDialog.FileName);
                MessageBox.Show("Dentist report exported successfully.", "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Export failed: " + ex.Message, "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (workbook != null)
                {
                    workbook.Close(false);
                    Marshal.ReleaseComObject(workbook);
                }

                if (excelApp != null)
                {
                    excelApp.Quit();
                    Marshal.ReleaseComObject(excelApp);
                }
            }
        }

        private void CreateHeader(Excel.Worksheet sheet, string companyName, string logoPath)
        {
            sheet.Range["A1", "H1"].Merge();
            sheet.Range["A1"].Value = companyName;
            sheet.Range["A1"].Font.Size = 16;
            sheet.Range["A1"].Font.Bold = true;
            sheet.Range["A1"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

            sheet.Range["A2", "H2"].Merge();
            sheet.Range["A2"].Value = "Dentist Report";
            sheet.Range["A2"].Font.Size = 12;
            sheet.Range["A2"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

            sheet.Range["A3", "H3"].Merge();
            sheet.Range["A3"].Value = "Generated Date: " + DateTime.Now.ToString("MMMM dd, yyyy hh:mm tt");
            sheet.Range["A3"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

            if (File.Exists(logoPath))
            {
                sheet.Shapes.AddPicture(
                    logoPath,
                    Microsoft.Office.Core.MsoTriState.msoFalse,
                    Microsoft.Office.Core.MsoTriState.msoCTrue,
                    10,
                    10,
                    70,
                    70
                );
            }
        }

        private void ExportGridToSheet(Excel.Worksheet sheet, DataGridView grid, int startRow)
        {
            int colIndex = 1;

            foreach (DataGridViewColumn column in grid.Columns)
            {
                if (!column.Visible || column.Name == "Edit" || column.HeaderText == "Action")
                    continue;

                sheet.Cells[startRow, colIndex] = column.HeaderText;
                sheet.Cells[startRow, colIndex].Font.Bold = true;
                sheet.Cells[startRow, colIndex].Interior.Color = System.Drawing.Color.LightGray;
                colIndex++;
            }

            int rowIndex = startRow + 1;

            foreach (DataGridViewRow row in grid.Rows)
            {
                if (row.IsNewRow) continue;

                colIndex = 1;

                foreach (DataGridViewColumn column in grid.Columns)
                {
                    if (!column.Visible || column.Name == "Edit" || column.HeaderText == "Action")
                        continue;

                    object value = row.Cells[column.Index].Value;
                    sheet.Cells[rowIndex, colIndex] = value == null ? "" : value.ToString();

                    colIndex++;
                }

                rowIndex++;
            }

            Excel.Range usedRange = sheet.Range[
                sheet.Cells[startRow, 1],
                sheet.Cells[rowIndex - 1, colIndex - 1]
            ];

            usedRange.Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
            usedRange.Columns.AutoFit();
        }

        private void CreateGraphSheet(Excel.Worksheet sheet, DataGridView grid)
        {
            sheet.Range["A5"].Value = "Category";
            sheet.Range["B5"].Value = "Total";
            sheet.Range["A5", "B5"].Font.Bold = true;

            DataGridViewColumn categoryColumn = grid.Columns
                .Cast<DataGridViewColumn>()
                .FirstOrDefault(c =>
                    c.Visible &&
                    (c.HeaderText.ToLower().Contains("status") ||
                     c.HeaderText.ToLower().Contains("type") ||
                     c.HeaderText.ToLower().Contains("gender") ||
                     c.HeaderText.ToLower().Contains("specialization")));

            if (categoryColumn == null)
            {
                sheet.Range["A6"].Value = "Total Dentists";
                sheet.Range["B6"].Value = grid.Rows.Cast<DataGridViewRow>().Count(r => !r.IsNewRow);
            }
            else
            {
                var groupedData = grid.Rows
                    .Cast<DataGridViewRow>()
                    .Where(r => !r.IsNewRow)
                    .GroupBy(r => Convert.ToString(r.Cells[categoryColumn.Index].Value))
                    .Select(g => new { Category = string.IsNullOrWhiteSpace(g.Key) ? "Unspecified" : g.Key, Total = g.Count() })
                    .ToList();

                int row = 6;

                foreach (var item in groupedData)
                {
                    sheet.Cells[row, 1] = item.Category;
                    sheet.Cells[row, 2] = item.Total;
                    row++;
                }
            }

            Excel.ChartObjects chartObjects = (Excel.ChartObjects)sheet.ChartObjects();
            Excel.ChartObject chartObject = chartObjects.Add(100, 120, 500, 300);
            Excel.Chart chart = chartObject.Chart;

            Excel.Range chartRange = sheet.Range["A5", "B20"];
            chart.SetSourceData(chartRange);
            chart.ChartType = Excel.XlChartType.xlColumnClustered;
            chart.HasTitle = true;
            chart.ChartTitle.Text = "Dentist Data Graph";

            sheet.Columns.AutoFit();
        }

        private void CreateSummarySheet(Excel.Worksheet sheet, DataGridView grid)
        {
            int totalRows = grid.Rows.Cast<DataGridViewRow>().Count(r => !r.IsNewRow);

            sheet.Range["A6"].Value = "Summary";
            sheet.Range["A6"].Font.Bold = true;
            sheet.Range["A6"].Font.Size = 14;

            sheet.Range["A8"].Value = "Total Records:";
            sheet.Range["B8"].Value = totalRows;

            sheet.Range["A9"].Value = "Generated By:";
            sheet.Range["B9"].Value = Environment.UserName;

            sheet.Range["A10"].Value = "Generated Date:";
            sheet.Range["B10"].Value = DateTime.Now.ToString("MMMM dd, yyyy hh:mm tt");

            sheet.Range["A8", "B10"].Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
            sheet.Columns.AutoFit();
        }

        private void CreateSignaturePlaceholder(Excel.Worksheet sheet, string signedBy, int row)
        {
            sheet.Cells[row, 1] = "Prepared By:";
            sheet.Cells[row + 2, 1] = "____________________________";
            sheet.Cells[row + 3, 1] = signedBy;

            sheet.Cells[row, 4] = "Approved / Signed By:";
            sheet.Cells[row + 2, 4] = "____________________________";
            sheet.Cells[row + 3, 4] = "Signature over Printed Name";
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

        private void appointmentsButton_Click(object sender, EventArgs e)
        {
            appointments appointments = new appointments();

            // Show the appointments form
            appointments.Show();
            // Hide or close the login form
            this.Hide();
        }

        private void dashboardButton_Click(object sender, EventArgs e)
        {
            dentistPanel.Visible = false;

        }

        private void paymentsButton_Click(object sender, EventArgs e)
        {
            payments payments = new payments();

            // Show the payments form
            payments.Show();
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

        private void aboutButton_Click(object sender, EventArgs e)
        {
            about about = new about();

            // Show the about form
            about.Show();
            // Hide or close the login form
            this.Hide();
        }


        private void LoadDentists()
        {
            DBConnection db = new DBConnection();

            try
            {
                db.conn.Open();

                string query = @"
                SELECT 
                    u.user_id                            AS ID,
                    CONCAT(u.first_name, ' ', u.last_name) AS Name,
                    u.email                              AS Email,
                    d.employmentType                     AS EmploymentType,
                    d.salary                             AS Salary,
                    d.specialization                     AS Specialization,
                    d.licenseID                          AS LicenseID,
                    u.status                             AS Status
                FROM users u
                INNER JOIN dentist d ON u.user_id = d.user_id
                WHERE u.role = 'Dentist'";


                if (!string.IsNullOrWhiteSpace(searchBox.Text))
                {
                    query += @" AND (
                        u.first_name LIKE @keyword 
                        OR u.last_name LIKE @keyword 
                        OR u.email LIKE @keyword
                        OR d.employmentType LIKE @keyword
                        OR d.specialization LIKE @keyword
                        OR d.licenseID LIKE @keyword
                    )";
                }

                if (Activelist.SelectedItem != null)
                {
                    string selectedStatus = Activelist.SelectedItem.ToString();

                    if (selectedStatus.Equals("Active", StringComparison.OrdinalIgnoreCase))
                    {
                        query += " AND u.status = 'Active'";
                    }
                    else if (selectedStatus.Equals("Inactive", StringComparison.OrdinalIgnoreCase))
                    {
                        query += " AND u.status = 'Inactive'";
                    }

                }

                using (MySqlCommand cmd = new MySqlCommand(query, db.conn))
                {
                    if (!string.IsNullOrWhiteSpace(searchBox.Text))
                    {
                        cmd.Parameters.AddWithValue("@keyword", "%" + searchBox.Text.Trim() + "%");
                    }

                    // This part stays — executes query and binds results
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dentistGrid.DataSource = table;
                    dentistGrid.ClearSelection();

                }
                // ── Grid size fitted to panel (741 x 599) ────────────────────

                dentistGrid.Dock = DockStyle.None;              // ← must be None to use Location
                dentistGrid.Location = new Point(12, 76);        // ← Y=96 moves grid down ~1 inch
                dentistGrid.Size = new Size(1137, 379);

                // ── Grid-level styling ────────────────────────────────────────
                dentistGrid.BorderStyle = BorderStyle.None;
                dentistGrid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                dentistGrid.GridColor = Color.FromArgb(181, 212, 244);
                dentistGrid.BackgroundColor = Color.White;
                dentistGrid.RowHeadersVisible = false;
                dentistGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dentistGrid.AllowUserToAddRows = false;
                dentistGrid.ScrollBars = ScrollBars.Vertical; // only vertical scroll if rows overflow

                // ── Header styling ────────────────────────────────────────────
                dentistGrid.EnableHeadersVisualStyles = false;
                dentistGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(24, 95, 165);
                dentistGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dentistGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                dentistGrid.ColumnHeadersDefaultCellStyle.Padding = new Padding(8, 0, 0, 0);
                dentistGrid.ColumnHeadersHeight = 42;
                dentistGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

                // ── Row styling ───────────────────────────────────────────────
                dentistGrid.DefaultCellStyle.Font = new Font("Segoe UI", 9.5f, FontStyle.Regular);
                dentistGrid.DefaultCellStyle.ForeColor = Color.FromArgb(30, 30, 30);
                dentistGrid.DefaultCellStyle.BackColor = Color.White;
                dentistGrid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(230, 241, 251);
                dentistGrid.DefaultCellStyle.SelectionForeColor = Color.FromArgb(12, 68, 124);
                dentistGrid.DefaultCellStyle.Padding = new Padding(6, 0, 0, 0);
                dentistGrid.RowTemplate.Height = 50; // ~13 rows fit in 599px (42 header + 13×44 = 614 ≈ fits)

                // ── Column widths fitted to 741px total ───────────────────────
                // Disable auto-size first, then set exact widths
                dentistGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

                dentistGrid.Columns["ID"].Width = 55;
                dentistGrid.Columns["Name"].Width = 150;
                dentistGrid.Columns["Email"].Width = 240;
                dentistGrid.Columns["EmploymentType"].Width = 120;
                dentistGrid.Columns["Salary"].Width = 90;
                dentistGrid.Columns["Specialization"].Width = 160;
                dentistGrid.Columns["LicenseID"].Width = 120;
                dentistGrid.Columns["Status"].Width = 92;



                // ── Edit button column ────────────────────────────────────────
                if (!dentistGrid.Columns.Contains("Edit"))
                {
                    DataGridViewButtonColumn editBtn = new DataGridViewButtonColumn
                    {
                        Name = "Edit",
                        HeaderText = "Action",
                        Text = "✎  Edit",
                        UseColumnTextForButtonValue = true,
                        Width = 70,
                        FlatStyle = FlatStyle.Flat
                    };
                    dentistGrid.Columns.Add(editBtn);
                }

                dentistGrid.Columns["Edit"].Width = 70;
                dentistGrid.Columns["Edit"].DefaultCellStyle.BackColor = Color.FromArgb(24, 95, 165);
                dentistGrid.Columns["Edit"].DefaultCellStyle.ForeColor = Color.White;
                dentistGrid.Columns["Edit"].DefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                dentistGrid.Columns["Edit"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                //dentistGrid.Columns["Edit"].DefaultCellStyle.SelectionBackColor = Color.FromArgb(12, 68, 124);
                dentistGrid.Columns["Edit"].DefaultCellStyle.Padding = new Padding(2, 5, 2, 5);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading dentists: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.conn.Close();
            }
        }

        private void dentistButton_Click(object sender, EventArgs e)
        {
            dentistPanel.Visible = true;
            searchBox.Visible = true;
            Activelist.Visible = true;
            searchButton.Visible = true;
            AddDentist.Visible = true;
            addUserPanel.Visible = false;
            editDentistPanel.Visible = false;

            LoadDentists();
        }

        private void AddDentist_Click(object sender, EventArgs e)
        {
            addUserPanel.BringToFront();
            addUserPanel.Visible = true;
            create_new_user.Visible = true;
            cancel_new_user.Visible = true;
            AddDentist.Visible = false;
            searchBox.Visible = false;
            Activelist.Visible = false;
            searchButton.Visible = false;

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            dentistPanel.Visible = true;
            editDentistPanel.Visible = false;
            cancelButton.Visible = false;
            saveButton.Visible = false;
            dentistImage.Visible = false;
            create_new_user.Visible = false;
            dentistGrid.Visible = true;
            AddDentist.Visible = true;
            searchBox.Visible = true;
            Activelist.Visible = true;
            searchButton.Visible = true;
        }

        private void dentistGrid_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // Set panel position at X=50, Y=100
            //editDentistPanel.Location = new Point(3, 64);

            // Set fixed size if needed
            //editDentistPanel.Size = new Size(600, 400);

            if (e.ColumnIndex == dentistGrid.Columns["Edit"].Index && e.RowIndex >= 0)
            {
                // Get selected user_id from the grid
                int userId = Convert.ToInt32(dentistGrid.Rows[e.RowIndex].Cells["ID"].Value);
                selectedUserId = userId;

                DBConnection db = new DBConnection();
                editDentistPanel.Visible = true;
                cancelButton.Visible = true;
                saveButton.Visible = true;
                dentistImage.Visible = true;
                dentistPanel.Visible = false;
                searchBox.Visible = false;
                Activelist.Visible = false;
                searchButton.Visible = false;
                addUserPanel.Visible = false;
                AddDentist.Visible = false;

                try
                {
                    db.conn.Open();

                    // Load user details
                    string queryUser = "SELECT * FROM users WHERE user_id=@userId";
                    using (MySqlCommand cmd = new MySqlCommand(queryUser, db.conn))
                    {
                        cmd.Parameters.AddWithValue("@userId", userId);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                edit_first_name.Text = reader["first_name"].ToString();
                                edit_last_name.Text = reader["last_name"].ToString();
                                edit_email.Text = reader["email"].ToString();
                                edit_contact.Text = reader["contact"].ToString();

                                // ComboBox for status
                                edit_status.SelectedItem = reader["status"].ToString();

                                // PictureBox for image
                                string imgPath = reader["image_path"].ToString();
                                if (!string.IsNullOrEmpty(imgPath) && File.Exists(imgPath))
                                {
                                    dentistImage.ImageLocation = imgPath;
                                    dentistImage.SizeMode = PictureBoxSizeMode.StretchImage;

                                }
                            }
                        }
                    }

                    // Load dentist details
                    string queryDentist = "SELECT * FROM dentist WHERE user_id=@userId";
                    using (MySqlCommand cmd = new MySqlCommand(queryDentist, db.conn))
                    {
                        cmd.Parameters.AddWithValue("@userId", userId);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                edit_salary.Text = reader["salary"].ToString();
                                edit_specialization.Text = reader["specialization"].ToString();
                                edit_employment_type.Text = reader["employmentType"].ToString();
                                dentist_license.Text = reader["licenseID"].ToString();

                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    db.conn.Close();
                }
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

            DBConnection db = new DBConnection();

            try
            {
                db.conn.Open();

                // Collect values from controls
                string imgPath = dentistImage.Tag?.ToString(); // Use the relative path stored in Tag
                string firstName = edit_first_name.Text;
                string lastName = edit_last_name.Text;
                string email = edit_email.Text;
                string contact = edit_contact.Text;
                string status = edit_status.SelectedItem.ToString(); // ComboBox

                string salary = edit_salary.Text;
                string specialization = edit_specialization.Text;
                string employmentType = edit_employment_type.Text;
                string license = dentist_license.Text;
                // IDs should come from your DataGridView selection
                int userId = Convert.ToInt32(selectedUserId);

                // Update USERS table
                string updateUser = @"UPDATE users 
                              SET first_name=@firstName, 
                                  last_name=@lastName, 
                                  email=@email, 
                                  contact=@contact, 
                                  status=@status, 
                                  image_path=@imgPath
                              WHERE user_id=@userId";

                using (MySqlCommand cmd = new MySqlCommand(updateUser, db.conn))
                {
                    cmd.Parameters.AddWithValue("@firstName", firstName);
                    cmd.Parameters.AddWithValue("@lastName", lastName);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@contact", contact);
                    cmd.Parameters.AddWithValue("@status", status);
                    cmd.Parameters.AddWithValue("@imgPath", imgPath);
                    cmd.Parameters.AddWithValue("@userId", userId);
                    cmd.ExecuteNonQuery();
                }

                // Update DENTIST table
                string updateDentist = @"UPDATE dentist 
                                 SET employmentType=@employmentType, 
                                     salary=@salary, 
                                     specialization=@specialization,
                                     licenseID=@license
                                 WHERE user_id=@userId";

                using (MySqlCommand cmd = new MySqlCommand(updateDentist, db.conn))
                {
                    cmd.Parameters.AddWithValue("@employmentType", employmentType);
                    cmd.Parameters.AddWithValue("@salary", salary);
                    cmd.Parameters.AddWithValue("@specialization", specialization);
                    cmd.Parameters.AddWithValue("@license", dentist_license.Text.Trim());
                    cmd.Parameters.AddWithValue("@userId", userId);
                    cmd.ExecuteNonQuery();
                }


                MessageBox.Show("Dentist profile updated successfully!");
                dentistPanel.Visible = true;
                AddDentist.Visible = true;
                searchBox.Visible = true;
                Activelist.Visible = true;
                searchButton.Visible = true;
                cancelButton.Visible = false;
                saveButton.Visible = false;
                editDentistPanel.Visible = false;
                dentistImage.Visible = false;
                addUserPanel.Visible = false;
                create_new_user.Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                db.conn.Close();
            }

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            LoadDentists();
        }

        private void create_new_user_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(new_firstname.Text) ||
       string.IsNullOrWhiteSpace(new_lastname.Text) ||
       string.IsNullOrWhiteSpace(new_email.Text) ||
       string.IsNullOrWhiteSpace(new_contact.Text) ||
       string.IsNullOrWhiteSpace(new_password.Text) ||
       string.IsNullOrWhiteSpace(new_confirm_password.Text) ||
       string.IsNullOrWhiteSpace(new_license.Text))
            {
                MessageBox.Show("All fields are required. Please fill in every textbox.",
                                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // ✅ Step 2: Check if password and confirm password match
            if (new_password.Text != new_confirm_password.Text)
            {
                MessageBox.Show("Passwords do not match. Please re-enter.",
                                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // ✅ Step 3: Proceed with adding user
            DBConnection db = new DBConnection();

            try
            {
                db.conn.Open();

                string query = @"INSERT INTO users 
                         (username,first_name, last_name, email, contact, password, role, status, image_path) 
                         VALUES (@firstName, @firstName, @lastName, @email, @contact, @password, 'Dentist', 'Active', @imgPath);
SELECT LAST_INSERT_ID();";

                int newUserId;
                using (MySqlCommand cmd = new MySqlCommand(query, db.conn))
                {
                    cmd.Parameters.AddWithValue("@firstName", new_firstname.Text.Trim());
                    cmd.Parameters.AddWithValue("@lastName", new_lastname.Text.Trim());
                    cmd.Parameters.AddWithValue("@email", new_email.Text.Trim());
                    cmd.Parameters.AddWithValue("@contact", new_contact.Text.Trim());
                    cmd.Parameters.AddWithValue("@password", new_password.Text.Trim());
                    cmd.Parameters.AddWithValue("@imgPath", new_image.Tag ?? "");
                    newUserId = Convert.ToInt32(cmd.ExecuteScalar());
                }

                string dentistQuery = @"INSERT INTO dentist 
                (user_id, employmentType, salary, specialization, licenseID) 
                VALUES (@userId, @employmentType, @salary, @specialization, @license)";

                using (MySqlCommand cmd2 = new MySqlCommand(dentistQuery, db.conn))
                {
                    cmd2.Parameters.AddWithValue("@userId", newUserId);
                    cmd2.Parameters.AddWithValue("@employmentType", new_employment_type.Text.Trim());
                    cmd2.Parameters.AddWithValue("@salary", Convert.ToDecimal(new_salary.Text.Trim()));
                    cmd2.Parameters.AddWithValue("@specialization", new_specialization.Text.Trim());
                    cmd2.Parameters.AddWithValue("@license", new_license.Text.Trim());

                    cmd2.ExecuteNonQuery();
                }

                MessageBox.Show("New user created successfully!",
                                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Optionally clear fields after success
                new_firstname.Clear();
                new_lastname.Clear();
                new_email.Clear();
                new_contact.Clear();
                new_password.Clear();
                new_confirm_password.Clear();

                // Refresh grid if needed
                LoadDentists();
                dentistPanel.Visible = true;
                AddDentist.Visible = true;
                searchBox.Visible = true;
                Activelist.Visible = true;
                searchButton.Visible = true;
                cancelButton.Visible = false;
                saveButton.Visible = false;
                editDentistPanel.Visible = false;
                dentistImage.Visible = false;
                addUserPanel.Visible = false;
                create_new_user.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating user: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                db.conn.Close();
            }

        }

        private void new_image_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Select Dentist Photo";
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    // Define your project Images folder
                    string imagesFolder = Path.Combine(Application.StartupPath, "Images");

                    // Ensure folder exists
                    if (!Directory.Exists(imagesFolder))
                        Directory.CreateDirectory(imagesFolder);

                    // Copy file into Images folder
                    string fileName = Path.GetFileName(ofd.FileName);
                    string destPath = Path.Combine(imagesFolder, fileName);
                    File.Copy(ofd.FileName, destPath, true);

                    // Show preview
                    new_image.ImageLocation = destPath;
                    new_image.SizeMode = PictureBoxSizeMode.StretchImage;

                    // Store relative path for DB
                    new_image.Tag = "Images/" + fileName;
                }
            }
        }

        private void cancel_new_user_Click(object sender, EventArgs e)
        {
            addUserPanel.Visible = false;
            dentistPanel.Visible = true;
            editDentistPanel.Visible = false;
            cancelButton.Visible = false;
            saveButton.Visible = false;
            dentistImage.Visible = false;
            create_new_user.Visible = false;
            dentistGrid.Visible = true;
            AddDentist.Visible = true;
            searchBox.Visible = true;
            Activelist.Visible = true;
            searchButton.Visible = true;
        }

        private void dentistImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Select Dentist Photo";
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    // Define your project Images folder
                    string imagesFolder = Path.Combine(Application.StartupPath, "Images");

                    // Ensure folder exists
                    if (!Directory.Exists(imagesFolder))
                        Directory.CreateDirectory(imagesFolder);

                    // Copy file into Images folder
                    string fileName = Path.GetFileName(ofd.FileName);
                    string destPath = Path.Combine(imagesFolder, fileName);
                    File.Copy(ofd.FileName, destPath, true);

                    // Show preview
                    dentistImage.ImageLocation = destPath;
                    dentistImage.SizeMode = PictureBoxSizeMode.StretchImage;

                    // Store relative path for DB
                    dentistImage.Tag = "Images/" + fileName;
                }
            }

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

       
    }
}
