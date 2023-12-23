using System;
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
    public partial class Appointment : Form
    {

        SqlCommand cmd;
        SqlDataReader dr;
        protected static SqlConnection getConnection()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-8JPNOOB\\MSSQLSERVER01;database=Clinic;integrated security=true";
            return con;
        }
        public Appointment()
        {
            InitializeComponent();
        }

        public static class appointmentDataBaseQueries
        {
            public static void SearchPatient(string phoneNumber, DataGridView dataGridView)
            {
                using (SqlConnection con = getConnection())
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand("SELECT a.app_id, (p.Fname + ' ' + p.Lname) AS PatientName, a.pat_phone, a.app_time, a.app_date FROM appointment a JOIN Patient p ON a.patient_id = p.patient_id WHERE a.pat_phone LIKE @Phone", con))
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

                            // Create columns manually
                            DataGridViewTextBoxColumn colAppointmentID = new DataGridViewTextBoxColumn();
                            colAppointmentID.Name = "AppointmentID";
                            colAppointmentID.DataPropertyName = "app_id";
                            colAppointmentID.HeaderText = "Appointment ID";
                            colAppointmentID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            dataGridView.Columns.Add(colAppointmentID);

                            DataGridViewTextBoxColumn colPatientName = new DataGridViewTextBoxColumn();
                            colPatientName.Name = "PatientName";
                            colPatientName.DataPropertyName = "PatientName"; // Use the alias used in the SQL query
                            colPatientName.HeaderText = "Patient Name";
                            colPatientName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            dataGridView.Columns.Add(colPatientName);

                            DataGridViewTextBoxColumn colPhone = new DataGridViewTextBoxColumn();
                            colPhone.Name = "Phone";
                            colPhone.DataPropertyName = "pat_phone";
                            colPhone.HeaderText = "Phone";
                            colPhone.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            dataGridView.Columns.Add(colPhone);

                            DataGridViewTextBoxColumn colTime = new DataGridViewTextBoxColumn();
                            colTime.Name = "Time";
                            colTime.DataPropertyName = "app_time";
                            colTime.HeaderText = "Time";
                            colTime.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            dataGridView.Columns.Add(colTime);

                            DataGridViewTextBoxColumn colDate = new DataGridViewTextBoxColumn();
                            colDate.Name = "Date";
                            colDate.DataPropertyName = "app_date";
                            colDate.HeaderText = "Date";
                            colDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            dataGridView.Columns.Add(colDate);

                            // Set the DataSource
                            dataGridView.DataSource = dt;
                        }
                    }
                }
            }
            //---------------------------------------------------------------------------------------------------------------------------------------------------------------

            public static void ShowAppointmentsInDataGridView(DataGridView dataGridView, DateTime dateOfTheDay)
            {
                try
                {
                    using (SqlConnection con = getConnection())
                    {
                        con.Open();

                        string queryString = "SELECT a.app_id, (p.Fname + ' ' + p.Lname) AS PatientName, a.pat_phone, a.app_time, a.app_date FROM appointment a JOIN Patient p ON a.patient_id = p.patient_id WHERE a.app_date=@dateOfTheDay";

                        using (SqlCommand cmd = new SqlCommand(queryString, con))
                        {
                            cmd.Parameters.AddWithValue("@dateOfTheDay", dateOfTheDay);

                            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                            {
                                DataTable dt = new DataTable();
                                adapter.Fill(dt);

                                dataGridView.Columns.Clear();
                                dataGridView.AutoGenerateColumns = false;

                                // Create columns manually
                                DataGridViewTextBoxColumn appointmentID = new DataGridViewTextBoxColumn();
                                appointmentID.Name = "AppointmentID";
                                appointmentID.DataPropertyName = "app_id";
                                appointmentID.HeaderText = "Appointment ID";
                                appointmentID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                dataGridView.Columns.Add(appointmentID);

                                DataGridViewTextBoxColumn patientName = new DataGridViewTextBoxColumn();
                                patientName.Name = "PatientName";
                                patientName.DataPropertyName = "PatientName";
                                patientName.HeaderText = "Patient Name";
                                patientName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                dataGridView.Columns.Add(patientName);

                                DataGridViewTextBoxColumn patphone = new DataGridViewTextBoxColumn();
                                patphone.Name = "pat_phone";
                                patphone.DataPropertyName = "pat_phone";
                                patphone.HeaderText = "Patient Phone";
                                patphone.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                dataGridView.Columns.Add(patphone);

                                DataGridViewTextBoxColumn colTime = new DataGridViewTextBoxColumn();
                                colTime.Name = "Time";
                                colTime.DataPropertyName = "app_time";
                                colTime.HeaderText = "Time";
                                colTime.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                dataGridView.Columns.Add(colTime);

                                DataGridViewTextBoxColumn colDate = new DataGridViewTextBoxColumn();
                                colDate.Name = "Date";
                                colDate.DataPropertyName = "app_date";
                                colDate.HeaderText = "Date";
                                colDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                dataGridView.Columns.Add(colDate);

                                dataGridView.DataSource = dt;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }





            //---------------------------------------------------------------------------------------------------------------------------------------------------------------
            public static void deleteAppointment(int appointment_id)
            {
                using (SqlConnection con = getConnection())
                {
                    con.Open();

                    try
                    {
                        // Check if the appointment with the given ID exists
                        using (SqlCommand selectCmd = new SqlCommand("SELECT * FROM appointment WHERE app_id = @AppointmentID", con))
                        {
                            selectCmd.Parameters.AddWithValue("@AppointmentID", appointment_id);

                            using (SqlDataReader dr = selectCmd.ExecuteReader())
                            {
                                if (dr.Read())
                                {
                                    dr.Close();

                                    // Delete the appointment
                                    using (SqlCommand deleteCmd = new SqlCommand("DELETE FROM appointment WHERE app_id = @AppointmentID", con))
                                    {
                                        deleteCmd.Parameters.AddWithValue("@AppointmentID", appointment_id);
                                        int rowsAffected = deleteCmd.ExecuteNonQuery();

                                        if (rowsAffected > 0)
                                        {
                                            MessageBox.Show("Appointment deleted successfully.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            // Optionally, you may navigate to another form or perform additional actions here.
                                        }
                                        else
                                        {
                                            MessageBox.Show("Failed to delete appointment. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Appointment not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            //---------------------------------------------------------------------------------------------------------------------------------------------------------------
            public static void EditAppointment(int appointmentID, string newPhone, string newTime, DateTime newDate)
            {
                using (SqlConnection con = getConnection())
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM appointment WHERE app_id=@AppointmentID", con))
                    {
                        cmd.Parameters.AddWithValue("@AppointmentID", appointmentID);

                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                dr.Close(); // Close the data reader before executing a new command

                                using (SqlCommand updateCmd = new SqlCommand("UPDATE appointment SET pat_phone=@newPhone, app_time=@newTime, app_date=@newDate WHERE app_id=@AppointmentID", con))
                                {
                                    updateCmd.Parameters.AddWithValue("@newPhone", newPhone);
                                    updateCmd.Parameters.AddWithValue("@newTime", newTime);
                                    updateCmd.Parameters.AddWithValue("@newDate", newDate);
                                    updateCmd.Parameters.AddWithValue("@AppointmentID", appointmentID);

                                    int rowsAffected = updateCmd.ExecuteNonQuery();

                                    if (rowsAffected > 0)
                                    {
                                        MessageBox.Show("Appointment information updated successfully.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                        // Reload data in the DataGridView after the update
                                        //  appointmentDataGridView(dataGridView, DateTime.Now); // You might need to pass the appropriate date

                                    }
                                    else
                                    {
                                        MessageBox.Show("Failed to update appointment information. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Appointment not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            //-----------------------------------------------------------------------------------------------------------------------------------------------
            public static void LoadAllAppointmentsInDataGridView(DataGridView dataGridView)
            {
                using (SqlConnection con = getConnection())
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand("SELECT a.app_id, (p.Fname + ' ' + p.Lname) AS PatientName, a.pat_phone, a.app_time, a.app_date FROM appointment a JOIN Patient p ON a.patient_id = p.patient_id", con))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            // Clear existing columns (if any)
                            dataGridView.Columns.Clear();

                            // Set AutoGenerateColumns to false
                            dataGridView.AutoGenerateColumns = false;

                            // Create columns manually
                            DataGridViewTextBoxColumn colAppointmentID = new DataGridViewTextBoxColumn();
                            colAppointmentID.Name = "AppointmentID";
                            colAppointmentID.DataPropertyName = "app_id";
                            colAppointmentID.HeaderText = "Appointment ID";
                            colAppointmentID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            dataGridView.Columns.Add(colAppointmentID);

                            DataGridViewTextBoxColumn colPatientName = new DataGridViewTextBoxColumn();
                            colPatientName.Name = "PatientName";
                            colPatientName.DataPropertyName = "PatientName";
                            colPatientName.HeaderText = "Patient Name";
                            colPatientName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            dataGridView.Columns.Add(colPatientName);

                            DataGridViewTextBoxColumn colPhone = new DataGridViewTextBoxColumn();
                            colPhone.Name = "Phone";
                            colPhone.DataPropertyName = "pat_phone";
                            colPhone.HeaderText = "Phone";
                            colPhone.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            dataGridView.Columns.Add(colPhone);

                            DataGridViewTextBoxColumn colTime = new DataGridViewTextBoxColumn();
                            colTime.Name = "Time";
                            colTime.DataPropertyName = "app_time";
                            colTime.HeaderText = "Time";
                            colTime.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            dataGridView.Columns.Add(colTime);

                            DataGridViewTextBoxColumn colDate = new DataGridViewTextBoxColumn();
                            colDate.Name = "Date";
                            colDate.DataPropertyName = "app_date";
                            colDate.HeaderText = "Date";
                            colDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            dataGridView.Columns.Add(colDate);

                            // Set the DataSource
                            dataGridView.DataSource = dt;
                        }
                    }
                }
            }


        }



   
        private void filterAppButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                DateTime dateOfTheDay = billingHistoryDateTimePicker.Value.Date;
                appointmentDataBaseQueries.ShowAppointmentsInDataGridView(appointmentDataGridView, dateOfTheDay);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Appointment_Load(object sender, EventArgs e)
        {
            try
            {
                DateTime dateOfTheDay = DateTime.Today;
                appointmentDataBaseQueries.ShowAppointmentsInDataGridView(appointmentDataGridView, dateOfTheDay);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void editAppButton_Click_1(object sender, EventArgs e)
        {
            if (appointmentDataGridView.SelectedRows.Count > 0)
            {
                // Retrieve data from the selected row
                DataGridViewRow selectedRow = appointmentDataGridView.SelectedRows[0];
                int appointmentID = Convert.ToInt32(selectedRow.Cells["AppointmentID"].Value);
                string phone = selectedRow.Cells["Phone"].Value.ToString();
                string time = selectedRow.Cells["Time"].Value.ToString();
                DateTime date = Convert.ToDateTime(selectedRow.Cells["Date"].Value);

                // Open the EditPatientForm and pass the patient data

                EditAppointmentForm editForm = new EditAppointmentForm(appointmentID, phone, time, date);
                this.Hide();
                editForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a patient to add.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void payButton_Click(object sender, EventArgs e)
        {
            if (appointmentDataGridView.SelectedRows.Count > 0)
            {
                // Get the selected appointment ID from the DataGridView
                int selectedAppointmentId = Convert.ToInt32(appointmentDataGridView.SelectedRows[0].Cells["AppointmentID"].Value);


                 Payment paymentForm = new Payment(selectedAppointmentId);
                 paymentForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select an appointment to proceed with payment.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void deleteAppButton_Click(object sender, EventArgs e)
        {
            DataGridView dataGrid = appointmentDataGridView;
            if (appointmentDataGridView.SelectedRows.Count > 0)
            {
                // Get the selected patient ID from the DataGridView
                int selectedPatientId = Convert.ToInt32(appointmentDataGridView.SelectedRows[0].Cells["AppointmentID"].Value);

                // Ask for confirmation
                DialogResult result = MessageBox.Show("Are you sure you want to delete this appointment?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Delete the patient from the database
                    appointmentDataBaseQueries.deleteAppointment(selectedPatientId);

                    // Refresh the DataGridView after deletion
                    appointmentDataBaseQueries.LoadAllAppointmentsInDataGridView(dataGrid);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void phoneTextBox_TextChanged(object sender, EventArgs e)
        {
            string phone = phoneTextBox.Text.Trim();
            DataGridView dataGrid = appointmentDataGridView;

            // You can set a minimum length if needed before starting the search
            if (phone.Length >= 1)
            {
                appointmentDataBaseQueries.SearchPatient(phone, dataGrid);
            }
            else
            {
                // If the TextBox is empty, load all patients
                appointmentDataBaseQueries.LoadAllAppointmentsInDataGridView(dataGrid);
            }
        }
    }


}