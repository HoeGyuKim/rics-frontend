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
            this.selectReconditionedButton = new MetroFramework.Controls.MetroButton();
            this.selectDefectiveButton = new MetroFramework.Controls.MetroButton();
            this.htmlLabel1 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.mySqlConnection1 = new MySql.Data.MySqlClient.MySqlConnection();
            this.SuspendLayout();
            // 
            // selectReconditionedButton
            // 
            this.selectReconditionedButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.selectReconditionedButton.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.selectReconditionedButton.Location = new System.Drawing.Point(329, 113);
            this.selectReconditionedButton.Name = "selectReconditionedButton";
            this.selectReconditionedButton.Size = new System.Drawing.Size(211, 111);
            this.selectReconditionedButton.TabIndex = 4;
            this.selectReconditionedButton.Text = "재생품\r\n자재 조회";
            this.selectReconditionedButton.UseSelectable = true;
            this.selectReconditionedButton.Click += new System.EventHandler(this.selectReconditionedButton_Click);
            // 
            // selectDefectiveButton
            // 
            this.selectDefectiveButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.selectDefectiveButton.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.selectDefectiveButton.Location = new System.Drawing.Point(93, 113);
            this.selectDefectiveButton.Name = "selectDefectiveButton";
            this.selectDefectiveButton.Size = new System.Drawing.Size(211, 111);
            this.selectDefectiveButton.TabIndex = 5;
            this.selectDefectiveButton.Text = "정비 필요품\r\n자재 조회";
            this.selectDefectiveButton.UseSelectable = true;
            // 
            // htmlLabel1
            // 
            this.htmlLabel1.AutoScroll = true;
            this.htmlLabel1.AutoScrollMinSize = new System.Drawing.Size(87, 27);
            this.htmlLabel1.AutoSize = false;
            this.htmlLabel1.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel1.Location = new System.Drawing.Point(25, 18);
            this.htmlLabel1.Name = "htmlLabel1";
            this.htmlLabel1.Size = new System.Drawing.Size(175, 38);
            this.htmlLabel1.TabIndex = 6;
            this.htmlLabel1.Text = "htmlLabel1";
            // 
            // SelectRD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 294);
            this.Controls.Add(this.htmlLabel1);
            this.Controls.Add(this.selectDefectiveButton);
            this.Controls.Add(this.selectReconditionedButton);
            this.Font = new System.Drawing.Font("굴림", 10F);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "SelectRD";
            this.Padding = new System.Windows.Forms.Padding(22, 68, 22, 22);
            this.Load += new System.EventHandler(this.SelectRD_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton selectReconditionedButton;
        private MetroFramework.Controls.MetroButton selectDefectiveButton;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel1;
        private MySql.Data.MySqlClient.MySqlConnection mySqlConnection1;
    }
}