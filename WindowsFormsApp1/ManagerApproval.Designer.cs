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
            approvalAll = new System.Windows.Forms.Button();
            ShowDetailButton = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            managerApprovalDataGridView = new System.Windows.Forms.DataGridView();
            prevButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)managerApprovalDataGridView).BeginInit();
            SuspendLayout();
            // 
            // approvalAll
            // 
            approvalAll.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            approvalAll.Location = new System.Drawing.Point(1162, 68);
            approvalAll.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            approvalAll.Name = "approvalAll";
            approvalAll.Size = new System.Drawing.Size(95, 32);
            approvalAll.TabIndex = 2;
            approvalAll.Text = "승인(일괄)";
            approvalAll.UseVisualStyleBackColor = true;
            approvalAll.Click += approvalAll_Click;
            // 
            // ShowDetailButton
            // 
            ShowDetailButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            ShowDetailButton.Location = new System.Drawing.Point(956, 68);
            ShowDetailButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            ShowDetailButton.Name = "ShowDetailButton";
            ShowDetailButton.Size = new System.Drawing.Size(95, 32);
            ShowDetailButton.TabIndex = 3;
            ShowDetailButton.Text = "상세";
            ShowDetailButton.UseVisualStyleBackColor = true;
            ShowDetailButton.Click += ShowDetailButton_Click;
            // 
            // button3
            // 
            button3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            button3.Location = new System.Drawing.Point(1059, 68);
            button3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(95, 32);
            button3.TabIndex = 4;
            button3.Text = "반려(일괄)";
            button3.UseVisualStyleBackColor = true;
            // 
            // managerApprovalDataGridView
            // 
            managerApprovalDataGridView.AllowUserToAddRows = false;
            managerApprovalDataGridView.AllowUserToDeleteRows = false;
            managerApprovalDataGridView.AllowUserToResizeRows = false;
            managerApprovalDataGridView.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            managerApprovalDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            managerApprovalDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            managerApprovalDataGridView.Location = new System.Drawing.Point(27, 103);
            managerApprovalDataGridView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            managerApprovalDataGridView.Name = "managerApprovalDataGridView";
            managerApprovalDataGridView.ReadOnly = true;
            managerApprovalDataGridView.RowHeadersWidth = 51;
            managerApprovalDataGridView.RowTemplate.Height = 27;
            managerApprovalDataGridView.ShowEditingIcon = false;
            managerApprovalDataGridView.ShowRowErrors = false;
            managerApprovalDataGridView.Size = new System.Drawing.Size(1230, 441);
            managerApprovalDataGridView.TabIndex = 5;
            // 
            // prevButton
            // 
            prevButton.Location = new System.Drawing.Point(27, 68);
            prevButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            prevButton.Name = "prevButton";
            prevButton.Size = new System.Drawing.Size(95, 32);
            prevButton.TabIndex = 6;
            prevButton.Text = "이전";
            prevButton.UseVisualStyleBackColor = true;
            prevButton.Click += prevButton_Click;
            // 
            // ManagerApproval
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1282, 574);
            Controls.Add(prevButton);
            Controls.Add(managerApprovalDataGridView);
            Controls.Add(button3);
            Controls.Add(ShowDetailButton);
            Controls.Add(approvalAll);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "ManagerApproval";
            Padding = new System.Windows.Forms.Padding(23, 100, 23, 27);
            Text = "전자결재(관리자)";
            ((System.ComponentModel.ISupportInitialize)managerApprovalDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Button approvalAll;
        private System.Windows.Forms.Button ShowDetailButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView managerApprovalDataGridView;
        private System.Windows.Forms.Button prevButton;
    }
}