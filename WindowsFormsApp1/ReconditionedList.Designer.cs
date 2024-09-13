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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DeleteDetailButton = new System.Windows.Forms.Button();
            this.ShowDetailButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.selectBox = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new MetroFramework.Controls.MetroGrid();
            this.prevButton = new System.Windows.Forms.Button();
            this.StartDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.EndDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SelectedProductNumTextBox = new System.Windows.Forms.TextBox();
            this.SelectedProductNameTextBox = new System.Windows.Forms.TextBox();
            this.UpLoadDetailButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // DeleteDetailButton
            // 
            this.DeleteDetailButton.Location = new System.Drawing.Point(886, 103);
            this.DeleteDetailButton.Name = "DeleteDetailButton";
            this.DeleteDetailButton.Size = new System.Drawing.Size(83, 30);
            this.DeleteDetailButton.TabIndex = 2;
            this.DeleteDetailButton.Text = "삭제";
            this.DeleteDetailButton.UseVisualStyleBackColor = true;
            // 
            // ShowDetailButton
            // 
            this.ShowDetailButton.Location = new System.Drawing.Point(975, 103);
            this.ShowDetailButton.Name = "ShowDetailButton";
            this.ShowDetailButton.Size = new System.Drawing.Size(83, 30);
            this.ShowDetailButton.TabIndex = 3;
            this.ShowDetailButton.Text = "상세";
            this.ShowDetailButton.UseVisualStyleBackColor = true;
            this.ShowDetailButton.Click += new System.EventHandler(this.ShowDetailButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("굴림", 9F);
            this.searchTextBox.Location = new System.Drawing.Point(34, 108);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(290, 25);
            this.searchTextBox.TabIndex = 11;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(448, 104);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(83, 30);
            this.searchButton.TabIndex = 6;
            this.searchButton.Text = "검색";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // selectBox
            // 
            this.selectBox.Font = new System.Drawing.Font("굴림", 9F);
            this.selectBox.FormattingEnabled = true;
            this.selectBox.Items.AddRange(new object[] {
            "시리얼번호",
            "작업자"});
            this.selectBox.Location = new System.Drawing.Point(330, 108);
            this.selectBox.Name = "selectBox";
            this.selectBox.Size = new System.Drawing.Size(112, 23);
            this.selectBox.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView1.Location = new System.Drawing.Point(35, 135);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.RowHeadersWidth = 80;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1023, 440);
            this.dataGridView1.TabIndex = 9;
            // 
            // prevButton
            // 
            this.prevButton.Location = new System.Drawing.Point(35, 72);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(83, 30);
            this.prevButton.TabIndex = 10;
            this.prevButton.Text = "이전";
            this.prevButton.UseVisualStyleBackColor = true;
            this.prevButton.Click += new System.EventHandler(this.PrevButton_Click);
            // 
            // StartDateTimePicker
            // 
            this.StartDateTimePicker.Location = new System.Drawing.Point(123, 73);
            this.StartDateTimePicker.Name = "StartDateTimePicker";
            this.StartDateTimePicker.Size = new System.Drawing.Size(201, 25);
            this.StartDateTimePicker.TabIndex = 12;
            // 
            // EndDateTimePicker
            // 
            this.EndDateTimePicker.Location = new System.Drawing.Point(330, 73);
            this.EndDateTimePicker.Name = "EndDateTimePicker";
            this.EndDateTimePicker.Size = new System.Drawing.Size(201, 25);
            this.EndDateTimePicker.TabIndex = 13;
            // 
            // SelectedProductNumTextBox
            // 
            this.SelectedProductNumTextBox.Location = new System.Drawing.Point(770, 72);
            this.SelectedProductNumTextBox.Name = "SelectedProductNumTextBox";
            this.SelectedProductNumTextBox.ReadOnly = true;
            this.SelectedProductNumTextBox.Size = new System.Drawing.Size(82, 25);
            this.SelectedProductNumTextBox.TabIndex = 14;
            // 
            // SelectedProductNameTextBox
            // 
            this.SelectedProductNameTextBox.Location = new System.Drawing.Point(858, 72);
            this.SelectedProductNameTextBox.Name = "SelectedProductNameTextBox";
            this.SelectedProductNameTextBox.ReadOnly = true;
            this.SelectedProductNameTextBox.Size = new System.Drawing.Size(200, 25);
            this.SelectedProductNameTextBox.TabIndex = 15;
            // 
            // UpLoadDetailButton
            // 
            this.UpLoadDetailButton.Location = new System.Drawing.Point(797, 103);
            this.UpLoadDetailButton.Name = "UpLoadDetailButton";
            this.UpLoadDetailButton.Size = new System.Drawing.Size(83, 30);
            this.UpLoadDetailButton.TabIndex = 1;
            this.UpLoadDetailButton.Text = "등록";
            this.UpLoadDetailButton.UseVisualStyleBackColor = true;
            this.UpLoadDetailButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ReconditionedList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 607);
            this.Controls.Add(this.SelectedProductNameTextBox);
            this.Controls.Add(this.SelectedProductNumTextBox);
            this.Controls.Add(this.EndDateTimePicker);
            this.Controls.Add(this.StartDateTimePicker);
            this.Controls.Add(this.prevButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.selectBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.ShowDetailButton);
            this.Controls.Add(this.DeleteDetailButton);
            this.Controls.Add(this.UpLoadDetailButton);
            this.Name = "ReconditionedList";
            this.Text = "재생 품목 목록";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private System.Windows.Forms.Button DeleteDetailButton;
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
        private MetroGrid dataGridView1;
    }
}