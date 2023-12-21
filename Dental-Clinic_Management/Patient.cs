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
    public partial class Patient : Form
    {
        SqlCommand cmd;
        SqlDataReader dr;
        protected static SqlConnection getConnection()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-8JPNOOB\\MSSQLSERVER01;database=Clinic;integrated security=true";
            return con;
        }
        public Patient()
        {
            InitializeComponent();
        }
        string searchPhone;




        private void Patient_Load(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Are You sure you want to edit patient data", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            patientDataBaseQueries.loadAllPatientsInDataGridView(patientDataGridView);

            if (result == DialogResult.Yes)
            {
                AddRecordForm obj = new AddRecordForm();
                this.Hide();
                obj.ShowDialog();
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("no");
            }
        }
        public static class patientDataBaseQueries
        {
            public static void addPatient(string fname, string lname, string phone, RadioButton rad, DateTime Date, string address)
            {
                using (SqlConnection con = getConnection())
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM Patient WHERE Fname=@Fname AND Lname=@Lname AND Phone=@Phone", con))
                    {
                        cmd.Parameters.AddWithValue("Fname", fname);
                        cmd.Parameters.AddWithValue("Lname", lname);
                        cmd.Parameters.AddWithValue("Phone", phone);

                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                MessageBox.Show("Patient already exists. Please try another.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                            else
                            {
                                dr.Close();

                                using (SqlCommand insertCmd = new SqlCommand("INSERT INTO Patient (Fname, Lname, Phone, gender, DOB, pat_address) " +
                                    "VALUES (@Fname, @Lname, @Phone, @gender, @DOB, @pat_address)", con))
                                {
                                    insertCmd.Parameters.AddWithValue("Fname", fname);
                                    insertCmd.Parameters.AddWithValue("Lname", lname);
                                    insertCmd.Parameters.AddWithValue("Phone", phone);
                                    insertCmd.Parameters.AddWithValue("gender", rad.Checked ? "Female" : "Male");
                                    insertCmd.Parameters.AddWithValue("DOB", Date);
                                    insertCmd.Parameters.AddWithValue("pat_address", address);

                                    insertCmd.ExecuteNonQuery();

                                    MessageBox.Show("Patient information added successfully.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    // Optionally, you may navigate to another form or perform additional actions here.
                                    //
                                    return;
                                }
                            }
                        }
                    }
                }
            }
            //--------------------------------------------------------------------------------------------------------------------------------------------------------
            public static void deletePatient(string phone)
            {
                using (SqlConnection con = getConnection())
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM Patient WHERE Phone=@Phone", con))
                    {
                        cmd.Parameters.AddWithValue("Phone", phone);

                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                dr.Close();

                                using (SqlCommand deleteCmd = new SqlCommand("DELETE FROM Patient WHERE Phone=@Phone", con))
                                {
                                    deleteCmd.Parameters.AddWithValue("Phone", phone);
                                    int rowsAffected = deleteCmd.ExecuteNonQuery();

                                    if (rowsAffected > 0)
                                    {
                                        MessageBox.Show("Patient deleted successfully.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        // Optionally, you may navigate to another form or perform additional actions here.
                                    }
                                    else
                                    {
                                        MessageBox.Show("Failed to delete patient. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Patient not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }

            //---------------------------------------------------------------------------------------------------------------------------------------------------------------------


            public static void searchPatient(string phone)
            {
                using (SqlConnection con = getConnection())
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM Patient WHERE Phone=@Phone", con))
                    {
                        cmd.Parameters.AddWithValue("Phone", phone);

                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                // Patient found, you can display or process the information as needed
                                string fname = dr["Fname"].ToString();
                                string lname = dr["Lname"].ToString();
                                string gender = dr["gender"].ToString();
                                DateTime dob = Convert.ToDateTime(dr["DOB"]);
                                string address = dr["pat_address"].ToString();

                                MessageBox.Show($"Patient Information:\n\nName: {fname} {lname}\nGender: {gender}\nDOB: {dob.ToShortDateString()}\nAddress: {address}", "Patient Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Patient not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }

            //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            public static void loadAllPatientsInDataGridView(DataGridView dataGridView)
            {
                using (SqlConnection con = getConnection())
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand("SELECT patient_id, Fname, Lname,Phone,pat_address, gender, DOB FROM Patient", con))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            dataGridView.DataSource = dt;

                            // Optional: Customize column names in the DataGridView
                            dataGridView.Columns["patient_id"].HeaderText = "id";
                            dataGridView.Columns["Fname"].HeaderText = "First Name";
                            dataGridView.Columns["Lname"].HeaderText = "Last Name";
                            dataGridView.Columns["gender"].HeaderText = "Gender";
                            dataGridView.Columns["Phone"].HeaderText = "phone";
                            dataGridView.Columns["pat_address"].HeaderText = "Address";
                            dataGridView.Columns["DOB"].HeaderText = "Date of Birth";
                        }
                    }
                }
            }
            //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            public static void editPatient(string phone, TextBox fnameTextBox, TextBox lnameTextBox, TextBox phoneTextBox, TextBox addressTextBox, DateTime date, RadioButton rad)
            {
                using (SqlConnection con = getConnection())
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM Patient WHERE Phone=@Phone", con))
                    {
                        cmd.Parameters.AddWithValue("Phone", phone);

                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                dr.Close();

                                using (SqlCommand updateCmd = new SqlCommand("UPDATE Patient SET Fname=@NewFname, Lname=@NewLname, gender=@NewGender, DOB=@NewDOB, pat_address=@NewAddress WHERE Phone=@Phone", con))
                                {
                                    updateCmd.Parameters.AddWithValue("Phone", phone);
                                    updateCmd.Parameters.AddWithValue("NewFname", fnameTextBox.Text);
                                    updateCmd.Parameters.AddWithValue("NewLname", lnameTextBox.Text);
                                    updateCmd.Parameters.AddWithValue("NewGender", rad.Checked ? "Female" : "Male");
                                    updateCmd.Parameters.AddWithValue("NewDOB", date);
                                    updateCmd.Parameters.AddWithValue("NewAddress", addressTextBox.Text);

                                    int rowsAffected = updateCmd.ExecuteNonQuery();

                                    if (rowsAffected > 0)
                                    {
                                        MessageBox.Show("Patient information updated successfully.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        // Optionally, you may navigate to another form or perform additional actions here.
                                    }
                                    else
                                    {
                                        MessageBox.Show("Failed to update patient information. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Patient not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }

        }
        private void totalCostTextBox_TextChanged(object sender, EventArgs e)
        {
            bool phoneFound =false;
            string phone = searchTextBox.Text.Trim();
            DataGridView dataGrid = patientDataGridView;

            // You can set a minimum length if needed before starting the search
            if (phone.Length == 11)
            {
                patientDataBaseQueries.searchPatient(phone);
               
            }
            
           
       
        }

        private void deletePatientButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (searchTextBox.Text != string.Empty)
                {
                    // Validate phone number input
                    if (searchTextBox.Text.Length == 11 && int.TryParse(searchTextBox.Text, out _))
                    {
                        patientDataBaseQueries.deletePatient(searchTextBox.Text);
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid 11-digit phone number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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

        private void patientDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        
        private void editPatientButton_Click(object sender, EventArgs e)
        {
            //searchPhone= searchTextBox.Text; 


            if (patientDataGridView.SelectedRows.Count > 0)
            {
                // Retrieve data from the selected row
                DataGridViewRow selectedRow = patientDataGridView.SelectedRows[0];
                string fname = selectedRow.Cells["Fname"].Value.ToString();
                string lname = selectedRow.Cells["Lname"].Value.ToString();
                string phone = selectedRow.Cells["Phone"].Value.ToString();
                string gender = selectedRow.Cells["gender"].Value.ToString();
                DateTime dob = Convert.ToDateTime(selectedRow.Cells["DOB"].Value);
                string address = selectedRow.Cells["pat_address"].Value.ToString();

                // Open the EditPatientForm and pass the patient data

                //EditPatientForm editForm = new EditPatientForm(fname, lname, phone, gender, dob, address);
                //editForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a patient to add.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}