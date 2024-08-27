namespace WindowsFormsApp1
{
    partial class SelectRD
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
            this.selectReconditionedButton = new System.Windows.Forms.Button();
            this.selectDefectiveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // selectReconditionedButton
            // 
            this.selectReconditionedButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selectReconditionedButton.BackColor = System.Drawing.SystemColors.Control;
            this.selectReconditionedButton.Font = new System.Drawing.Font("굴림", 20F);
            this.selectReconditionedButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.selectReconditionedButton.Location = new System.Drawing.Point(291, 73);
            this.selectReconditionedButton.Name = "selectReconditionedButton";
            this.selectReconditionedButton.Size = new System.Drawing.Size(274, 140);
            this.selectReconditionedButton.TabIndex = 2;
            this.selectReconditionedButton.Text = "(R)재생품\r\n자재 조회\r\n";
            this.selectReconditionedButton.UseVisualStyleBackColor = false;
            this.selectReconditionedButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // selectDefectiveButton
            // 
            this.selectDefectiveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selectDefectiveButton.BackColor = System.Drawing.SystemColors.Control;
            this.selectDefectiveButton.Font = new System.Drawing.Font("굴림", 20F);
            this.selectDefectiveButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.selectDefectiveButton.Location = new System.Drawing.Point(1, 73);
            this.selectDefectiveButton.Name = "selectDefectiveButton";
            this.selectDefectiveButton.Size = new System.Drawing.Size(284, 140);
            this.selectDefectiveButton.TabIndex = 3;
            this.selectDefectiveButton.Text = "(D)정비필요품\r\n자재 조회";
            this.selectDefectiveButton.UseVisualStyleBackColor = false;
            this.selectDefectiveButton.Click += new System.EventHandler(this.selectDefectiveButton_Click);
            // 
            // SelectRD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(577, 259);
            this.Controls.Add(this.selectDefectiveButton);
            this.Controls.Add(this.selectReconditionedButton);
            this.Name = "SelectRD";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button selectReconditionedButton;
        private System.Windows.Forms.Button selectDefectiveButton;
    }
}