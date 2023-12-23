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
using static Dental_Clinic_Management.Patient;

namespace Dental_Clinic_Management
{
    public partial class ViewReceptionist : Form
    {
        SqlCommand cmd;
        SqlDataReader dr;
        protected static SqlConnection getConnection()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-8JPNOOB\\MSSQLSERVER01;database=Clinic;integrated security=true";
            return con;
        }
        public ViewReceptionist()
        {
            InitializeComponent();
        }

        public static class receptionistDataBaseQueries
        {
            public static void loadAllReceptionistInDataGridView(DataGridView dataGridView)
            {
                using (SqlConnection con = getConnection())
                {
                    con.Open();
                 
                    using (SqlCommand cmd = new SqlCommand("SELECT recep_id, Fname, Lname,Phone,gender,DOB, recep_address FROM Receptionist", con))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            // Clear existing columns (if any)
                            dataGridView.Columns.Clear();

                            // Set AutoGenerateColumns to false
                            dataGridView.AutoGenerateColumns = false;

                            // Manually add columns and map them to DataTable columns
                            DataGridViewTextBoxColumn colPatientID = new DataGridViewTextBoxColumn();
                            colPatientID.Name = "recep_id";
                            colPatientID.DataPropertyName = "recep_id";
                            colPatientID.HeaderText = "Receptionist ID";
                            colPatientID.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            dataGridView.Columns.Add(colPatientID);

                            DataGridViewTextBoxColumn colFname = new DataGridViewTextBoxColumn();
                            colFname.Name = "Fname";
                            colFname.DataPropertyName = "Fname";
                            colFname.HeaderText = "First Name";
                            colFname.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            dataGridView.Columns.Add(colFname);

                            DataGridViewTextBoxColumn colLname = new DataGridViewTextBoxColumn();
                            colLname.Name = "Lname";
                            colLname.DataPropertyName = "Lname";
                            colLname.HeaderText = "Last Name";
                            colLname.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            dataGridView.Columns.Add(colLname);

                            DataGridViewTextBoxColumn colPhone = new DataGridViewTextBoxColumn();
                            colPhone.Name = "Phone";
                            colPhone.DataPropertyName = "Phone";
                            colPhone.HeaderText = "Phone";
                            colPhone.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            dataGridView.Columns.Add(colPhone);

                            DataGridViewTextBoxColumn colGender = new DataGridViewTextBoxColumn();
                            colGender.Name = "gender";
                            colGender.DataPropertyName = "gender";
                            colGender.HeaderText = "Gender";
                            colGender.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            dataGridView.Columns.Add(colGender);

                            DataGridViewTextBoxColumn colDOB = new DataGridViewTextBoxColumn();
                            colDOB.Name = "DOB";
                            colDOB.DataPropertyName = "DOB";
                            colDOB.HeaderText = "Date of Birth";
                            colDOB.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            dataGridView.Columns.Add(colDOB);

                            DataGridViewTextBoxColumn colPatAddress = new DataGridViewTextBoxColumn();
                            colPatAddress.Name = "recep_address";
                            colPatAddress.DataPropertyName = "recep_address";
                            colPatAddress.HeaderText = "Receptionist Address";
                            colPatAddress.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            dataGridView.Columns.Add(colPatAddress);
                          
                            

                            // Set the DataSource
                            dataGridView.DataSource = dt;
                        }
                    }
                }
            }

            //========================================================================================================================
            public static void deleteReceptionist(int receptionistId)
            {
                using (SqlConnection con = getConnection())
                {
                    con.Open();

                    // Assuming 'Patients' table has a column named 'PatientId'
                    string query = "DELETE FROM Receptionist WHERE recep_id = @recep_id";
                    SqlCommand command = new SqlCommand(query, con);
                    command.Parameters.AddWithValue("@recep_id", receptionistId);

                    command.ExecuteNonQuery();
                }
            }

            //==========================================================================================================================
            public static void EditReceptionist(int receptionistID, string newUsername, string newFname, string newLname, string newPhone, string newAddress, string newPassword, DateTime newDOB, RadioButton rad)
            {
                using (SqlConnection con = getConnection())
                {
                    con.Open();

                    // Fetch existing data for the receptionist
                    using (SqlCommand selectCmd = new SqlCommand("SELECT * FROM Receptionist WHERE ID=@ID", con))
                    {
                        selectCmd.Parameters.AddWithValue("ID", receptionistID);

                        using (SqlDataReader dr = selectCmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                // Use the fetched data to update the receptionist
                                using (SqlCommand updateCmd = new SqlCommand("UPDATE Receptionist SET Fname=@NewFname, Lname=@NewLname, Phone=@NewPhone,gender=@NewGender, DOB=@NewDOB, recep_address=@NewAddress, username=@NewUsername , pass=@NewPass WHERE ID=@ID", con))
                                {
                                    updateCmd.Parameters.AddWithValue("NewFname", newFname);
                                    updateCmd.Parameters.AddWithValue("NewLname", newLname);
                                    updateCmd.Parameters.AddWithValue("NewPhone", newPhone);
                                    updateCmd.Parameters.AddWithValue("NewGender", rad.Checked ? "Female" : "Male");
                                    updateCmd.Parameters.AddWithValue("NewDOB", newDOB);
                                    updateCmd.Parameters.AddWithValue("NewAddress", newAddress);
                                    updateCmd.Parameters.AddWithValue("NewUsername", newUsername);
                                    updateCmd.Parameters.AddWithValue("NewPass", newPassword);

                                    // Use the receptionist ID from the fetched data
                                    updateCmd.Parameters.AddWithValue("ID", dr["ID"]);

                                    int rowsAffected = updateCmd.ExecuteNonQuery();

                                    if (rowsAffected > 0)
                                    {
                                        MessageBox.Show("Receptionist information updated successfully.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    else
                                    {
                                        MessageBox.Show("Failed to update receptionist information. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Receptionist not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            //=======================================================================================================================================================
        }

        private void signUpRecepButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            addNewReceptionist add = new addNewReceptionist();
            add.ShowDialog();
        }

        private void ViewReceptionist_Load(object sender, EventArgs e)
        {
            receptionistDataBaseQueries.loadAllReceptionistInDataGridView(recepDataGridView);
        }

        private void deleteRecepButton_Click(object sender, EventArgs e)
        {
            DataGridView dataGrid = recepDataGridView;
            if (recepDataGridView.SelectedRows.Count > 0)
            {
                // Get the selected patient ID from the DataGridView
                int selectedReceptionisttId = Convert.ToInt32(recepDataGridView.SelectedRows[0].Cells["recep_id"].Value);

                // Ask for confirmation
                DialogResult result = MessageBox.Show("Are you sure you want to delete this receptionist?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Delete the patient from the database
                    receptionistDataBaseQueries.deleteReceptionist(selectedReceptionisttId);

                    // Refresh the DataGridView after deletion
                    receptionistDataBaseQueries.loadAllReceptionistInDataGridView(recepDataGridView);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void editRecepButton_Click(object sender, EventArgs e)
        {
            if (recepDataGridView.SelectedRows.Count > 0)
            {
                // Retrieve data from the selected row
                DataGridViewRow selectedRow = recepDataGridView.SelectedRows[0];
                int receptionistID = Convert.ToInt32(selectedRow.Cells["recep_id"].Value);
                string fname = selectedRow.Cells["Fname"].Value.ToString();
                string lname = selectedRow.Cells["Lname"].Value.ToString();
                string phone = selectedRow.Cells["Phone"].Value.ToString();
                string gender = selectedRow.Cells["gender"].Value.ToString();
                DateTime dob = Convert.ToDateTime(selectedRow.Cells["DOB"].Value);
                string address = selectedRow.Cells["recep_address"].Value.ToString();

                // Open the EditPatientForm and pass the patient data

                EditReceptionist editForm = new EditReceptionist(receptionistID,fname, lname, phone, gender, dob, address);
                this.Hide();
                editForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a patient to add.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
