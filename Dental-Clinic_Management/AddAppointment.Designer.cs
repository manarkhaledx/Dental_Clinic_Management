namespace Dental_Clinic_Management
{
    partial class AddAppointment
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timeTextBox = new System.Windows.Forms.TextBox();
            this.closePictureBox = new System.Windows.Forms.PictureBox();
            this.saveNewAppointmentButton = new System.Windows.Forms.Button();
            this.appointmentDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateLabel = new System.Windows.Forms.Label();
            this.addAppointmentLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.closePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(130)))), ((int)(((byte)(100)))));
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(60, 251);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(419, 1);
            this.panel3.TabIndex = 56;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phoneTextBox.Font = new System.Drawing.Font("Microsoft Uighur", 22.2F, System.Drawing.FontStyle.Bold);
            this.phoneTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(111)))), ((int)(((byte)(24)))));
            this.phoneTextBox.Location = new System.Drawing.Point(58, 214);
            this.phoneTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(419, 32);
            this.phoneTextBox.TabIndex = 54;
            this.phoneTextBox.Text = "Phone Number";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(130)))), ((int)(((byte)(100)))));
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(58, 312);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(419, 1);
            this.panel2.TabIndex = 53;
            // 
            // timeTextBox
            // 
            this.timeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.timeTextBox.Font = new System.Drawing.Font("Microsoft Uighur", 22.2F, System.Drawing.FontStyle.Bold);
            this.timeTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(111)))), ((int)(((byte)(24)))));
            this.timeTextBox.Location = new System.Drawing.Point(58, 275);
            this.timeTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.Size = new System.Drawing.Size(419, 32);
            this.timeTextBox.TabIndex = 52;
            this.timeTextBox.Text = "Time";
            // 
            // closePictureBox
            // 
            this.closePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closePictureBox.BackgroundImage = global::Dental_Clinic_Management.Properties.Resources.Exit;
            this.closePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closePictureBox.Location = new System.Drawing.Point(60, 76);
            this.closePictureBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.closePictureBox.Name = "closePictureBox";
            this.closePictureBox.Size = new System.Drawing.Size(24, 26);
            this.closePictureBox.TabIndex = 51;
            this.closePictureBox.TabStop = false;
            // 
            // saveNewAppointmentButton
            // 
            this.saveNewAppointmentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(167)))), ((int)(((byte)(137)))));
            this.saveNewAppointmentButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.saveNewAppointmentButton.FlatAppearance.BorderSize = 0;
            this.saveNewAppointmentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveNewAppointmentButton.Location = new System.Drawing.Point(410, 431);
            this.saveNewAppointmentButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.saveNewAppointmentButton.Name = "saveNewAppointmentButton";
            this.saveNewAppointmentButton.Size = new System.Drawing.Size(102, 46);
            this.saveNewAppointmentButton.TabIndex = 50;
            this.saveNewAppointmentButton.Text = "Save";
            this.saveNewAppointmentButton.UseVisualStyleBackColor = false;
            this.saveNewAppointmentButton.Click += new System.EventHandler(this.saveNewAppointmentButton_Click);
            // 
            // appointmentDateTimePicker
            // 
            this.appointmentDateTimePicker.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(111)))), ((int)(((byte)(24)))));
            this.appointmentDateTimePicker.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.appointmentDateTimePicker.CalendarTitleForeColor = System.Drawing.SystemColors.ControlText;
            this.appointmentDateTimePicker.Font = new System.Drawing.Font("Microsoft Uighur", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentDateTimePicker.Location = new System.Drawing.Point(154, 358);
            this.appointmentDateTimePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.appointmentDateTimePicker.Name = "appointmentDateTimePicker";
            this.appointmentDateTimePicker.Size = new System.Drawing.Size(325, 36);
            this.appointmentDateTimePicker.TabIndex = 49;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Uighur", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(111)))), ((int)(((byte)(24)))));
            this.dateLabel.Location = new System.Drawing.Point(53, 358);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(59, 37);
            this.dateLabel.TabIndex = 48;
            this.dateLabel.Text = "Date";
            // 
            // addAppointmentLabel
            // 
            this.addAppointmentLabel.AutoSize = true;
            this.addAppointmentLabel.Font = new System.Drawing.Font("Times New Roman", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAppointmentLabel.Location = new System.Drawing.Point(43, 104);
            this.addAppointmentLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.addAppointmentLabel.Name = "addAppointmentLabel";
            this.addAppointmentLabel.Size = new System.Drawing.Size(296, 44);
            this.addAppointmentLabel.TabIndex = 47;
            this.addAppointmentLabel.Text = "Add Appointment";
            // 
            // AddAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 487);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.timeTextBox);
            this.Controls.Add(this.closePictureBox);
            this.Controls.Add(this.saveNewAppointmentButton);
            this.Controls.Add(this.appointmentDateTimePicker);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.addAppointmentLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddAppointment";
            this.Text = "AddAppointment";
            ((System.ComponentModel.ISupportInitialize)(this.closePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox timeTextBox;
        private System.Windows.Forms.PictureBox closePictureBox;
        private System.Windows.Forms.Button saveNewAppointmentButton;
        private System.Windows.Forms.DateTimePicker appointmentDateTimePicker;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label addAppointmentLabel;
    }
}