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
            ShowDetailButton = new System.Windows.Forms.Button();
            searchTextBox = new System.Windows.Forms.TextBox();
            searchButton = new System.Windows.Forms.Button();
            selectBox = new System.Windows.Forms.ComboBox();
            prevButton = new System.Windows.Forms.Button();
            StartDateTimePicker = new System.Windows.Forms.DateTimePicker();
            EndDateTimePicker = new System.Windows.Forms.DateTimePicker();
            SelectedProductNumTextBox = new System.Windows.Forms.TextBox();
            SelectedProductNameTextBox = new System.Windows.Forms.TextBox();
            UpLoadDetailButton = new System.Windows.Forms.Button();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // ShowDetailButton
            // 
            ShowDetailButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            ShowDetailButton.Location = new System.Drawing.Point(1165, 113);
            ShowDetailButton.Name = "ShowDetailButton";
            ShowDetailButton.Size = new System.Drawing.Size(93, 31);
            ShowDetailButton.TabIndex = 3;
            ShowDetailButton.Text = "상세";
            ShowDetailButton.UseVisualStyleBackColor = true;
            ShowDetailButton.Click += ShowDetailButton_Click;
            // 
            // searchTextBox
            // 
            searchTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            searchTextBox.Font = new System.Drawing.Font("굴림", 9F);
            searchTextBox.Location = new System.Drawing.Point(28, 117);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new System.Drawing.Size(326, 25);
            searchTextBox.TabIndex = 11;
            // 
            // searchButton
            // 
            searchButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            searchButton.Location = new System.Drawing.Point(492, 113);
            searchButton.Name = "searchButton";
            searchButton.Size = new System.Drawing.Size(96, 31);
            searchButton.TabIndex = 6;
            searchButton.Text = "검색";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += SearchButton_Click;
            // 
            // selectBox
            // 
            selectBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            selectBox.Font = new System.Drawing.Font("굴림", 9F);
            selectBox.FormattingEnabled = true;
            selectBox.Items.AddRange(new object[] { "시리얼번호", "작업자" });
            selectBox.Location = new System.Drawing.Point(362, 117);
            selectBox.Name = "selectBox";
            selectBox.Size = new System.Drawing.Size(124, 23);
            selectBox.TabIndex = 8;
            // 
            // prevButton
            // 
            prevButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            prevButton.Location = new System.Drawing.Point(27, 78);
            prevButton.Name = "prevButton";
            prevButton.Size = new System.Drawing.Size(93, 32);
            prevButton.TabIndex = 10;
            prevButton.Text = "이전";
            prevButton.UseVisualStyleBackColor = true;
            prevButton.Click += PrevButton_Click;
            // 
            // StartDateTimePicker
            // 
            StartDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Top;
            StartDateTimePicker.Location = new System.Drawing.Point(128, 78);
            StartDateTimePicker.Name = "StartDateTimePicker";
            StartDateTimePicker.Size = new System.Drawing.Size(226, 27);
            StartDateTimePicker.TabIndex = 12;
            // 
            // EndDateTimePicker
            // 
            EndDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Top;
            EndDateTimePicker.Location = new System.Drawing.Point(362, 78);
            EndDateTimePicker.Name = "EndDateTimePicker";
            EndDateTimePicker.Size = new System.Drawing.Size(226, 27);
            EndDateTimePicker.TabIndex = 13;
            // 
            // SelectedProductNumTextBox
            // 
            SelectedProductNumTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            SelectedProductNumTextBox.Location = new System.Drawing.Point(714, 83);
            SelectedProductNumTextBox.Name = "SelectedProductNumTextBox";
            SelectedProductNumTextBox.ReadOnly = true;
            SelectedProductNumTextBox.Size = new System.Drawing.Size(154, 27);
            SelectedProductNumTextBox.TabIndex = 14;
            // 
            // SelectedProductNameTextBox
            // 
            SelectedProductNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            SelectedProductNameTextBox.Location = new System.Drawing.Point(714, 113);
            SelectedProductNameTextBox.Name = "SelectedProductNameTextBox";
            SelectedProductNameTextBox.ReadOnly = true;
            SelectedProductNameTextBox.Size = new System.Drawing.Size(371, 27);
            SelectedProductNameTextBox.TabIndex = 15;
            // 
            // UpLoadDetailButton
            // 
            UpLoadDetailButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            UpLoadDetailButton.Location = new System.Drawing.Point(1165, 78);
            UpLoadDetailButton.Name = "UpLoadDetailButton";
            UpLoadDetailButton.Size = new System.Drawing.Size(93, 32);
            UpLoadDetailButton.TabIndex = 1;
            UpLoadDetailButton.Text = "등록";
            UpLoadDetailButton.UseVisualStyleBackColor = true;
            UpLoadDetailButton.Click += UpLoadDetailButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(27, 150);
            dataGridView1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 23;
            dataGridView1.Size = new System.Drawing.Size(1231, 602);
            dataGridView1.TabIndex = 17;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(label2, 0, 1);
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Location = new System.Drawing.Point(596, 75);
            tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new System.Drawing.Size(112, 66);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(4, 33);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(104, 32);
            label2.TabIndex = 1;
            label2.Text = "자재명";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(4, 1);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(104, 31);
            label1.TabIndex = 0;
            label1.Text = "자재번호";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ReconditionedList
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1296, 784);
            Controls.Add(SelectedProductNameTextBox);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(SelectedProductNumTextBox);
            Controls.Add(dataGridView1);
            Controls.Add(EndDateTimePicker);
            Controls.Add(StartDateTimePicker);
            Controls.Add(prevButton);
            Controls.Add(selectBox);
            Controls.Add(searchButton);
            Controls.Add(searchTextBox);
            Controls.Add(ShowDetailButton);
            Controls.Add(UpLoadDetailButton);
            Name = "ReconditionedList";
            Padding = new System.Windows.Forms.Padding(24, 100, 24, 27);
            Text = "재생 품목 목록";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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