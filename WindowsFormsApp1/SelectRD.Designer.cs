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
            this.selectDefectiveButton = new System.Windows.Forms.Button();
            this.selectReconditionedButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // selectDefectiveButton
            // 
            this.selectDefectiveButton.BackColor = System.Drawing.SystemColors.Control;
            this.selectDefectiveButton.Font = new System.Drawing.Font("굴림", 20F);
            this.selectDefectiveButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.selectDefectiveButton.Location = new System.Drawing.Point(39, 73);
            this.selectDefectiveButton.Name = "selectDefectiveButton";
            this.selectDefectiveButton.Size = new System.Drawing.Size(202, 109);
            this.selectDefectiveButton.TabIndex = 1;
            this.selectDefectiveButton.Text = "정비필요품\r\n(D)";
            this.selectDefectiveButton.UseVisualStyleBackColor = false;
            this.selectDefectiveButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // selectReconditionedButton
            // 
            this.selectReconditionedButton.BackColor = System.Drawing.SystemColors.Control;
            this.selectReconditionedButton.Font = new System.Drawing.Font("굴림", 20F);
            this.selectReconditionedButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.selectReconditionedButton.Location = new System.Drawing.Point(266, 73);
            this.selectReconditionedButton.Name = "selectReconditionedButton";
            this.selectReconditionedButton.Size = new System.Drawing.Size(202, 109);
            this.selectReconditionedButton.TabIndex = 2;
            this.selectReconditionedButton.Text = "재생품\r\n(R)";
            this.selectReconditionedButton.UseVisualStyleBackColor = false;
            this.selectReconditionedButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // Select
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(501, 228);
            this.Controls.Add(this.selectReconditionedButton);
            this.Controls.Add(this.selectDefectiveButton);
            this.Name = "Select";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button selectDefectiveButton;
        private System.Windows.Forms.Button selectReconditionedButton;
    }
}