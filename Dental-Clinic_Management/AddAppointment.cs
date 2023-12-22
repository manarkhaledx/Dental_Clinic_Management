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
        SqlConnection conn; // Assuming that you have a SqlConnection object as a class-level field

        public AddAppointment()
        {
            InitializeComponent();

            // Initialize the SqlConnection object
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "data source =DESKTOP-8JPNOOB\\MSSQLSERVER01 ;database=Clinic;integrated security = true";
        }

        private void AddAppointment_Load(object sender, EventArgs e)
        {
            
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
                            using (SqlCommand cmd = new SqlCommand("INSERT INTO appointment (pat_phone, app_time, app_date, patientID) VALUES (@phone, @time, @date, @patientID)", con))
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

            /*try
            {
                if (phoneTextBox.Text != string.Empty || appointmentDateTimePicker.Value != null || timeTextBox.Text != string.Empty)
                {
                    int patientId = GetPatientIdByPhoneNumber(phoneTextBox.Text);

                    if (patientId != -1)
                    {
                        SqlConnection conn = new SqlConnection();
                        conn.ConnectionString = "data source=DESKTOP-8JPNOOB\\MSSQLSERVER01;database=Clinic;integrated security=true";
                        conn.Open();

                        // Check if the patient exists before inserting the appointment
                        if (IsPatientExists(patientId, conn))
                        {
                            SqlCommand cmd = new SqlCommand("INSERT INTO Appointment " +
                                                           "(patient_id, pat_phone, app_time, app_date) " +
                                                           "VALUES (@patient_id, @pat_phone, @app_time, @app_date)", conn);

                            cmd.Parameters.AddWithValue("@patient_id", patientId);
                            cmd.Parameters.AddWithValue("@pat_phone", phoneTextBox.Text);
                            cmd.Parameters.AddWithValue("@app_time", timeTextBox.Text);
                            cmd.Parameters.AddWithValue("@app_date", appointmentDateTimePicker.Value);

                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Appointment saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Patient not found. Please check the phone number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        conn.Close();
                    }
                    else
                    {
                        MessageBox.Show("Patient not found. Please check the phone number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a value in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }

        private static int GetPatientIDByPhone(SqlConnection con, string phone)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand("SELECT pat_id FROM patient WHERE pat_phone=@phone", con))
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

        private int GetPatientIdByPhoneNumber(string phoneNumber)
        {
            int patientId = -1;

            using (SqlConnection conn = new SqlConnection("data source=DESKTOP-8JPNOOB\\MSSQLSERVER01;database=Clinic;integrated security=true"))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("SELECT patient_id FROM Patient WHERE pat_phone = @pat_phone", conn))
                {
                    cmd.Parameters.AddWithValue("@pat_phone", phoneNumber);

                    object result = cmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        patientId = Convert.ToInt32(result);
                    }
                }
            }

            return patientId;
        }

        private bool IsPatientExists(int patientId, SqlConnection conn)
        {
            using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Patient WHERE patient_id = @patient_id", conn))
            {
                cmd.Parameters.AddWithValue("@patient_id", patientId);

                int count = (int)cmd.ExecuteScalar();

                return count > 0;
            }
        }
    }
}