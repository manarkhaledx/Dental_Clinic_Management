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
    public partial class showAppointmentsOfTheDayForm : Form
    {
        SqlCommand cmd;
        SqlDataReader dr;
        protected static SqlConnection getConnection()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-8JPNOOB\\MSSQLSERVER01;database=Clinic;integrated security=true";
            return con;
        }
        public showAppointmentsOfTheDayForm()
        {
            InitializeComponent();
        }

        public static void ShowAppointmentsInDataGridView(DataGridView dataGridView, DateTime dateOfTheDay)
        {
            try
            {
                using (SqlConnection con = getConnection())
                {
                    con.Open();

                    string queryString = "SELECT a.app_id, p.Fname + ' ' + p.Lname AS PatientName, a.pat_phone FROM appointment a JOIN Patient p ON a.patient_id = p.patient_id WHERE a.app_date=@dateOfTheDay";

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

        public static int GetPatientIDByPhone(SqlConnection con, string phone)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("SELECT patient_id FROM patient WHERE Phone=@phone", con))
                {
                    cmd.Parameters.AddWithValue("@phone", phone);

                    // ExecuteScalar is used to retrieve a single value from the query result
                    object result = cmd.ExecuteScalar();

                    // Check if a result was found
                    if (result != null)
                    {
                        // Convert the result to an integer (patientID)
                        return Convert.ToInt32(result);
                    }
                    else
                    {
                        // Return 0 if no matching patientID was found
                        return 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
                return 0;
            }
        }

        private void showAppointmentsOfTheDayForm_Load(object sender, EventArgs e)
        {
            try
            {
                DateTime dateOfTheDay = DateTime.Now;
                ShowAppointmentsInDataGridView(appointmentDataGridView, dateOfTheDay);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void appointmentDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dashboardButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            dentistDashboardForm den=new dentistDashboardForm();
            den.ShowDialog();
        }

        private void prescriptionButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewReceptionist recep = new ViewReceptionist();
            recep.ShowDialog();
        }

        private void billingsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Billing bill = new Billing();
            bill.ShowDialog();
        }

        private void appointmentsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            showAppointmentsOfTheDayForm app = new showAppointmentsOfTheDayForm();
            app.ShowDialog();
        }
    }
}