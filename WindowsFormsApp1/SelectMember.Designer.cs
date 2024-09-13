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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new MetroFramework.Controls.MetroGrid();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectMemberButton = new System.Windows.Forms.Button();
            this.prevButton = new System.Windows.Forms.Button();
            this.searchForNameTextBox = new System.Windows.Forms.TextBox();
            this.searchForNameButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.EmployeeNum,
            this.Department});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView1.Location = new System.Drawing.Point(11, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(702, 184);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Name
            // 
            this.Name.HeaderText = "이름";
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            this.Name.Width = 125;
            // 
            // EmployeeNum
            // 
            this.EmployeeNum.HeaderText = "사번";
            this.EmployeeNum.MinimumWidth = 6;
            this.EmployeeNum.Name = "EmployeeNum";
            this.EmployeeNum.Width = 125;
            // 
            // Department
            // 
            this.Department.HeaderText = "부서";
            this.Department.MinimumWidth = 6;
            this.Department.Name = "Department";
            this.Department.Width = 400;
            // 
            // selectMemberButton
            // 
            this.selectMemberButton.Location = new System.Drawing.Point(610, 291);
            this.selectMemberButton.Name = "selectMemberButton";
            this.selectMemberButton.Size = new System.Drawing.Size(103, 25);
            this.selectMemberButton.TabIndex = 1;
            this.selectMemberButton.Text = "확인";
            this.selectMemberButton.UseVisualStyleBackColor = true;
            this.selectMemberButton.Click += new System.EventHandler(this.selectMemberButton_Click);
            // 
            // prevButton
            // 
            this.prevButton.Location = new System.Drawing.Point(338, 70);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(103, 25);
            this.prevButton.TabIndex = 2;
            this.prevButton.Text = "이전";
            this.prevButton.UseVisualStyleBackColor = true;
            this.prevButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // searchForNameTextBox
            // 
            this.searchForNameTextBox.Location = new System.Drawing.Point(15, 70);
            this.searchForNameTextBox.Name = "searchForNameTextBox";
            this.searchForNameTextBox.Size = new System.Drawing.Size(208, 25);
            this.searchForNameTextBox.TabIndex = 3;
            // 
            // searchForNameButton
            // 
            this.searchForNameButton.Location = new System.Drawing.Point(229, 70);
            this.searchForNameButton.Name = "searchForNameButton";
            this.searchForNameButton.Size = new System.Drawing.Size(103, 25);
            this.searchForNameButton.TabIndex = 4;
            this.searchForNameButton.Text = "검색(성명)";
            this.searchForNameButton.UseVisualStyleBackColor = true;
            this.searchForNameButton.Click += new System.EventHandler(this.searchForNameButton_Click);
            // 
            // SelectMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 339);
            this.Controls.Add(this.searchForNameButton);
            this.Controls.Add(this.searchForNameTextBox);
            this.Controls.Add(this.prevButton);
            this.Controls.Add(this.selectMemberButton);
            this.Controls.Add(this.dataGridView1);
            this.Text = "직원 검색";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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