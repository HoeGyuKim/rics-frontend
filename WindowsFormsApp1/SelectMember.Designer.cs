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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.EmployeeNum,
            this.Department});
            this.dataGridView1.Location = new System.Drawing.Point(0, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(702, 150);
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
            this.selectMemberButton.Location = new System.Drawing.Point(586, 207);
            this.selectMemberButton.Name = "selectMemberButton";
            this.selectMemberButton.Size = new System.Drawing.Size(103, 25);
            this.selectMemberButton.TabIndex = 1;
            this.selectMemberButton.Text = "확인";
            this.selectMemberButton.UseVisualStyleBackColor = true;
            this.selectMemberButton.Click += new System.EventHandler(this.selectMemberButton_Click);
            // 
            // prevButton
            // 
            this.prevButton.Location = new System.Drawing.Point(327, 20);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(103, 25);
            this.prevButton.TabIndex = 2;
            this.prevButton.Text = "이전";
            this.prevButton.UseVisualStyleBackColor = true;
            this.prevButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // searchForNameTextBox
            // 
            this.searchForNameTextBox.Location = new System.Drawing.Point(4, 20);
            this.searchForNameTextBox.Name = "searchForNameTextBox";
            this.searchForNameTextBox.Size = new System.Drawing.Size(208, 25);
            this.searchForNameTextBox.TabIndex = 3;
            // 
            // searchForNameButton
            // 
            this.searchForNameButton.Location = new System.Drawing.Point(218, 20);
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
            this.ClientSize = new System.Drawing.Size(701, 244);
            this.Controls.Add(this.searchForNameButton);
            this.Controls.Add(this.searchForNameTextBox);
            this.Controls.Add(this.prevButton);
            this.Controls.Add(this.selectMemberButton);
            this.Controls.Add(this.dataGridView1);

            this.Text = "RICS - 직원 검색";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
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
    }
}