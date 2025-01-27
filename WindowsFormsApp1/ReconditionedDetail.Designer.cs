namespace WindowsFormsApp1
{
    partial class ReconditionedDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReconditionedDetail));
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.creatQRCodeButton = new System.Windows.Forms.Button();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.departMentNameTextBox = new System.Windows.Forms.TextBox();
            this.DateTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.serialNumTextBox = new System.Windows.Forms.TextBox();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.productNumTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lastApprovalDateTextBox = new System.Windows.Forms.TextBox();
            this.lastManagerNameTextBox = new System.Windows.Forms.TextBox();
            this.firstApprovalDateTextBox = new System.Windows.Forms.TextBox();
            this.submitDateTextBox = new System.Windows.Forms.TextBox();
            this.workerNameTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.middleManagerNameTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.text1 = new System.Windows.Forms.Label();
            this.memoTextBox = new System.Windows.Forms.TextBox();
            this.fixButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.QRCodePictureBox = new System.Windows.Forms.PictureBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.contactNumberTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.DownQRCodeButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.approvalStatusTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.PDFViewer1 = new AxAcroPDFLib.AxAcroPDF();
            this.PDFViewer2 = new AxAcroPDFLib.AxAcroPDF();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QRCodePictureBox)).BeginInit();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PDFViewer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PDFViewer2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(2113, 171);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(165, 144);
            this.pictureBox.TabIndex = 5;
            this.pictureBox.TabStop = false;
            // 
            // creatQRCodeButton
            // 
            this.creatQRCodeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.creatQRCodeButton.Location = new System.Drawing.Point(1535, 62);
            this.creatQRCodeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.creatQRCodeButton.Name = "creatQRCodeButton";
            this.creatQRCodeButton.Size = new System.Drawing.Size(155, 38);
            this.creatQRCodeButton.TabIndex = 8;
            this.creatQRCodeButton.Text = "QR생성(불러오기)";
            this.creatQRCodeButton.UseVisualStyleBackColor = true;
            this.creatQRCodeButton.Click += new System.EventHandler(this.CreatQRCodeButton_Click);
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.42246F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.57754F));
            this.tableLayoutPanel1.Controls.Add(this.departMentNameTextBox, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.DateTextBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.serialNumTextBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.productNameTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.productNumTextBox, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 15);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(374, 181);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // departMentNameTextBox
            // 
            this.departMentNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.departMentNameTextBox.Location = new System.Drawing.Point(139, 150);
            this.departMentNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.departMentNameTextBox.Name = "departMentNameTextBox";
            this.departMentNameTextBox.ReadOnly = true;
            this.departMentNameTextBox.Size = new System.Drawing.Size(220, 25);
            this.departMentNameTextBox.TabIndex = 6;
            // 
            // DateTextBox
            // 
            this.DateTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DateTextBox.Location = new System.Drawing.Point(139, 114);
            this.DateTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DateTextBox.Name = "DateTextBox";
            this.DateTextBox.ReadOnly = true;
            this.DateTextBox.Size = new System.Drawing.Size(220, 25);
            this.DateTextBox.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 155);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 15);
            this.label9.TabIndex = 2;
            this.label9.Text = "발생부서";
            // 
            // serialNumTextBox
            // 
            this.serialNumTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.serialNumTextBox.Location = new System.Drawing.Point(139, 78);
            this.serialNumTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.serialNumTextBox.Name = "serialNumTextBox";
            this.serialNumTextBox.ReadOnly = true;
            this.serialNumTextBox.Size = new System.Drawing.Size(220, 25);
            this.serialNumTextBox.TabIndex = 7;
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.productNameTextBox.Location = new System.Drawing.Point(139, 42);
            this.productNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.ReadOnly = true;
            this.productNameTextBox.Size = new System.Drawing.Size(220, 25);
            this.productNameTextBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "완료일자";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "자재명";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "일련번호";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "자재번호";
            // 
            // productNumTextBox
            // 
            this.productNumTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.productNumTextBox.Location = new System.Drawing.Point(139, 6);
            this.productNumTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productNumTextBox.Name = "productNumTextBox";
            this.productNumTextBox.ReadOnly = true;
            this.productNumTextBox.Size = new System.Drawing.Size(220, 25);
            this.productNumTextBox.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.70711F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.70711F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.58577F));
            this.tableLayoutPanel2.Controls.Add(this.lastApprovalDateTextBox, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.lastManagerNameTextBox, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.workerNameTextBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.middleManagerNameTextBox, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.firstApprovalDateTextBox, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.submitDateTextBox, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(393, 51);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(479, 110);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // lastApprovalDateTextBox
            // 
            this.lastApprovalDateTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lastApprovalDateTextBox.Location = new System.Drawing.Point(288, 78);
            this.lastApprovalDateTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lastApprovalDateTextBox.Name = "lastApprovalDateTextBox";
            this.lastApprovalDateTextBox.ReadOnly = true;
            this.lastApprovalDateTextBox.Size = new System.Drawing.Size(187, 25);
            this.lastApprovalDateTextBox.TabIndex = 11;
            // 
            // lastManagerNameTextBox
            // 
            this.lastManagerNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lastManagerNameTextBox.Location = new System.Drawing.Point(147, 78);
            this.lastManagerNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lastManagerNameTextBox.Name = "lastManagerNameTextBox";
            this.lastManagerNameTextBox.ReadOnly = true;
            this.lastManagerNameTextBox.Size = new System.Drawing.Size(133, 25);
            this.lastManagerNameTextBox.TabIndex = 10;
            // 
            // firstApprovalDateTextBox
            // 
            this.firstApprovalDateTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.firstApprovalDateTextBox.Location = new System.Drawing.Point(288, 42);
            this.firstApprovalDateTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.firstApprovalDateTextBox.Name = "firstApprovalDateTextBox";
            this.firstApprovalDateTextBox.ReadOnly = true;
            this.firstApprovalDateTextBox.Size = new System.Drawing.Size(186, 25);
            this.firstApprovalDateTextBox.TabIndex = 9;
            // 
            // submitDateTextBox
            // 
            this.submitDateTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.submitDateTextBox.Location = new System.Drawing.Point(288, 6);
            this.submitDateTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.submitDateTextBox.Name = "submitDateTextBox";
            this.submitDateTextBox.ReadOnly = true;
            this.submitDateTextBox.Size = new System.Drawing.Size(187, 25);
            this.submitDateTextBox.TabIndex = 8;
            // 
            // workerNameTextBox
            // 
            this.workerNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.workerNameTextBox.Location = new System.Drawing.Point(147, 6);
            this.workerNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.workerNameTextBox.Name = "workerNameTextBox";
            this.workerNameTextBox.ReadOnly = true;
            this.workerNameTextBox.Size = new System.Drawing.Size(133, 25);
            this.workerNameTextBox.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "최종 검토";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "상신";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "검토";
            // 
            // middleManagerNameTextBox
            // 
            this.middleManagerNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.middleManagerNameTextBox.Location = new System.Drawing.Point(147, 42);
            this.middleManagerNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.middleManagerNameTextBox.Name = "middleManagerNameTextBox";
            this.middleManagerNameTextBox.ReadOnly = true;
            this.middleManagerNameTextBox.Size = new System.Drawing.Size(133, 25);
            this.middleManagerNameTextBox.TabIndex = 6;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.57862F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.42139F));
            this.tableLayoutPanel3.Controls.Add(this.text1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.memoTextBox, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(13, 196);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 89F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(665, 90);
            this.tableLayoutPanel3.TabIndex = 10;
            // 
            // text1
            // 
            this.text1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.text1.AutoSize = true;
            this.text1.Location = new System.Drawing.Point(19, 37);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(46, 15);
            this.text1.TabIndex = 0;
            this.text1.Text = "memo";
            // 
            // memoTextBox
            // 
            this.memoTextBox.Location = new System.Drawing.Point(88, 3);
            this.memoTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.memoTextBox.Multiline = true;
            this.memoTextBox.Name = "memoTextBox";
            this.memoTextBox.ReadOnly = true;
            this.memoTextBox.Size = new System.Drawing.Size(573, 82);
            this.memoTextBox.TabIndex = 1;
            // 
            // fixButton
            // 
            this.fixButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fixButton.Location = new System.Drawing.Point(1696, 15);
            this.fixButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fixButton.Name = "fixButton";
            this.fixButton.Size = new System.Drawing.Size(155, 39);
            this.fixButton.TabIndex = 11;
            this.fixButton.Text = "수정";
            this.fixButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.tableLayoutPanel7);
            this.panel1.Controls.Add(this.deleteButton);
            this.panel1.Controls.Add(this.tableLayoutPanel6);
            this.panel1.Controls.Add(this.DownQRCodeButton);
            this.panel1.Controls.Add(this.tableLayoutPanel5);
            this.panel1.Controls.Add(this.tableLayoutPanel4);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Controls.Add(this.tableLayoutPanel3);
            this.panel1.Controls.Add(this.fixButton);
            this.panel1.Controls.Add(this.pictureBox);
            this.panel1.Controls.Add(this.creatQRCodeButton);
            this.panel1.Location = new System.Drawing.Point(21, 75);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1879, 985);
            this.panel1.TabIndex = 15;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel7.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 157F));
            this.tableLayoutPanel7.Controls.Add(this.label10, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.QRCodePictureBox, 0, 0);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(1696, 106);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(155, 175);
            this.tableLayoutPanel7.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(50, 155);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 15);
            this.label10.TabIndex = 22;
            this.label10.Text = "QR코드";
            // 
            // QRCodePictureBox
            // 
            this.QRCodePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QRCodePictureBox.Location = new System.Drawing.Point(4, 5);
            this.QRCodePictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.QRCodePictureBox.Name = "QRCodePictureBox";
            this.QRCodePictureBox.Size = new System.Drawing.Size(151, 142);
            this.QRCodePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.QRCodePictureBox.TabIndex = 21;
            this.QRCodePictureBox.TabStop = false;
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteButton.Location = new System.Drawing.Point(1535, 15);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(155, 39);
            this.deleteButton.TabIndex = 20;
            this.deleteButton.Text = "삭제 신청";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.contactNumberTextBox, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.label11, 0, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(393, 160);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(285, 36);
            this.tableLayoutPanel6.TabIndex = 19;
            // 
            // contactNumberTextBox
            // 
            this.contactNumberTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.contactNumberTextBox.Location = new System.Drawing.Point(147, 5);
            this.contactNumberTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.contactNumberTextBox.Name = "contactNumberTextBox";
            this.contactNumberTextBox.ReadOnly = true;
            this.contactNumberTextBox.Size = new System.Drawing.Size(133, 25);
            this.contactNumberTextBox.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 15);
            this.label11.TabIndex = 5;
            this.label11.Text = "작업자 연락처";
            // 
            // DownQRCodeButton
            // 
            this.DownQRCodeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DownQRCodeButton.Location = new System.Drawing.Point(1696, 62);
            this.DownQRCodeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DownQRCodeButton.Name = "DownQRCodeButton";
            this.DownQRCodeButton.Size = new System.Drawing.Size(155, 38);
            this.DownQRCodeButton.TabIndex = 17;
            this.DownQRCodeButton.Text = "QR 다운로드";
            this.DownQRCodeButton.UseVisualStyleBackColor = true;
            this.DownQRCodeButton.Click += new System.EventHandler(this.DownQRCodeButton_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.approvalStatusTextBox, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(393, 15);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(285, 36);
            this.tableLayoutPanel5.TabIndex = 16;
            // 
            // approvalStatusTextBox
            // 
            this.approvalStatusTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.approvalStatusTextBox.Location = new System.Drawing.Point(147, 5);
            this.approvalStatusTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.approvalStatusTextBox.Name = "approvalStatusTextBox";
            this.approvalStatusTextBox.ReadOnly = true;
            this.approvalStatusTextBox.Size = new System.Drawing.Size(133, 25);
            this.approvalStatusTextBox.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 0;
            this.label8.Text = "결재상태";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.PDFViewer1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.PDFViewer2, 1, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(13, 288);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 688F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1839, 688);
            this.tableLayoutPanel4.TabIndex = 15;
            // 
            // PDFViewer1
            // 
            this.PDFViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PDFViewer1.Enabled = true;
            this.PDFViewer1.Location = new System.Drawing.Point(3, 2);
            this.PDFViewer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PDFViewer1.Name = "PDFViewer1";
            this.PDFViewer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("PDFViewer1.OcxState")));
            this.PDFViewer1.Size = new System.Drawing.Size(913, 684);
            this.PDFViewer1.TabIndex = 0;
            // 
            // PDFViewer2
            // 
            this.PDFViewer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PDFViewer2.Enabled = true;
            this.PDFViewer2.Location = new System.Drawing.Point(922, 2);
            this.PDFViewer2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PDFViewer2.Name = "PDFViewer2";
            this.PDFViewer2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("PDFViewer2.OcxState")));
            this.PDFViewer2.Size = new System.Drawing.Size(914, 684);
            this.PDFViewer2.TabIndex = 1;
            // 
            // ReconditionedDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ReconditionedDetail";
            this.Padding = new System.Windows.Forms.Padding(21, 75, 21, 20);
            this.Text = "상세정보";
            this.Load += new System.EventHandler(this.ReconditionedDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QRCodePictureBox)).EndInit();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PDFViewer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PDFViewer2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button creatQRCodeButton;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button fixButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private AxAcroPDFLib.AxAcroPDF PDFViewer1;
        private AxAcroPDFLib.AxAcroPDF PDFViewer2;
        private System.Windows.Forms.Label text1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox memoTextBox;
        private System.Windows.Forms.TextBox DateTextBox;
        private System.Windows.Forms.TextBox serialNumTextBox;
        private System.Windows.Forms.TextBox productNameTextBox;
        private System.Windows.Forms.TextBox productNumTextBox;
        private System.Windows.Forms.TextBox middleManagerNameTextBox;
        private System.Windows.Forms.TextBox lastApprovalDateTextBox;
        private System.Windows.Forms.TextBox lastManagerNameTextBox;
        private System.Windows.Forms.TextBox firstApprovalDateTextBox;
        private System.Windows.Forms.TextBox submitDateTextBox;
        private System.Windows.Forms.TextBox workerNameTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox approvalStatusTextBox;
        private System.Windows.Forms.Button DownQRCodeButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox departMentNameTextBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.PictureBox QRCodePictureBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox contactNumberTextBox;
        private System.Windows.Forms.Label label11;
    }
}