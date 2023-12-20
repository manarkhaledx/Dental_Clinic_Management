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
    public partial class AddRecordForm : Form
    {
        public AddRecordForm()
        {
            InitializeComponent();
          
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
            string gender = GetSelectedRadioButtonValue();
            if (firstNameTextBox.Text!=string.Empty&&lastNameTextBox.Text!=string.Empty&&genderGroupBox!=null&&phoneTextBox.Text!=string.Empty&&addressTextBox.Text!=string.Empty)
            {
                
                PatientDataBaseQueries.AddPatient(this.firstNameTextBox.Text, this.lastNameTextBox.Text, gender, this.phoneTextBox.Text, this.addressTextBox.Text, this.dobDateTimePicker.Value);
                MessageBox.Show(" Patient saved successfully :)");
                //Patient p1=new Patient();
               //p1.ShowDialog();
            }
            else
            {
                MessageBox.Show(" Please enter all the data fields ;)");
            }
            
        }
    }
}
