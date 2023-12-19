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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label app_timeLabel;
            System.Windows.Forms.Label app_dateLabel;
            System.Windows.Forms.Label phoneLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAppointment));
            this.panel2 = new System.Windows.Forms.Panel();
            this.closePictureBox = new System.Windows.Forms.PictureBox();
            this.saveNewAppointmentButton = new System.Windows.Forms.Button();
            this.appointmentDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateLabel = new System.Windows.Forms.Label();
            this.addAppointmentLabel = new System.Windows.Forms.Label();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.timeTextBox = new System.Windows.Forms.TextBox();
            this.app_timeTextBox = new System.Windows.Forms.TextBox();
            this.app_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.phoneTextBox1 = new System.Windows.Forms.TextBox();
            this.dataSet1 = new Dental_Clinic_Management.DataSet1();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable1TableAdapter = new Dental_Clinic_Management.DataSet1TableAdapters.DataTable1TableAdapter();
            this.tableAdapterManager = new Dental_Clinic_Management.DataSet1TableAdapters.TableAdapterManager();
            this.dataTable1BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.dataTable1BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dataTable1DataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            app_timeLabel = new System.Windows.Forms.Label();
            app_dateLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.closePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingNavigator)).BeginInit();
            this.dataTable1BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(130)))), ((int)(((byte)(100)))));
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(45, 388);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(628, 2);
            this.panel2.TabIndex = 40;
            // 
            // closePictureBox
            // 
            this.closePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closePictureBox.BackgroundImage = global::Dental_Clinic_Management.Properties.Resources.Exit;
            this.closePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closePictureBox.Location = new System.Drawing.Point(106, 25);
            this.closePictureBox.Name = "closePictureBox";
            this.closePictureBox.Size = new System.Drawing.Size(36, 40);
            this.closePictureBox.TabIndex = 37;
            this.closePictureBox.TabStop = false;
            // 
            // saveNewAppointmentButton
            // 
            this.saveNewAppointmentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(167)))), ((int)(((byte)(137)))));
            this.saveNewAppointmentButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.saveNewAppointmentButton.FlatAppearance.BorderSize = 0;
            this.saveNewAppointmentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveNewAppointmentButton.Location = new System.Drawing.Point(573, 571);
            this.saveNewAppointmentButton.Name = "saveNewAppointmentButton";
            this.saveNewAppointmentButton.Size = new System.Drawing.Size(153, 71);
            this.saveNewAppointmentButton.TabIndex = 36;
            this.saveNewAppointmentButton.Text = "Save";
            this.saveNewAppointmentButton.UseVisualStyleBackColor = false;
            // 
            // appointmentDateTimePicker
            // 
            this.appointmentDateTimePicker.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(111)))), ((int)(((byte)(24)))));
            this.appointmentDateTimePicker.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.appointmentDateTimePicker.CalendarTitleForeColor = System.Drawing.SystemColors.ControlText;
            this.appointmentDateTimePicker.Font = new System.Drawing.Font("Microsoft Uighur", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentDateTimePicker.Location = new System.Drawing.Point(189, 458);
            this.appointmentDateTimePicker.Name = "appointmentDateTimePicker";
            this.appointmentDateTimePicker.Size = new System.Drawing.Size(486, 50);
            this.appointmentDateTimePicker.TabIndex = 31;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Uighur", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(111)))), ((int)(((byte)(24)))));
            this.dateLabel.Location = new System.Drawing.Point(38, 458);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(87, 54);
            this.dateLabel.TabIndex = 30;
            this.dateLabel.Text = "Date";
            // 
            // addAppointmentLabel
            // 
            this.addAppointmentLabel.AutoSize = true;
            this.addAppointmentLabel.Font = new System.Drawing.Font("Times New Roman", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAppointmentLabel.Location = new System.Drawing.Point(22, 68);
            this.addAppointmentLabel.Name = "addAppointmentLabel";
            this.addAppointmentLabel.Size = new System.Drawing.Size(444, 65);
            this.addAppointmentLabel.TabIndex = 29;
            this.addAppointmentLabel.Text = "Add Appointment";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phoneTextBox.Font = new System.Drawing.Font("Microsoft Uighur", 22.2F, System.Drawing.FontStyle.Bold);
            this.phoneTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(111)))), ((int)(((byte)(24)))));
            this.phoneTextBox.Location = new System.Drawing.Point(45, 237);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(628, 48);
            this.phoneTextBox.TabIndex = 41;
            this.phoneTextBox.Text = "Phone Number";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(130)))), ((int)(((byte)(100)))));
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(48, 294);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(628, 2);
            this.panel3.TabIndex = 42;
            // 
            // timeTextBox
            // 
            this.timeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.timeTextBox.Font = new System.Drawing.Font("Microsoft Uighur", 22.2F, System.Drawing.FontStyle.Bold);
            this.timeTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(111)))), ((int)(((byte)(24)))));
            this.timeTextBox.Location = new System.Drawing.Point(45, 331);
            this.timeTextBox.Name = "timeTextBox";
            this.timeTextBox.Size = new System.Drawing.Size(628, 48);
            this.timeTextBox.TabIndex = 39;
            this.timeTextBox.Text = "Time";
            // 
            // app_timeLabel
            // 
            app_timeLabel.AutoSize = true;
            app_timeLabel.Location = new System.Drawing.Point(782, 338);
            app_timeLabel.Name = "app_timeLabel";
            app_timeLabel.Size = new System.Drawing.Size(74, 20);
            app_timeLabel.TabIndex = 42;
            app_timeLabel.Text = "app time:";
            // 
            // app_timeTextBox
            // 
            this.app_timeTextBox.Location = new System.Drawing.Point(862, 335);
            this.app_timeTextBox.Name = "app_timeTextBox";
            this.app_timeTextBox.Size = new System.Drawing.Size(100, 26);
            this.app_timeTextBox.TabIndex = 43;
            // 
            // app_dateLabel
            // 
            app_dateLabel.AutoSize = true;
            app_dateLabel.Location = new System.Drawing.Point(732, 476);
            app_dateLabel.Name = "app_dateLabel";
            app_dateLabel.Size = new System.Drawing.Size(76, 20);
            app_dateLabel.TabIndex = 43;
            app_dateLabel.Text = "app date:";
            // 
            // app_dateDateTimePicker
            // 
            this.app_dateDateTimePicker.Location = new System.Drawing.Point(814, 472);
            this.app_dateDateTimePicker.Name = "app_dateDateTimePicker";
            this.app_dateDateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.app_dateDateTimePicker.TabIndex = 44;
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(797, 256);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(59, 20);
            phoneLabel.TabIndex = 44;
            phoneLabel.Text = "Phone:";
            // 
            // phoneTextBox1
            // 
            this.phoneTextBox1.Location = new System.Drawing.Point(862, 253);
            this.phoneTextBox1.Name = "phoneTextBox1";
            this.phoneTextBox1.Size = new System.Drawing.Size(100, 26);
            this.phoneTextBox1.TabIndex = 45;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.dataSet1;
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = Dental_Clinic_Management.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dataTable1BindingNavigator
            // 
            this.dataTable1BindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.dataTable1BindingNavigator.BindingSource = this.dataTable1BindingSource;
            this.dataTable1BindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.dataTable1BindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.dataTable1BindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.dataTable1BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.dataTable1BindingNavigatorSaveItem});
            this.dataTable1BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.dataTable1BindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.dataTable1BindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.dataTable1BindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.dataTable1BindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.dataTable1BindingNavigator.Name = "dataTable1BindingNavigator";
            this.dataTable1BindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.dataTable1BindingNavigator.Size = new System.Drawing.Size(1126, 33);
            this.dataTable1BindingNavigator.TabIndex = 46;
            this.dataTable1BindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 20);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 20);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 25);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // dataTable1BindingNavigatorSaveItem
            // 
            this.dataTable1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.dataTable1BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("dataTable1BindingNavigatorSaveItem.Image")));
            this.dataTable1BindingNavigatorSaveItem.Name = "dataTable1BindingNavigatorSaveItem";
            this.dataTable1BindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.dataTable1BindingNavigatorSaveItem.Text = "Save Data";
            this.dataTable1BindingNavigatorSaveItem.Click += new System.EventHandler(this.dataTable1BindingNavigatorSaveItem_Click_1);
            // 
            // dataTable1DataGridView
            // 
            this.dataTable1DataGridView.AutoGenerateColumns = false;
            this.dataTable1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTable1DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataTable1DataGridView.DataSource = this.dataTable1BindingSource;
            this.dataTable1DataGridView.Location = new System.Drawing.Point(573, -9);
            this.dataTable1DataGridView.Name = "dataTable1DataGridView";
            this.dataTable1DataGridView.RowHeadersWidth = 62;
            this.dataTable1DataGridView.RowTemplate.Height = 28;
            this.dataTable1DataGridView.Size = new System.Drawing.Size(514, 220);
            this.dataTable1DataGridView.TabIndex = 46;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "app_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "app_id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "app_time";
            this.dataGridViewTextBoxColumn2.HeaderText = "app_time";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "app_date";
            this.dataGridViewTextBoxColumn3.HeaderText = "app_date";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // AddAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 675);
            this.Controls.Add(this.dataTable1DataGridView);
            this.Controls.Add(this.dataTable1BindingNavigator);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneTextBox1);
            this.Controls.Add(app_dateLabel);
            this.Controls.Add(this.app_dateDateTimePicker);
            this.Controls.Add(app_timeLabel);
            this.Controls.Add(this.app_timeTextBox);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.timeTextBox);
            this.Controls.Add(this.closePictureBox);
            this.Controls.Add(this.saveNewAppointmentButton);
            this.Controls.Add(this.appointmentDateTimePicker);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.addAppointmentLabel);
            this.Name = "AddAppointment";
            this.Text = "AddAppointment";
            this.Load += new System.EventHandler(this.AddAppointment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.closePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingNavigator)).EndInit();
            this.dataTable1BindingNavigator.ResumeLayout(false);
            this.dataTable1BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox closePictureBox;
        private System.Windows.Forms.Button saveNewAppointmentButton;
        private System.Windows.Forms.DateTimePicker appointmentDateTimePicker;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label addAppointmentLabel;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox timeTextBox;
        private System.Windows.Forms.TextBox app_timeTextBox;
        private System.Windows.Forms.DateTimePicker app_dateDateTimePicker;
        private System.Windows.Forms.TextBox phoneTextBox1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private DataSet1TableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator dataTable1BindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton dataTable1BindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView dataTable1DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}