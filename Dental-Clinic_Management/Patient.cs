//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dental_Clinic_Management
{
    using System;
    using System.Collections.Generic;
    
    public partial class Patient
    {
<<<<<<< HEAD
        public int patient_id { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Phone { get; set; }
        public string pat_address { get; set; }
        public string gender { get; set; }
        public Nullable<System.DateTime> DOB { get; set; }
    
        public virtual Appointment Appointment { get; set; }
        public virtual Payment Payment { get; set; }
        public virtual Prescription Prescription { get; set; }
=======
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
>>>>>>> parent of a06415a (commit)
    }
}
