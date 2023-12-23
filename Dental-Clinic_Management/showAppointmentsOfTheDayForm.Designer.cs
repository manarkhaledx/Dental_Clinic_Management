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
            this.addAppointmentButton = new System.Windows.Forms.Button();
            this.appointmentDataGridView = new System.Windows.Forms.DataGridView();
            this.currentAppointmentsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // addAppointmentButton
            // 
            this.addAppointmentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(167)))), ((int)(((byte)(137)))));
            this.addAppointmentButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addAppointmentButton.FlatAppearance.BorderSize = 0;
            this.addAppointmentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addAppointmentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.addAppointmentButton.Location = new System.Drawing.Point(1565, 955);
            this.addAppointmentButton.Name = "addAppointmentButton";
            this.addAppointmentButton.Size = new System.Drawing.Size(153, 71);
            this.addAppointmentButton.TabIndex = 67;
            this.addAppointmentButton.Text = "Add";
            this.addAppointmentButton.UseVisualStyleBackColor = false;
            // 
            // appointmentDataGridView
            // 
            this.appointmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appointmentDataGridView.Location = new System.Drawing.Point(142, 266);
            this.appointmentDataGridView.Name = "appointmentDataGridView";
            this.appointmentDataGridView.RowHeadersWidth = 62;
            this.appointmentDataGridView.RowTemplate.Height = 28;
            this.appointmentDataGridView.Size = new System.Drawing.Size(1317, 717);
            this.appointmentDataGridView.TabIndex = 66;
            // 
            // currentAppointmentsLabel
            // 
            this.currentAppointmentsLabel.AutoSize = true;
            this.currentAppointmentsLabel.Font = new System.Drawing.Font("Times New Roman", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentAppointmentsLabel.Location = new System.Drawing.Point(488, 74);
            this.currentAppointmentsLabel.Name = "currentAppointmentsLabel";
            this.currentAppointmentsLabel.Size = new System.Drawing.Size(604, 65);
            this.currentAppointmentsLabel.TabIndex = 65;
            this.currentAppointmentsLabel.Text = "Appointments of the day";
            this.currentAppointmentsLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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

        private System.Windows.Forms.Button addAppointmentButton;
        private System.Windows.Forms.DataGridView appointmentDataGridView;
        private System.Windows.Forms.Label currentAppointmentsLabel;
    }
}