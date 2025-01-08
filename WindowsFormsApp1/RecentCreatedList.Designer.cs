using MetroFramework.Controls;

namespace WindowsFormsApp1
{
    partial class RecentCreatedList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.htmlLabel1 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.myDataGridView = new MetroFramework.Controls.MetroGrid();
            this.makeQRAll = new System.Windows.Forms.Button();
            this.detail = new System.Windows.Forms.Button();
            this.prevButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.myDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // htmlLabel1
            // 
            this.htmlLabel1.AutoScroll = true;
            this.htmlLabel1.AutoScrollMinSize = new System.Drawing.Size(384, 25);
            this.htmlLabel1.AutoSize = false;
            this.htmlLabel1.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel1.Location = new System.Drawing.Point(23, 463);
            this.htmlLabel1.Name = "htmlLabel1";
            this.htmlLabel1.Size = new System.Drawing.Size(438, 29);
            this.htmlLabel1.TabIndex = 0;
            this.htmlLabel1.Text = "* 1개월 지난 데이터는 자재조회에서 확인 가능합니다.";
            // 
            // myDataGridView
            // 
            this.myDataGridView.AllowUserToResizeRows = false;
            this.myDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.myDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.myDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.myDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.myDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.myDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.myDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.myDataGridView.EnableHeadersVisualStyles = false;
            this.myDataGridView.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.myDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.myDataGridView.Location = new System.Drawing.Point(23, 119);
            this.myDataGridView.Name = "myDataGridView";
            this.myDataGridView.ReadOnly = true;
            this.myDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.myDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.myDataGridView.RowHeadersWidth = 51;
            this.myDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.myDataGridView.RowTemplate.Height = 27;
            this.myDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.myDataGridView.Size = new System.Drawing.Size(760, 338);
            this.myDataGridView.TabIndex = 1;
            // 
            // makeQRAll
            // 
            this.makeQRAll.Location = new System.Drawing.Point(656, 63);
            this.makeQRAll.Name = "makeQRAll";
            this.makeQRAll.Size = new System.Drawing.Size(127, 41);
            this.makeQRAll.TabIndex = 2;
            this.makeQRAll.Text = "QR 생성 (일괄)";
            this.makeQRAll.UseVisualStyleBackColor = true;
            // 
            // detail
            // 
            this.detail.Location = new System.Drawing.Point(523, 63);
            this.detail.Name = "detail";
            this.detail.Size = new System.Drawing.Size(127, 41);
            this.detail.TabIndex = 3;
            this.detail.Text = "상세 조회 (단일)";
            this.detail.UseVisualStyleBackColor = true;
            // 
            // prevButton
            // 
            this.prevButton.Location = new System.Drawing.Point(23, 63);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(86, 30);
            this.prevButton.TabIndex = 4;
            this.prevButton.Text = "이전";
            this.prevButton.UseVisualStyleBackColor = true;
            this.prevButton.Click += new System.EventHandler(this.prevButton_Click);
            // 
            // RecentCreatedList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 515);
            this.Controls.Add(this.prevButton);
            this.Controls.Add(this.detail);
            this.Controls.Add(this.makeQRAll);
            this.Controls.Add(this.myDataGridView);
            this.Controls.Add(this.htmlLabel1);
            this.Name = "RecentCreatedList";
            this.Text = "CreatedList";
            ((System.ComponentModel.ISupportInitialize)(this.myDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel1;
        private MetroGrid myDataGridView;
        private System.Windows.Forms.Button makeQRAll;
        private System.Windows.Forms.Button detail;
        private System.Windows.Forms.Button prevButton;
    }
}