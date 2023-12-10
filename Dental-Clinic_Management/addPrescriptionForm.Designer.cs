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
            this.savePrescriptionButton.Location = new System.Drawing.Point(624, 731);
            this.savePrescriptionButton.Name = "savePrescriptionButton";
            this.savePrescriptionButton.Size = new System.Drawing.Size(136, 56);
            this.savePrescriptionButton.TabIndex = 36;
            this.savePrescriptionButton.Text = "Save";
            this.savePrescriptionButton.UseVisualStyleBackColor = false;
            // 
            // prescriptionTextBox
            // 
            this.prescriptionTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(111)))), ((int)(((byte)(24)))));
            this.prescriptionTextBox.Location = new System.Drawing.Point(175, 281);
            this.prescriptionTextBox.Multiline = true;
            this.prescriptionTextBox.Name = "prescriptionTextBox";
            this.prescriptionTextBox.Size = new System.Drawing.Size(515, 421);
            this.prescriptionTextBox.TabIndex = 34;
            // 
            // prescriptionLabel
            // 
            this.prescriptionLabel.AutoSize = true;
            this.prescriptionLabel.Font = new System.Drawing.Font("Microsoft Uighur", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prescriptionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(111)))), ((int)(((byte)(24)))));
            this.prescriptionLabel.Location = new System.Drawing.Point(359, 205);
            this.prescriptionLabel.Name = "prescriptionLabel";
            this.prescriptionLabel.Size = new System.Drawing.Size(158, 45);
            this.prescriptionLabel.TabIndex = 32;
            this.prescriptionLabel.Text = "Prescription";
            // 
            // addPrescriptionLabel
            // 
            this.addPrescriptionLabel.AutoSize = true;
            this.addPrescriptionLabel.Font = new System.Drawing.Font("Times New Roman", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPrescriptionLabel.Location = new System.Drawing.Point(63, 38);
            this.addPrescriptionLabel.Name = "addPrescriptionLabel";
            this.addPrescriptionLabel.Size = new System.Drawing.Size(372, 52);
            this.addPrescriptionLabel.TabIndex = 29;
            this.addPrescriptionLabel.Text = "Add Presecription";
            // 
            // addPrescriptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 835);
            this.Controls.Add(this.savePrescriptionButton);
            this.Controls.Add(this.prescriptionTextBox);
            this.Controls.Add(this.prescriptionLabel);
            this.Controls.Add(this.addPrescriptionLabel);
            this.Name = "addPrescriptionForm";
            this.Text = "addPrescriptionForm";
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