namespace WindowsFormsApp1
{
    partial class R_SelectProductNum
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.r_product_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.r_product_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SearchRProductList = new System.Windows.Forms.Button();
            this.AddRProductList = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.r_product_num,
            this.r_product_name});
            this.dataGridView1.Location = new System.Drawing.Point(40, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(629, 320);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // r_product_num
            // 
            this.r_product_num.HeaderText = "자재번호";
            this.r_product_num.MinimumWidth = 6;
            this.r_product_num.Name = "r_product_num";
            this.r_product_num.ReadOnly = true;
            this.r_product_num.Width = 125;
            // 
            // r_product_name
            // 
            this.r_product_name.HeaderText = "자재명";
            this.r_product_name.MinimumWidth = 6;
            this.r_product_name.Name = "r_product_name";
            this.r_product_name.ReadOnly = true;
            this.r_product_name.Width = 450;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(167, 40);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(246, 25);
            this.searchTextBox.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(40, 42);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 3;
            // 
            // SearchRProductList
            // 
            this.SearchRProductList.Location = new System.Drawing.Point(419, 36);
            this.SearchRProductList.Name = "SearchRProductList";
            this.SearchRProductList.Size = new System.Drawing.Size(153, 27);
            this.SearchRProductList.TabIndex = 4;
            this.SearchRProductList.Text = "검색 (새로고침)";
            this.SearchRProductList.UseVisualStyleBackColor = true;
            this.SearchRProductList.Click += new System.EventHandler(this.searchRProductNum_Click);
            // 
            // AddRProductList
            // 
            this.AddRProductList.Location = new System.Drawing.Point(574, 36);
            this.AddRProductList.Name = "AddRProductList";
            this.AddRProductList.Size = new System.Drawing.Size(95, 26);
            this.AddRProductList.TabIndex = 5;
            this.AddRProductList.Text = "품목 추가";
            this.AddRProductList.UseVisualStyleBackColor = true;
            this.AddRProductList.Click += new System.EventHandler(this.AddRProductList_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 407);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "*[품목 추가]관리자 확인 후 품목이 추가됩니다.";
            // 
            // R_SelectProductNum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 451);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddRProductList);
            this.Controls.Add(this.SearchRProductList);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Name = "R_SelectProductNum";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.R_SelectProductNum_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn r_product_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn r_product_name;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button SearchRProductList;
        private System.Windows.Forms.Button AddRProductList;
        private System.Windows.Forms.Label label1;
    }
}
