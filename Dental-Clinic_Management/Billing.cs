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

        public static void ShowPaymentsInDataGridView(DataGridView dataGridView, DateTime date)
        {
            try
            {
                using (SqlConnection con = getConnection())
                {
                    con.Open();

                    string queryString = "SELECT a.app_id, a.amount, p.Fname + ' ' + p.Lname AS PatientName, p.Phone " +
                                         "FROM Payment a " +
                                         "JOIN Appointment app ON a.app_id = app.app_id " +
                                         "JOIN Patient p ON app.patient_id = p.patient_id " +
                                         "WHERE app.app_date=@date";

                    using (SqlCommand cmd = new SqlCommand(queryString, con))
                    {
                        cmd.Parameters.AddWithValue("@date", date);

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

                            DataGridViewTextBoxColumn amountColumn = new DataGridViewTextBoxColumn();
                            amountColumn.Name = "Amount";
                            amountColumn.DataPropertyName = "amount";
                            amountColumn.HeaderText = "Amount";
                            amountColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            dataGridView.Columns.Add(amountColumn);

                            DataGridViewTextBoxColumn patientName = new DataGridViewTextBoxColumn();
                            patientName.Name = "PatientName";
                            patientName.DataPropertyName = "PatientName";
                            patientName.HeaderText = "Patient Name";
                            patientName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            dataGridView.Columns.Add(patientName);

                            DataGridViewTextBoxColumn patphone = new DataGridViewTextBoxColumn();
                            patphone.Name = "Phone";
                            patphone.DataPropertyName = "Phone";
                            patphone.HeaderText = "Patient Phone";
                            patphone.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            dataGridView.Columns.Add(patphone);

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



        private void filterBillingButton_Click(object sender, EventArgs e)
        {
            DateTime date = billingHistoryDateTimePicker.Value.Date;
            ShowPaymentsInDataGridView(totalBillingsDataGridView,date);
        }
    }
}
