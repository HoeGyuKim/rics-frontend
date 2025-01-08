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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.managerApprovalDataGridView = new System.Windows.Forms.DataGridView();
            this.prevButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.managerApprovalDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // approvalAll
            // 
            this.approvalAll.Location = new System.Drawing.Point(793, 70);
            this.approvalAll.Name = "approvalAll";
            this.approvalAll.Size = new System.Drawing.Size(136, 34);
            this.approvalAll.TabIndex = 2;
            this.approvalAll.Text = "승인(일괄)";
            this.approvalAll.UseVisualStyleBackColor = true;
            this.approvalAll.Click += new System.EventHandler(this.approvalAll_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(509, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 34);
            this.button2.TabIndex = 3;
            this.button2.Text = "상세";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(651, 70);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 34);
            this.button3.TabIndex = 4;
            this.button3.Text = "반려(일괄)";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // managerApprovalDataGridView
            // 
            this.managerApprovalDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.managerApprovalDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.managerApprovalDataGridView.Location = new System.Drawing.Point(48, 120);
            this.managerApprovalDataGridView.Name = "managerApprovalDataGridView";
            this.managerApprovalDataGridView.RowHeadersWidth = 51;
            this.managerApprovalDataGridView.RowTemplate.Height = 27;
            this.managerApprovalDataGridView.Size = new System.Drawing.Size(881, 447);
            this.managerApprovalDataGridView.TabIndex = 5;
            // 
            // prevButton
            // 
            this.prevButton.Location = new System.Drawing.Point(48, 70);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(136, 34);
            this.prevButton.TabIndex = 6;
            this.prevButton.Text = "이전";
            this.prevButton.UseVisualStyleBackColor = true;
            this.prevButton.Click += new System.EventHandler(this.prevButton_Click);
            // 
            // ManagerApproval
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 611);
            this.Controls.Add(this.prevButton);
            this.Controls.Add(this.managerApprovalDataGridView);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.approvalAll);
            this.Name = "ManagerApproval";
            this.Text = "ManagerApproval";
            ((System.ComponentModel.ISupportInitialize)(this.managerApprovalDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button approvalAll;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView managerApprovalDataGridView;
        private System.Windows.Forms.Button prevButton;
    }
}