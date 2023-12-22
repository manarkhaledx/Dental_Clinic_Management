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

                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM appointment WHERE pat_phone=@phone AND app_time=@time AND app_date=@date", con))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            // Clear existing columns (if any)
                            dataGridView.Columns.Clear();

                            // Set AutoGenerateColumns to false
                            dataGridView.AutoGenerateColumns = false;

                            // Manually add columns and map them to DataTable columns
                            DataGridViewTextBoxColumn colPatientID = new DataGridViewTextBoxColumn();
                            colPatientID.Name = "patient_id";
                            colPatientID.DataPropertyName = "patient_id";
                            colPatientID.HeaderText = "Patient ID";
                            colPatientID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            dataGridView.Columns.Add(colPatientID);

                            DataGridViewTextBoxColumn colFname = new DataGridViewTextBoxColumn();
                            colFname.Name = "Fname";
                            colFname.DataPropertyName = "Fname";
                            colFname.HeaderText = "First Name";
                            colFname.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            dataGridView.Columns.Add(colFname);

                            DataGridViewTextBoxColumn colLname = new DataGridViewTextBoxColumn();
                            colLname.Name = "Lname";
                            colLname.DataPropertyName = "Lname";
                            colLname.HeaderText = "Last Name";
                            colLname.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            dataGridView.Columns.Add(colLname);

                            DataGridViewTextBoxColumn colPhone = new DataGridViewTextBoxColumn();
                            colPhone.Name = "Phone";
                            colPhone.DataPropertyName = "Phone";
                            colPhone.HeaderText = "Phone";
                            colPhone.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            dataGridView.Columns.Add(colPhone);

                            DataGridViewTextBoxColumn colPatAddress = new DataGridViewTextBoxColumn();
                            colPatAddress.Name = "pat_address";
                            colPatAddress.DataPropertyName = "pat_address";
                            colPatAddress.HeaderText = "Patient Address";
                            colPatAddress.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            dataGridView.Columns.Add(colPatAddress);

                            DataGridViewTextBoxColumn colGender = new DataGridViewTextBoxColumn();
                            colGender.Name = "gender";
                            colGender.DataPropertyName = "gender";
                            colGender.HeaderText = "Gender";
                            colGender.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            dataGridView.Columns.Add(colGender);

                            DataGridViewTextBoxColumn colDOB = new DataGridViewTextBoxColumn();
                            colDOB.Name = "DOB";
                            colDOB.DataPropertyName = "DOB";
                            colDOB.HeaderText = "Date of Birth";
                            colDOB.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            dataGridView.Columns.Add(colDOB);

                            // Set the DataSource
                            dataGridView.DataSource = dt;
                        }
                    }
                }
            }
        }
    }
}
