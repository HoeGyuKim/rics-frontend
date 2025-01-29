namespace WindowsFormsApp
{
    partial class Login
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
            passwordtxt = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            nametxt = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // passwordtxt
            // 
            passwordtxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            passwordtxt.Location = new System.Drawing.Point(260, 267);
            passwordtxt.Name = "passwordtxt";
            passwordtxt.Size = new System.Drawing.Size(371, 27);
            passwordtxt.TabIndex = 3;
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(213, 271);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(39, 20);
            label3.TabIndex = 4;
            label3.Text = "사번";
            label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.SystemColors.Control;
            label2.Location = new System.Drawing.Point(213, 242);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(39, 20);
            label2.TabIndex = 2;
            label2.Text = "성명";
            label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            button1.Location = new System.Drawing.Point(346, 314);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(186, 56);
            button1.TabIndex = 5;
            button1.Text = "로그인";
            button1.UseVisualStyleBackColor = true;
            button1.Click += BtnLogin_Click;
            // 
            // nametxt
            // 
            nametxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            nametxt.Location = new System.Drawing.Point(260, 234);
            nametxt.Name = "nametxt";
            nametxt.Size = new System.Drawing.Size(371, 27);
            nametxt.TabIndex = 1;
            // 
            // label4
            // 
            label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("돋움", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
            label4.Location = new System.Drawing.Point(260, 194);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(399, 18);
            label4.TabIndex = 6;
            label4.Text = "Reconditioned Product Informationization System";
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("돋움", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 129);
            label1.Location = new System.Drawing.Point(200, 109);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(506, 50);
            label1.TabIndex = 0;
            label1.Text = "재생품 정보화 시스템";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            pictureBox1.Image = WindowsFormsApp1.Properties.Resources.korailPng;
            pictureBox1.Location = new System.Drawing.Point(694, 34);
            pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(194, 51);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(915, 469);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(nametxt);
            Controls.Add(button1);
            Controls.Add(passwordtxt);
            Controls.Add(label2);
            Controls.Add(label3);
            Name = "Login";
            Padding = new System.Windows.Forms.Padding(24, 100, 24, 27);
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox passwordtxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}