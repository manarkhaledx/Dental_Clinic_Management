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
    public partial class addPrescriptionForm : Form
    {
        SqlCommand cmd;
        SqlDataReader dr;
        public addPrescriptionForm()
        {
            InitializeComponent();
        }
        protected SqlConnection getConnection()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = MARK;database=Pharmacy;integrated security = true";
            return con;
        }

        private void prescriptionTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void savePrescriptionButton_Click(object sender, EventArgs e)
        {
            // Get the prescription text from the TextBox
            string prescriptionText = prescriptionTextBox.Text;

            // Check if the text is not empty
            if (!string.IsNullOrEmpty(prescriptionText))
            {
                // Create a new SqlConnection
                using (SqlConnection con = getConnection())
                {
                    try
                    {
                        con.Open();

                        // Use parameterized query to avoid SQL injection
                        string query = "INSERT INTO [Clinic].[dbo].[Prescription] ([Pres_text]) VALUES (@PrescriptionText)";

                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            // Add parameter
                            cmd.Parameters.AddWithValue("@PrescriptionText", prescriptionText);

                            // Execute the query
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Prescription saved successfully.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a prescription before saving.");
            }
        }

        private void addPrescriptionForm_Load(object sender, EventArgs e)
        {

        }
    }
}
