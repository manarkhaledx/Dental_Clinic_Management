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
using static Dental_Clinic_Management.Patient;

namespace Dental_Clinic_Management
{
    public partial class AddRecordForm : Form

    {
        SqlCommand cmd;
        SqlDataReader dr;
        public AddRecordForm()
        {
            InitializeComponent();

        }
        protected SqlConnection getConnection()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-8JPNOOB\\MSSQLSERVER01;database=Clinic;integrated security=true";
            return con;
        }



        private void AddRecordForm_Load(object sender, EventArgs e)  //make the form always appear in the right side & centered 
        {
            // Calculate the X-coordinate to position the form on the right side
            int x = Screen.PrimaryScreen.WorkingArea.Width - this.Width;

            // Calculate the Y-coordinate to center the form vertically
            int y = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;

            // Set the form's location
            this.Location = new System.Drawing.Point(x, y);
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                // Set the shadow color to light gray
                cp.ClassStyle |= 0x20000; // CS_DROPSHADOW
                return cp;
            }
        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private string GetSelectedRadioButtonValue()
        {
            // Iterate through radio buttons to find the selected one
            foreach (RadioButton radioButton in genderGroupBox.Controls)
            {
                if (radioButton.Checked)
                {
                    return radioButton.Text; // You can change this based on your scenario
                }
            }

            return null; // No radio button selected
        }

        private void savePatientButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (firstNameTextBox.Text != string.Empty || lastNameTextBox.Text != string.Empty || phoneTextBox.Text != string.Empty
                    || (femaleRadioButton.Checked || maleRadioButton.Checked) || dobDateTimePicker.Value != null || addressTextBox.Text != string.Empty)
                {


                    using (SqlConnection con = getConnection())
                    {
                        con.Open();

                        // Check if phone already exists in patient table
                        using (SqlCommand patientCmd = new SqlCommand("SELECT * FROM Patient WHERE Phone=@Phone", con))
                        {


                            using (SqlDataReader patientDr = patientCmd.ExecuteReader())
                            {
                                if (patientDr.Read())
                                {
                                    MessageBox.Show("Phone number already exists. Please try another.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                    return;
                                }
                            }
                        }


                        // If username is unique, proceed to insert into Receptionist table
                        using (SqlCommand insertCmd = new SqlCommand("INSERT INTO Patient (Fname, Lname, Phone, pat_address, gender, DOB) " +
                            "VALUES (@Fname, @Lname, @Phone, @pat_address, @gender, @DOB)", con))
                        {
                            insertCmd.Parameters.AddWithValue("Fname", firstNameTextBox.Text);
                            insertCmd.Parameters.AddWithValue("Lname", lastNameTextBox.Text);
                            insertCmd.Parameters.AddWithValue("Phone", phoneTextBox.Text);
                            insertCmd.Parameters.AddWithValue("gender", femaleRadioButton.Checked ? "Female" : "Male");
                            insertCmd.Parameters.AddWithValue("DOB", dobDateTimePicker.Value);
                            insertCmd.Parameters.AddWithValue("recep_address", addressTextBox.Text);


                            insertCmd.ExecuteNonQuery();

                            MessageBox.Show("patient added  successfully.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            Login loginForm = new Login();
                            loginForm.ShowDialog();
                            return;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a value in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }

            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}