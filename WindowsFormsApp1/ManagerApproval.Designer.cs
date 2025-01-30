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
            select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            productNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            serialNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            workerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            submitTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            middleManagerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            firstApprovalTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            lastManagerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            lastApprovalTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            prevButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)managerApprovalDataGridView).BeginInit();
            SuspendLayout();
            // 
            // approvalAll
            // 
            approvalAll.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            approvalAll.Location = new System.Drawing.Point(1242, 68);
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
            ShowDetailButton.Location = new System.Drawing.Point(1036, 68);
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
            button3.Location = new System.Drawing.Point(1139, 68);
            button3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(95, 32);
            button3.TabIndex = 4;
            button3.Text = "반려(일괄)";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // managerApprovalDataGridView
            // 
            managerApprovalDataGridView.AllowUserToAddRows = false;
            managerApprovalDataGridView.AllowUserToDeleteRows = false;
            managerApprovalDataGridView.AllowUserToResizeRows = false;
            managerApprovalDataGridView.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            managerApprovalDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            managerApprovalDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            managerApprovalDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { select, id, productNum, productName, serialNum, workerName, submitTime, middleManagerName, firstApprovalTime, lastManagerName, lastApprovalTime });
            managerApprovalDataGridView.Location = new System.Drawing.Point(27, 103);
            managerApprovalDataGridView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            managerApprovalDataGridView.Name = "managerApprovalDataGridView";
            managerApprovalDataGridView.ReadOnly = true;
            managerApprovalDataGridView.RowHeadersVisible = false;
            managerApprovalDataGridView.RowHeadersWidth = 51;
            managerApprovalDataGridView.RowTemplate.Height = 27;
            managerApprovalDataGridView.ShowEditingIcon = false;
            managerApprovalDataGridView.ShowRowErrors = false;
            managerApprovalDataGridView.Size = new System.Drawing.Size(1300, 450);
            managerApprovalDataGridView.TabIndex = 5;
            // 
            // select
            // 
            select.HeaderText = "선택";
            select.MinimumWidth = 6;
            select.Name = "select";
            select.ReadOnly = true;
            select.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            select.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            select.Width = 50;
            // 
            // id
            // 
            id.DataPropertyName = "id";
            id.HeaderText = "등록번호";
            id.MinimumWidth = 125;
            id.Name = "id";
            id.ReadOnly = true;
            id.Width = 125;
            // 
            // productNum
            // 
            productNum.DataPropertyName = "productNum";
            productNum.HeaderText = "자재번호";
            productNum.MinimumWidth = 125;
            productNum.Name = "productNum";
            productNum.ReadOnly = true;
            productNum.Width = 125;
            // 
            // productName
            // 
            productName.DataPropertyName = "productName";
            productName.HeaderText = "자재명";
            productName.MinimumWidth = 125;
            productName.Name = "productName";
            productName.ReadOnly = true;
            productName.Width = 125;
            // 
            // serialNum
            // 
            serialNum.DataPropertyName = "serialNum";
            serialNum.HeaderText = "시리얼번호";
            serialNum.MinimumWidth = 125;
            serialNum.Name = "serialNum";
            serialNum.ReadOnly = true;
            serialNum.Width = 125;
            // 
            // workerName
            // 
            workerName.DataPropertyName = "workerName";
            workerName.HeaderText = "상신";
            workerName.MinimumWidth = 125;
            workerName.Name = "workerName";
            workerName.ReadOnly = true;
            workerName.Width = 125;
            // 
            // submitTime
            // 
            submitTime.DataPropertyName = "submitTime";
            submitTime.HeaderText = "";
            submitTime.MinimumWidth = 125;
            submitTime.Name = "submitTime";
            submitTime.ReadOnly = true;
            submitTime.Width = 125;
            // 
            // middleManagerName
            // 
            middleManagerName.DataPropertyName = "middleManagerName";
            middleManagerName.HeaderText = "1차검토";
            middleManagerName.MinimumWidth = 125;
            middleManagerName.Name = "middleManagerName";
            middleManagerName.ReadOnly = true;
            middleManagerName.Width = 125;
            // 
            // firstApprovalTime
            // 
            firstApprovalTime.DataPropertyName = "firstApprovalTime";
            firstApprovalTime.HeaderText = "";
            firstApprovalTime.MinimumWidth = 125;
            firstApprovalTime.Name = "firstApprovalTime";
            firstApprovalTime.ReadOnly = true;
            firstApprovalTime.Width = 125;
            // 
            // lastManagerName
            // 
            lastManagerName.DataPropertyName = "lastManagerName";
            lastManagerName.HeaderText = "최종 승인";
            lastManagerName.MinimumWidth = 125;
            lastManagerName.Name = "lastManagerName";
            lastManagerName.ReadOnly = true;
            lastManagerName.Width = 125;
            // 
            // lastApprovalTime
            // 
            lastApprovalTime.DataPropertyName = "lastApprovalTime";
            lastApprovalTime.HeaderText = "";
            lastApprovalTime.MinimumWidth = 125;
            lastApprovalTime.Name = "lastApprovalTime";
            lastApprovalTime.ReadOnly = true;
            lastApprovalTime.Width = 125;
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
            ClientSize = new System.Drawing.Size(1362, 574);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn serailNum;
        private System.Windows.Forms.DataGridViewCheckBoxColumn select;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn workerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn submitTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn middleManagerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstApprovalTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastManagerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastApprovalTime;
    }
}