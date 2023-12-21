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
        SqlCommand cmd;
        SqlDataReader dr;
        protected static SqlConnection getConnection()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-8JPNOOB\\MSSQLSERVER01;database=Clinic;integrated security=true";
            return con;
        }
        public Patient()
        {
            InitializeComponent();
        }

        private void Patient_Load(object sender, EventArgs e)
        {

        }
        public static class patientDataBaseQueries
        {
            public static void addPatient(string fname,string lname,string phone,RadioButton rad, DateTime Date, string address){
                using (SqlConnection con = getConnection())
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM Patient WHERE Fname=@Fname AND Lname=@Lname AND Phone=@Phone", con))
                    {
                        cmd.Parameters.AddWithValue("Fname", fname);
                        cmd.Parameters.AddWithValue("Lname", lname);
                        cmd.Parameters.AddWithValue("Phone", phone);

                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                MessageBox.Show("Patient already exists. Please try another.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                            else
                            {
                                dr.Close();

                                using (SqlCommand insertCmd = new SqlCommand("INSERT INTO Patient (Fname, Lname, Phone, gender, DOB, pat_address) " +
                                    "VALUES (@Fname, @Lname, @Phone, @gender, @DOB, @pat_address)", con))
                                {
                                    insertCmd.Parameters.AddWithValue("Fname", fname);
                                    insertCmd.Parameters.AddWithValue("Lname", lname);
                                    insertCmd.Parameters.AddWithValue("Phone", phone);
                                    insertCmd.Parameters.AddWithValue("gender",  rad.Checked? "Female" : "Male");
                                    insertCmd.Parameters.AddWithValue("DOB", Date);
                                    insertCmd.Parameters.AddWithValue("pat_address", address);

                                    insertCmd.ExecuteNonQuery();

                                    MessageBox.Show("Patient information added successfully.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    // Optionally, you may navigate to another form or perform additional actions here.
                                    //
                                    return;
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
