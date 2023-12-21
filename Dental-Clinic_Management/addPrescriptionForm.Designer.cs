namespace Dental_Clinic_Management
{
    partial class addPrescriptionForm
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
            this.savePrescriptionButton = new System.Windows.Forms.Button();
            this.prescriptionTextBox = new System.Windows.Forms.TextBox();
            this.prescriptionLabel = new System.Windows.Forms.Label();
            this.addPrescriptionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // savePrescriptionButton
            // 
            this.savePrescriptionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(167)))), ((int)(((byte)(137)))));
            this.savePrescriptionButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.savePrescriptionButton.FlatAppearance.BorderSize = 0;
            this.savePrescriptionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savePrescriptionButton.Location = new System.Drawing.Point(702, 914);
            this.savePrescriptionButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.savePrescriptionButton.Name = "savePrescriptionButton";
            this.savePrescriptionButton.Size = new System.Drawing.Size(153, 70);
            this.savePrescriptionButton.TabIndex = 36;
            this.savePrescriptionButton.Text = "Save";
            this.savePrescriptionButton.UseVisualStyleBackColor = false;
            this.savePrescriptionButton.Click += new System.EventHandler(this.savePrescriptionButton_Click);
            // 
            // prescriptionTextBox
            // 
            this.prescriptionTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(111)))), ((int)(((byte)(24)))));
            this.prescriptionTextBox.Location = new System.Drawing.Point(56, 233);
            this.prescriptionTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.prescriptionTextBox.Multiline = true;
            this.prescriptionTextBox.Name = "prescriptionTextBox";
            this.prescriptionTextBox.Size = new System.Drawing.Size(720, 643);
            this.prescriptionTextBox.TabIndex = 34;
            this.prescriptionTextBox.TextChanged += new System.EventHandler(this.prescriptionTextBox_TextChanged);
            // 
            // prescriptionLabel
            // 
            this.prescriptionLabel.AutoSize = true;
            this.prescriptionLabel.Font = new System.Drawing.Font("Microsoft Uighur", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prescriptionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(111)))), ((int)(((byte)(24)))));
            this.prescriptionLabel.Location = new System.Drawing.Point(333, 165);
            this.prescriptionLabel.Name = "prescriptionLabel";
            this.prescriptionLabel.Size = new System.Drawing.Size(190, 54);
            this.prescriptionLabel.TabIndex = 32;
            this.prescriptionLabel.Text = "Prescription";
            // 
            // addPrescriptionLabel
            // 
            this.addPrescriptionLabel.AutoSize = true;
            this.addPrescriptionLabel.Font = new System.Drawing.Font("Times New Roman", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPrescriptionLabel.Location = new System.Drawing.Point(71, 48);
            this.addPrescriptionLabel.Name = "addPrescriptionLabel";
            this.addPrescriptionLabel.Size = new System.Drawing.Size(452, 65);
            this.addPrescriptionLabel.TabIndex = 29;
            this.addPrescriptionLabel.Text = "Add Presecription";
            // 
            // addPrescriptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 1044);
            this.Controls.Add(this.savePrescriptionButton);
            this.Controls.Add(this.prescriptionTextBox);
            this.Controls.Add(this.prescriptionLabel);
            this.Controls.Add(this.addPrescriptionLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "addPrescriptionForm";
            this.Text = "addPrescriptionForm";
            this.Load += new System.EventHandler(this.addPrescriptionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button savePrescriptionButton;
        private System.Windows.Forms.TextBox prescriptionTextBox;
        private System.Windows.Forms.Label prescriptionLabel;
        private System.Windows.Forms.Label addPrescriptionLabel;
    }
}