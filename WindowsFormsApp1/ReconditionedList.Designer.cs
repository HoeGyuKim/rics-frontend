using MetroFramework.Controls;

namespace WindowsFormsApp1
{
    partial class ReconditionedList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param Name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.ShowDetailButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.selectBox = new System.Windows.Forms.ComboBox();
            this.prevButton = new System.Windows.Forms.Button();
            this.StartDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.EndDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SelectedProductNumTextBox = new System.Windows.Forms.TextBox();
            this.SelectedProductNameTextBox = new System.Windows.Forms.TextBox();
            this.UpLoadDetailButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ShowDetailButton
            // 
            this.ShowDetailButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ShowDetailButton.Location = new System.Drawing.Point(970, 118);
            this.ShowDetailButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ShowDetailButton.Name = "ShowDetailButton";
            this.ShowDetailButton.Size = new System.Drawing.Size(83, 30);
            this.ShowDetailButton.TabIndex = 3;
            this.ShowDetailButton.Text = "상세";
            this.ShowDetailButton.UseVisualStyleBackColor = true;
            this.ShowDetailButton.Click += new System.EventHandler(this.ShowDetailButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchTextBox.Font = new System.Drawing.Font("굴림", 9F);
            this.searchTextBox.Location = new System.Drawing.Point(24, 112);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(290, 25);
            this.searchTextBox.TabIndex = 11;
            // 
            // searchButton
            // 
            this.searchButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchButton.Location = new System.Drawing.Point(441, 115);
            this.searchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(83, 30);
            this.searchButton.TabIndex = 6;
            this.searchButton.Text = "검색";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // selectBox
            // 
            this.selectBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.selectBox.Font = new System.Drawing.Font("굴림", 9F);
            this.selectBox.FormattingEnabled = true;
            this.selectBox.Items.AddRange(new object[] {
            "시리얼번호",
            "작업자"});
            this.selectBox.Location = new System.Drawing.Point(322, 115);
            this.selectBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.selectBox.Name = "selectBox";
            this.selectBox.Size = new System.Drawing.Size(111, 23);
            this.selectBox.TabIndex = 8;
            // 
            // prevButton
            // 
            this.prevButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.prevButton.Location = new System.Drawing.Point(24, 78);
            this.prevButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(83, 30);
            this.prevButton.TabIndex = 10;
            this.prevButton.Text = "이전";
            this.prevButton.UseVisualStyleBackColor = true;
            this.prevButton.Click += new System.EventHandler(this.PrevButton_Click);
            // 
            // StartDateTimePicker
            // 
            this.StartDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StartDateTimePicker.Location = new System.Drawing.Point(114, 81);
            this.StartDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StartDateTimePicker.Name = "StartDateTimePicker";
            this.StartDateTimePicker.Size = new System.Drawing.Size(201, 25);
            this.StartDateTimePicker.TabIndex = 12;
            // 
            // EndDateTimePicker
            // 
            this.EndDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EndDateTimePicker.Location = new System.Drawing.Point(322, 81);
            this.EndDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EndDateTimePicker.Name = "EndDateTimePicker";
            this.EndDateTimePicker.Size = new System.Drawing.Size(201, 25);
            this.EndDateTimePicker.TabIndex = 13;
            // 
            // SelectedProductNumTextBox
            // 
            this.SelectedProductNumTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SelectedProductNumTextBox.Location = new System.Drawing.Point(632, 85);
            this.SelectedProductNumTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SelectedProductNumTextBox.Name = "SelectedProductNumTextBox";
            this.SelectedProductNumTextBox.ReadOnly = true;
            this.SelectedProductNumTextBox.Size = new System.Drawing.Size(243, 25);
            this.SelectedProductNumTextBox.TabIndex = 14;
            // 
            // SelectedProductNameTextBox
            // 
            this.SelectedProductNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SelectedProductNameTextBox.Location = new System.Drawing.Point(632, 118);
            this.SelectedProductNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SelectedProductNameTextBox.Name = "SelectedProductNameTextBox";
            this.SelectedProductNameTextBox.ReadOnly = true;
            this.SelectedProductNameTextBox.Size = new System.Drawing.Size(243, 25);
            this.SelectedProductNameTextBox.TabIndex = 15;
            // 
            // UpLoadDetailButton
            // 
            this.UpLoadDetailButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UpLoadDetailButton.Location = new System.Drawing.Point(970, 85);
            this.UpLoadDetailButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UpLoadDetailButton.Name = "UpLoadDetailButton";
            this.UpLoadDetailButton.Size = new System.Drawing.Size(83, 30);
            this.UpLoadDetailButton.TabIndex = 1;
            this.UpLoadDetailButton.Text = "등록";
            this.UpLoadDetailButton.UseVisualStyleBackColor = true;
            this.UpLoadDetailButton.Click += new System.EventHandler(this.UpLoadDetailButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 156);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1029, 462);
            this.dataGridView1.TabIndex = 17;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(530, 81);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(100, 63);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "자재명";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "자재번호";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ReconditionedList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 642);
            this.Controls.Add(this.SelectedProductNameTextBox);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.SelectedProductNumTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.EndDateTimePicker);
            this.Controls.Add(this.StartDateTimePicker);
            this.Controls.Add(this.prevButton);
            this.Controls.Add(this.selectBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.ShowDetailButton);
            this.Controls.Add(this.UpLoadDetailButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ReconditionedList";
            this.Padding = new System.Windows.Forms.Padding(21, 75, 21, 20);
            this.Text = "재생 품목 목록";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private System.Windows.Forms.Button ShowDetailButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ComboBox selectBox;
        private System.Windows.Forms.Button prevButton;
        private System.Windows.Forms.DateTimePicker StartDateTimePicker;
        private System.Windows.Forms.DateTimePicker EndDateTimePicker;
        private System.Windows.Forms.TextBox SelectedProductNumTextBox;
        private System.Windows.Forms.TextBox SelectedProductNameTextBox;
        private System.Windows.Forms.Button UpLoadDetailButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}