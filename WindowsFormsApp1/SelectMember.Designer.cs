using MetroFramework.Controls;

namespace WindowsFormsApp1
{
    partial class SelectMember
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
            dataGridView1 = new MetroGrid();
            Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            EmployeeNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            selectMemberButton = new System.Windows.Forms.Button();
            prevButton = new System.Windows.Forms.Button();
            searchForNameTextBox = new System.Windows.Forms.TextBox();
            searchForNameButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(255, 255, 255);
            dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Name, EmployeeNum, Department });
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridView1.GridColor = System.Drawing.Color.FromArgb(255, 255, 255);
            dataGridView1.Location = new System.Drawing.Point(27, 103);
            dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.RowTemplate.Height = 27;
            dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new System.Drawing.Size(703, 245);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Name
            // 
            Name.HeaderText = "이름";
            Name.MinimumWidth = 6;
            Name.Name = "Name";
            Name.Width = 125;
            // 
            // EmployeeNum
            // 
            EmployeeNum.HeaderText = "사번";
            EmployeeNum.MinimumWidth = 6;
            EmployeeNum.Name = "EmployeeNum";
            EmployeeNum.Width = 125;
            // 
            // Department
            // 
            Department.HeaderText = "부서";
            Department.MinimumWidth = 6;
            Department.Name = "Department";
            Department.Width = 400;
            // 
            // selectMemberButton
            // 
            selectMemberButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            selectMemberButton.Location = new System.Drawing.Point(614, 354);
            selectMemberButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            selectMemberButton.Name = "selectMemberButton";
            selectMemberButton.Size = new System.Drawing.Size(116, 33);
            selectMemberButton.TabIndex = 1;
            selectMemberButton.Text = "확인";
            selectMemberButton.UseVisualStyleBackColor = true;
            selectMemberButton.Click += selectMemberButton_Click;
            // 
            // prevButton
            // 
            prevButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            prevButton.Location = new System.Drawing.Point(395, 61);
            prevButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            prevButton.Name = "prevButton";
            prevButton.Size = new System.Drawing.Size(116, 33);
            prevButton.TabIndex = 2;
            prevButton.Text = "이전";
            prevButton.UseVisualStyleBackColor = true;
            prevButton.Click += button2_Click;
            // 
            // searchForNameTextBox
            // 
            searchForNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            searchForNameTextBox.Location = new System.Drawing.Point(31, 61);
            searchForNameTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            searchForNameTextBox.Name = "searchForNameTextBox";
            searchForNameTextBox.Size = new System.Drawing.Size(233, 27);
            searchForNameTextBox.TabIndex = 3;
            // 
            // searchForNameButton
            // 
            searchForNameButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            searchForNameButton.Location = new System.Drawing.Point(271, 61);
            searchForNameButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            searchForNameButton.Name = "searchForNameButton";
            searchForNameButton.Size = new System.Drawing.Size(116, 33);
            searchForNameButton.TabIndex = 4;
            searchForNameButton.Text = "검색(성명)";
            searchForNameButton.UseVisualStyleBackColor = true;
            searchForNameButton.Click += searchForNameButton_Click;
            // 
            // SelectMember
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(761, 423);
            Controls.Add(searchForNameButton);
            Controls.Add(searchForNameTextBox);
            Controls.Add(prevButton);
            Controls.Add(selectMemberButton);
            Controls.Add(dataGridView1);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Padding = new System.Windows.Forms.Padding(23, 100, 23, 27);
            Text = "직원 검색";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn department;
        private System.Windows.Forms.Button selectMemberButton;
        private System.Windows.Forms.Button prevButton;
        private System.Windows.Forms.TextBox searchForNameTextBox;
        private System.Windows.Forms.Button searchForNameButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Department;
        private MetroGrid dataGridView1;
    }
}