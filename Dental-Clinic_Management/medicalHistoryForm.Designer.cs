namespace Dental_Clinic_Management
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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.pickDateLabel = new System.Windows.Forms.Label();
            this.billingDataGridView = new System.Windows.Forms.DataGridView();
            this.filterButton = new System.Windows.Forms.Button();
            this.patientPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.billingDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(130)))), ((int)(((byte)(100)))));
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(48, 193);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(629, 1);
            this.panel1.TabIndex = 24;
            // 
            // nameTextBox
            // 
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Uighur", 22.2F, System.Drawing.FontStyle.Bold);
            this.nameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(111)))), ((int)(((byte)(24)))));
            this.nameTextBox.Location = new System.Drawing.Point(48, 135);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(629, 48);
            this.nameTextBox.TabIndex = 23;
            this.nameTextBox.Text = "Phone Number";
            // 
            // pickDateLabel
            // 
            this.pickDateLabel.AutoSize = true;
            this.pickDateLabel.Font = new System.Drawing.Font("Times New Roman", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pickDateLabel.Location = new System.Drawing.Point(774, 46);
            this.pickDateLabel.Name = "pickDateLabel";
            this.pickDateLabel.Size = new System.Drawing.Size(407, 65);
            this.pickDateLabel.TabIndex = 53;
            this.pickDateLabel.Text = "Medical History";
            this.pickDateLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // billingDataGridView
            // 
            this.billingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.billingDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.patientPhone,
            this.patientName});
            this.billingDataGridView.Location = new System.Drawing.Point(48, 231);
            this.billingDataGridView.Name = "billingDataGridView";
            this.billingDataGridView.RowHeadersWidth = 62;
            this.billingDataGridView.RowTemplate.Height = 28;
            this.billingDataGridView.Size = new System.Drawing.Size(1409, 717);
            this.billingDataGridView.TabIndex = 54;
            // 
            // filterButton
            // 
            this.filterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(167)))), ((int)(((byte)(137)))));
            this.filterButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.filterButton.FlatAppearance.BorderSize = 0;
            this.filterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.filterButton.Location = new System.Drawing.Point(1615, 973);
            this.filterButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(153, 70);
            this.filterButton.TabIndex = 55;
            this.filterButton.Text = "View";
            this.filterButton.UseVisualStyleBackColor = false;
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
            // medicalHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1903, 1071);
            this.Controls.Add(this.filterButton);
            this.Controls.Add(this.billingDataGridView);
            this.Controls.Add(this.pickDateLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.nameTextBox);
            this.Name = "medicalHistoryForm";
            this.Text = "medicalHistoryForm";
            ((System.ComponentModel.ISupportInitialize)(this.billingDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label pickDateLabel;
        private System.Windows.Forms.DataGridView billingDataGridView;
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientName;
    }
}