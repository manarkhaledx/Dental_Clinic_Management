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
            this.saveButton = new System.Windows.Forms.Button();
            this.allergiesTextBox = new System.Windows.Forms.TextBox();
            this.allergiesLabel = new System.Windows.Forms.Label();
            this.addRecordLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(167)))), ((int)(((byte)(137)))));
            this.saveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.saveButton.FlatAppearance.BorderSize = 0;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Location = new System.Drawing.Point(624, 731);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(136, 56);
            this.saveButton.TabIndex = 36;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            // 
            // allergiesTextBox
            // 
            this.allergiesTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(111)))), ((int)(((byte)(24)))));
            this.allergiesTextBox.Location = new System.Drawing.Point(175, 281);
            this.allergiesTextBox.Multiline = true;
            this.allergiesTextBox.Name = "allergiesTextBox";
            this.allergiesTextBox.Size = new System.Drawing.Size(515, 421);
            this.allergiesTextBox.TabIndex = 34;
            // 
            // allergiesLabel
            // 
            this.allergiesLabel.AutoSize = true;
            this.allergiesLabel.Font = new System.Drawing.Font("Microsoft Uighur", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allergiesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(111)))), ((int)(((byte)(24)))));
            this.allergiesLabel.Location = new System.Drawing.Point(359, 205);
            this.allergiesLabel.Name = "allergiesLabel";
            this.allergiesLabel.Size = new System.Drawing.Size(158, 45);
            this.allergiesLabel.TabIndex = 32;
            this.allergiesLabel.Text = "Prescription";
            // 
            // addRecordLabel
            // 
            this.addRecordLabel.AutoSize = true;
            this.addRecordLabel.Font = new System.Drawing.Font("Times New Roman", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addRecordLabel.Location = new System.Drawing.Point(63, 38);
            this.addRecordLabel.Name = "addRecordLabel";
            this.addRecordLabel.Size = new System.Drawing.Size(372, 52);
            this.addRecordLabel.TabIndex = 29;
            this.addRecordLabel.Text = "Add Presecription";
            // 
            // addPrescriptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 835);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.allergiesTextBox);
            this.Controls.Add(this.allergiesLabel);
            this.Controls.Add(this.addRecordLabel);
            this.Name = "addPrescriptionForm";
            this.Text = "addPrescriptionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox allergiesTextBox;
        private System.Windows.Forms.Label allergiesLabel;
        private System.Windows.Forms.Label addRecordLabel;
    }
}