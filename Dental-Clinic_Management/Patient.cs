﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Dental_Clinic_Management
{
    public partial class Patient : Form
    {
        SqlCommand cmd;
        SqlDataReader dr;
        protected static SqlConnection getConnection()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = MARK;database=Clinic;integrated security=true";
            return con;
        }
        public Patient()
        {
            InitializeComponent();
        }
        string searchPhone;




     
        public static class patientDataBaseQueries
        {
            public static void addPatient(string fname, string lname, string phone, RadioButton rad, DateTime Date, string address)
            {
                using (SqlConnection con = getConnection())
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM Patient WHERE Fname=@Fname AND Lname=@Lname AND Phone=@Phone", con))
                    {
                        cmd.Parameters.AddWithValue("Fname", fname);
                        cmd.Parameters.AddWithValue("Lname", lname);
                        cmd.Parameters.AddWithValue("Phone", phone);

                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                MessageBox.Show("Patient already exists. Please try another.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                            else
                            {
                                dr.Close();

                                using (SqlCommand insertCmd = new SqlCommand("INSERT INTO Patient (Fname, Lname, Phone, gender, DOB, pat_address) " +
                                    "VALUES (@Fname, @Lname, @Phone, @gender, @DOB, @pat_address)", con))
                                {
                                    insertCmd.Parameters.AddWithValue("Fname", fname);
                                    insertCmd.Parameters.AddWithValue("Lname", lname);
                                    insertCmd.Parameters.AddWithValue("Phone", phone);
                                    insertCmd.Parameters.AddWithValue("gender", rad.Checked ? "Female" : "Male");
                                    insertCmd.Parameters.AddWithValue("DOB", Date);
                                    insertCmd.Parameters.AddWithValue("pat_address", address);

                                    insertCmd.ExecuteNonQuery();

                                    MessageBox.Show("Patient information added successfully.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    // Optionally, you may navigate to another form or perform additional actions here.
                                    //
                                    return;
                                }
                            }
                        }
                    }
                }
            }
            //--------------------------------------------------------------------------------------------------------------------------------------------------------
            

 

            public static void SearchPatient(string phoneNumber, DataGridView dataGridView)
            {
                using (SqlConnection con = getConnection())
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand("SELECT patient_id, Fname, Lname, Phone, pat_address, gender, DOB FROM Patient WHERE Phone LIKE @Phone", con))
                    {
                        cmd.Parameters.AddWithValue("Phone", phoneNumber + "%");

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            // Clear existing columns (if any)
                            dataGridView.Columns.Clear();

                            // Set AutoGenerateColumns to false
                            dataGridView.AutoGenerateColumns = false;

                            // Manually add columns and map them to DataTable columns
                            DataGridViewTextBoxColumn colPatientID = new DataGridViewTextBoxColumn();
                            colPatientID.Name = "patient_id";
                            colPatientID.DataPropertyName = "patient_id";
                            colPatientID.HeaderText = "Patient ID";
                            colPatientID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            dataGridView.Columns.Add(colPatientID);

                            DataGridViewTextBoxColumn colFname = new DataGridViewTextBoxColumn();
                            colFname.Name = "Fname";
                            colFname.DataPropertyName = "Fname";
                            colFname.HeaderText = "First Name";
                            colFname.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            dataGridView.Columns.Add(colFname);

                            DataGridViewTextBoxColumn colLname = new DataGridViewTextBoxColumn();
                            colLname.Name = "Lname";
                            colLname.DataPropertyName = "Lname";
                            colLname.HeaderText = "Last Name";
                            colLname.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            dataGridView.Columns.Add(colLname);

                            DataGridViewTextBoxColumn colPhone = new DataGridViewTextBoxColumn();
                            colPhone.Name = "Phone";
                            colPhone.DataPropertyName = "Phone";
                            colPhone.HeaderText = "Phone";
                            colPhone.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            dataGridView.Columns.Add(colPhone);

                            DataGridViewTextBoxColumn colPatAddress = new DataGridViewTextBoxColumn();
                            colPatAddress.Name = "pat_address";
                            colPatAddress.DataPropertyName = "pat_address";
                            colPatAddress.HeaderText = "Patient Address";
                            colPatAddress.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            dataGridView.Columns.Add(colPatAddress);

                            DataGridViewTextBoxColumn colGender = new DataGridViewTextBoxColumn();
                            colGender.Name = "gender";
                            colGender.DataPropertyName = "gender";
                            colGender.HeaderText = "Gender";
                            colGender.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            dataGridView.Columns.Add(colGender);

                            DataGridViewTextBoxColumn colDOB = new DataGridViewTextBoxColumn();
                            colDOB.Name = "DOB";
                            colDOB.DataPropertyName = "DOB";
                            colDOB.HeaderText = "Date of Birth";
                            colDOB.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            dataGridView.Columns.Add(colDOB);

                            // Set the DataSource
                            dataGridView.DataSource = dt;
                        }
                    }
                }
            }
            //--------------------------------------------------------------------------------------------------------------------------------------------------------
            public static void EditPatient(string phone, string newFname, string newLname, string newPhone, string newAddress, DateTime newDOB, RadioButton rad)
            {
                using (SqlConnection con = getConnection())
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM Patient WHERE Phone=@Phone", con))
                    {
                        cmd.Parameters.AddWithValue("Phone", phone);

                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                using (SqlCommand updateCmd = new SqlCommand("UPDATE Patient SET Fname=@NewFname, Lname=@NewLname, gender=@NewGender, DOB=@NewDOB, pat_address=@NewAddress WHERE Phone=@Phone AND patient_id=@ID", con))
                                {
                                    updateCmd.Parameters.AddWithValue("Phone", newPhone);
                                    updateCmd.Parameters.AddWithValue("NewFname", newFname);
                                    updateCmd.Parameters.AddWithValue("NewLname", newLname);
                                    updateCmd.Parameters.AddWithValue("NewGender", rad.Checked ? "Female" : "Male");
                                    updateCmd.Parameters.AddWithValue("NewDOB", newDOB);
                                    updateCmd.Parameters.AddWithValue("NewAddress", newAddress);

                                    updateCmd.Parameters.AddWithValue("ID", dr["patient_id"]);

                                    dr.Close();

                                    int rowsAffected = updateCmd.ExecuteNonQuery();

                                    if (rowsAffected > 0)
                                    {
                                        MessageBox.Show("Patient information updated successfully.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    }
                                    else
                                    {
                                        MessageBox.Show("Failed to update patient information. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Patient not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }


            //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            public static void loadAllPatientsInDataGridView(DataGridView dataGridView)
            {
                using (SqlConnection con = getConnection())
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand("SELECT patient_id, Fname, Lname,Phone,pat_address, gender, DOB FROM Patient", con))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            // Clear existing columns (if any)
                            dataGridView.Columns.Clear();

                            // Set AutoGenerateColumns to false
                            dataGridView.AutoGenerateColumns = false;

                            // Manually add columns and map them to DataTable columns
                            DataGridViewTextBoxColumn colPatientID = new DataGridViewTextBoxColumn();
                            colPatientID.Name = "patient_id";
                            colPatientID.DataPropertyName = "patient_id";
                            colPatientID.HeaderText = "Patient ID";
                            colPatientID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            dataGridView.Columns.Add(colPatientID);

                            DataGridViewTextBoxColumn colFname = new DataGridViewTextBoxColumn();
                            colFname.Name = "Fname";
                            colFname.DataPropertyName = "Fname";
                            colFname.HeaderText = "First Name";
                            colFname.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            dataGridView.Columns.Add(colFname);

                            DataGridViewTextBoxColumn colLname = new DataGridViewTextBoxColumn();
                            colLname.Name = "Lname";
                            colLname.DataPropertyName = "Lname";
                            colLname.HeaderText = "Last Name";
                            colLname.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            dataGridView.Columns.Add(colLname);

                            DataGridViewTextBoxColumn colPhone = new DataGridViewTextBoxColumn();
                            colPhone.Name = "Phone";
                            colPhone.DataPropertyName = "Phone";
                            colPhone.HeaderText = "Phone";
                            colPhone.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            dataGridView.Columns.Add(colPhone);

                            DataGridViewTextBoxColumn colPatAddress = new DataGridViewTextBoxColumn();
                            colPatAddress.Name = "pat_address";
                            colPatAddress.DataPropertyName = "pat_address";
                            colPatAddress.HeaderText = "Patient Address";
                            colPatAddress.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            dataGridView.Columns.Add(colPatAddress);

                            DataGridViewTextBoxColumn colGender = new DataGridViewTextBoxColumn();
                            colGender.Name = "gender";
                            colGender.DataPropertyName = "gender";
                            colGender.HeaderText = "Gender";
                            colGender.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            dataGridView.Columns.Add(colGender);

                            DataGridViewTextBoxColumn colDOB = new DataGridViewTextBoxColumn();
                            colDOB.Name = "DOB";
                            colDOB.DataPropertyName = "DOB";
                            colDOB.HeaderText = "Date of Birth";
                            colDOB.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            dataGridView.Columns.Add(colDOB);

                            // Set the DataSource
                            dataGridView.DataSource = dt;
                        }
                    }
                }
            }
            //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            public static void DeletePatient(int patientId)
            {
                using (SqlConnection con = getConnection())
                {
                    con.Open();

                    // Assuming 'Patients' table has a column named 'PatientId'
                    string query = "DELETE FROM Patient WHERE patient_id = @patient_id";
                    SqlCommand command = new SqlCommand(query, con);
                    command.Parameters.AddWithValue("@patient_id", patientId);

                    command.ExecuteNonQuery();
                }
            }


        }






        private void editPatientButton_Click(object sender, EventArgs e)
        {
            if (patientDataGridView.SelectedRows.Count > 0)
            {
                // Retrieve data from the selected row
                DataGridViewRow selectedRow = patientDataGridView.SelectedRows[0];
                string fname = selectedRow.Cells["Fname"].Value.ToString();
                string lname = selectedRow.Cells["Lname"].Value.ToString();
                string phone = selectedRow.Cells["Phone"].Value.ToString();
                string gender = selectedRow.Cells["gender"].Value.ToString();
                DateTime dob = Convert.ToDateTime(selectedRow.Cells["DOB"].Value);
                string address = selectedRow.Cells["pat_address"].Value.ToString();

                // Open the EditPatientForm and pass the patient data

                EditPatinet editForm = new EditPatinet(fname, lname, phone, gender, dob, address);
                this.Hide();
                editForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a patient to add.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deletePatientButton_Click(object sender, EventArgs e)
        {
            DataGridView dataGrid = patientDataGridView;
            if (patientDataGridView.SelectedRows.Count > 0)
            {
                // Get the selected patient ID from the DataGridView
                int selectedPatientId = Convert.ToInt32(patientDataGridView.SelectedRows[0].Cells["patient_id"].Value);

                // Ask for confirmation
                DialogResult result = MessageBox.Show("Are you sure you want to delete this patient?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Delete the patient from the database
                    patientDataBaseQueries.DeletePatient(selectedPatientId);

                    // Refresh the DataGridView after deletion
                    patientDataBaseQueries.loadAllPatientsInDataGridView(dataGrid);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            string phone = searchTextBox.Text.Trim();
            DataGridView dataGrid = patientDataGridView;

            // You can set a minimum length if needed before starting the search
            if (phone.Length >= 1)
            {
                patientDataBaseQueries.SearchPatient(phone, dataGrid);
            }
            else
            {
                // If the TextBox is empty, load all patients
                patientDataBaseQueries.loadAllPatientsInDataGridView(dataGrid);
            }
        }

        private void Patient_Load(object sender, EventArgs e)
        {
            patientDataBaseQueries.loadAllPatientsInDataGridView(patientDataGridView);
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dashboardButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            recepDashboardForm rec = new recepDashboardForm();
            rec.ShowDialog();
        }

        private void patientButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Patient pat = new Patient();
            pat.ShowDialog();
        }

        private void appointmentsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Appointment appointment = new Appointment();
            appointment.ShowDialog();
        }

        private void addPatient_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddRecordForm addRecordForm = new AddRecordForm();
            addRecordForm.ShowDialog();
        }

        private void closePictureBox_Click(object sender, EventArgs e)
        {
            closeFormChecker();
        }
        public void closeFormChecker()
        {
            // message to check whether the user wants to close the app or not
            DialogResult result = MessageBox.Show("Are you Sure you want to close the app", "Quit",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }


        }
    }
}