namespace WindowsFormsApp1
{
    partial class D_Defective
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.button4 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.d_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d_product_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d_serial_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d_product_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d_worker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d_manager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(722, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "등록";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(811, 60);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 30);
            this.button2.TabIndex = 2;
            this.button2.Text = "삭제";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(900, 61);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(83, 30);
            this.button3.TabIndex = 3;
            this.button3.Text = "상세";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("굴림", 9F);
            this.textBox1.Location = new System.Drawing.Point(36, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(309, 25);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(633, 60);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(83, 30);
            this.button4.TabIndex = 6;
            this.button4.Text = "검색";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("굴림", 9F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "완료일자",
            "작업자",
            "자재번호",
            "시리얼번호",
            "자재명"});
            this.comboBox1.Location = new System.Drawing.Point(353, 66);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(112, 23);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.d_date,
            this.d_product_num,
            this.d_serial_num,
            this.d_product_name,
            this.d_worker,
            this.d_manager});
            this.dataGridView1.Location = new System.Drawing.Point(36, 112);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 80;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(947, 440);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // d_date
            // 
            this.d_date.HeaderText = "발생일자";
            this.d_date.MinimumWidth = 6;
            this.d_date.Name = "d_date";
            this.d_date.Width = 125;
            // 
            // d_product_num
            // 
            this.d_product_num.HeaderText = "자재번호";
            this.d_product_num.MinimumWidth = 6;
            this.d_product_num.Name = "d_product_num";
            this.d_product_num.Width = 125;
            // 
            // d_serial_num
            // 
            this.d_serial_num.HeaderText = "Serial_No.";
            this.d_serial_num.MinimumWidth = 6;
            this.d_serial_num.Name = "d_serial_num";
            this.d_serial_num.Width = 125;
            // 
            // d_product_name
            // 
            this.d_product_name.HeaderText = "자재명";
            this.d_product_name.MinimumWidth = 6;
            this.d_product_name.Name = "d_product_name";
            this.d_product_name.Width = 125;
            // 
            // d_worker
            // 
            this.d_worker.HeaderText = "점검자";
            this.d_worker.MinimumWidth = 6;
            this.d_worker.Name = "d_worker";
            this.d_worker.Width = 125;
            // 
            // d_manager
            // 
            this.d_manager.HeaderText = "관리자";
            this.d_manager.MinimumWidth = 6;
            this.d_manager.Name = "d_manager";
            this.d_manager.Width = 125;
            // 
            // D_Defective
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1054, 607);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Enabled = false;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "D_Defective";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.R_Regener_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn d_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn d_product_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn d_serial_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn d_product_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn d_worker;
        private System.Windows.Forms.DataGridViewTextBoxColumn d_manager;
    }
}