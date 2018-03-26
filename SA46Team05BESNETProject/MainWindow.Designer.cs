namespace SA46Team05BESNETProject
{
    partial class MainWindow
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MemberMaintenanceButton = new System.Windows.Forms.Button();
            this.FacilityMaintenanceButton = new System.Windows.Forms.Button();
            this.BookingCancellationButton = new System.Windows.Forms.Button();
            this.AvailavbilityQueryButton = new System.Windows.Forms.Button();
            this.BookingButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CRMemberListButton = new System.Windows.Forms.Button();
            this.CRReceiptButton = new System.Windows.Forms.Button();
            this.CRTotalSalesButton = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 679);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1221, 30);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(179, 25);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CRTotalSalesButton);
            this.panel1.Controls.Add(this.CRReceiptButton);
            this.panel1.Controls.Add(this.CRMemberListButton);
            this.panel1.Controls.Add(this.MemberMaintenanceButton);
            this.panel1.Controls.Add(this.FacilityMaintenanceButton);
            this.panel1.Controls.Add(this.BookingCancellationButton);
            this.panel1.Controls.Add(this.AvailavbilityQueryButton);
            this.panel1.Controls.Add(this.BookingButton);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(147, 679);
            this.panel1.TabIndex = 3;
            // 
            // MemberMaintenanceButton
            // 
            this.MemberMaintenanceButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.MemberMaintenanceButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.MemberMaintenanceButton.Location = new System.Drawing.Point(0, 361);
            this.MemberMaintenanceButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MemberMaintenanceButton.Name = "MemberMaintenanceButton";
            this.MemberMaintenanceButton.Size = new System.Drawing.Size(147, 79);
            this.MemberMaintenanceButton.TabIndex = 4;
            this.MemberMaintenanceButton.Text = "&Member Maintenance";
            this.MemberMaintenanceButton.UseVisualStyleBackColor = false;
            this.MemberMaintenanceButton.Click += new System.EventHandler(this.MemberMaintenanceButton_Click);
            this.MemberMaintenanceButton.MouseEnter += new System.EventHandler(this.BookingButton_MouseEnter);
            this.MemberMaintenanceButton.MouseLeave += new System.EventHandler(this.BookingButton_MouseLeave);
            // 
            // FacilityMaintenanceButton
            // 
            this.FacilityMaintenanceButton.BackColor = System.Drawing.Color.Silver;
            this.FacilityMaintenanceButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.FacilityMaintenanceButton.Location = new System.Drawing.Point(0, 282);
            this.FacilityMaintenanceButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FacilityMaintenanceButton.Name = "FacilityMaintenanceButton";
            this.FacilityMaintenanceButton.Size = new System.Drawing.Size(147, 79);
            this.FacilityMaintenanceButton.TabIndex = 4;
            this.FacilityMaintenanceButton.Text = "&Facility Maintenance";
            this.FacilityMaintenanceButton.UseVisualStyleBackColor = false;
            this.FacilityMaintenanceButton.Click += new System.EventHandler(this.FacilityMaintenanceButton_Click);
            this.FacilityMaintenanceButton.MouseEnter += new System.EventHandler(this.BookingButton_MouseEnter);
            this.FacilityMaintenanceButton.MouseLeave += new System.EventHandler(this.BookingButton_MouseLeave);
            // 
            // BookingCancellationButton
            // 
            this.BookingCancellationButton.BackColor = System.Drawing.Color.LightGray;
            this.BookingCancellationButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.BookingCancellationButton.Location = new System.Drawing.Point(0, 203);
            this.BookingCancellationButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BookingCancellationButton.Name = "BookingCancellationButton";
            this.BookingCancellationButton.Size = new System.Drawing.Size(147, 79);
            this.BookingCancellationButton.TabIndex = 4;
            this.BookingCancellationButton.Text = "Booking &Cancellation";
            this.BookingCancellationButton.UseVisualStyleBackColor = false;
            this.BookingCancellationButton.Click += new System.EventHandler(this.BookingCancellationButton_Click);
            this.BookingCancellationButton.MouseEnter += new System.EventHandler(this.BookingButton_MouseEnter);
            this.BookingCancellationButton.MouseLeave += new System.EventHandler(this.BookingButton_MouseLeave);
            // 
            // AvailavbilityQueryButton
            // 
            this.AvailavbilityQueryButton.BackColor = System.Drawing.Color.Gainsboro;
            this.AvailavbilityQueryButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.AvailavbilityQueryButton.Location = new System.Drawing.Point(0, 124);
            this.AvailavbilityQueryButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AvailavbilityQueryButton.Name = "AvailavbilityQueryButton";
            this.AvailavbilityQueryButton.Size = new System.Drawing.Size(147, 79);
            this.AvailavbilityQueryButton.TabIndex = 4;
            this.AvailavbilityQueryButton.Text = "&AvailabilityQuery";
            this.AvailavbilityQueryButton.UseVisualStyleBackColor = false;
            this.AvailavbilityQueryButton.Click += new System.EventHandler(this.AvailabilityQueryButton_Click);
            this.AvailavbilityQueryButton.MouseEnter += new System.EventHandler(this.BookingButton_MouseEnter);
            this.AvailavbilityQueryButton.MouseLeave += new System.EventHandler(this.BookingButton_MouseLeave);
            // 
            // BookingButton
            // 
            this.BookingButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.BookingButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.BookingButton.Location = new System.Drawing.Point(0, 45);
            this.BookingButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BookingButton.Name = "BookingButton";
            this.BookingButton.Size = new System.Drawing.Size(147, 79);
            this.BookingButton.TabIndex = 4;
            this.BookingButton.Text = "&Booking";
            this.BookingButton.UseVisualStyleBackColor = false;
            this.BookingButton.Click += new System.EventHandler(this.BookingButton_Click);
            this.BookingButton.MouseEnter += new System.EventHandler(this.BookingButton_MouseEnter);
            this.BookingButton.MouseLeave += new System.EventHandler(this.BookingButton_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::SA46Team05BESNETProject.Properties.Resources.Logo;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(147, 45);
            this.panel2.TabIndex = 0;
            // 
            // CRMemberListButton
            // 
            this.CRMemberListButton.BackColor = System.Drawing.Color.Gray;
            this.CRMemberListButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.CRMemberListButton.Location = new System.Drawing.Point(0, 440);
            this.CRMemberListButton.Name = "CRMemberListButton";
            this.CRMemberListButton.Size = new System.Drawing.Size(147, 79);
            this.CRMemberListButton.TabIndex = 5;
            this.CRMemberListButton.Text = "C&RMemberList";
            this.CRMemberListButton.UseVisualStyleBackColor = false;
            this.CRMemberListButton.Click += new System.EventHandler(this.CRMemberListButton_Click);
            this.CRMemberListButton.MouseEnter += new System.EventHandler(this.BookingButton_MouseEnter);
            this.CRMemberListButton.MouseLeave += new System.EventHandler(this.BookingButton_MouseLeave);
            // 
            // CRReceiptButton
            // 
            this.CRReceiptButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.CRReceiptButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.CRReceiptButton.Location = new System.Drawing.Point(0, 519);
            this.CRReceiptButton.Name = "CRReceiptButton";
            this.CRReceiptButton.Size = new System.Drawing.Size(147, 79);
            this.CRReceiptButton.TabIndex = 5;
            this.CRReceiptButton.Text = "CRR&eceipt";
            this.CRReceiptButton.UseVisualStyleBackColor = false;
            this.CRReceiptButton.Click += new System.EventHandler(this.CRReceiptButton_Click);
            this.CRReceiptButton.MouseEnter += new System.EventHandler(this.BookingButton_MouseEnter);
            this.CRReceiptButton.MouseLeave += new System.EventHandler(this.BookingButton_MouseLeave);
            // 
            // CRTotalSalesButton
            // 
            this.CRTotalSalesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.CRTotalSalesButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.CRTotalSalesButton.Location = new System.Drawing.Point(0, 598);
            this.CRTotalSalesButton.Name = "CRTotalSalesButton";
            this.CRTotalSalesButton.Size = new System.Drawing.Size(147, 79);
            this.CRTotalSalesButton.TabIndex = 5;
            this.CRTotalSalesButton.Text = "CR&TotalSales";
            this.CRTotalSalesButton.UseVisualStyleBackColor = false;
            this.CRTotalSalesButton.Click += new System.EventHandler(this.CRTotalSalesButton_Click);
            this.CRTotalSalesButton.MouseEnter += new System.EventHandler(this.BookingButton_MouseEnter);
            this.CRTotalSalesButton.MouseLeave += new System.EventHandler(this.BookingButton_MouseLeave);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1221, 709);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainWindow_KeyDown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button MemberMaintenanceButton;
        private System.Windows.Forms.Button FacilityMaintenanceButton;
        private System.Windows.Forms.Button BookingCancellationButton;
        private System.Windows.Forms.Button AvailavbilityQueryButton;
        private System.Windows.Forms.Button BookingButton;
        private System.Windows.Forms.Button CRTotalSalesButton;
        private System.Windows.Forms.Button CRReceiptButton;
        private System.Windows.Forms.Button CRMemberListButton;
    }
}