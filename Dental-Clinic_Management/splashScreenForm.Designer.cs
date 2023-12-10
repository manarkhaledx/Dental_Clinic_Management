namespace Dental_Clinic_Management
{
    partial class splashScreenForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(splashScreenForm));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.circularProgressBar = new CircularProgressBar.CircularProgressBar();
            this.dentalClinicLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // circularProgressBar
            // 
            this.circularProgressBar.AnimationFunction = ((WinFormAnimation.AnimationFunctions.Function)(resources.GetObject("circularProgressBar.AnimationFunction")));
            this.circularProgressBar.AnimationSpeed = 500;
            this.circularProgressBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.circularProgressBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.circularProgressBar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.circularProgressBar.InnerMargin = 2;
            this.circularProgressBar.InnerWidth = -1;
            this.circularProgressBar.Location = new System.Drawing.Point(69, 82);
            this.circularProgressBar.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar.Name = "circularProgressBar";
            this.circularProgressBar.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(26)))), ((int)(((byte)(43)))));
            this.circularProgressBar.OuterMargin = -25;
            this.circularProgressBar.OuterWidth = 26;
            this.circularProgressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.circularProgressBar.ProgressWidth = 6;
            this.circularProgressBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circularProgressBar.Size = new System.Drawing.Size(278, 204);
            this.circularProgressBar.StartAngle = 270;
            this.circularProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.circularProgressBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar.SubscriptText = "";
            this.circularProgressBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar.SuperscriptText = "";
            this.circularProgressBar.TabIndex = 0;
            this.circularProgressBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBar.Value = 50;
            // 
            // dentalClinicLabel
            // 
            this.dentalClinicLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dentalClinicLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dentalClinicLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.dentalClinicLabel.Location = new System.Drawing.Point(82, 9);
            this.dentalClinicLabel.Name = "dentalClinicLabel";
            this.dentalClinicLabel.Size = new System.Drawing.Size(455, 60);
            this.dentalClinicLabel.TabIndex = 1;
            this.dentalClinicLabel.Text = "Dental Clinic";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(213)))), ((int)(((byte)(219)))));
            this.label2.Location = new System.Drawing.Point(94, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 85);
            this.label2.TabIndex = 2;
            this.label2.Text = "Loading...";
            // 
            // splashScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(410, 358);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dentalClinicLabel);
            this.Controls.Add(this.circularProgressBar);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "splashScreenForm";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "splashScreenForm";
            this.Load += new System.EventHandler(this.splashScreenForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private CircularProgressBar.CircularProgressBar circularProgressBar;
        private System.Windows.Forms.Label dentalClinicLabel;
        private System.Windows.Forms.Label label2;
    }
}