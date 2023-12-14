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
            this.appointmentDataGridView = new System.Windows.Forms.DataGridView();
            this.appointmentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentAppointmentsLabel = new System.Windows.Forms.Label();
            this.addAppointmentButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // appointmentDataGridView
            // 
            this.appointmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appointmentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.appointmentID,
            this.patientName,
            this.patientPhone});
            this.appointmentDataGridView.Location = new System.Drawing.Point(57, 261);
            this.appointmentDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.appointmentDataGridView.Name = "appointmentDataGridView";
            this.appointmentDataGridView.RowHeadersWidth = 62;
            this.appointmentDataGridView.RowTemplate.Height = 28;
            this.appointmentDataGridView.Size = new System.Drawing.Size(1316, 718);
            this.appointmentDataGridView.TabIndex = 63;
            // 
            // appointmentID
            // 
            this.appointmentID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.appointmentID.HeaderText = "AppointmentID";
            this.appointmentID.MinimumWidth = 8;
            this.appointmentID.Name = "appointmentID";
            // 
            // patientName
            // 
            this.patientName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.patientName.HeaderText = "PatientName";
            this.patientName.MinimumWidth = 8;
            this.patientName.Name = "patientName";
            // 
            // patientPhone
            // 
            this.patientPhone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.patientPhone.HeaderText = "PatientPhone";
            this.patientPhone.MinimumWidth = 6;
            this.patientPhone.Name = "patientPhone";
            // 
            // currentAppointmentsLabel
            // 
            this.currentAppointmentsLabel.AutoSize = true;
            this.currentAppointmentsLabel.Font = new System.Drawing.Font("Times New Roman", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentAppointmentsLabel.Location = new System.Drawing.Point(584, 70);
            this.currentAppointmentsLabel.Name = "currentAppointmentsLabel";
            this.currentAppointmentsLabel.Size = new System.Drawing.Size(604, 65);
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
            this.addAppointmentButton.Location = new System.Drawing.Point(1480, 951);
            this.addAppointmentButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addAppointmentButton.Name = "addAppointmentButton";
            this.addAppointmentButton.Size = new System.Drawing.Size(153, 70);
            this.addAppointmentButton.TabIndex = 64;
            this.addAppointmentButton.Text = "Add";
            this.addAppointmentButton.UseVisualStyleBackColor = false;
            // 
            // showAppointmentsOfTheDayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1846, 1118);
            this.Controls.Add(this.addAppointmentButton);
            this.Controls.Add(this.appointmentDataGridView);
            this.Controls.Add(this.currentAppointmentsLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "showAppointmentsOfTheDayForm";
            this.Text = "showAppointmentsOfTheDayForm";
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView appointmentDataGridView;
        private System.Windows.Forms.Label currentAppointmentsLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn appointmentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientPhone;
        private System.Windows.Forms.Button addAppointmentButton;
    }
}