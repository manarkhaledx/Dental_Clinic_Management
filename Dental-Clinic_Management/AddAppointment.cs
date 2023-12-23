using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Dental_Clinic_Management
{
    public partial class AddAppointment : Form
    {

        public AddAppointment()
        {
            InitializeComponent();

            // Initialize the SqlConnection object
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "data source =DESKTOP-8JPNOOB\\MSSQLSERVER01 ;database=Clinic;integrated security = true";
        }

        private static int GetPatientIDByPhone(SqlConnection con, string phone)
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

        private void saveNewAppointmentButton_Click(object sender, EventArgs e)
        {
            try
            {
                string phone = phoneTextBox.Text;
                string time = timeTextBox.Text;
                DateTime date = appointmentDateTimePicker.Value;
                if (phoneTextBox.Text != string.Empty && appointmentDateTimePicker.Value != null && timeTextBox.Text != string.Empty)
                {
                    using (SqlConnection con = new SqlConnection("data source=DESKTOP-8JPNOOB\\MSSQLSERVER01;database=Clinic;integrated security=true"))
                    {
                        con.Open();

                        // Retrieve the patientID based on the provided phone number
                        int patientID = GetPatientIDByPhone(con, phoneTextBox.Text);

                        // Check if patientID is valid (greater than 0) before proceeding
                        if (patientID > 0)
                        {
                            // Insert the new appointment using the retrieved patientID
                            using (SqlCommand cmd = new SqlCommand("INSERT INTO appointment (pat_phone, app_time, app_date, patient_id) VALUES (@phone, @time, @date, @patientID)", con))
                            {
                                cmd.Parameters.AddWithValue("@phone", phone);
                                cmd.Parameters.AddWithValue("@time", time);
                                cmd.Parameters.AddWithValue("@date", date);
                                cmd.Parameters.AddWithValue("@patientID", patientID);

                                int rowsAffected = cmd.ExecuteNonQuery();

                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Appointment added successfully.");
                                }
                                else
                                {
                                    MessageBox.Show("Failed to add appointment.");
                                }
                            }
                        }
                        else
                        {
                            // Handle the case where the patientID could not be found
                            MessageBox.Show("Patient not found for the provided phone number.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please enter valid values for phone, time, and date.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void AddAppointment_Load_1(object sender, EventArgs e)
        {

        }
    }
}