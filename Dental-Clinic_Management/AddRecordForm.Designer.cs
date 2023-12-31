﻿namespace Dental_Clinic_Management
{
    partial class AddRecordForm
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
            this.dobDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dobLabel = new System.Windows.Forms.Label();
            this.patientRecordLabel = new System.Windows.Forms.Label();
            this.femaleRadioButton = new System.Windows.Forms.RadioButton();
            this.maleRadioButton = new System.Windows.Forms.RadioButton();
            this.savePatientButton = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.closePictureBox = new System.Windows.Forms.PictureBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.genderGroupBox = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.closePictureBox)).BeginInit();
            this.genderGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // dobDateTimePicker
            // 
            this.dobDateTimePicker.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(111)))), ((int)(((byte)(24)))));
            this.dobDateTimePicker.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dobDateTimePicker.CalendarTitleForeColor = System.Drawing.SystemColors.ControlText;
            this.dobDateTimePicker.Font = new System.Drawing.Font("Microsoft Uighur", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobDateTimePicker.Location = new System.Drawing.Point(146, 408);
            this.dobDateTimePicker.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dobDateTimePicker.Name = "dobDateTimePicker";
            this.dobDateTimePicker.Size = new System.Drawing.Size(325, 36);
            this.dobDateTimePicker.TabIndex = 40;
            // 
            // dobLabel
            // 
            this.dobLabel.AutoSize = true;
            this.dobLabel.Font = new System.Drawing.Font("Microsoft Uighur", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(111)))), ((int)(((byte)(24)))));
            this.dobLabel.Location = new System.Drawing.Point(45, 407);
            this.dobLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dobLabel.Name = "dobLabel";
            this.dobLabel.Size = new System.Drawing.Size(64, 37);
            this.dobLabel.TabIndex = 39;
            this.dobLabel.Text = "DOB";
            // 
            // patientRecordLabel
            // 
            this.patientRecordLabel.AutoSize = true;
            this.patientRecordLabel.Font = new System.Drawing.Font("Times New Roman", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientRecordLabel.Location = new System.Drawing.Point(44, 82);
            this.patientRecordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.patientRecordLabel.Name = "patientRecordLabel";
            this.patientRecordLabel.Size = new System.Drawing.Size(280, 44);
            this.patientRecordLabel.TabIndex = 38;
            this.patientRecordLabel.Text = "Patient\'s Record";
            // 
            // femaleRadioButton
            // 
            this.femaleRadioButton.AutoSize = true;
            this.femaleRadioButton.Location = new System.Drawing.Point(34, 32);
            this.femaleRadioButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.femaleRadioButton.Name = "femaleRadioButton";
            this.femaleRadioButton.Size = new System.Drawing.Size(80, 41);
            this.femaleRadioButton.TabIndex = 13;
            this.femaleRadioButton.TabStop = true;
            this.femaleRadioButton.Text = "Male";
            this.femaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // maleRadioButton
            // 
            this.maleRadioButton.AutoSize = true;
            this.maleRadioButton.Location = new System.Drawing.Point(34, 76);
            this.maleRadioButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.maleRadioButton.Name = "maleRadioButton";
            this.maleRadioButton.Size = new System.Drawing.Size(99, 41);
            this.maleRadioButton.TabIndex = 14;
            this.maleRadioButton.TabStop = true;
            this.maleRadioButton.Text = "Female";
            this.maleRadioButton.UseVisualStyleBackColor = true;
            // 
            // savePatientButton
            // 
            this.savePatientButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(167)))), ((int)(((byte)(137)))));
            this.savePatientButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.savePatientButton.FlatAppearance.BorderSize = 0;
            this.savePatientButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savePatientButton.Location = new System.Drawing.Point(394, 543);
            this.savePatientButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.savePatientButton.Name = "savePatientButton";
            this.savePatientButton.Size = new System.Drawing.Size(102, 46);
            this.savePatientButton.TabIndex = 51;
            this.savePatientButton.Text = "Save";
            this.savePatientButton.UseVisualStyleBackColor = false;
            this.savePatientButton.Click += new System.EventHandler(this.savePatientButton_Click_1);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(130)))), ((int)(((byte)(100)))));
            this.panel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.Location = new System.Drawing.Point(52, 209);
            this.panel5.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(418, 2);
            this.panel5.TabIndex = 50;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.firstNameTextBox.Font = new System.Drawing.Font("Microsoft Uighur", 22.2F, System.Drawing.FontStyle.Bold);
            this.firstNameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(111)))), ((int)(((byte)(24)))));
            this.firstNameTextBox.Location = new System.Drawing.Point(52, 171);
            this.firstNameTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(418, 32);
            this.firstNameTextBox.TabIndex = 49;
            this.firstNameTextBox.Text = "First Name";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(130)))), ((int)(((byte)(100)))));
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(52, 376);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(418, 2);
            this.panel4.TabIndex = 48;
            // 
            // addressTextBox
            // 
            this.addressTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addressTextBox.Font = new System.Drawing.Font("Microsoft Uighur", 22.2F, System.Drawing.FontStyle.Bold);
            this.addressTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(111)))), ((int)(((byte)(24)))));
            this.addressTextBox.Location = new System.Drawing.Point(52, 339);
            this.addressTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(418, 32);
            this.addressTextBox.TabIndex = 47;
            this.addressTextBox.Text = "Address";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(130)))), ((int)(((byte)(100)))));
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(52, 321);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(418, 2);
            this.panel3.TabIndex = 46;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phoneTextBox.Font = new System.Drawing.Font("Microsoft Uighur", 22.2F, System.Drawing.FontStyle.Bold);
            this.phoneTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(111)))), ((int)(((byte)(24)))));
            this.phoneTextBox.Location = new System.Drawing.Point(52, 283);
            this.phoneTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(418, 32);
            this.phoneTextBox.TabIndex = 45;
            this.phoneTextBox.Text = "Phone";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(130)))), ((int)(((byte)(100)))));
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(52, 266);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(418, 2);
            this.panel1.TabIndex = 44;
            // 
            // closePictureBox
            // 
            this.closePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closePictureBox.BackgroundImage = global::Dental_Clinic_Management.Properties.Resources.Exit;
            this.closePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closePictureBox.Location = new System.Drawing.Point(584, 11);
            this.closePictureBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.closePictureBox.Name = "closePictureBox";
            this.closePictureBox.Size = new System.Drawing.Size(24, 26);
            this.closePictureBox.TabIndex = 43;
            this.closePictureBox.TabStop = false;
            this.closePictureBox.Click += new System.EventHandler(this.closePictureBox_Click);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lastNameTextBox.Font = new System.Drawing.Font("Microsoft Uighur", 22.2F, System.Drawing.FontStyle.Bold);
            this.lastNameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(111)))), ((int)(((byte)(24)))));
            this.lastNameTextBox.Location = new System.Drawing.Point(52, 228);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(418, 32);
            this.lastNameTextBox.TabIndex = 42;
            this.lastNameTextBox.Text = "Last Name";
            // 
            // genderGroupBox
            // 
            this.genderGroupBox.Controls.Add(this.femaleRadioButton);
            this.genderGroupBox.Controls.Add(this.maleRadioButton);
            this.genderGroupBox.Font = new System.Drawing.Font("Microsoft Uighur", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(111)))), ((int)(((byte)(24)))));
            this.genderGroupBox.Location = new System.Drawing.Point(31, 466);
            this.genderGroupBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.genderGroupBox.Name = "genderGroupBox";
            this.genderGroupBox.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.genderGroupBox.Size = new System.Drawing.Size(212, 133);
            this.genderGroupBox.TabIndex = 41;
            this.genderGroupBox.TabStop = false;
            this.genderGroupBox.Text = "Gender";
            // 
            // AddRecordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(617, 717);
            this.ControlBox = false;
            this.Controls.Add(this.dobDateTimePicker);
            this.Controls.Add(this.dobLabel);
            this.Controls.Add(this.patientRecordLabel);
            this.Controls.Add(this.savePatientButton);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.closePictureBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.genderGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "AddRecordForm";
            this.Text = "AddRecordForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AddRecordForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.closePictureBox)).EndInit();
            this.genderGroupBox.ResumeLayout(false);
            this.genderGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dobDateTimePicker;
        private System.Windows.Forms.Label dobLabel;
        private System.Windows.Forms.Label patientRecordLabel;
        private System.Windows.Forms.RadioButton femaleRadioButton;
        private System.Windows.Forms.RadioButton maleRadioButton;
        private System.Windows.Forms.Button savePatientButton;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox closePictureBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.GroupBox genderGroupBox;
    }
}