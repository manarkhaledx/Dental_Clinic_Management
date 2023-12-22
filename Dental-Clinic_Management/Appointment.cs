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

                    using (SqlCommand cmd = new SqlCommand("SELECT a.appoitment_id, (p.Fname + ' ' + p.Lname) AS PatientName, a.pat_phone, a.app_time, a.app_date FROM appointment a JOIN Patient p ON a.patient_id = p.pat_id WHERE a.pat_phone LIKE @Phone", con))
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
                            colAppointmentID.DataPropertyName = "appoitment_id";
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
                //appointmentDataBaseQueries.loadAllPatientsInDataGridView(dataGrid);
            }
        }


        private void appointmentDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == appointmentDataGridView.Columns["Delete"].Index)
            {
                // Get the appointment ID from the selected row
                int appointmentID = Convert.ToInt32(appointmentDataGridView.Rows[e.RowIndex].Cells["AppointmentID"].Value);

                // Call the method to delete the appointment
                DeleteAppointment(appointmentID);

                // Refresh the DataGridView after deletion
                string phone = phoneTextBox.Text.Trim();
                DataGridView dataGrid = appointmentDataGridView;
                appointmentDataBaseQueries.SearchPatient(phone, dataGrid);
            }
        }

        // Add this method to delete the appointment
        private void DeleteAppointment(int appointmentID)
        {
            using (SqlConnection con = getConnection())
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand("DELETE FROM appointment WHERE appoitment_id = @AppointmentID", con))
                {
                    cmd.Parameters.AddWithValue("@AppointmentID", appointmentID);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        private void appointmentDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == appointmentDataGridView.Columns["Delete"].Index)
                {
                    // Get the appointment ID from the selected row
                    int appointmentID = Convert.ToInt32(appointmentDataGridView.Rows[e.RowIndex].Cells["AppointmentID"].Value);

                    // Call the method to delete the appointment
                    DeleteAppointment(appointmentID);

                    // Refresh the DataGridView after deletion
                    string phone = phoneTextBox.Text.Trim();
                    DataGridView dataGrid = appointmentDataGridView;
                    appointmentDataBaseQueries.SearchPatient(phone, dataGrid);
                }
                else if (e.ColumnIndex == appointmentDataGridView.Columns["Edit"].Index)
                {
                    // Get the appointment ID from the selected row
                    int appointmentID = Convert.ToInt32(appointmentDataGridView.Rows[e.RowIndex].Cells["AppointmentID"].Value);

                    // Call the method to edit the appointment
                    EditAppointment(appointmentID);

                    // Refresh the DataGridView after editing
                    string phone = phoneTextBox.Text.Trim();
                    DataGridView dataGrid = appointmentDataGridView;
                    appointmentDataBaseQueries.SearchPatient(phone, dataGrid);
                }
            }
        }

        // Add this method to edit the appointment
        private void EditAppointment(int appointmentID)
        {
            // You can open a new form for editing or handle it within the current form
            // For simplicity, let's assume you have a form called EditAppointmentForm
            using (Appointment editForm = new  Appointment(appointmentID))
            {
                // Show the edit form
                editForm.ShowDialog();
            }
        }
    }


}
