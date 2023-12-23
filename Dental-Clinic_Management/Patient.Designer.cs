namespace Dental_Clinic_Management
{
    partial class Patient
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
            this.patientDataGridView = new System.Windows.Forms.DataGridView();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.patientButton = new System.Windows.Forms.Button();
            this.appointmentsButton = new System.Windows.Forms.Button();
            this.dashboardButton = new System.Windows.Forms.Button();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.editPatientButton = new System.Windows.Forms.Button();
            this.deletePatientButton = new System.Windows.Forms.Button();
            this.totalCostLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.addPatient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.patientDataGridView)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // patientDataGridView
            // 
            this.patientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientDataGridView.Location = new System.Drawing.Point(434, 185);
            this.patientDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.patientDataGridView.Name = "patientDataGridView";
            this.patientDataGridView.RowHeadersWidth = 62;
            this.patientDataGridView.RowTemplate.Height = 28;
            this.patientDataGridView.Size = new System.Drawing.Size(1246, 588);
            this.patientDataGridView.TabIndex = 77;
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
            this.panel7.Size = new System.Drawing.Size(375, 950);
            this.panel7.TabIndex = 76;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(167)))), ((int)(((byte)(137)))));
            this.panel8.Controls.Add(this.patientButton);
            this.panel8.Controls.Add(this.appointmentsButton);
            this.panel8.Controls.Add(this.dashboardButton);
            this.panel8.Controls.Add(this.pictureBox10);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(375, 950);
            this.panel8.TabIndex = 22;
            this.panel8.Paint += new System.Windows.Forms.PaintEventHandler(this.panel8_Paint);
            // 
            // patientButton
            // 
            this.patientButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(167)))), ((int)(((byte)(137)))));
            this.patientButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.patientButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.patientButton.Font = new System.Drawing.Font("MS Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.patientButton.Image = global::Dental_Clinic_Management.Properties.Resources.icons8_person_50__1_;
            this.patientButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.patientButton.Location = new System.Drawing.Point(-5, 392);
            this.patientButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.patientButton.Name = "patientButton";
            this.patientButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.patientButton.Size = new System.Drawing.Size(375, 63);
            this.patientButton.TabIndex = 24;
            this.patientButton.Text = "patient";
            this.patientButton.UseVisualStyleBackColor = false;
            this.patientButton.Click += new System.EventHandler(this.patientButton_Click);
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
            this.appointmentsButton.Location = new System.Drawing.Point(-5, 535);
            this.appointmentsButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.appointmentsButton.Name = "appointmentsButton";
            this.appointmentsButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.appointmentsButton.Size = new System.Drawing.Size(375, 63);
            this.appointmentsButton.TabIndex = 25;
            this.appointmentsButton.Text = " Appointments";
            this.appointmentsButton.UseVisualStyleBackColor = false;
            this.appointmentsButton.Click += new System.EventHandler(this.appointmentsButton_Click);
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
            this.dashboardButton.Location = new System.Drawing.Point(-5, 250);
            this.dashboardButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dashboardButton.Name = "dashboardButton";
            this.dashboardButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.dashboardButton.Size = new System.Drawing.Size(375, 63);
            this.dashboardButton.TabIndex = 23;
            this.dashboardButton.Text = "DashBoard";
            this.dashboardButton.UseVisualStyleBackColor = false;
            this.dashboardButton.Click += new System.EventHandler(this.dashboardButton_Click);
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(167)))), ((int)(((byte)(137)))));
            this.pictureBox10.BackgroundImage = global::Dental_Clinic_Management.Properties.Resources.Logo;
            this.pictureBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox10.Location = new System.Drawing.Point(-3, 0);
            this.pictureBox10.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(375, 187);
            this.pictureBox10.TabIndex = 22;
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
            // editPatientButton
            // 
            this.editPatientButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(167)))), ((int)(((byte)(137)))));
            this.editPatientButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.editPatientButton.FlatAppearance.BorderSize = 0;
            this.editPatientButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editPatientButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.editPatientButton.Location = new System.Drawing.Point(1043, 836);
            this.editPatientButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.editPatientButton.Name = "editPatientButton";
            this.editPatientButton.Size = new System.Drawing.Size(136, 57);
            this.editPatientButton.TabIndex = 79;
            this.editPatientButton.Text = "Edit";
            this.editPatientButton.UseVisualStyleBackColor = false;
            this.editPatientButton.Click += new System.EventHandler(this.editPatientButton_Click);
            // 
            // deletePatientButton
            // 
            this.deletePatientButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(167)))), ((int)(((byte)(137)))));
            this.deletePatientButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.deletePatientButton.FlatAppearance.BorderSize = 0;
            this.deletePatientButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletePatientButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deletePatientButton.Location = new System.Drawing.Point(1439, 836);
            this.deletePatientButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.deletePatientButton.Name = "deletePatientButton";
            this.deletePatientButton.Size = new System.Drawing.Size(136, 57);
            this.deletePatientButton.TabIndex = 78;
            this.deletePatientButton.Text = "Delete";
            this.deletePatientButton.UseVisualStyleBackColor = false;
            this.deletePatientButton.Click += new System.EventHandler(this.deletePatientButton_Click);
            // 
            // totalCostLabel
            // 
            this.totalCostLabel.AutoSize = true;
            this.totalCostLabel.Font = new System.Drawing.Font("Microsoft Uighur", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCostLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(111)))), ((int)(((byte)(24)))));
            this.totalCostLabel.Location = new System.Drawing.Point(760, 78);
            this.totalCostLabel.Name = "totalCostLabel";
            this.totalCostLabel.Size = new System.Drawing.Size(196, 45);
            this.totalCostLabel.TabIndex = 80;
            this.totalCostLabel.Text = "Phone Number:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = global::Dental_Clinic_Management.Properties.Resources.Exit;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(2110, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 44);
            this.pictureBox1.TabIndex = 74;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackgroundImage = global::Dental_Clinic_Management.Properties.Resources.Minimize;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(2057, 10);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 44);
            this.pictureBox2.TabIndex = 75;
            this.pictureBox2.TabStop = false;
            // 
            // searchTextBox
            // 
            this.searchTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.searchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchTextBox.Font = new System.Drawing.Font("Microsoft Uighur", 22.2F, System.Drawing.FontStyle.Bold);
            this.searchTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(111)))), ((int)(((byte)(24)))));
            this.searchTextBox.Location = new System.Drawing.Point(994, 78);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(283, 40);
            this.searchTextBox.TabIndex = 81;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // addPatient
            // 
            this.addPatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(167)))), ((int)(((byte)(137)))));
            this.addPatient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addPatient.FlatAppearance.BorderSize = 0;
            this.addPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPatient.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addPatient.Location = new System.Drawing.Point(628, 836);
            this.addPatient.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addPatient.Name = "addPatient";
            this.addPatient.Size = new System.Drawing.Size(136, 57);
            this.addPatient.TabIndex = 82;
            this.addPatient.Text = "Add";
            this.addPatient.UseVisualStyleBackColor = false;
            this.addPatient.Click += new System.EventHandler(this.addPatient_Click);
            // 
            // Patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1709, 950);
            this.Controls.Add(this.addPatient);
            this.Controls.Add(this.patientDataGridView);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.editPatientButton);
            this.Controls.Add(this.deletePatientButton);
            this.Controls.Add(this.totalCostLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.searchTextBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Patient";
            this.Text = "Patient";
            this.Load += new System.EventHandler(this.Patient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.patientDataGridView)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView patientDataGridView;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Button editPatientButton;
        private System.Windows.Forms.Button deletePatientButton;
        private System.Windows.Forms.Label totalCostLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button patientButton;
        private System.Windows.Forms.Button appointmentsButton;
        private System.Windows.Forms.Button dashboardButton;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Button addPatient;
    }
}