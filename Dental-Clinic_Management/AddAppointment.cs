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
    public partial class AddAppointment : Form
    {
        public AddAppointment()
        {
            InitializeComponent();
        }

        private void AddAppointment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.DataTable1' table. You can move, or remove it, as needed.
            this.dataTable1TableAdapter.Fill(this.dataSet1.DataTable1);
            // TODO: This line of code loads data into the 'dataSet1.DataTable1' table. You can move, or remove it, as needed.
            this.dataTable1TableAdapter.Fill(this.dataSet1.DataTable1);
            // TODO: This line of code loads data into the 'dataSet1.DataTable1' table. You can move, or remove it, as needed.
            this.dataTable1TableAdapter.Fill(this.dataSet1.DataTable1);

        }

        private void dataTable1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dataTable1BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void dataTable1BindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.dataTable1BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }
    }
}
