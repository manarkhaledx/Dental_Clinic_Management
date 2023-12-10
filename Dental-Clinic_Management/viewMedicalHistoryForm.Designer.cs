namespace Dental_Clinic_Management
{
    partial class viewMedicalHistoryForm
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
            this.appointmentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pickDateLabel = new System.Windows.Forms.Label();
            this.prescriptionViewLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.billingDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // billingDataGridView
            // 
            this.billingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.billingDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.appointmentID,
            this.patientName,
            this.prescription});
            this.billingDataGridView.Location = new System.Drawing.Point(43, 184);
            this.billingDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.billingDataGridView.Name = "billingDataGridView";
            this.billingDataGridView.RowHeadersWidth = 62;
            this.billingDataGridView.RowTemplate.Height = 28;
            this.billingDataGridView.Size = new System.Drawing.Size(1170, 574);
            this.billingDataGridView.TabIndex = 59;
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
            // prescription
            // 
            this.prescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.prescription.HeaderText = "Prescription";
            this.prescription.MinimumWidth = 8;
            this.prescription.Name = "prescription";
            // 
            // pickDateLabel
            // 
            this.pickDateLabel.AutoSize = true;
            this.pickDateLabel.Font = new System.Drawing.Font("Times New Roman", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pickDateLabel.Location = new System.Drawing.Point(688, 36);
            this.pickDateLabel.Name = "pickDateLabel";
            this.pickDateLabel.Size = new System.Drawing.Size(336, 52);
            this.pickDateLabel.TabIndex = 58;
            this.pickDateLabel.Text = "Medical History";
            this.pickDateLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // prescriptionViewLabel
            // 
            this.prescriptionViewLabel.Location = new System.Drawing.Point(1271, 184);
            this.prescriptionViewLabel.Name = "prescriptionViewLabel";
            this.prescriptionViewLabel.Size = new System.Drawing.Size(363, 574);
            this.prescriptionViewLabel.TabIndex = 61;
            this.prescriptionViewLabel.Text = "prescription view";
            // 
            // viewMedicalHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1692, 844);
            this.Controls.Add(this.prescriptionViewLabel);
            this.Controls.Add(this.billingDataGridView);
            this.Controls.Add(this.pickDateLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "viewMedicalHistoryForm";
            this.Text = "viewMedicalHistoryForm";
            ((System.ComponentModel.ISupportInitialize)(this.billingDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView billingDataGridView;
        private System.Windows.Forms.Label pickDateLabel;
        private System.Windows.Forms.Label prescriptionViewLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn appointmentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn prescription;
    }
}