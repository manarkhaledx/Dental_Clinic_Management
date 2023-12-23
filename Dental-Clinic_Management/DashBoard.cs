﻿using System;
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
        private const string ConnectionString = "data source=DESKTOP-8JPNOOB\\MSSQLSERVER01;database=Clinic;integrated security=true";
        public recepDashboardForm(int v)
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
                    numOfAppointmentsLabel.Text = "Appointments: " + totalAppointments;

                    //Get the number of patients
                    SqlCommand patientCommand = new SqlCommand(
                         "SELECT COUNT(*) AS TotalPatients " +
                          "FROM [Clinic].[dbo].[Patient];",
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

                    // Log to confirm that the numbers are for the current day
                    Console.WriteLine($"Total Appointments: {totalAppointments}");
                    Console.WriteLine($"Total Patients: {totalPatients}");
                    Console.WriteLine($"Total Billings: {totalBillings}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        public void closeFormChecker()
        {



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

        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            DisplayCounts();
        }

     

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void exitPictureBox_Click(object sender, EventArgs e)
        {
            closeFormChecker();
        }

      
        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }

}

