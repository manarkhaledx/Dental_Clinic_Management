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
    public partial class Patient : Form
    {
        public Patient()
        {
            InitializeComponent();
        }

        private void Patient_Load(object sender, EventArgs e)
        {

        }




        public static class PatientDataBaseQueries
        {
            private static readonly string ConnectionString = @"data source = DESKTOP-8JPNOOB\MSSQLSERVER01;database=Clinic;integrated security=true";

            public static void AddPatient(string firstName, string lastName, string gender, string phone, string address, DateTime dateOfBirth)
            {
                using (SqlConnection con = new SqlConnection(ConnectionString))
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = con;

                        string patientQuery = "INSERT INTO Patient (Fname, Lname, Phone, pat_address, gender, DOB) " +
                                              "VALUES (@FirstName, @LastName, @Phone, @Address, @Gender, @DOB)";

                        cmd.CommandText = patientQuery;
                        cmd.Parameters.AddWithValue("@FirstName", firstName);
                        cmd.Parameters.AddWithValue("@LastName", lastName);
                        cmd.Parameters.AddWithValue("@Phone", phone);
                        cmd.Parameters.AddWithValue("@Address", address);
                        cmd.Parameters.AddWithValue("@Gender", gender);
                        cmd.Parameters.AddWithValue("@DOB", dateOfBirth);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

    }
}
