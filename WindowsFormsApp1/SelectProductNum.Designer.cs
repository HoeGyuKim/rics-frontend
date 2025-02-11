using MetroFramework.Controls;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    partial class SelectProductNum
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dataGridView1 = new MetroGrid();
            r_product_num = new DataGridViewTextBoxColumn();
            r_product_name = new DataGridViewTextBoxColumn();
            searchTextBox = new TextBox();
            comboBox1 = new ComboBox();
            SearchRProductList = new Button();
            label1 = new Label();
            prevButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.Anchor = AnchorStyles.None;
            dataGridView1.BackgroundColor = Color.FromArgb(255, 255, 255);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { r_product_num, r_product_name });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridView1.GridColor = Color.FromArgb(255, 255, 255);
            dataGridView1.Location = new Point(34, 136);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.RowTemplate.Height = 27;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(578, 330);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellDoubleClick;
            // 
            // r_product_num
            // 
            r_product_num.FillWeight = 30F;
            r_product_num.HeaderText = "자재번호";
            r_product_num.MinimumWidth = 6;
            r_product_num.Name = "r_product_num";
            r_product_num.ReadOnly = true;
            r_product_num.Width = 125;
            // 
            // r_product_name
            // 
            r_product_name.FillWeight = 70F;
            r_product_name.HeaderText = "자재명";
            r_product_name.MinimumWidth = 6;
            r_product_name.Name = "r_product_name";
            r_product_name.ReadOnly = true;
            r_product_name.Width = 450;
            // 
            // searchTextBox
            // 
            searchTextBox.Anchor = AnchorStyles.None;
            searchTextBox.Location = new Point(176, 101);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(299, 27);
            searchTextBox.TabIndex = 2;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.None;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(34, 101);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(136, 28);
            comboBox1.TabIndex = 3;
            // 
            // SearchRProductList
            // 
            SearchRProductList.Anchor = AnchorStyles.None;
            SearchRProductList.Location = new Point(481, 103);
            SearchRProductList.Name = "SearchRProductList";
            SearchRProductList.Size = new Size(131, 27);
            SearchRProductList.TabIndex = 4;
            SearchRProductList.Text = "검색 (새로고침)";
            SearchRProductList.UseVisualStyleBackColor = true;
            SearchRProductList.Click += searchRProductNum_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(34, 469);
            label1.Name = "label1";
            label1.Size = new Size(356, 20);
            label1.TabIndex = 6;
            label1.Text = "* 품목을 추가를 원하시는 경우 ---로 연락 바랍니다.";
            // 
            // prevButton
            // 
            prevButton.Anchor = AnchorStyles.None;
            prevButton.Location = new Point(34, 65);
            prevButton.Name = "prevButton";
            prevButton.Size = new Size(87, 30);
            prevButton.TabIndex = 7;
            prevButton.Text = "이전";
            prevButton.UseVisualStyleBackColor = true;
            prevButton.Click += prevButton_Click;
            // 
            // SelectProductNum
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(639, 503);
            Controls.Add(prevButton);
            Controls.Add(label1);
            Controls.Add(SearchRProductList);
            Controls.Add(comboBox1);
            Controls.Add(searchTextBox);
            Controls.Add(dataGridView1);
            Name = "SelectProductNum";
            Padding = new Padding(24, 100, 24, 27);
            Text = "품목 선택";
            Load += R_SelectProductNum_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button SearchRProductList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button prevButton;
        private MetroGrid dataGridView1;
        private DataGridViewTextBoxColumn r_product_num;
        private DataGridViewTextBoxColumn r_product_name;
    }
}
