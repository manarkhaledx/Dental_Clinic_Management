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
            this.billingDataGridView = new System.Windows.Forms.DataGridView();
            this.pickDateLabel = new System.Windows.Forms.Label();
            this.appointmentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filterButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.billingDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // billingDataGridView
            // 
            this.billingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.billingDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.appointmentID,
            this.patientName,
            this.patientPhone});
            this.billingDataGridView.Location = new System.Drawing.Point(51, 209);
            this.billingDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.billingDataGridView.Name = "billingDataGridView";
            this.billingDataGridView.RowHeadersWidth = 62;
            this.billingDataGridView.RowTemplate.Height = 28;
            this.billingDataGridView.Size = new System.Drawing.Size(1170, 574);
            this.billingDataGridView.TabIndex = 63;
            // 
            // pickDateLabel
            // 
            this.pickDateLabel.AutoSize = true;
            this.pickDateLabel.Font = new System.Drawing.Font("Times New Roman", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pickDateLabel.Location = new System.Drawing.Point(519, 56);
            this.pickDateLabel.Name = "pickDateLabel";
            this.pickDateLabel.Size = new System.Drawing.Size(497, 52);
            this.pickDateLabel.TabIndex = 62;
            this.pickDateLabel.Text = "Appointments of the day";
            this.pickDateLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            // filterButton
            // 
            this.filterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(167)))), ((int)(((byte)(137)))));
            this.filterButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.filterButton.FlatAppearance.BorderSize = 0;
            this.filterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.filterButton.Location = new System.Drawing.Point(1316, 761);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(136, 56);
            this.filterButton.TabIndex = 64;
            this.filterButton.Text = "Add";
            this.filterButton.UseVisualStyleBackColor = false;
            // 
            // showAppointmentsOfTheDayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1692, 844);
            this.Controls.Add(this.filterButton);
            this.Controls.Add(this.billingDataGridView);
            this.Controls.Add(this.pickDateLabel);
            this.Name = "showAppointmentsOfTheDayForm";
            this.Text = "showAppointmentsOfTheDayForm";
            ((System.ComponentModel.ISupportInitialize)(this.billingDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView billingDataGridView;
        private System.Windows.Forms.Label pickDateLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn appointmentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientPhone;
        private System.Windows.Forms.Button filterButton;
    }
}