using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dental_Clinic_Management
{
    public partial class recepDashboardForm : Form
    {
        private const string ConnectionString = "data source=MARK;database=Clinic;integrated security=true";
        public recepDashboardForm()
        {
            InitializeComponent();
            DisplayCounts();
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
                    numOfAppointmentsLabel.Text = "Appointments: " + totalAppointments;

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

                    // Log to confirm that the numbers are for the current day
                    Console.WriteLine($"Total Appointments: {totalAppointments}");
                   
                    Console.WriteLine($"Total Billings: {totalBillings}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
       

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

      

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

    

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Patient pat = new Patient();
            pat.ShowDialog();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            DisplayCounts();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Appointment app = new Appointment();
            app.ShowDialog();
        }

        private void exitPictureBox_Click(object sender, EventArgs e)
        {
           
        }

      
        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void dashboardButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            recepDashboardForm rec = new recepDashboardForm();
            rec.ShowDialog();
        }

        private void totalBillingsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            closeFormChecker();
        }
    }

}

