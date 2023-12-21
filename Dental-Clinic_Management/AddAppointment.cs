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
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "data source =DESKTOP-8JPNOOB\\MSSQLSERVER01 ;database=Clinic;integrated security = true";
            conn.Open();

            // Assuming you have TextBox controls named txtSupplierId, txtName, txtContactPerson,
            // txtPhoneNumber, txtTime, and txtDate
            SqlCommand cmd = new SqlCommand("INSERT INTO Appointment " +
                                           "( pat_phone,app_time, app_date) " +
                                           "VALUES (@pat_phone, @app_time, @app_date)", conn);

            cmd.Parameters.AddWithValue("@pat_phone", phoneTextBox.Text);
            cmd.Parameters.AddWithValue("@app_time", timeTextBox.Text);
            cmd.Parameters.AddWithValue("@app_date", appointmentDateTimePicker.Value);


            cmd.ExecuteNonQuery();

            // Don't forget to close the connection when done
            conn.Close();
        }
    }
}