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
using static Dental_Clinic_Management.Patient;
using static Dental_Clinic_Management.ViewReceptionist;

namespace Dental_Clinic_Management
{
    public partial class EditReceptionist : Form
    {
      
        private int receptionistID;
        public EditReceptionist(int receptionistID, string fname, string lname, string phone, string gender, DateTime dob, string address)
        {
            InitializeComponent();
            this.receptionistID = receptionistID;
            recepFNameTextBox.Text = fname;
            recepLNameTextBox.Text = lname;
            receptPhoneTextBox.Text = phone;
            recepFemaleRadioButton.Checked = gender.Equals("Female", StringComparison.OrdinalIgnoreCase);
            recepMaleRadioButton.Checked = gender.Equals("Male", StringComparison.OrdinalIgnoreCase);
            recepDobDateTimePicker.Value = dob;
            recepAddressTextBox.Text = address;
            RetrieveUsernameAndPasswordFromDatabase();
        }

        private void RetrieveUsernameAndPasswordFromDatabase()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("data source = MARK;database=Clinic;integrated security=true"))
                {
                    connection.Open();

                    // Assume Receptionists table has columns: RecepID, UserName, Password
                    string query = "SELECT username, pass FROM Receptionist WHERE recep_id = @recep_id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Adjust this based on how you uniquely identify the receptionist
                        // If it's based on RecepID, use that; otherwise, adjust accordingly
                        command.Parameters.AddWithValue("@recep_id", receptionistID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Assuming you have columns named UserName and Password in your database
                                string userName = reader["username"].ToString();
                                string password = reader["pass"].ToString();

                                // Use the retrieved values as needed
                                // Example: display in textboxes
                                tb_username.Text = userName;
                                tb_password.Text = password;
                                tb_Confirmpassword.Text = password;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving data from the database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

    

        private void saveReceptionistButton_Click(object sender, EventArgs e)
        {
            try
            {
                string fname = recepFNameTextBox.Text;
                string lname = recepLNameTextBox.Text;
                string phone = receptPhoneTextBox.Text;
                string gender = recepFemaleRadioButton.Checked ? "Female" : "Male";
                DateTime dob = recepDobDateTimePicker.Value;
                string address = recepAddressTextBox.Text;
                string userName = tb_username.Text;
                string password = tb_password.Text;

                if (phone.Length == 11 && int.TryParse(phone, out _))
                {
                    // Call the method to edit patient information
                    receptionistDataBaseQueries.EditReceptionist(receptionistID, userName, fname, lname, phone, address, password, dob, recepFemaleRadioButton);
                    MessageBox.Show("Receptionist information updated successfully.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    ViewReceptionist ob = new ViewReceptionist();
                    ob.ShowDialog();
                    // Optionally, you may navigate to another form or perform additional actions here.
                }
                else
                {
                    MessageBox.Show("Please enter a valid 11-digit phone number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
