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
    public partial class Patient : Form
    {
        public Patient()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Patient_Load(object sender, EventArgs e)
        {

        }
    }

    public class PatientQueries
    {
        
        public int patientID;
        public string fristName;
        public string lastName;
        public string city;
        public string street;
        public string phone;
        public string gender;
        public string dateOfBirth;
        public static void addPatient(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}