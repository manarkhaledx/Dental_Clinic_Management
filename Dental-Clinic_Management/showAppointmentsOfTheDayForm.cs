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

        public static class appointmentDataBaseQueries
        {
            public static void addappointment(string phone, string time, DateTime date, int patientID)
            {
                using (SqlConnection con = getConnection())
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM appointment WHERE pat_phone=@phone AND app_time=@time AND app_date=@date", con))
                    {
                        cmd.Parameters.AddWithValue("pat_phone", phone);
                        cmd.Parameters.AddWithValue("app_time", time);
                        cmd.Parameters.AddWithValue("app_date", date);

                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            
                            
                        }
                    }
                }
            }

            public static void ShowAppointmentsInDataGridView(DataGridView dataGridView,DateTime dateOfTheDay)
            {
                using (SqlConnection con = getConnection())
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM appointment WHERE app_date=@dateOfTheDay", con))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            // Clear existing columns (if any)
                            dataGridView.Columns.Clear();

                            // Set AutoGenerateColumns to false
                            dataGridView.AutoGenerateColumns = false;
                            DataGridViewTextBoxColumn appointmentID = new DataGridViewTextBoxColumn();
                            appointmentID.Name = "appointment_id";
                            appointmentID.DataPropertyName = "appointment_id";
                            appointmentID.HeaderText = "Appointment ID";
                            appointmentID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            dataGridView.Columns.Add(appointmentID);

                            // Manually add columns and map them to DataTable columns
                            DataGridViewTextBoxColumn patphone = new DataGridViewTextBoxColumn();
                            patphone.Name = "pat_phone";
                            patphone.DataPropertyName = "pat_phone";
                            patphone.HeaderText = "Patient Phone";
                            patphone.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            dataGridView.Columns.Add(patphone);
]
                            // Set the DataSource
                            dataGridView.DataSource = dt;
                        }
                    }
                }
            }
        }
    }
}
