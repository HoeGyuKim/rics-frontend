namespace WindowsFormsApp1
{
    partial class AddProductList
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AcceptApp = new System.Windows.Forms.Button();
            this.CancelAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.addProductNumTextBox = new System.Windows.Forms.TextBox();
            this.addProductNameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(18, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "자재명";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(18, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "자재번호";
            // 
            // AcceptApp
            // 
            this.AcceptApp.Location = new System.Drawing.Point(120, 125);
            this.AcceptApp.Name = "AcceptApp";
            this.AcceptApp.Size = new System.Drawing.Size(118, 35);
            this.AcceptApp.TabIndex = 2;
            this.AcceptApp.Text = "확인";
            this.AcceptApp.UseVisualStyleBackColor = true;
            this.AcceptApp.Click += new System.EventHandler(this.AcceptApp_Click);
            // 
            // CancelAdd
            // 
            this.CancelAdd.Location = new System.Drawing.Point(237, 125);
            this.CancelAdd.Name = "CancelAdd";
            this.CancelAdd.Size = new System.Drawing.Size(118, 35);
            this.CancelAdd.TabIndex = 3;
            this.CancelAdd.Text = "취소";
            this.CancelAdd.UseVisualStyleBackColor = true;
            this.CancelAdd.Click += new System.EventHandler(this.CancelAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(373, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "관리자 확인 후 추가됩니다. 문의 전화 : 043-200-4615";
            // 
            // addProductNumTextBox
            // 
            this.addProductNumTextBox.Location = new System.Drawing.Point(120, 37);
            this.addProductNumTextBox.Name = "addProductNumTextBox";
            this.addProductNumTextBox.Size = new System.Drawing.Size(235, 25);
            this.addProductNumTextBox.TabIndex = 5;
            // 
            // addProductNameTextBox
            // 
            this.addProductNameTextBox.Location = new System.Drawing.Point(120, 83);
            this.addProductNameTextBox.Name = "addProductNameTextBox";
            this.addProductNameTextBox.Size = new System.Drawing.Size(235, 25);
            this.addProductNameTextBox.TabIndex = 6;
            // 
            // AddProductList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 233);
            this.Controls.Add(this.addProductNameTextBox);
            this.Controls.Add(this.addProductNumTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CancelAdd);
            this.Controls.Add(this.AcceptApp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddProductList";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AcceptApp;
        private System.Windows.Forms.Button CancelAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addProductNumTextBox;
        private System.Windows.Forms.TextBox addProductNameTextBox;
    }
}