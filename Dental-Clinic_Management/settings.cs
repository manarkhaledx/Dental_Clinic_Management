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
            string currentUsername = passwordTextBox.Text;
            string newUsername = newUsernameTextBox.Text;
            string newPassword = newPasswordTextBox.Text;

            // Update username and password in the Dentist table
            UpdateDentistCredentials(currentUsername, newUsername, newPassword);
        }

        private void UpdateDentistCredentials(string currentUsername, string newUsername, string newPassword)
        {
            using (SqlConnection con = getConnection())
            {
                con.Open();

                // Retrieve the dentist ID based on the current username
                int dentistId = GetDentistIdByUsername(con, currentUsername);

                if (dentistId == -1)
                {
                    MessageBox.Show("Dentist not found. Update failed.");
                    return;
                }

                string updateQuery = "UPDATE Dentist SET username = @newUsername, pass = @newPassword WHERE dentist_id = @dentistId";

                using (SqlCommand cmd = new SqlCommand(updateQuery, con))
                {
                    cmd.Parameters.AddWithValue("@newUsername", newUsername);
                    cmd.Parameters.AddWithValue("@newPassword", newPassword);
                    cmd.Parameters.AddWithValue("@dentistId", dentistId);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Account information updated successfully.");
            }
        }

        private int GetDentistIdByUsername(SqlConnection con, string currentUsername)
        {
            string selectQuery = "SELECT dentist_id FROM Dentist WHERE username = @currentUsername";
            int dentistId = -1;

            using (SqlCommand cmd = new SqlCommand(selectQuery, con))
            {
                cmd.Parameters.AddWithValue("@currentUsername", currentUsername);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        dentistId = reader.GetInt32(0);
                    }
                }
            }

            return dentistId;
        }
    }
}
