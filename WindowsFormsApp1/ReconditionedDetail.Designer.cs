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
            pictureBox = new System.Windows.Forms.PictureBox();
            creatQRCodeButton = new System.Windows.Forms.Button();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            departMentNameTextBox = new System.Windows.Forms.TextBox();
            DateTextBox = new System.Windows.Forms.TextBox();
            label9 = new System.Windows.Forms.Label();
            serialNumTextBox = new System.Windows.Forms.TextBox();
            productNameTextBox = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            productNumTextBox = new System.Windows.Forms.TextBox();
            tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            lastApprovalDateTextBox = new System.Windows.Forms.TextBox();
            lastManagerNameTextBox = new System.Windows.Forms.TextBox();
            workerNameTextBox = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            middleManagerNameTextBox = new System.Windows.Forms.TextBox();
            firstApprovalDateTextBox = new System.Windows.Forms.TextBox();
            submitDateTextBox = new System.Windows.Forms.TextBox();
            tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            text1 = new System.Windows.Forms.Label();
            memoTextBox = new System.Windows.Forms.TextBox();
            editButton = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            label10 = new System.Windows.Forms.Label();
            QRCodePictureBox = new System.Windows.Forms.PictureBox();
            deleteButton = new System.Windows.Forms.Button();
            tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            contactNumberTextBox = new System.Windows.Forms.TextBox();
            label11 = new System.Windows.Forms.Label();
            DownQRCodeButton = new System.Windows.Forms.Button();
            tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            approvalStatusTextBox = new System.Windows.Forms.TextBox();
            label8 = new System.Windows.Forms.Label();
            tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            PDFViewer1 = new AxAcroPDFLib.AxAcroPDF();
            PDFViewer2 = new AxAcroPDFLib.AxAcroPDF();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)QRCodePictureBox).BeginInit();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PDFViewer1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PDFViewer2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.Location = new System.Drawing.Point(2377, 228);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new System.Drawing.Size(186, 192);
            pictureBox.TabIndex = 5;
            pictureBox.TabStop = false;
            // 
            // creatQRCodeButton
            // 
            creatQRCodeButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            creatQRCodeButton.Location = new System.Drawing.Point(1595, 68);
            creatQRCodeButton.Name = "creatQRCodeButton";
            creatQRCodeButton.Size = new System.Drawing.Size(142, 40);
            creatQRCodeButton.TabIndex = 8;
            creatQRCodeButton.Text = "QR생성(불러오기)";
            creatQRCodeButton.UseVisualStyleBackColor = true;
            creatQRCodeButton.Click += CreatQRCodeButton_Click;
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.42246F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.57754F));
            tableLayoutPanel1.Controls.Add(departMentNameTextBox, 1, 4);
            tableLayoutPanel1.Controls.Add(DateTextBox, 1, 3);
            tableLayoutPanel1.Controls.Add(label9, 0, 4);
            tableLayoutPanel1.Controls.Add(serialNumTextBox, 1, 2);
            tableLayoutPanel1.Controls.Add(productNameTextBox, 1, 1);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(productNumTextBox, 1, 0);
            tableLayoutPanel1.Location = new System.Drawing.Point(15, 20);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new System.Drawing.Size(421, 175);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // departMentNameTextBox
            // 
            departMentNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            departMentNameTextBox.Location = new System.Drawing.Point(157, 142);
            departMentNameTextBox.Name = "departMentNameTextBox";
            departMentNameTextBox.ReadOnly = true;
            departMentNameTextBox.Size = new System.Drawing.Size(247, 27);
            departMentNameTextBox.TabIndex = 6;
            // 
            // DateTextBox
            // 
            DateTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            DateTextBox.Location = new System.Drawing.Point(157, 106);
            DateTextBox.Name = "DateTextBox";
            DateTextBox.ReadOnly = true;
            DateTextBox.Size = new System.Drawing.Size(247, 27);
            DateTextBox.TabIndex = 8;
            // 
            // label9
            // 
            label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(36, 145);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(69, 20);
            label9.TabIndex = 2;
            label9.Text = "발생부서";
            // 
            // serialNumTextBox
            // 
            serialNumTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            serialNumTextBox.Location = new System.Drawing.Point(157, 72);
            serialNumTextBox.Name = "serialNumTextBox";
            serialNumTextBox.ReadOnly = true;
            serialNumTextBox.Size = new System.Drawing.Size(247, 27);
            serialNumTextBox.TabIndex = 7;
            // 
            // productNameTextBox
            // 
            productNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            productNameTextBox.Location = new System.Drawing.Point(157, 38);
            productNameTextBox.Name = "productNameTextBox";
            productNameTextBox.ReadOnly = true;
            productNameTextBox.Size = new System.Drawing.Size(247, 27);
            productNameTextBox.TabIndex = 6;
            // 
            // label4
            // 
            label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(36, 109);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(69, 20);
            label4.TabIndex = 4;
            label4.Text = "완료일자";
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(43, 41);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(54, 20);
            label2.TabIndex = 2;
            label2.Text = "자재명";
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(36, 75);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(69, 20);
            label3.TabIndex = 3;
            label3.Text = "일련번호";
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(36, 7);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(69, 20);
            label1.TabIndex = 1;
            label1.Text = "자재번호";
            // 
            // productNumTextBox
            // 
            productNumTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            productNumTextBox.Location = new System.Drawing.Point(157, 4);
            productNumTextBox.Name = "productNumTextBox";
            productNumTextBox.ReadOnly = true;
            productNumTextBox.Size = new System.Drawing.Size(247, 27);
            productNumTextBox.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.7397766F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.7397766F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.5204468F));
            tableLayoutPanel2.Controls.Add(lastApprovalDateTextBox, 2, 2);
            tableLayoutPanel2.Controls.Add(lastManagerNameTextBox, 1, 2);
            tableLayoutPanel2.Controls.Add(workerNameTextBox, 1, 0);
            tableLayoutPanel2.Controls.Add(label7, 0, 2);
            tableLayoutPanel2.Controls.Add(label5, 0, 0);
            tableLayoutPanel2.Controls.Add(label6, 0, 1);
            tableLayoutPanel2.Controls.Add(middleManagerNameTextBox, 1, 1);
            tableLayoutPanel2.Controls.Add(firstApprovalDateTextBox, 2, 1);
            tableLayoutPanel2.Controls.Add(submitDateTextBox, 2, 0);
            tableLayoutPanel2.Location = new System.Drawing.Point(442, 53);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            tableLayoutPanel2.Size = new System.Drawing.Size(539, 103);
            tableLayoutPanel2.TabIndex = 10;
            // 
            // lastApprovalDateTextBox
            // 
            lastApprovalDateTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            lastApprovalDateTextBox.Location = new System.Drawing.Point(324, 72);
            lastApprovalDateTextBox.Name = "lastApprovalDateTextBox";
            lastApprovalDateTextBox.ReadOnly = true;
            lastApprovalDateTextBox.Size = new System.Drawing.Size(210, 27);
            lastApprovalDateTextBox.TabIndex = 11;
            // 
            // lastManagerNameTextBox
            // 
            lastManagerNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            lastManagerNameTextBox.Location = new System.Drawing.Point(166, 72);
            lastManagerNameTextBox.Name = "lastManagerNameTextBox";
            lastManagerNameTextBox.ReadOnly = true;
            lastManagerNameTextBox.Size = new System.Drawing.Size(149, 27);
            lastManagerNameTextBox.TabIndex = 10;
            // 
            // workerNameTextBox
            // 
            workerNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            workerNameTextBox.Location = new System.Drawing.Point(166, 4);
            workerNameTextBox.Name = "workerNameTextBox";
            workerNameTextBox.ReadOnly = true;
            workerNameTextBox.Size = new System.Drawing.Size(149, 27);
            workerNameTextBox.TabIndex = 7;
            // 
            // label7
            // 
            label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(43, 75);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(74, 20);
            label7.TabIndex = 4;
            label7.Text = "최종 검토";
            // 
            // label5
            // 
            label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(61, 7);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(39, 20);
            label5.TabIndex = 2;
            label5.Text = "상신";
            // 
            // label6
            // 
            label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(61, 41);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(39, 20);
            label6.TabIndex = 3;
            label6.Text = "검토";
            // 
            // middleManagerNameTextBox
            // 
            middleManagerNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            middleManagerNameTextBox.Location = new System.Drawing.Point(166, 38);
            middleManagerNameTextBox.Name = "middleManagerNameTextBox";
            middleManagerNameTextBox.ReadOnly = true;
            middleManagerNameTextBox.Size = new System.Drawing.Size(149, 27);
            middleManagerNameTextBox.TabIndex = 6;
            // 
            // firstApprovalDateTextBox
            // 
            firstApprovalDateTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            firstApprovalDateTextBox.Location = new System.Drawing.Point(325, 38);
            firstApprovalDateTextBox.Name = "firstApprovalDateTextBox";
            firstApprovalDateTextBox.ReadOnly = true;
            firstApprovalDateTextBox.Size = new System.Drawing.Size(209, 27);
            firstApprovalDateTextBox.TabIndex = 9;
            // 
            // submitDateTextBox
            // 
            submitDateTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            submitDateTextBox.Location = new System.Drawing.Point(324, 4);
            submitDateTextBox.Name = "submitDateTextBox";
            submitDateTextBox.ReadOnly = true;
            submitDateTextBox.Size = new System.Drawing.Size(210, 27);
            submitDateTextBox.TabIndex = 8;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.57862F));
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.42139F));
            tableLayoutPanel3.Controls.Add(text1, 0, 0);
            tableLayoutPanel3.Controls.Add(memoTextBox, 1, 0);
            tableLayoutPanel3.Location = new System.Drawing.Point(15, 201);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 119F));
            tableLayoutPanel3.Size = new System.Drawing.Size(748, 105);
            tableLayoutPanel3.TabIndex = 10;
            // 
            // text1
            // 
            text1.Anchor = System.Windows.Forms.AnchorStyles.None;
            text1.AutoSize = true;
            text1.Location = new System.Drawing.Point(21, 42);
            text1.Name = "text1";
            text1.Size = new System.Drawing.Size(52, 20);
            text1.TabIndex = 0;
            text1.Text = "memo";
            // 
            // memoTextBox
            // 
            memoTextBox.Location = new System.Drawing.Point(98, 4);
            memoTextBox.Multiline = true;
            memoTextBox.Name = "memoTextBox";
            memoTextBox.ReadOnly = true;
            memoTextBox.Size = new System.Drawing.Size(644, 97);
            memoTextBox.TabIndex = 1;
            // 
            // editButton
            // 
            editButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            editButton.Location = new System.Drawing.Point(1743, 20);
            editButton.Name = "editButton";
            editButton.Size = new System.Drawing.Size(142, 42);
            editButton.TabIndex = 11;
            editButton.Text = "수정";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel7);
            panel1.Controls.Add(deleteButton);
            panel1.Controls.Add(tableLayoutPanel6);
            panel1.Controls.Add(DownQRCodeButton);
            panel1.Controls.Add(tableLayoutPanel5);
            panel1.Controls.Add(tableLayoutPanel4);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Controls.Add(tableLayoutPanel3);
            panel1.Controls.Add(editButton);
            panel1.Controls.Add(pictureBox);
            panel1.Controls.Add(creatQRCodeButton);
            panel1.Location = new System.Drawing.Point(24, 74);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1891, 1339);
            panel1.TabIndex = 15;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            tableLayoutPanel7.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel7.ColumnCount = 1;
            tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 179F));
            tableLayoutPanel7.Controls.Add(label10, 0, 1);
            tableLayoutPanel7.Controls.Add(QRCodePictureBox, 0, 0);
            tableLayoutPanel7.Location = new System.Drawing.Point(1711, 115);
            tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 2;
            tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 163F));
            tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel7.Size = new System.Drawing.Size(174, 196);
            tableLayoutPanel7.TabIndex = 22;
            // 
            // label10
            // 
            label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(60, 170);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(60, 20);
            label10.TabIndex = 22;
            label10.Text = "QR코드";
            // 
            // QRCodePictureBox
            // 
            QRCodePictureBox.Location = new System.Drawing.Point(4, 6);
            QRCodePictureBox.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            QRCodePictureBox.Name = "QRCodePictureBox";
            QRCodePictureBox.Size = new System.Drawing.Size(158, 147);
            QRCodePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            QRCodePictureBox.TabIndex = 21;
            QRCodePictureBox.TabStop = false;
            // 
            // deleteButton
            // 
            deleteButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            deleteButton.Location = new System.Drawing.Point(1595, 20);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new System.Drawing.Size(142, 42);
            deleteButton.TabIndex = 20;
            deleteButton.Text = "삭제 신청";
            deleteButton.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel6.Controls.Add(contactNumberTextBox, 1, 0);
            tableLayoutPanel6.Controls.Add(label11, 0, 0);
            tableLayoutPanel6.Location = new System.Drawing.Point(442, 155);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel6.Size = new System.Drawing.Size(321, 40);
            tableLayoutPanel6.TabIndex = 19;
            // 
            // contactNumberTextBox
            // 
            contactNumberTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            contactNumberTextBox.Location = new System.Drawing.Point(166, 6);
            contactNumberTextBox.Name = "contactNumberTextBox";
            contactNumberTextBox.ReadOnly = true;
            contactNumberTextBox.Size = new System.Drawing.Size(149, 27);
            contactNumberTextBox.TabIndex = 11;
            // 
            // label11
            // 
            label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(28, 10);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(104, 20);
            label11.TabIndex = 5;
            label11.Text = "작업자 연락처";
            // 
            // DownQRCodeButton
            // 
            DownQRCodeButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            DownQRCodeButton.Location = new System.Drawing.Point(1743, 67);
            DownQRCodeButton.Name = "DownQRCodeButton";
            DownQRCodeButton.Size = new System.Drawing.Size(142, 40);
            DownQRCodeButton.TabIndex = 17;
            DownQRCodeButton.Text = "QR 다운로드";
            DownQRCodeButton.UseVisualStyleBackColor = true;
            DownQRCodeButton.Click += DownQRCodeButton_Click;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(approvalStatusTextBox, 1, 0);
            tableLayoutPanel5.Controls.Add(label8, 0, 0);
            tableLayoutPanel5.Location = new System.Drawing.Point(442, 20);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new System.Drawing.Size(321, 34);
            tableLayoutPanel5.TabIndex = 16;
            // 
            // approvalStatusTextBox
            // 
            approvalStatusTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            approvalStatusTextBox.Location = new System.Drawing.Point(166, 4);
            approvalStatusTextBox.Name = "approvalStatusTextBox";
            approvalStatusTextBox.ReadOnly = true;
            approvalStatusTextBox.Size = new System.Drawing.Size(149, 27);
            approvalStatusTextBox.TabIndex = 8;
            // 
            // label8
            // 
            label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(46, 7);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(69, 20);
            label8.TabIndex = 0;
            label8.Text = "결재상태";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(PDFViewer1, 0, 0);
            tableLayoutPanel4.Controls.Add(PDFViewer2, 1, 0);
            tableLayoutPanel4.Location = new System.Drawing.Point(15, 312);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 917F));
            tableLayoutPanel4.Size = new System.Drawing.Size(1870, 1015);
            tableLayoutPanel4.TabIndex = 15;
            // 
            // PDFViewer1
            // 
            PDFViewer1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            PDFViewer1.Enabled = true;
            PDFViewer1.Location = new System.Drawing.Point(3, 3);
            PDFViewer1.Name = "PDFViewer1";
            PDFViewer1.OcxState = (System.Windows.Forms.AxHost.State)resources.GetObject("PDFViewer1.OcxState");
            PDFViewer1.Size = new System.Drawing.Size(929, 1009);
            PDFViewer1.TabIndex = 0;
            // 
            // PDFViewer2
            // 
            PDFViewer2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            PDFViewer2.Enabled = true;
            PDFViewer2.Location = new System.Drawing.Point(938, 3);
            PDFViewer2.Name = "PDFViewer2";
            PDFViewer2.OcxState = (System.Windows.Forms.AxHost.State)resources.GetObject("PDFViewer2.OcxState");
            PDFViewer2.Size = new System.Drawing.Size(929, 1009);
            PDFViewer2.TabIndex = 1;
            // 
            // ReconditionedDetail
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1942, 988);
            Controls.Add(panel1);
            Name = "ReconditionedDetail";
            Padding = new System.Windows.Forms.Padding(24, 100, 24, 27);
            Text = "상세정보";
            Load += ReconditionedDetail_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            panel1.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)QRCodePictureBox).EndInit();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PDFViewer1).EndInit();
            ((System.ComponentModel.ISupportInitialize)PDFViewer2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button creatQRCodeButton;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button editButton;
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