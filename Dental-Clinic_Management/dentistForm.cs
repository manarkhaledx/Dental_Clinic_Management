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
    public partial class dentistDashboardForm : Form
    {
        private const string ConnectionString = "data source=DESKTOP-8JPNOOB\\MSSQLSERVER01;database=Clinic;integrated security=true";
        public dentistDashboardForm(int v)
        {
            InitializeComponent();
            DisplayCounts();
        }
        private void DisplayCounts()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    // Get the number of appointments
                    SqlCommand appointmentCommand = new SqlCommand(
                        "SELECT COUNT(*) AS TotalAppointments " +
                        "FROM [Clinic].[dbo].[Appointment] " +
                        "WHERE CONVERT(DATE, [app_date]) = CONVERT(DATE, GETDATE());",
                        connection);

                    int totalAppointments = (int)appointmentCommand.ExecuteScalar();
                    numOfAppointmentLabel.Text = "Appointments: " + totalAppointments;

                    // Get the number of patients
                    SqlCommand patientCommand = new SqlCommand(
                        "SELECT COUNT(*) AS TotalPatients " +
                        "FROM [Clinic].[dbo].[Patient] " +
                        "WHERE [patient_id] IN (" +
                        "   SELECT DISTINCT [patient_id] " +
                        "   FROM [Clinic].[dbo].[Appointment] " +
                        "   WHERE CONVERT(DATE, [app_date]) = CONVERT(DATE, GETDATE())" +
                        ");",
                        connection);

                    int totalPatients = (int)patientCommand.ExecuteScalar();
                    numOfPatientsLabel.Text = "Patients: " + totalPatients;

                    // Get the number of billings
                    SqlCommand billingCommand = new SqlCommand(
                        "SELECT COUNT(*) AS TotalBillings " +
                        "FROM [Clinic].[dbo].[Payment] " +
                        "WHERE [app_id] IN (" +
                        "   SELECT [app_id] " +
                        "   FROM [Clinic].[dbo].[Appointment] " +
                        "   WHERE CONVERT(DATE, [app_date]) = CONVERT(DATE, GETDATE())" +
                        ");",
                        connection);

                    int totalBillings = (int)billingCommand.ExecuteScalar();
                    numOfTotalBillingsLabel.Text = "Billings: " + totalBillings;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }
    }
}
