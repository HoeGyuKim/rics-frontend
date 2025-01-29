using MetroFramework.Controls;

namespace WindowsFormsApp1
{
    partial class WorkerRecentCreatedList
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
            htmlLabel1 = new MetroFramework.Drawing.Html.HtmlLabel();
            createQRAll = new System.Windows.Forms.Button();
            prevButton = new System.Windows.Forms.Button();
            myDataGridView = new System.Windows.Forms.DataGridView();
            downloadQRAll = new System.Windows.Forms.Button();
            select = new System.Windows.Forms.DataGridViewTextBoxColumn();
            formattedId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            productNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            serialNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            approvalStatusText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)myDataGridView).BeginInit();
            SuspendLayout();
            // 
            // htmlLabel1
            // 
            htmlLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            htmlLabel1.AutoScroll = true;
            htmlLabel1.AutoScrollMinSize = new System.Drawing.Size(401, 30);
            htmlLabel1.AutoSize = false;
            htmlLabel1.BackColor = System.Drawing.SystemColors.Window;
            htmlLabel1.Location = new System.Drawing.Point(25, 562);
            htmlLabel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            htmlLabel1.Name = "htmlLabel1";
            htmlLabel1.Size = new System.Drawing.Size(424, 29);
            htmlLabel1.TabIndex = 0;
            htmlLabel1.Text = "* 1개월이 지난 데이터는 자재조회에서 확인 가능합니다.";
            // 
            // createQRAll
            // 
            createQRAll.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            createQRAll.Location = new System.Drawing.Point(615, 74);
            createQRAll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            createQRAll.Name = "createQRAll";
            createQRAll.Size = new System.Drawing.Size(123, 33);
            createQRAll.TabIndex = 2;
            createQRAll.Text = "QR 생성 (일괄)";
            createQRAll.UseVisualStyleBackColor = true;
            createQRAll.Click += createQRAll_Click;
            // 
            // prevButton
            // 
            prevButton.Location = new System.Drawing.Point(25, 74);
            prevButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            prevButton.Name = "prevButton";
            prevButton.Size = new System.Drawing.Size(117, 33);
            prevButton.TabIndex = 4;
            prevButton.Text = "이전";
            prevButton.UseVisualStyleBackColor = true;
            prevButton.Click += prevButton_Click;
            // 
            // myDataGridView
            // 
            myDataGridView.AllowUserToAddRows = false;
            myDataGridView.AllowUserToDeleteRows = false;
            myDataGridView.AllowUserToResizeRows = false;
            myDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            myDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { select, formattedId, date, productNum, productName, serialNum, approvalStatusText });
            myDataGridView.Location = new System.Drawing.Point(29, 114);
            myDataGridView.Name = "myDataGridView";
            myDataGridView.ReadOnly = true;
            myDataGridView.RowHeadersVisible = false;
            myDataGridView.RowHeadersWidth = 51;
            myDataGridView.Size = new System.Drawing.Size(876, 441);
            myDataGridView.TabIndex = 5;
            // 
            // downloadQRAll
            // 
            downloadQRAll.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            downloadQRAll.Location = new System.Drawing.Point(744, 74);
            downloadQRAll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            downloadQRAll.Name = "downloadQRAll";
            downloadQRAll.Size = new System.Drawing.Size(161, 33);
            downloadQRAll.TabIndex = 6;
            downloadQRAll.Text = "QR 다운로드 (일괄)";
            downloadQRAll.UseVisualStyleBackColor = true;
            downloadQRAll.Click += downloadQRAll_Click;
            // 
            // select
            // 
            select.HeaderText = "선택";
            select.MinimumWidth = 6;
            select.Name = "select";
            select.ReadOnly = true;
            select.Width = 125;
            // 
            // formattedId
            // 
            formattedId.DataPropertyName = "formattedId";
            formattedId.HeaderText = "등록번호";
            formattedId.MinimumWidth = 6;
            formattedId.Name = "formattedId";
            formattedId.ReadOnly = true;
            formattedId.Width = 125;
            // 
            // date
            // 
            date.DataPropertyName = "date";
            date.HeaderText = "완료일자";
            date.MinimumWidth = 6;
            date.Name = "date";
            date.ReadOnly = true;
            date.Width = 125;
            // 
            // productNum
            // 
            productNum.DataPropertyName = "productNum";
            productNum.HeaderText = "자재번호";
            productNum.MinimumWidth = 6;
            productNum.Name = "productNum";
            productNum.ReadOnly = true;
            productNum.Width = 125;
            // 
            // productName
            // 
            productName.DataPropertyName = "productName";
            productName.HeaderText = "자재명";
            productName.MinimumWidth = 6;
            productName.Name = "productName";
            productName.ReadOnly = true;
            productName.Width = 125;
            // 
            // serialNum
            // 
            serialNum.DataPropertyName = "serialNum";
            serialNum.HeaderText = "시리얼번호";
            serialNum.MinimumWidth = 6;
            serialNum.Name = "serialNum";
            serialNum.ReadOnly = true;
            serialNum.Width = 125;
            // 
            // approvalStatusText
            // 
            approvalStatusText.DataPropertyName = "approvalStatusText";
            approvalStatusText.HeaderText = "결재상태";
            approvalStatusText.MinimumWidth = 6;
            approvalStatusText.Name = "approvalStatusText";
            approvalStatusText.ReadOnly = true;
            approvalStatusText.Width = 125;
            // 
            // WorkerRecentCreatedList
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(930, 638);
            Controls.Add(downloadQRAll);
            Controls.Add(myDataGridView);
            Controls.Add(prevButton);
            Controls.Add(createQRAll);
            Controls.Add(htmlLabel1);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "WorkerRecentCreatedList";
            Padding = new System.Windows.Forms.Padding(22, 80, 22, 27);
            Text = "최근 생성 목록";
            ((System.ComponentModel.ISupportInitialize)myDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel1;
        private System.Windows.Forms.Button createQRAll;
        private System.Windows.Forms.Button prevButton;
        private System.Windows.Forms.DataGridView myDataGridView;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.Button downloadQRAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn select;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn approvalStatusText;
        private System.Windows.Forms.DataGridViewTextBoxColumn formattedId;
    }
}