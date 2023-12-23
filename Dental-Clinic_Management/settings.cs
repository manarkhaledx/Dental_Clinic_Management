using System.Data.SqlClient;
using System.Windows.Forms;
using System;

namespace Dental_Clinic_Management
{
    public partial class settings : Form
    {
        SqlCommand cmd;
        SqlDataReader dr;

        protected static SqlConnection getConnection()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-8JPNOOB\\MSSQLSERVER01;database=Clinic;integrated security=true";
            return con;
        }

        public settings()
        {
            InitializeComponent();
        }

        private void settings_Load(object sender, EventArgs e)
        {
            // Initialize your form or perform any necessary setup here
        }

        private void saveAccountButton_Click(object sender, EventArgs e)
        {
            // Get values from textboxes
            string currentPassword = passwordTextBox.Text;
            string newUsername = newUsernameTextBox.Text;
            string newPassword = newPasswordTextBox.Text;

            // Validate current password (you may need to adjust this part based on your authentication mechanism)
            if (!IsValidCurrentPassword(currentPassword))
            {
                MessageBox.Show("Invalid current password. Please try again.");
                return;
            }

            // Update username and password in the Dentist table
            UpdateDentistCredentials(newUsername, newPassword);

            MessageBox.Show("Account information updated successfully.");
        }

        private bool IsValidCurrentPassword(string currentPassword)
        {
            // Implement your logic to validate the current password
            // You may need to query the database to check if the current password is correct
            // For security reasons, consider using hashing for password storage and comparison
            // Return true if the current password is valid, otherwise return false
            // Example: return CheckIfCurrentPasswordIsValid(currentPassword);
            return true; // Replace this with your actual validation logic
        }

        private void UpdateDentistCredentials(string newUsername, string newPassword)
        {
            using (SqlConnection con = getConnection())
            {
                con.Open();
                string updateQuery = "UPDATE Dentist SET username = @newUsername, pass = @newPassword WHERE /* Add your condition, e.g., dentist_id = @dentistId */";

                using (SqlCommand cmd = new SqlCommand(updateQuery, con))
                {
                    cmd.Parameters.AddWithValue("@newUsername", newUsername);
                    cmd.Parameters.AddWithValue("@newPassword", newPassword);
                    // Add condition parameter, e.g., cmd.Parameters.AddWithValue("@dentistId", dentistId);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
