﻿namespace Dental_Clinic_Management
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
            this.appointmentDataGridView = new System.Windows.Forms.DataGridView();
            this.currentAppointmentsLabel = new System.Windows.Forms.Label();
            this.addAppointmentButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // appointmentDataGridView
            // 
            this.appointmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appointmentDataGridView.Location = new System.Drawing.Point(51, 209);
            this.appointmentDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.appointmentDataGridView.Name = "appointmentDataGridView";
            this.appointmentDataGridView.RowHeadersWidth = 62;
            this.appointmentDataGridView.RowTemplate.Height = 28;
            this.appointmentDataGridView.Size = new System.Drawing.Size(1170, 574);
            this.appointmentDataGridView.TabIndex = 63;
            // 
            // currentAppointmentsLabel
            // 
            this.currentAppointmentsLabel.AutoSize = true;
            this.currentAppointmentsLabel.Font = new System.Drawing.Font("Times New Roman", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentAppointmentsLabel.Location = new System.Drawing.Point(519, 56);
            this.currentAppointmentsLabel.Name = "currentAppointmentsLabel";
            this.currentAppointmentsLabel.Size = new System.Drawing.Size(497, 52);
            this.currentAppointmentsLabel.TabIndex = 62;
            this.currentAppointmentsLabel.Text = "Appointments of the day";
            this.currentAppointmentsLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // addAppointmentButton
            // 
            this.addAppointmentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(167)))), ((int)(((byte)(137)))));
            this.addAppointmentButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addAppointmentButton.FlatAppearance.BorderSize = 0;
            this.addAppointmentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addAppointmentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.addAppointmentButton.Location = new System.Drawing.Point(1316, 761);
            this.addAppointmentButton.Name = "addAppointmentButton";
            this.addAppointmentButton.Size = new System.Drawing.Size(136, 56);
            this.addAppointmentButton.TabIndex = 64;
            this.addAppointmentButton.Text = "Add";
            this.addAppointmentButton.UseVisualStyleBackColor = false;
            // 
            // showAppointmentsOfTheDayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1641, 844);
            this.Controls.Add(this.addAppointmentButton);
            this.Controls.Add(this.appointmentDataGridView);
            this.Controls.Add(this.currentAppointmentsLabel);
            this.Name = "showAppointmentsOfTheDayForm";
            this.Text = "showAppointmentsOfTheDayForm";
            this.Load += new System.EventHandler(this.showAppointmentsOfTheDayForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView appointmentDataGridView;
        private System.Windows.Forms.Label currentAppointmentsLabel;
        private System.Windows.Forms.Button addAppointmentButton;
    }
}