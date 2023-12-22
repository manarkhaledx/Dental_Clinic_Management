using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Dental_Clinic_Management.Appointment;

namespace Dental_Clinic_Management
{
    public partial class EditAppointmentForm : Form
    {

        private int appointment_id;
        public EditAppointmentForm(int appointment_id,string phone,string time,DateTime date)
        {
            InitializeComponent();
            this.appointment_id=appointment_id;
            phoneTextBox.Text = phone;
            timeTextBox.Text = time;
            appointmentDateTimePicker.Value = date;
        }

        private void saveNewAppointmentButton_Click(object sender, EventArgs e)
        {
            try
            {
                string phone = phoneTextBox.Text;
                string time = timeTextBox.Text;
                DateTime date = appointmentDateTimePicker.Value;

                // Validate phone number input
                if (phone.Length == 11 && int.TryParse(phone, out _))
                {
                    // Call the method to edit appointment information
                    appointmentDataBaseQueries.EditAppointment(appointment_id, phone, time, date);
                    MessageBox.Show("Appointment information updated successfully.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // Close the current form
                    Appointment app = new Appointment();
                    app.ShowDialog();
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
