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
        private int appointmentId; // New field to store app_id

        public Payment(int app_id)
        {
            InitializeComponent();
            this.appointmentId = app_id;
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
                            serviceCostLabel.Text = serviceCost.ToString("C");
                            totalCost += serviceCost;
                            totalCostLabel.Text = "Total Cost: " + totalCost.ToString("C");
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
            try
            {
                // Check if a payment method is selected
                if (paymentMethodGroupBox.Controls.OfType<RadioButton>().Any(rb => rb.Checked))
                {
                    // Get the selected payment method
                    string paymentMethod = paymentMethodGroupBox.Controls.OfType<RadioButton>().FirstOrDefault(rb => rb.Checked)?.Text;

                    // Update the database with the new amount, payment method, and current date
                    using (SqlConnection con = getConnection())
                    {
                        con.Open();

                        // Update the 'amount', 'method', 'pay_date', and 'app_id' in the 'Payment' table
                        string updateQuery = "UPDATE [Clinic].[dbo].[Payment] SET [amount] = [amount] + @totalCost, [method] = @method, [pay_date] = @payDate, [app_id] = @appId WHERE [payment_id] = (SELECT MAX([payment_id]) FROM [Clinic].[dbo].[Payment])";
                        cmd = new SqlCommand(updateQuery, con);
                        cmd.Parameters.AddWithValue("@totalCost", totalCost);
                        cmd.Parameters.AddWithValue("@method", paymentMethod);
                        cmd.Parameters.AddWithValue("@payDate", DateTime.Now);
                        cmd.Parameters.AddWithValue("@appId", appointmentId);
                        cmd.ExecuteNonQuery();

                        // Insert a new payment record with the updated amount, payment method, and current date
                        string insertQuery = "INSERT INTO [Clinic].[dbo].[Payment] ([pay_date], [amount], [method], [app_id]) VALUES (@payDate, @totalCost, @method, @appId)";
                        cmd = new SqlCommand(insertQuery, con);
                        cmd.Parameters.AddWithValue("@payDate", DateTime.Now);
                        cmd.Parameters.AddWithValue("@totalCost", totalCost);
                        cmd.Parameters.AddWithValue("@method", paymentMethod);
                        cmd.Parameters.AddWithValue("@appId", appointmentId);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Payment confirmed and updated in the database.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Clear the form for the next payment
                    serviceNameLabel.Text = "";
                    serviceCostLabel.Text = "Service Cost: $0.00";
                    totalCost = 0;
                    totalCostLabel.Text = "Total Cost: $0.00";
                    paymentMethodGroupBox.Controls.OfType<RadioButton>().ToList().ForEach(rb => rb.Checked = false);
                }
                else
                {
                    MessageBox.Show("Please select a payment method.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error confirming payment: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    




private void serviceNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void serviceCostLabel_Click(object sender, EventArgs e)
        {

        }

        private void paymentMethodGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void totalCostLabel_Click(object sender, EventArgs e)
        {

        }

        private void cashRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void visaRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
