namespace Dental_Clinic_Management
{
    partial class Payment
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
            this.confirmButton = new System.Windows.Forms.Button();
            this.serviceCostTextBox = new System.Windows.Forms.TextBox();
            this.serviceCostLabel = new System.Windows.Forms.Label();
            this.serviceNameLabel = new System.Windows.Forms.Label();
            this.addServiceTextBox = new System.Windows.Forms.TextBox();
            this.paymentMethodGroupBox = new System.Windows.Forms.GroupBox();
            this.cashRadioButton = new System.Windows.Forms.RadioButton();
            this.visaRadioButton = new System.Windows.Forms.RadioButton();
            this.serviceListBox = new System.Windows.Forms.ListBox();
            this.addItemButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.totalCostTextBox = new System.Windows.Forms.TextBox();
            this.totalCostLabel = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.patientButton = new System.Windows.Forms.Button();
            this.appointmentsButton = new System.Windows.Forms.Button();
            this.dashboardButton = new System.Windows.Forms.Button();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.paymentMethodGroupBox.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.SuspendLayout();
            // 
            // confirmButton
            // 
            this.confirmButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(167)))), ((int)(((byte)(137)))));
            this.confirmButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.confirmButton.FlatAppearance.BorderSize = 0;
            this.confirmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.confirmButton.Location = new System.Drawing.Point(1513, 814);
            this.confirmButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(164, 57);
            this.confirmButton.TabIndex = 77;
            this.confirmButton.Text = "Confirm Payment";
            this.confirmButton.UseVisualStyleBackColor = false;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // serviceCostTextBox
            // 
            this.serviceCostTextBox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.serviceCostTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.serviceCostTextBox.Font = new System.Drawing.Font("Microsoft Uighur", 22.2F, System.Drawing.FontStyle.Bold);
            this.serviceCostTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(111)))), ((int)(((byte)(24)))));
            this.serviceCostTextBox.Location = new System.Drawing.Point(463, 459);
            this.serviceCostTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.serviceCostTextBox.Name = "serviceCostTextBox";
            this.serviceCostTextBox.Size = new System.Drawing.Size(283, 40);
            this.serviceCostTextBox.TabIndex = 82;
            // 
            // serviceCostLabel
            // 
            this.serviceCostLabel.AutoSize = true;
            this.serviceCostLabel.Font = new System.Drawing.Font("Microsoft Uighur", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceCostLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(111)))), ((int)(((byte)(24)))));
            this.serviceCostLabel.Location = new System.Drawing.Point(479, 683);
            this.serviceCostLabel.Name = "serviceCostLabel";
            this.serviceCostLabel.Size = new System.Drawing.Size(161, 45);
            this.serviceCostLabel.TabIndex = 81;
            this.serviceCostLabel.Text = "Service Cost:";
            this.serviceCostLabel.Click += new System.EventHandler(this.serviceCostLabel_Click);
            // 
            // serviceNameLabel
            // 
            this.serviceNameLabel.AutoSize = true;
            this.serviceNameLabel.Font = new System.Drawing.Font("Microsoft Uighur", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(111)))), ((int)(((byte)(24)))));
            this.serviceNameLabel.Location = new System.Drawing.Point(488, 48);
            this.serviceNameLabel.Name = "serviceNameLabel";
            this.serviceNameLabel.Size = new System.Drawing.Size(176, 45);
            this.serviceNameLabel.TabIndex = 80;
            this.serviceNameLabel.Text = "Service Name:";
            this.serviceNameLabel.Click += new System.EventHandler(this.serviceNameLabel_Click);
            // 
            // addServiceTextBox
            // 
            this.addServiceTextBox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.addServiceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addServiceTextBox.Font = new System.Drawing.Font("Microsoft Uighur", 22.2F, System.Drawing.FontStyle.Bold);
            this.addServiceTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(111)))), ((int)(((byte)(24)))));
            this.addServiceTextBox.Location = new System.Drawing.Point(463, 290);
            this.addServiceTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addServiceTextBox.Name = "addServiceTextBox";
            this.addServiceTextBox.Size = new System.Drawing.Size(283, 40);
            this.addServiceTextBox.TabIndex = 79;
            // 
            // paymentMethodGroupBox
            // 
            this.paymentMethodGroupBox.Controls.Add(this.cashRadioButton);
            this.paymentMethodGroupBox.Controls.Add(this.visaRadioButton);
            this.paymentMethodGroupBox.Font = new System.Drawing.Font("Microsoft Uighur", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentMethodGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(111)))), ((int)(((byte)(24)))));
            this.paymentMethodGroupBox.Location = new System.Drawing.Point(838, 653);
            this.paymentMethodGroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.paymentMethodGroupBox.Name = "paymentMethodGroupBox";
            this.paymentMethodGroupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.paymentMethodGroupBox.Size = new System.Drawing.Size(283, 164);
            this.paymentMethodGroupBox.TabIndex = 78;
            this.paymentMethodGroupBox.TabStop = false;
            this.paymentMethodGroupBox.Text = "Payment Method";
            this.paymentMethodGroupBox.Enter += new System.EventHandler(this.paymentMethodGroupBox_Enter);
            // 
            // cashRadioButton
            // 
            this.cashRadioButton.AutoSize = true;
            this.cashRadioButton.Location = new System.Drawing.Point(46, 39);
            this.cashRadioButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cashRadioButton.Name = "cashRadioButton";
            this.cashRadioButton.Size = new System.Drawing.Size(96, 49);
            this.cashRadioButton.TabIndex = 13;
            this.cashRadioButton.TabStop = true;
            this.cashRadioButton.Text = "Cash";
            this.cashRadioButton.UseVisualStyleBackColor = true;
            this.cashRadioButton.CheckedChanged += new System.EventHandler(this.cashRadioButton_CheckedChanged);
            // 
            // visaRadioButton
            // 
            this.visaRadioButton.AutoSize = true;
            this.visaRadioButton.Location = new System.Drawing.Point(46, 94);
            this.visaRadioButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.visaRadioButton.Name = "visaRadioButton";
            this.visaRadioButton.Size = new System.Drawing.Size(90, 49);
            this.visaRadioButton.TabIndex = 14;
            this.visaRadioButton.TabStop = true;
            this.visaRadioButton.Text = "Visa";
            this.visaRadioButton.UseVisualStyleBackColor = true;
            this.visaRadioButton.CheckedChanged += new System.EventHandler(this.visaRadioButton_CheckedChanged);
            // 
            // serviceListBox
            // 
            this.serviceListBox.FormattingEnabled = true;
            this.serviceListBox.ItemHeight = 16;
            this.serviceListBox.Location = new System.Drawing.Point(1007, 32);
            this.serviceListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.serviceListBox.Name = "serviceListBox";
            this.serviceListBox.Size = new System.Drawing.Size(612, 436);
            this.serviceListBox.TabIndex = 75;
            this.serviceListBox.SelectedIndexChanged += new System.EventHandler(this.serviceListBox_SelectedIndexChanged);
            // 
            // addItemButton
            // 
            this.addItemButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(167)))), ((int)(((byte)(137)))));
            this.addItemButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addItemButton.FlatAppearance.BorderSize = 0;
            this.addItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addItemButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.addItemButton.Location = new System.Drawing.Point(1032, 542);
            this.addItemButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(164, 57);
            this.addItemButton.TabIndex = 76;
            this.addItemButton.Text = "Add Item";
            this.addItemButton.UseVisualStyleBackColor = false;
            this.addItemButton.Click += new System.EventHandler(this.addItemButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(130)))), ((int)(((byte)(100)))));
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(838, 633);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(283, 6);
            this.panel2.TabIndex = 74;
            // 
            // totalCostTextBox
            // 
            this.totalCostTextBox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.totalCostTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.totalCostTextBox.Font = new System.Drawing.Font("Microsoft Uighur", 22.2F, System.Drawing.FontStyle.Bold);
            this.totalCostTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(111)))), ((int)(((byte)(24)))));
            this.totalCostTextBox.Location = new System.Drawing.Point(838, 587);
            this.totalCostTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.totalCostTextBox.Name = "totalCostTextBox";
            this.totalCostTextBox.Size = new System.Drawing.Size(283, 40);
            this.totalCostTextBox.TabIndex = 73;
            // 
            // totalCostLabel
            // 
            this.totalCostLabel.AutoSize = true;
            this.totalCostLabel.Font = new System.Drawing.Font("Microsoft Uighur", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCostLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(111)))), ((int)(((byte)(24)))));
            this.totalCostLabel.Location = new System.Drawing.Point(479, 750);
            this.totalCostLabel.Name = "totalCostLabel";
            this.totalCostLabel.Size = new System.Drawing.Size(142, 45);
            this.totalCostLabel.TabIndex = 72;
            this.totalCostLabel.Text = "Total Cost:";
            this.totalCostLabel.Click += new System.EventHandler(this.totalCostLabel_Click);
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
            this.panel8.Size = new System.Drawing.Size(375, 844);
            this.panel8.TabIndex = 71;
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
            this.patientButton.Location = new System.Drawing.Point(-3, 392);
            this.patientButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.patientButton.Name = "patientButton";
            this.patientButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.patientButton.Size = new System.Drawing.Size(375, 63);
            this.patientButton.TabIndex = 28;
            this.patientButton.Text = "patient";
            this.patientButton.UseVisualStyleBackColor = false;
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
            this.appointmentsButton.Location = new System.Drawing.Point(-3, 535);
            this.appointmentsButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.appointmentsButton.Name = "appointmentsButton";
            this.appointmentsButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.appointmentsButton.Size = new System.Drawing.Size(375, 63);
            this.appointmentsButton.TabIndex = 29;
            this.appointmentsButton.Text = " Appointments";
            this.appointmentsButton.UseVisualStyleBackColor = false;
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
            this.dashboardButton.Location = new System.Drawing.Point(-3, 250);
            this.dashboardButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dashboardButton.Name = "dashboardButton";
            this.dashboardButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.dashboardButton.Size = new System.Drawing.Size(375, 63);
            this.dashboardButton.TabIndex = 27;
            this.dashboardButton.Text = "DashBoard";
            this.dashboardButton.UseVisualStyleBackColor = false;
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
            this.pictureBox10.TabIndex = 26;
            this.pictureBox10.TabStop = false;
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1710, 844);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.serviceCostTextBox);
            this.Controls.Add(this.serviceCostLabel);
            this.Controls.Add(this.serviceNameLabel);
            this.Controls.Add(this.addServiceTextBox);
            this.Controls.Add(this.paymentMethodGroupBox);
            this.Controls.Add(this.serviceListBox);
            this.Controls.Add(this.addItemButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.totalCostTextBox);
            this.Controls.Add(this.totalCostLabel);
            this.Controls.Add(this.panel8);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Payment";
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.Payment_Load);
            this.paymentMethodGroupBox.ResumeLayout(false);
            this.paymentMethodGroupBox.PerformLayout();
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.TextBox serviceCostTextBox;
        private System.Windows.Forms.Label serviceCostLabel;
        private System.Windows.Forms.Label serviceNameLabel;
        private System.Windows.Forms.TextBox addServiceTextBox;
        private System.Windows.Forms.GroupBox paymentMethodGroupBox;
        private System.Windows.Forms.RadioButton cashRadioButton;
        private System.Windows.Forms.RadioButton visaRadioButton;
        private System.Windows.Forms.ListBox serviceListBox;
        private System.Windows.Forms.Button addItemButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox totalCostTextBox;
        private System.Windows.Forms.Label totalCostLabel;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button patientButton;
        private System.Windows.Forms.Button appointmentsButton;
        private System.Windows.Forms.Button dashboardButton;
        private System.Windows.Forms.PictureBox pictureBox10;
    }
}