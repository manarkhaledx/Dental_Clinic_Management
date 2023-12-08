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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (passTxtBox.UseSystemPasswordChar == true)
            {
                passTxtBox.UseSystemPasswordChar = false;
                eyeBox.Image = Properties.Resources.visibleEyeIcon;
            }
            else
            {
                passTxtBox.UseSystemPasswordChar = true;
                eyeBox.Image = Properties.Resources.hiddenEyeIcon;
            }
            //end
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
