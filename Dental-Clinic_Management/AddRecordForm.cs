using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
