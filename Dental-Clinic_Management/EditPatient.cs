using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Dental_Clinic_Management.Patient;

namespace Dental_Clinic_Management
{
    public partial class EditPatinet : Form
    {

        public EditPatinet(string fname, string lname, string phone, string gender, DateTime dob, string address)
        {
            InitializeComponent();
            firstNameTextBox.Text = fname;
            lastNameTextBox.Text = lname;
            phoneTextBox.Text = phone;
            femaleRadioButton.Checked = gender.Equals("Female", StringComparison.OrdinalIgnoreCase);
            maleRadioButton.Checked = gender.Equals("Male", StringComparison.OrdinalIgnoreCase);
            dobDateTimePicker.Value = dob;
            addressTextBox.Text = address;

        }

        private void savePatientButton_Click(object sender, EventArgs e)
        {
            try
            {
                string fname = firstNameTextBox.Text;
                string lname = lastNameTextBox.Text;
                string phone = phoneTextBox.Text;
                string gender = femaleRadioButton.Checked ? "Female" : "Male";
                DateTime dob = dobDateTimePicker.Value;
                string address = addressTextBox.Text;

                // Validate phone number input
                if (phone.Length == 11 && int.TryParse(phone, out _))
                {
                    // Call the method to edit patient information
                    patientDataBaseQueries.EditPatient(phone, fname, lname, phone, address, dob, femaleRadioButton);
                    MessageBox.Show("Patient information updated successfully.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Patient ob = new Patient();
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

        private void dobLabel_Click(object sender, EventArgs e)
        {

        }

        private void patientRecordLabel_Click(object sender, EventArgs e)
        {

        }

        private void dobDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void firstNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addressTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void phoneTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void closePictureBox_Click(object sender, EventArgs e)
        {

        }

        private void lastNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void genderGroupBox_Enter(object sender, EventArgs e)
        {

        }
    }
}
