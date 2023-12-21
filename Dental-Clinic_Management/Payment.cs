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
        public Payment()
        {
            InitializeComponent();
        }

        private void serviceListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "data source=DESKTOP-8JPNOOB\\MSSQLSERVER01;database=Clinic;integrated security=true";
            conn.Open();

            // Create a SqlCommand to retrieve data
            SqlCommand retrieveCmd = new SqlCommand("SELECT ser_name, ser_price, FROM dent_services", conn);

            // Use a SqlDataReader to read the data
            using (SqlDataReader reader = retrieveCmd.ExecuteReader())
            {
                // Clear existing items in the ListBox
                serviceListBox.Items.Clear();

                // Read the data and add it to the ListBox
                while (reader.Read())
                {
                    // Assuming you want to display a formatted string in the ListBox
                    string listItem = $"{reader["ser_name"]} - {reader["ser_price"]}";
                    serviceListBox.Items.Add(listItem);
                }
            }

            // Don't forget to close the connection when done
            conn.Close();
        }
    }
}
