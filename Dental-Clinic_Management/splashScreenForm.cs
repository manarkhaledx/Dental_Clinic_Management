using CircularProgressBar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dental_Clinic_Management
{
    public partial class splashScreenForm : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn(

           int left, int top, int right, int bottom, int width, int height



           );
        public splashScreenForm()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void splashScreenForm_Load(object sender, EventArgs e)
        {

        

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            circularProgressBar.Value += 1;
            circularProgressBar.Text = circularProgressBar.Value.ToString() + "%";
            if (circularProgressBar.Value == 100)
            {
                timer1.Enabled = false;
                Login l1 = new Login();
                l1.Show();
                this.Hide();

            }
        }
    }
}
