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
            this.medicalHistoryDataGridView = new System.Windows.Forms.DataGridView();
            this.appointmentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicalHistoryLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.totalCostTextBox = new System.Windows.Forms.TextBox();
            this.totalCostLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.medicalHistoryDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // medicalHistoryDataGridView
            // 
            this.medicalHistoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.medicalHistoryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.appointmentID,
            this.patientName,
            this.prescription});
            this.medicalHistoryDataGridView.Location = new System.Drawing.Point(86, 143);
            this.medicalHistoryDataGridView.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.medicalHistoryDataGridView.Name = "medicalHistoryDataGridView";
            this.medicalHistoryDataGridView.RowHeadersWidth = 62;
            this.medicalHistoryDataGridView.RowTemplate.Height = 28;
            this.medicalHistoryDataGridView.Size = new System.Drawing.Size(1110, 467);
            this.medicalHistoryDataGridView.TabIndex = 59;
            this.medicalHistoryDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.medicalHistoryDataGridView_CellContentClick);
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
            // medicalHistoryLabel
            // 
            this.medicalHistoryLabel.AutoSize = true;
            this.medicalHistoryLabel.Font = new System.Drawing.Font("Times New Roman", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medicalHistoryLabel.Location = new System.Drawing.Point(516, 29);
            this.medicalHistoryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.medicalHistoryLabel.Name = "medicalHistoryLabel";
            this.medicalHistoryLabel.Size = new System.Drawing.Size(275, 44);
            this.medicalHistoryLabel.TabIndex = 58;
            this.medicalHistoryLabel.Text = "Medical History";
            this.medicalHistoryLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(130)))), ((int)(((byte)(100)))));
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(568, 125);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(212, 5);
            this.panel2.TabIndex = 64;
            // 
            // totalCostTextBox
            // 
            this.totalCostTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.totalCostTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.totalCostTextBox.Font = new System.Drawing.Font("Microsoft Uighur", 22.2F, System.Drawing.FontStyle.Bold);
            this.totalCostTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(111)))), ((int)(((byte)(24)))));
            this.totalCostTextBox.Location = new System.Drawing.Point(568, 92);
            this.totalCostTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.totalCostTextBox.Name = "totalCostTextBox";
            this.totalCostTextBox.Size = new System.Drawing.Size(212, 32);
            this.totalCostTextBox.TabIndex = 63;
            this.totalCostTextBox.TextChanged += new System.EventHandler(this.totalCostTextBox_TextChanged);
            // 
            // totalCostLabel
            // 
            this.totalCostLabel.AutoSize = true;
            this.totalCostLabel.Font = new System.Drawing.Font("Microsoft Uighur", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCostLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(111)))), ((int)(((byte)(24)))));
            this.totalCostLabel.Location = new System.Drawing.Point(406, 92);
            this.totalCostLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalCostLabel.Name = "totalCostLabel";
            this.totalCostLabel.Size = new System.Drawing.Size(157, 37);
            this.totalCostLabel.TabIndex = 62;
            this.totalCostLabel.Text = "Phone Number:";
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(167)))), ((int)(((byte)(137)))));
            this.searchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.searchButton.FlatAppearance.BorderSize = 0;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.searchButton.Location = new System.Drawing.Point(1094, 633);
            this.searchButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(102, 46);
            this.searchButton.TabIndex = 65;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            // 
            // viewMedicalHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 609);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.totalCostTextBox);
            this.Controls.Add(this.totalCostLabel);
            this.Controls.Add(this.medicalHistoryDataGridView);
            this.Controls.Add(this.medicalHistoryLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "viewMedicalHistoryForm";
            this.Text = "viewMedicalHistoryForm";
            this.Load += new System.EventHandler(this.viewMedicalHistoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.medicalHistoryDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView medicalHistoryDataGridView;
        private System.Windows.Forms.Label medicalHistoryLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn appointmentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn prescription;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox totalCostTextBox;
        private System.Windows.Forms.Label totalCostLabel;
        private System.Windows.Forms.Button searchButton;
    }
}