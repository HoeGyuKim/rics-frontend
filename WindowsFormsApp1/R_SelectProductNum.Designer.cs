using MetroFramework.Controls;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new MetroFramework.Controls.MetroGrid();
            this.r_product_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.r_product_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SearchRProductList = new System.Windows.Forms.Button();
            this.AddRProductList = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.prevButton = new System.Windows.Forms.Button();
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
            this.r_product_num,
            this.r_product_name});
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
            this.dataGridView1.Location = new System.Drawing.Point(40, 128);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
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
            this.dataGridView1.Size = new System.Drawing.Size(629, 351);
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
            this.searchTextBox.Location = new System.Drawing.Point(167, 97);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(246, 25);
            this.searchTextBox.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(40, 99);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 3;
            // 
            // SearchRProductList
            // 
            this.SearchRProductList.Location = new System.Drawing.Point(419, 93);
            this.SearchRProductList.Name = "SearchRProductList";
            this.SearchRProductList.Size = new System.Drawing.Size(153, 27);
            this.SearchRProductList.TabIndex = 4;
            this.SearchRProductList.Text = "검색 (새로고침)";
            this.SearchRProductList.UseVisualStyleBackColor = true;
            this.SearchRProductList.Click += new System.EventHandler(this.searchRProductNum_Click);
            // 
            // AddRProductList
            // 
            this.AddRProductList.Location = new System.Drawing.Point(574, 93);
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
            this.label1.Location = new System.Drawing.Point(37, 498);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "*[품목 추가]관리자 확인 후 품목이 추가됩니다.";
            // 
            // prevButton
            // 
            this.prevButton.Location = new System.Drawing.Point(40, 69);
            this.prevButton.Name = "prevButton";
            this.prevButton.Size = new System.Drawing.Size(89, 25);
            this.prevButton.TabIndex = 7;
            this.prevButton.Text = "이전";
            this.prevButton.UseVisualStyleBackColor = true;
            this.prevButton.Click += new System.EventHandler(this.prevButton_Click);
            // 
            // R_SelectProductNum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 533);
            this.Controls.Add(this.prevButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddRProductList);
            this.Controls.Add(this.SearchRProductList);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Name = "R_SelectProductNum";
            this.Text = "품목 선택";
            this.Load += new System.EventHandler(this.R_SelectProductNum_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn r_product_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn r_product_name;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button SearchRProductList;
        private System.Windows.Forms.Button AddRProductList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button prevButton;
        private MetroGrid dataGridView1;
    }
}
