namespace Dental_Clinic_Management
{
    partial class AddRecordForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Record";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Uighur", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(111)))), ((int)(((byte)(24)))));
            this.label6.Location = new System.Drawing.Point(94, 766);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 45);
            this.label6.TabIndex = 5;
            this.label6.Text = "DOB";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(111)))), ((int)(((byte)(24)))));
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.SystemColors.ControlText;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Uighur", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(229, 766);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(432, 43);
            this.dateTimePicker1.TabIndex = 11;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Uighur", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(111)))), ((int)(((byte)(24)))));
            this.label8.Location = new System.Drawing.Point(69, 1047);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 45);
            this.label8.TabIndex = 12;
            this.label8.Text = "Allergies";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(47, 39);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(122, 49);
            this.radioButton1.TabIndex = 13;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Female";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(47, 94);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(98, 49);
            this.radioButton2.TabIndex = 14;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Male";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Uighur", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(111)))), ((int)(((byte)(24)))));
            this.groupBox1.Location = new System.Drawing.Point(76, 856);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 164);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gender";
            // 
            // textBox5
            // 
            this.textBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(111)))), ((int)(((byte)(24)))));
            this.textBox5.Location = new System.Drawing.Point(244, 1055);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(308, 158);
            this.textBox5.TabIndex = 16;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Uighur", 22.2F, System.Drawing.FontStyle.Bold);
            this.textBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(111)))), ((int)(((byte)(24)))));
            this.textBox3.Location = new System.Drawing.Point(102, 243);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(559, 40);
            this.textBox3.TabIndex = 17;
            this.textBox3.Text = "Name";
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(167)))), ((int)(((byte)(137)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(625, 1198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 56);
            this.button1.TabIndex = 20;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = global::Dental_Clinic_Management.Properties.Resources.Grey_close_x_svg;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(130)))), ((int)(((byte)(100)))));
            this.panel1.Font = new System.Drawing.Font("Agency FB", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(102, 290);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(559, 1);
            this.panel1.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(130)))), ((int)(((byte)(100)))));
            this.panel2.Font = new System.Drawing.Font("Agency FB", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(102, 400);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(559, 1);
            this.panel2.TabIndex = 24;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Uighur", 22.2F, System.Drawing.FontStyle.Bold);
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(111)))), ((int)(((byte)(24)))));
            this.textBox1.Location = new System.Drawing.Point(102, 353);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(559, 40);
            this.textBox1.TabIndex = 23;
            this.textBox1.Text = "Phone";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(130)))), ((int)(((byte)(100)))));
            this.panel3.Font = new System.Drawing.Font("Agency FB", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(102, 522);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(559, 1);
            this.panel3.TabIndex = 26;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Uighur", 22.2F, System.Drawing.FontStyle.Bold);
            this.textBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(111)))), ((int)(((byte)(24)))));
            this.textBox2.Location = new System.Drawing.Point(102, 475);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(559, 40);
            this.textBox2.TabIndex = 25;
            this.textBox2.Text = "Email";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(130)))), ((int)(((byte)(100)))));
            this.panel4.Font = new System.Drawing.Font("Agency FB", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(102, 663);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(559, 1);
            this.panel4.TabIndex = 28;
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Uighur", 22.2F, System.Drawing.FontStyle.Bold);
            this.textBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(111)))), ((int)(((byte)(24)))));
            this.textBox4.Location = new System.Drawing.Point(102, 616);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(559, 40);
            this.textBox4.TabIndex = 27;
            this.textBox4.Text = "Address";
            // 
            // AddRecordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 1278);
            this.ControlBox = false;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddRecordForm";
            this.Text = "AddRecordForm";
            this.Load += new System.EventHandler(this.AddRecordForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBox4;
    }
}