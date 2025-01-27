namespace WindowsFormsApp1
{
    partial class ManagerApproval
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
            this.approvalAll = new System.Windows.Forms.Button();
            this.ShowDetailButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.managerApprovalDataGridView = new System.Windows.Forms.DataGridView();
            this.prevButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.managerApprovalDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // approvalAll
            // 
            this.approvalAll.Location = new System.Drawing.Point(503, 56);
            this.approvalAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.approvalAll.Name = "approvalAll";
            this.approvalAll.Size = new System.Drawing.Size(119, 27);
            this.approvalAll.TabIndex = 2;
            this.approvalAll.Text = "승인(일괄)";
            this.approvalAll.UseVisualStyleBackColor = true;
            this.approvalAll.Click += new System.EventHandler(this.approvalAll_Click);
            // 
            // ShowDetailButton
            // 
            this.ShowDetailButton.Location = new System.Drawing.Point(253, 56);
            this.ShowDetailButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ShowDetailButton.Name = "ShowDetailButton";
            this.ShowDetailButton.Size = new System.Drawing.Size(119, 27);
            this.ShowDetailButton.TabIndex = 3;
            this.ShowDetailButton.Text = "상세";
            this.ShowDetailButton.UseVisualStyleBackColor = true;
            this.ShowDetailButton.Click += new System.EventHandler(this.ShowDetailButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(378, 57);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 27);
            this.button3.TabIndex = 4;
            this.button3.Text = "반려(일괄)";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // managerApprovalDataGridView
            // 
            this.managerApprovalDataGridView.AllowUserToAddRows = false;
            this.managerApprovalDataGridView.AllowUserToDeleteRows = false;
            this.managerApprovalDataGridView.AllowUserToResizeRows = false;
            this.managerApprovalDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.managerApprovalDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.managerApprovalDataGridView.Location = new System.Drawing.Point(20, 88);
            this.managerApprovalDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.managerApprovalDataGridView.Name = "managerApprovalDataGridView";
            this.managerApprovalDataGridView.ReadOnly = true;
            this.managerApprovalDataGridView.RowHeadersWidth = 51;
            this.managerApprovalDataGridView.RowTemplate.Height = 27;
            this.managerApprovalDataGridView.ShowEditingIcon = false;
            this.managerApprovalDataGridView.ShowRowErrors = false;
            this.managerApprovalDataGridView.Size = new System.Drawing.Size(602, 335);
            this.managerApprovalDataGridView.TabIndex = 5;
            // 
            // prevButton
            // 
            this.prevButton.Location = new System.Drawing.Point(20, 56);
            this.prevButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(119, 27);
            this.prevButton.TabIndex = 6;
            this.prevButton.Text = "이전";
            this.prevButton.UseVisualStyleBackColor = true;
            this.prevButton.Click += new System.EventHandler(this.prevButton_Click);
            // 
            // ManagerApproval
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 442);
            this.Controls.Add(this.prevButton);
            this.Controls.Add(this.managerApprovalDataGridView);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.ShowDetailButton);
            this.Controls.Add(this.approvalAll);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ManagerApproval";
            this.Padding = new System.Windows.Forms.Padding(18, 60, 18, 16);
            this.Text = "전자결재(관리자)";
            ((System.ComponentModel.ISupportInitialize)(this.managerApprovalDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button approvalAll;
        private System.Windows.Forms.Button ShowDetailButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView managerApprovalDataGridView;
        private System.Windows.Forms.Button prevButton;
    }
}