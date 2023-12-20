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
        public static class patientDataBaseQueries
        {
            readonly static SqlConnection con = new SqlConnection(@"data source = DESKTOP-8JPNOOB\MSSQLSERVER01;database=Clinic;integrated security = true");
            static SqlCommand cmd;
            readonly static SqlDataReader dr;
            public static void addPatient(string firstName, string lastName,string Gender,string phone,string address,string dateOfBirth)
            {
                cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                string patient = $"insert into Patient (Fname,Lname,Phone,pat_address,gender,DOB) values('{firstName}', '{lastName}','{phone}','{address}','{Gender}','{dateOfBirth}')";
                cmd.CommandText = patient;
                cmd.ExecuteReader();
                con.Close();
            }

        }
    }
}
