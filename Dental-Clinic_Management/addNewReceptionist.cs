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
using System.Text.RegularExpressions;

namespace Dental_Clinic_Management
{
    public partial class addNewReceptionist : Form
    {
        SqlCommand cmd;
        SqlDataReader dr;
        public addNewReceptionist()
        {
            InitializeComponent();
        }
        protected SqlConnection getConnection()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = MARK;database=Clinic;integrated security = true";
            return con;
        }

        private void addNewReceptionist_Load(object sender, EventArgs e)
        {

        }

        private void signUpReceptiontistLabel_Click(object sender, EventArgs e)
        {

        }

        private void recepFNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void recepLNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void receptPhoneTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void recepAddressTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void recepDobDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void recepFemaleRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void recepMaleRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void recepGenderGroupBox_Enter(object sender, EventArgs e)
        {

        }

        public bool hasSpecialCharacter(string password)
        {
            // Define the regular expression pattern to match special characters
            string pattern = @"[^a-zA-Z0-9]";

            // Create a regular expression object
            Regex regex = new Regex(pattern);

            // Check if the password contains at least one special character
            return regex.IsMatch(password);
        }

       

        private void ClearReceptionistFields()
        {
            // Clear all receptionist-related fields
            recepFNameTextBox.Text = "";
            recepLNameTextBox.Text = "";
            receptPhoneTextBox.Text = "";
            recepFemaleRadioButton.Checked = false;
            recepMaleRadioButton.Checked = false;
            recepDobDateTimePicker.Value = DateTime.Now;
            recepAddressTextBox.Text = "";
            tb_username.Text = "";
            tb_password.Text = "";
            tb_Confirmpassword.Text = "";
        }

        private void fristNameEnter(object sender, EventArgs e)
        {
            //Event
            if (recepFNameTextBox.Text == "FristName")
            {
                recepFNameTextBox.Text = "";
            }
        }

        private void fristNameLeave(object sender, EventArgs e)
        {
            if (recepFNameTextBox.Text == "")
            {
                recepFNameTextBox.Text = "FristName";
            }
        }
        private void lastNameEnter(object sender, EventArgs e)
        {
            //Event
            if (recepLNameTextBox.Text == "Frist Name")
            {
                recepLNameTextBox.Text = "";
            }
        }

        private void lastNameLeave(object sender, EventArgs e)
        {
            if (recepLNameTextBox.Text == "")
            {
                recepLNameTextBox.Text = "Frist Name";
            }
        }

        private void addressEnter(object sender, EventArgs e)
        {
            if (recepAddressTextBox.Text == "Address")
            {
                recepAddressTextBox.Text = "";
            }
        }

        private void addressLeave(object sender, EventArgs e)
        {
            if (recepAddressTextBox.Text == "")
            {
                recepAddressTextBox.Text = "Address";
            }
        }

        private void phoneEnter(object sender, EventArgs e)
        {
            if (receptPhoneTextBox.Text == "Phone")
            {
                receptPhoneTextBox.Text = "";
            }
        }

        private void phoneLeave(object sender, EventArgs e)
        {
            if (receptPhoneTextBox.Text == "")
            {
                receptPhoneTextBox.Text = "Phone";
            }
        }
        private void passwordEnter(object sender, EventArgs e)
        {
            if (tb_password.Text == "Password")
            {
                tb_password.Text = "";

            }
        }

        private void passwordLeave(object sender, EventArgs e)
        {
            if (tb_password.Text == "")
            {
                tb_password.Text = "Password";

            }
        }

        private void confirmPasswordEnter(object sender, EventArgs e)
        {
            if (tb_Confirmpassword.Text == "ConfirmPassword")
            {
                tb_Confirmpassword.Text = "";

            }
        }

        private void confirmPasswordLeave(object sender, EventArgs e)
        {
            if (tb_Confirmpassword.Text == "")
            {
                tb_Confirmpassword.Text = "ConfirmPassword";

            }
        }


        private void tb_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_Confirmpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveReceptionistButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (recepFNameTextBox.Text != string.Empty || recepLNameTextBox.Text != string.Empty || receptPhoneTextBox.Text != string.Empty
                    || (recepFemaleRadioButton.Checked || recepMaleRadioButton.Checked) || recepDobDateTimePicker.Value != null || recepAddressTextBox.Text != string.Empty
                    || tb_username.Text != string.Empty || tb_password.Text != string.Empty)
                {
                    if (tb_password.Text == tb_Confirmpassword.Text)
                    {
                        if (tb_password.Text.Length >= 8 && hasSpecialCharacter(tb_password.Text))
                        {
                            using (SqlConnection con = getConnection())
                            {
                                con.Open();

                                using (SqlCommand cmd = new SqlCommand("SELECT * FROM Receptionist WHERE username=@username", con))
                                {
                                    cmd.Parameters.AddWithValue("username", tb_username.Text);

                                    using (SqlDataReader dr = cmd.ExecuteReader())
                                    {
                                        if (dr.Read())
                                        {
                                            MessageBox.Show("Username already exists. Please try another.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            ClearReceptionistFields();
                                        }
                                        else
                                        {
                                            dr.Close();

                                            using (SqlCommand insertCmd = new SqlCommand("INSERT INTO Receptionist (Fname, Lname, Phone, gender, DOB, recep_address, username, pass) " +
                                                "VALUES (@Fname, @Lname, @Phone, @gender, @DOB, @recep_address, @username, @password)", con))
                                            {
                                                insertCmd.Parameters.AddWithValue("Fname", recepFNameTextBox.Text);
                                                insertCmd.Parameters.AddWithValue("Lname", recepLNameTextBox.Text);
                                                insertCmd.Parameters.AddWithValue("Phone", receptPhoneTextBox.Text);
                                                insertCmd.Parameters.AddWithValue("gender", recepFemaleRadioButton.Checked ? "Female" : "Male");
                                                insertCmd.Parameters.AddWithValue("DOB", recepDobDateTimePicker.Value);
                                                insertCmd.Parameters.AddWithValue("recep_address", recepAddressTextBox.Text);
                                                insertCmd.Parameters.AddWithValue("username", tb_username.Text);
                                                insertCmd.Parameters.AddWithValue("password", tb_password.Text);

                                                insertCmd.ExecuteNonQuery();

                                                MessageBox.Show("Receptionist account created successfully.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                this.Hide();
                                                ViewReceptionist rec = new ViewReceptionist();
                                                rec.ShowDialog();

                                                return;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Password must be at least 8 characters long and contain at least one special character.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            ClearReceptionistFields();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter the same password in both fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ClearReceptionistFields();
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a value in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearReceptionistFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void closePictureBox_Click(object sender, EventArgs e)
        {
            closeFormChecker();
        }
        public void closeFormChecker()
        {
            // message to check whether the user wants to close the app or not
            DialogResult result = MessageBox.Show("Are you Sure you want to close the app", "Quit",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }


        }
    }
}

