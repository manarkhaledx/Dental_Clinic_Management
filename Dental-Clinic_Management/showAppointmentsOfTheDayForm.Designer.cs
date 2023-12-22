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
            this.currentAppointmentsLabel = new System.Windows.Forms.Label();
            this.addAppointmentButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // appointmentDataGridView
            // 
            this.appointmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appointmentDataGridView.Location = new System.Drawing.Point(38, 170);
            this.appointmentDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.appointmentDataGridView.Name = "appointmentDataGridView";
            this.appointmentDataGridView.RowHeadersWidth = 62;
            this.appointmentDataGridView.RowTemplate.Height = 28;
            this.appointmentDataGridView.Size = new System.Drawing.Size(878, 466);
            this.appointmentDataGridView.TabIndex = 63;
            this.appointmentDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.appointmentDataGridView_CellContentClick);
            // 
            // currentAppointmentsLabel
            // 
            this.currentAppointmentsLabel.AutoSize = true;
            this.currentAppointmentsLabel.Font = new System.Drawing.Font("Times New Roman", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentAppointmentsLabel.Location = new System.Drawing.Point(389, 46);
            this.currentAppointmentsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.currentAppointmentsLabel.Name = "currentAppointmentsLabel";
            this.currentAppointmentsLabel.Size = new System.Drawing.Size(405, 44);
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
            this.addAppointmentButton.Location = new System.Drawing.Point(987, 618);
            this.addAppointmentButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addAppointmentButton.Name = "addAppointmentButton";
            this.addAppointmentButton.Size = new System.Drawing.Size(102, 46);
            this.addAppointmentButton.TabIndex = 64;
            this.addAppointmentButton.Text = "Add";
            this.addAppointmentButton.UseVisualStyleBackColor = false;
            // 
            // showAppointmentsOfTheDayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 609);
            this.Controls.Add(this.addAppointmentButton);
            this.Controls.Add(this.appointmentDataGridView);
            this.Controls.Add(this.currentAppointmentsLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "showAppointmentsOfTheDayForm";
            this.Text = "showAppointmentsOfTheDayForm";
            this.Load += new System.EventHandler(this.showAppointmentsOfTheDayForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView appointmentDataGridView;
        private System.Windows.Forms.Label currentAppointmentsLabel;
        private System.Windows.Forms.Button addAppointmentButton;
    }
}