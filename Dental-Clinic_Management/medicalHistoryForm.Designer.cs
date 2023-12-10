﻿namespace Dental_Clinic_Management
{
    partial class medicalHistoryForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.medicalHistoryLabel = new System.Windows.Forms.Label();
            this.phoneAndNameDataGridView = new System.Windows.Forms.DataGridView();
            this.patientPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewPatientRecordButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.phoneAndNameDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(130)))), ((int)(((byte)(100)))));
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(43, 154);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(559, 1);
            this.panel1.TabIndex = 24;
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phoneNumberTextBox.Font = new System.Drawing.Font("Microsoft Uighur", 22.2F, System.Drawing.FontStyle.Bold);
            this.phoneNumberTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(111)))), ((int)(((byte)(24)))));
            this.phoneNumberTextBox.Location = new System.Drawing.Point(43, 108);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(559, 32);
            this.phoneNumberTextBox.TabIndex = 23;
            this.phoneNumberTextBox.Text = "Phone Number";
            // 
            // medicalHistoryLabel
            // 
            this.medicalHistoryLabel.AutoSize = true;
            this.medicalHistoryLabel.Font = new System.Drawing.Font("Times New Roman", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medicalHistoryLabel.Location = new System.Drawing.Point(688, 37);
            this.medicalHistoryLabel.Name = "medicalHistoryLabel";
            this.medicalHistoryLabel.Size = new System.Drawing.Size(275, 44);
            this.medicalHistoryLabel.TabIndex = 53;
            this.medicalHistoryLabel.Text = "Medical History";
            this.medicalHistoryLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // phoneAndNameDataGridView
            // 
            this.phoneAndNameDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.phoneAndNameDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.patientPhone,
            this.patientName});
            this.phoneAndNameDataGridView.Location = new System.Drawing.Point(43, 185);
            this.phoneAndNameDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.phoneAndNameDataGridView.Name = "phoneAndNameDataGridView";
            this.phoneAndNameDataGridView.RowHeadersWidth = 62;
            this.phoneAndNameDataGridView.RowTemplate.Height = 28;
            this.phoneAndNameDataGridView.Size = new System.Drawing.Size(1252, 574);
            this.phoneAndNameDataGridView.TabIndex = 54;
            // 
            // patientPhone
            // 
            this.patientPhone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.patientPhone.HeaderText = "PatientPhone";
            this.patientPhone.MinimumWidth = 8;
            this.patientPhone.Name = "patientPhone";
            // 
            // patientName
            // 
            this.patientName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.patientName.HeaderText = "PatientName";
            this.patientName.MinimumWidth = 8;
            this.patientName.Name = "patientName";
            // 
            // viewPatientRecordButton
            // 
            this.viewPatientRecordButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(167)))), ((int)(((byte)(137)))));
            this.viewPatientRecordButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.viewPatientRecordButton.FlatAppearance.BorderSize = 0;
            this.viewPatientRecordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewPatientRecordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.viewPatientRecordButton.Location = new System.Drawing.Point(1436, 778);
            this.viewPatientRecordButton.Name = "viewPatientRecordButton";
            this.viewPatientRecordButton.Size = new System.Drawing.Size(136, 56);
            this.viewPatientRecordButton.TabIndex = 55;
            this.viewPatientRecordButton.Text = "View";
            this.viewPatientRecordButton.UseVisualStyleBackColor = false;
            // 
            // medicalHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1692, 857);
            this.Controls.Add(this.viewPatientRecordButton);
            this.Controls.Add(this.phoneAndNameDataGridView);
            this.Controls.Add(this.medicalHistoryLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "medicalHistoryForm";
            this.Text = "medicalHistoryForm";
            ((System.ComponentModel.ISupportInitialize)(this.phoneAndNameDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.Label medicalHistoryLabel;
        private System.Windows.Forms.DataGridView phoneAndNameDataGridView;
        private System.Windows.Forms.Button viewPatientRecordButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientName;
    }
}