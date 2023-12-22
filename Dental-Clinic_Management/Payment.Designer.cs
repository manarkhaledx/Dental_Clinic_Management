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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment));
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
            this.paymentButton = new System.Windows.Forms.Button();
            this.prescriptionButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
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
            this.confirmButton.Location = new System.Drawing.Point(1454, 950);
            this.confirmButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(184, 71);
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
            this.serviceCostTextBox.Location = new System.Drawing.Point(521, 574);
            this.serviceCostTextBox.Name = "serviceCostTextBox";
            this.serviceCostTextBox.Size = new System.Drawing.Size(318, 48);
            this.serviceCostTextBox.TabIndex = 82;
            // 
            // serviceCostLabel
            // 
            this.serviceCostLabel.AutoSize = true;
            this.serviceCostLabel.Font = new System.Drawing.Font("Microsoft Uighur", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceCostLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(111)))), ((int)(((byte)(24)))));
            this.serviceCostLabel.Location = new System.Drawing.Point(539, 854);
            this.serviceCostLabel.Name = "serviceCostLabel";
            this.serviceCostLabel.Size = new System.Drawing.Size(196, 54);
            this.serviceCostLabel.TabIndex = 81;
            this.serviceCostLabel.Text = "Service Cost:";
            this.serviceCostLabel.Click += new System.EventHandler(this.serviceCostLabel_Click);
            // 
            // serviceNameLabel
            // 
            this.serviceNameLabel.AutoSize = true;
            this.serviceNameLabel.Font = new System.Drawing.Font("Microsoft Uighur", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(111)))), ((int)(((byte)(24)))));
            this.serviceNameLabel.Location = new System.Drawing.Point(539, 159);
            this.serviceNameLabel.Name = "serviceNameLabel";
            this.serviceNameLabel.Size = new System.Drawing.Size(215, 54);
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
            this.addServiceTextBox.Location = new System.Drawing.Point(521, 362);
            this.addServiceTextBox.Name = "addServiceTextBox";
            this.addServiceTextBox.Size = new System.Drawing.Size(318, 48);
            this.addServiceTextBox.TabIndex = 79;
            // 
            // paymentMethodGroupBox
            // 
            this.paymentMethodGroupBox.Controls.Add(this.cashRadioButton);
            this.paymentMethodGroupBox.Controls.Add(this.visaRadioButton);
            this.paymentMethodGroupBox.Font = new System.Drawing.Font("Microsoft Uighur", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentMethodGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(111)))), ((int)(((byte)(24)))));
            this.paymentMethodGroupBox.Location = new System.Drawing.Point(943, 816);
            this.paymentMethodGroupBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.paymentMethodGroupBox.Name = "paymentMethodGroupBox";
            this.paymentMethodGroupBox.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.paymentMethodGroupBox.Size = new System.Drawing.Size(318, 205);
            this.paymentMethodGroupBox.TabIndex = 78;
            this.paymentMethodGroupBox.TabStop = false;
            this.paymentMethodGroupBox.Text = "Payment Method";
            this.paymentMethodGroupBox.Enter += new System.EventHandler(this.paymentMethodGroupBox_Enter);
            // 
            // cashRadioButton
            // 
            this.cashRadioButton.AutoSize = true;
            this.cashRadioButton.Location = new System.Drawing.Point(52, 49);
            this.cashRadioButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cashRadioButton.Name = "cashRadioButton";
            this.cashRadioButton.Size = new System.Drawing.Size(115, 58);
            this.cashRadioButton.TabIndex = 13;
            this.cashRadioButton.TabStop = true;
            this.cashRadioButton.Text = "Cash";
            this.cashRadioButton.UseVisualStyleBackColor = true;
            this.cashRadioButton.CheckedChanged += new System.EventHandler(this.cashRadioButton_CheckedChanged);
            // 
            // visaRadioButton
            // 
            this.visaRadioButton.AutoSize = true;
            this.visaRadioButton.Location = new System.Drawing.Point(52, 118);
            this.visaRadioButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.visaRadioButton.Name = "visaRadioButton";
            this.visaRadioButton.Size = new System.Drawing.Size(107, 58);
            this.visaRadioButton.TabIndex = 14;
            this.visaRadioButton.TabStop = true;
            this.visaRadioButton.Text = "Visa";
            this.visaRadioButton.UseVisualStyleBackColor = true;
            this.visaRadioButton.CheckedChanged += new System.EventHandler(this.visaRadioButton_CheckedChanged);
            // 
            // serviceListBox
            // 
            this.serviceListBox.FormattingEnabled = true;
            this.serviceListBox.ItemHeight = 20;
            this.serviceListBox.Location = new System.Drawing.Point(1162, 172);
            this.serviceListBox.Name = "serviceListBox";
            this.serviceListBox.Size = new System.Drawing.Size(688, 544);
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
            this.addItemButton.Location = new System.Drawing.Point(943, 645);
            this.addItemButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(184, 71);
            this.addItemButton.TabIndex = 76;
            this.addItemButton.Text = "Add Item";
            this.addItemButton.UseVisualStyleBackColor = false;
            this.addItemButton.Click += new System.EventHandler(this.addItemButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(130)))), ((int)(((byte)(100)))));
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(943, 791);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(318, 8);
            this.panel2.TabIndex = 74;
            // 
            // totalCostTextBox
            // 
            this.totalCostTextBox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.totalCostTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.totalCostTextBox.Font = new System.Drawing.Font("Microsoft Uighur", 22.2F, System.Drawing.FontStyle.Bold);
            this.totalCostTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(111)))), ((int)(((byte)(24)))));
            this.totalCostTextBox.Location = new System.Drawing.Point(943, 734);
            this.totalCostTextBox.Name = "totalCostTextBox";
            this.totalCostTextBox.Size = new System.Drawing.Size(318, 48);
            this.totalCostTextBox.TabIndex = 73;
            // 
            // totalCostLabel
            // 
            this.totalCostLabel.AutoSize = true;
            this.totalCostLabel.Font = new System.Drawing.Font("Microsoft Uighur", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCostLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(111)))), ((int)(((byte)(24)))));
            this.totalCostLabel.Location = new System.Drawing.Point(539, 938);
            this.totalCostLabel.Name = "totalCostLabel";
            this.totalCostLabel.Size = new System.Drawing.Size(174, 54);
            this.totalCostLabel.TabIndex = 72;
            this.totalCostLabel.Text = "Total Cost:";
            this.totalCostLabel.Click += new System.EventHandler(this.totalCostLabel_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(167)))), ((int)(((byte)(137)))));
            this.panel8.Controls.Add(this.paymentButton);
            this.panel8.Controls.Add(this.prescriptionButton);
            this.panel8.Controls.Add(this.settingsButton);
            this.panel8.Controls.Add(this.dashboardButton);
            this.panel8.Controls.Add(this.pictureBox10);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(422, 1178);
            this.panel8.TabIndex = 71;
            // 
            // paymentButton
            // 
            this.paymentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(167)))), ((int)(((byte)(137)))));
            this.paymentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.paymentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.paymentButton.Font = new System.Drawing.Font("MS Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.paymentButton.Image = global::Dental_Clinic_Management.Properties.Resources.icons8_cash_50__1_;
            this.paymentButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.paymentButton.Location = new System.Drawing.Point(0, 454);
            this.paymentButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.paymentButton.Name = "paymentButton";
            this.paymentButton.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.paymentButton.Size = new System.Drawing.Size(422, 78);
            this.paymentButton.TabIndex = 26;
            this.paymentButton.Text = "Payment";
            this.paymentButton.UseVisualStyleBackColor = false;
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
            this.prescriptionButton.Location = new System.Drawing.Point(-3, 605);
            this.prescriptionButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.prescriptionButton.Name = "prescriptionButton";
            this.prescriptionButton.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.prescriptionButton.Size = new System.Drawing.Size(422, 78);
            this.prescriptionButton.TabIndex = 25;
            this.prescriptionButton.Text = "  Prescreption";
            this.prescriptionButton.UseVisualStyleBackColor = false;
            // 
            // settingsButton
            // 
            this.settingsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(167)))), ((int)(((byte)(137)))));
            this.settingsButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.Font = new System.Drawing.Font("MS Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.settingsButton.Image = global::Dental_Clinic_Management.Properties.Resources.icons8_setting_50__1_;
            this.settingsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingsButton.Location = new System.Drawing.Point(0, 752);
            this.settingsButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.settingsButton.Size = new System.Drawing.Size(422, 78);
            this.settingsButton.TabIndex = 23;
            this.settingsButton.Text = "Settings";
            this.settingsButton.UseVisualStyleBackColor = false;
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
            this.dashboardButton.Location = new System.Drawing.Point(0, 300);
            this.dashboardButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dashboardButton.Name = "dashboardButton";
            this.dashboardButton.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.dashboardButton.Size = new System.Drawing.Size(422, 78);
            this.dashboardButton.TabIndex = 19;
            this.dashboardButton.Text = "DashBoard";
            this.dashboardButton.UseVisualStyleBackColor = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(167)))), ((int)(((byte)(137)))));
            this.pictureBox10.BackgroundImage = global::Dental_Clinic_Management.Properties.Resources.Logo;
            this.pictureBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox10.Location = new System.Drawing.Point(0, 0);
            this.pictureBox10.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(422, 234);
            this.pictureBox10.TabIndex = 17;
            this.pictureBox10.TabStop = false;
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2020, 1178);
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
        private System.Windows.Forms.Button paymentButton;
        private System.Windows.Forms.Button prescriptionButton;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button dashboardButton;
        private System.Windows.Forms.PictureBox pictureBox10;
    }
}