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
    public partial class Login : Form
    {
        SqlCommand cmd;
        SqlDataReader dr;
        public Login()
        {
            InitializeComponent();
        }

        protected SqlConnection getConnection()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source =DESKTOP-8JPNOOB\\MSSQLSERVER01 ;database=Clinic;integrated security = true";
            return con;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (passwordTextBox.UseSystemPasswordChar == true)
            {
                passwordTextBox.UseSystemPasswordChar = false;
                viewPasswordPictureBox.Image = Properties.Resources.visibleEyeIcon;
            }
            else
            {
                passwordTextBox.UseSystemPasswordChar = true;
                viewPasswordPictureBox.Image = Properties.Resources.hiddenEyeIcon;
            }
            //end
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordLabel_Click(object sender, EventArgs e)
        {

        }

        private void usernameLabel_Click(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            // Check if both username and password fields are not empty
            if (!string.IsNullOrEmpty(passwordTextBox.Text) && !string.IsNullOrEmpty(usernameTextBox.Text))
            {
                try
                {
                    // Establish a connection to the SQL Server database
                    using (SqlConnection con = getConnection())
                    {
                        con.Open();

                        // Check if the user is a dentist
                        using (SqlCommand cmd = new SqlCommand("SELECT * FROM [Clinic].[dbo].[Dentist] WHERE username=@username", con))
                        {
                            // Set parameters for the SQL query
                            cmd.Parameters.AddWithValue("@username", usernameTextBox.Text);

                            // Execute the query and check if a record is found
                            using (SqlDataReader dr = cmd.ExecuteReader())
                            {
                                if (dr.Read())
                                {
                                    // If a dentist is found, check the password
                                    if (passwordTextBox.Text.Equals(dr["pass"].ToString()))
                                    {
                                        // If password is correct, hide the current form and show the dentist dashboard
                                        this.Hide();
                                        dentistDashboardForm DentistForm = new dentistDashboardForm();
                                        DentistForm.ShowDialog();
                                        return;
                                    }
                                    else
                                    {
                                        MessageBox.Show("Incorrect password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return;
                                    }
                                }
                            }
                        }

                        // Check if the user is a receptionist
                        using (SqlCommand cmd = new SqlCommand("SELECT * FROM [Clinic].[dbo].[Receptionist] WHERE username=@username", con))
                        {
                            // Set parameters for the SQL query
                            cmd.Parameters.AddWithValue("@username", usernameTextBox.Text);

                            // Execute the query and check if a record is found
                            using (SqlDataReader dr = cmd.ExecuteReader())
                            {
                                if (dr.Read())
                                {
                                    // If a receptionist is found, check the password
                                    if (passwordTextBox.Text.Equals(dr["pass"].ToString()))
                                    {
                                        // If password is correct, hide the current form and show the receptionist dashboard
                                        this.Hide();
                                        recepDashboardForm receptionistForm = new recepDashboardForm();
                                        receptionistForm.ShowDialog();
                                        return;
                                    }
                                    else
                                    {
                                        MessageBox.Show("Incorrect password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return;
                                    }
                                }
                            }
                        }

                        // If neither Dentist nor Receptionist is found, show an error message
                        MessageBox.Show("No account available with this username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    // Handle exceptions and show an error message
                    MessageBox.Show("An error occurred while executing the query: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // If username or password is empty, show an error message
                MessageBox.Show("Please enter a value in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





        private void exitButton_Click_1(object sender, EventArgs e)
        {

        }

        private void Login_Load_1(object sender, EventArgs e)
        {

        }
    }
}