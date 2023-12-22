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
    public partial class showAppointmentsOfTheDayForm : Form
    {
        SqlCommand cmd;
        SqlDataReader dr;
        protected static SqlConnection getConnection()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-8JPNOOB\\MSSQLSERVER01;database=Clinic;integrated security=true";
            return con;
        }
        public showAppointmentsOfTheDayForm()
        {
            InitializeComponent();
        }

        public static class appointmentDataBaseQueries
        {
            public static void addappointment(string phone, string time, DateTime date, int patientID)
            {
                using (SqlConnection con = getConnection())
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM appointment WHERE pat_phone=@phone AND app_time=@time AND app_date=@date", con))
                    {
                        cmd.Parameters.AddWithValue("pat_phone", phone);
                        cmd.Parameters.AddWithValue("app_time", time);
                        cmd.Parameters.AddWithValue("app_date", date);

                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            
                            
                        }
                    }
                }
            }
        }
    }
}
