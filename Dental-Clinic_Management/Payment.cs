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
    public partial class Payment : Form
    {
        SqlCommand cmd;
        SqlDataReader dr;
        public Payment()
        {
            InitializeComponent();
        }
        protected SqlConnection getConnection()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = MARK;database=Pharmacy;integrated security = true";
            return con;
        }


        private void serviceListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Display selected service details in labels
                if (serviceListBox.SelectedIndex != -1)
                {
                    using (SqlConnection con = getConnection())
                    {
                        con.Open();
                        string query = "SELECT [ser_id], [ser_name], [ser_price], [payment_id] FROM [Clinic].[dbo].[dent_services] WHERE [ser_name] = @serviceName";
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@serviceName", serviceListBox.SelectedItem.ToString());
                            using (SqlDataReader dr = cmd.ExecuteReader())
                            {
                                if (dr.Read())
                                {
                                    // Display service details in labels
                                    serviceNameLabel.Text = dr["ser_name"].ToString();
                                    serviceCostLabel.Text = dr["ser_price"].ToString();
                                }
                            }
                        }

                        // Update data in serviceListBox
                        UpdateServiceListBox();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateServiceListBox()
        {
            // Repopulate the serviceListBox with updated data from the database
            serviceListBox.Items.Clear();

            using (SqlConnection con = getConnection())
            {
                con.Open();
                string query = "SELECT [ser_name] FROM [Clinic].[dbo].[dent_services]";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            // Add each service name to the serviceListBox
                            serviceListBox.Items.Add(dr["ser_name"].ToString());
                        }
                    }
                }
            }
        }

        private void addItemButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Clear existing items in the list box
                serviceListBox.Items.Clear();

                // Fetch data from the database and populate the list box
                using (SqlConnection con = getConnection())
                {
                    con.Open();
                    string query = "SELECT [ser_id], [ser_name], [ser_price], [payment_id] FROM [Clinic].[dbo].[dent_services]";
                    cmd = new SqlCommand(query, con);
                    dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        // Display service name in the list box
                        serviceListBox.Items.Add(dr["ser_name"].ToString());
                    }

                    dr.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Payment_Load(object sender, EventArgs e)
        {

        }

        private void confirmButton_Click(object sender, EventArgs e)
        {

        }

        private void serviceNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void serviceCostLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
