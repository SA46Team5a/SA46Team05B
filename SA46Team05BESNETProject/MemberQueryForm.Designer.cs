namespace SA46Team05BESNETProject
{
    partial class MemberQueryForm
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
            this.MemberQueryDataGridView = new System.Windows.Forms.DataGridView();
            this.MemberName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NRIC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelectMemberButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MemberQueryDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // MemberQueryDataGridView
            // 
            this.MemberQueryDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MemberQueryDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.MemberQueryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MemberQueryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MemberName,
            this.NRIC,
            this.Phone});
            this.MemberQueryDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.MemberQueryDataGridView.Location = new System.Drawing.Point(37, 38);
            this.MemberQueryDataGridView.Name = "MemberQueryDataGridView";
            this.MemberQueryDataGridView.ReadOnly = true;
            this.MemberQueryDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MemberQueryDataGridView.Size = new System.Drawing.Size(389, 227);
            this.MemberQueryDataGridView.TabIndex = 3;
            // 
            // MemberName
            // 
            this.MemberName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MemberName.DataPropertyName = "MemberName";
            this.MemberName.HeaderText = "MemberName";
            this.MemberName.Name = "MemberName";
            this.MemberName.ReadOnly = true;
            this.MemberName.Width = 98;
            // 
            // NRIC
            // 
            this.NRIC.DataPropertyName = "NRIC";
            this.NRIC.HeaderText = "NRIC";
            this.NRIC.Name = "NRIC";
            this.NRIC.ReadOnly = true;
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "Phone";
            this.Phone.HeaderText = "Phone";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            // 
            // SelectMemberButton
            // 
            this.SelectMemberButton.Location = new System.Drawing.Point(355, 291);
            this.SelectMemberButton.Margin = new System.Windows.Forms.Padding(2);
            this.SelectMemberButton.Name = "SelectMemberButton";
            this.SelectMemberButton.Size = new System.Drawing.Size(101, 32);
            this.SelectMemberButton.TabIndex = 5;
            this.SelectMemberButton.Text = "Select Member";
            this.SelectMemberButton.UseVisualStyleBackColor = true;
            this.SelectMemberButton.Click += new System.EventHandler(this.SelectMemberButton_Click);
            // 
            // MemberQueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 367);
            this.Controls.Add(this.SelectMemberButton);
            this.Controls.Add(this.MemberQueryDataGridView);
            this.Name = "MemberQueryForm";
            this.Text = "MemberQueryForm";
            this.Load += new System.EventHandler(this.MemberQueryForm_Load);
            this.Controls.SetChildIndex(this.MemberQueryDataGridView, 0);
            this.Controls.SetChildIndex(this.SelectMemberButton, 0);
            ((System.ComponentModel.ISupportInitialize)(this.MemberQueryDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView MemberQueryDataGridView;
        private System.Windows.Forms.Button SelectMemberButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberName;
        private System.Windows.Forms.DataGridViewTextBoxColumn NRIC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
    }
}