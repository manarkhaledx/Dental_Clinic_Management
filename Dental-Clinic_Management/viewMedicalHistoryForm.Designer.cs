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
            this.pickDateLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.appointmentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.billingDataGridView.Location = new System.Drawing.Point(48, 230);
            this.billingDataGridView.Name = "billingDataGridView";
            this.billingDataGridView.RowHeadersWidth = 62;
            this.billingDataGridView.RowTemplate.Height = 28;
            this.billingDataGridView.Size = new System.Drawing.Size(1316, 717);
            this.billingDataGridView.TabIndex = 59;
            // 
            // pickDateLabel
            // 
            this.pickDateLabel.AutoSize = true;
            this.pickDateLabel.Font = new System.Drawing.Font("Times New Roman", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pickDateLabel.Location = new System.Drawing.Point(774, 45);
            this.pickDateLabel.Name = "pickDateLabel";
            this.pickDateLabel.Size = new System.Drawing.Size(407, 65);
            this.pickDateLabel.TabIndex = 58;
            this.pickDateLabel.Text = "Medical History";
            this.pickDateLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(1430, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 717);
            this.label1.TabIndex = 61;
            this.label1.Text = "prescription view";
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
            // viewMedicalHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1903, 1071);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.billingDataGridView);
            this.Controls.Add(this.pickDateLabel);
            this.Name = "viewMedicalHistoryForm";
            this.Text = "viewMedicalHistoryForm";
            ((System.ComponentModel.ISupportInitialize)(this.billingDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView billingDataGridView;
        private System.Windows.Forms.Label pickDateLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn appointmentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn prescription;
    }
}