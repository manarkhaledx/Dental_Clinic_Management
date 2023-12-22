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
    public partial class Billing : Form
    {
        SqlCommand cmd;
        SqlDataReader dr;
        protected static SqlConnection getConnection()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-8JPNOOB\\MSSQLSERVER01;database=Clinic;integrated security=true";
            return con;
        }

        public Billing()
        {
            InitializeComponent();
        }

        private void Billing_Load(object sender, EventArgs e)
        {

        }

        private void filterBillingButton_Click(object sender, EventArgs e)
        {
            // Get the selected date from DateTimePicker
            string selectedDate = billingHistoryDateTimePicker.Value.ToString("yyyy-MM-dd");

            // Call the method to filter appointments based on the selected date
            filterBillings(selectedDate);
        }
        private void filterBillings(string selectedDate)
        {
            using (SqlConnection con = getConnection())
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand("SELECT a.app_id, p.patient_id, CONCAT(p.Fname, ' ', p.Lname) AS patient_name, pay.amount " +
                                                      "FROM Appointment a " +
                                                      "INNER JOIN Patient p ON a.patient_id = p.patient_id " +
                                                      "INNER JOIN Payment pay ON a.app_id = pay.app_id " +
                                                      "WHERE CONVERT(date, a.app_date) = @SelectedDate", con))
                {
                    cmd.Parameters.AddWithValue("@SelectedDate", selectedDate);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        // Clear existing columns (if any)
                        totalBillingsDataGridView.Columns.Clear();

                        // Set AutoGenerateColumns to false
                        totalBillingsDataGridView.AutoGenerateColumns = false;

                        // Manually add columns and map them to DataTable columns
                        DataGridViewTextBoxColumn colAppointmentID = new DataGridViewTextBoxColumn();
                        colAppointmentID.Name = "app_id";
                        colAppointmentID.DataPropertyName = "app_id";
                        colAppointmentID.HeaderText = "Appointment ID";
                        colAppointmentID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        totalBillingsDataGridView.Columns.Add(colAppointmentID);

                        DataGridViewTextBoxColumn colPatientID = new DataGridViewTextBoxColumn();
                        colPatientID.Name = "patient_id";
                        colPatientID.DataPropertyName = "patient_id";
                        colPatientID.HeaderText = "Patient ID";
                        colPatientID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        totalBillingsDataGridView.Columns.Add(colPatientID);

                        DataGridViewTextBoxColumn colPatientName = new DataGridViewTextBoxColumn();
                        colPatientName.Name = "patient_name";
                        colPatientName.DataPropertyName = "patient_name";
                        colPatientName.HeaderText = "Patient Name";
                        colPatientName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        totalBillingsDataGridView.Columns.Add(colPatientName);

                        DataGridViewTextBoxColumn colTotalAmount = new DataGridViewTextBoxColumn();
                        colTotalAmount.Name = "amount";
                        colTotalAmount.DataPropertyName = "amount";
                        colTotalAmount.HeaderText = "Total Billing";
                        colTotalAmount.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        totalBillingsDataGridView.Columns.Add(colTotalAmount);

                        // Set the DataSource
                        totalBillingsDataGridView.DataSource = dt;
                    }
                }
            }
        }

        private void closePictureBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void hidePictureBox_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}