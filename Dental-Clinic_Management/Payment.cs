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
        private decimal totalCost;

        public Payment()
        {
            InitializeComponent();
        }
        protected SqlConnection getConnection()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-8JPNOOB\\MSSQLSERVER01;database=Clinic;integrated security = true";
            return con;
        }
        private void Payment_Load(object sender, EventArgs e)
        {
            try
            {
                // Load service names into serviceListBox during form load
                using (SqlConnection con = getConnection())
                {
                    con.Open();
                    string query = "SELECT [ser_name] FROM [Clinic].[dbo].[dent_services]";
                    cmd = new SqlCommand(query, con);
                    dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        serviceListBox.Items.Add(dr["ser_name"].ToString());
                    }

                    dr.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading service names: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void serviceListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void addItemButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Add selected service name to serviceNameLabel
                if (serviceListBox.SelectedItem != null)
                {
                    serviceNameLabel.Text += serviceListBox.SelectedItem.ToString() + Environment.NewLine;

                    // Fetch and add the cost to totalCost
                    using (SqlConnection con = getConnection())
                    {
                        con.Open();
                        string query = "SELECT [ser_price] FROM [Clinic].[dbo].[dent_services] WHERE [ser_name] = @serviceName";
                        cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@serviceName", serviceListBox.SelectedItem.ToString());

                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            decimal serviceCost = Convert.ToDecimal(result);
                            totalCost += serviceCost;
                            serviceCostLabel.Text = "Total Cost: " + totalCost.ToString("C");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding item: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
