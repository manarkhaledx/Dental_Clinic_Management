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
                        cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@serviceName", serviceListBox.SelectedItem.ToString());
                        dr = cmd.ExecuteReader();

                        if (dr.Read())
                        {
                            // Display service details in labels
                            serviceNameLabel.Text = dr["ser_name"].ToString();
                            serviceCostLabel.Text = dr["ser_price"].ToString();
                        }

                        dr.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                    decimal totalCost = 0;
                    int itemCounter = 0;
                    StringBuilder serviceNameBuilder = new StringBuilder();

                    while (dr.Read())
                    {
                        // Display service name in the list box
                        string serviceName = dr["ser_name"].ToString();
                        serviceListBox.Items.Add(serviceName);

                        // Append service name to the label
                        serviceNameBuilder.Append(serviceName);
                        serviceNameBuilder.Append(", ");

                        // Sum up service prices
                        totalCost += Convert.ToDecimal(dr["ser_price"]);
                        itemCounter++;

                        // If more than 3 items, show the remaining items as "..."
                        if (itemCounter >= 3)
                        {
                            serviceNameBuilder.Append("...");
                            break;
                        }
                    }

                    dr.Close();

                    // Set the labels
                    serviceNameLabel.Text = serviceNameBuilder.ToString();
                    serviceCostLabel.Text = totalCost.ToString();
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
