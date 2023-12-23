namespace Dental_Clinic_Management
{
    partial class showAppointmentsOfTheDayForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(showAppointmentsOfTheDayForm));
            this.appointmentDataGridView = new System.Windows.Forms.DataGridView();
            this.currentAppointmentsLabel = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.appointmentsButton = new System.Windows.Forms.Button();
            this.prescriptionButton = new System.Windows.Forms.Button();
            this.billingsButton = new System.Windows.Forms.Button();
            this.dashboardButton = new System.Windows.Forms.Button();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDataGridView)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.SuspendLayout();
            // 
            // appointmentDataGridView
            // 
            this.appointmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appointmentDataGridView.Location = new System.Drawing.Point(412, 163);
            this.appointmentDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.appointmentDataGridView.Name = "appointmentDataGridView";
            this.appointmentDataGridView.RowHeadersWidth = 62;
            this.appointmentDataGridView.RowTemplate.Height = 28;
            this.appointmentDataGridView.Size = new System.Drawing.Size(1171, 574);
            this.appointmentDataGridView.TabIndex = 66;
            // 
            // currentAppointmentsLabel
            // 
            this.currentAppointmentsLabel.AutoSize = true;
            this.currentAppointmentsLabel.Font = new System.Drawing.Font("Times New Roman", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentAppointmentsLabel.Location = new System.Drawing.Point(740, 26);
            this.currentAppointmentsLabel.Name = "currentAppointmentsLabel";
            this.currentAppointmentsLabel.Size = new System.Drawing.Size(497, 52);
            this.currentAppointmentsLabel.TabIndex = 65;
            this.currentAppointmentsLabel.Text = "Appointments of the day";
            this.currentAppointmentsLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(167)))), ((int)(((byte)(137)))));
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Controls.Add(this.button3);
            this.panel7.Controls.Add(this.button2);
            this.panel7.Controls.Add(this.button1);
            this.panel7.Controls.Add(this.pictureBox9);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(375, 844);
            this.panel7.TabIndex = 68;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(167)))), ((int)(((byte)(137)))));
            this.panel8.Controls.Add(this.appointmentsButton);
            this.panel8.Controls.Add(this.prescriptionButton);
            this.panel8.Controls.Add(this.billingsButton);
            this.panel8.Controls.Add(this.dashboardButton);
            this.panel8.Controls.Add(this.pictureBox10);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(375, 844);
            this.panel8.TabIndex = 22;
            // 
            // appointmentsButton
            // 
            this.appointmentsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(167)))), ((int)(((byte)(137)))));
            this.appointmentsButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.appointmentsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.appointmentsButton.Font = new System.Drawing.Font("MS Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentsButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.appointmentsButton.Image = global::Dental_Clinic_Management.Properties.Resources.icons8_appointment_50__1_;
            this.appointmentsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.appointmentsButton.Location = new System.Drawing.Point(0, 615);
            this.appointmentsButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.appointmentsButton.Name = "appointmentsButton";
            this.appointmentsButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.appointmentsButton.Size = new System.Drawing.Size(375, 63);
            this.appointmentsButton.TabIndex = 26;
            this.appointmentsButton.Text = " Appointments";
            this.appointmentsButton.UseVisualStyleBackColor = false;
            this.appointmentsButton.Click += new System.EventHandler(this.appointmentsButton_Click);
            // 
            // prescriptionButton
            // 
            this.prescriptionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(167)))), ((int)(((byte)(137)))));
            this.prescriptionButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.prescriptionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prescriptionButton.Font = new System.Drawing.Font("MS Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prescriptionButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.prescriptionButton.Image = ((System.Drawing.Image)(resources.GetObject("prescriptionButton.Image")));
            this.prescriptionButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.prescriptionButton.Location = new System.Drawing.Point(-3, 484);
            this.prescriptionButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.prescriptionButton.Name = "prescriptionButton";
            this.prescriptionButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.prescriptionButton.Size = new System.Drawing.Size(375, 63);
            this.prescriptionButton.TabIndex = 25;
            this.prescriptionButton.Text = "Receptionists";
            this.prescriptionButton.UseVisualStyleBackColor = false;
            this.prescriptionButton.Click += new System.EventHandler(this.prescriptionButton_Click);
            // 
            // billingsButton
            // 
            this.billingsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(167)))), ((int)(((byte)(137)))));
            this.billingsButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.billingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.billingsButton.Font = new System.Drawing.Font("MS Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billingsButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.billingsButton.Image = global::Dental_Clinic_Management.Properties.Resources.icons8_cash_50__1_;
            this.billingsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.billingsButton.Location = new System.Drawing.Point(0, 363);
            this.billingsButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.billingsButton.Name = "billingsButton";
            this.billingsButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.billingsButton.Size = new System.Drawing.Size(375, 63);
            this.billingsButton.TabIndex = 22;
            this.billingsButton.Text = "Billings";
            this.billingsButton.UseVisualStyleBackColor = false;
            this.billingsButton.Click += new System.EventHandler(this.billingsButton_Click);
            // 
            // dashboardButton
            // 
            this.dashboardButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(167)))), ((int)(((byte)(137)))));
            this.dashboardButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.dashboardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboardButton.Font = new System.Drawing.Font("MS Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dashboardButton.Image = global::Dental_Clinic_Management.Properties.Resources.icons8_dashboard_50;
            this.dashboardButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardButton.Location = new System.Drawing.Point(0, 240);
            this.dashboardButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dashboardButton.Name = "dashboardButton";
            this.dashboardButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.dashboardButton.Size = new System.Drawing.Size(375, 63);
            this.dashboardButton.TabIndex = 19;
            this.dashboardButton.Text = "DashBoard";
            this.dashboardButton.UseVisualStyleBackColor = false;
            this.dashboardButton.Click += new System.EventHandler(this.dashboardButton_Click);
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(167)))), ((int)(((byte)(137)))));
            this.pictureBox10.BackgroundImage = global::Dental_Clinic_Management.Properties.Resources.Logo;
            this.pictureBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox10.Location = new System.Drawing.Point(0, 0);
            this.pictureBox10.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(375, 187);
            this.pictureBox10.TabIndex = 17;
            this.pictureBox10.TabStop = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(167)))), ((int)(((byte)(137)))));
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("MS Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Image = global::Dental_Clinic_Management.Properties.Resources.icons8_dashboard_50;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(0, 615);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(375, 123);
            this.button3.TabIndex = 21;
            this.button3.Text = "DashBoard";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(167)))), ((int)(((byte)(137)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("MS Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Image = global::Dental_Clinic_Management.Properties.Resources.icons8_dashboard_50;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 441);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(375, 123);
            this.button2.TabIndex = 20;
            this.button2.Text = "DashBoard";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(167)))), ((int)(((byte)(137)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("MS Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Image = global::Dental_Clinic_Management.Properties.Resources.icons8_dashboard_50;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 277);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(375, 123);
            this.button1.TabIndex = 19;
            this.button1.Text = "DashBoard";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(167)))), ((int)(((byte)(137)))));
            this.pictureBox9.BackgroundImage = global::Dental_Clinic_Management.Properties.Resources.Logo;
            this.pictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox9.Location = new System.Drawing.Point(0, 0);
            this.pictureBox9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(375, 234);
            this.pictureBox9.TabIndex = 17;
            this.pictureBox9.TabStop = false;
            // 
            // showAppointmentsOfTheDayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1641, 844);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.appointmentDataGridView);
            this.Controls.Add(this.currentAppointmentsLabel);
            this.Name = "showAppointmentsOfTheDayForm";
            this.Text = "showAppointmentsOfTheDayForm";
            this.Load += new System.EventHandler(this.showAppointmentsOfTheDayForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDataGridView)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView appointmentDataGridView;
        private System.Windows.Forms.Label currentAppointmentsLabel;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button appointmentsButton;
        private System.Windows.Forms.Button prescriptionButton;
        private System.Windows.Forms.Button billingsButton;
        private System.Windows.Forms.Button dashboardButton;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox9;
    }
}