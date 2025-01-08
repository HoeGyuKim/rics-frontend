using Org.BouncyCastle.Bcpg;

namespace WindowsFormsApp1
{
    partial class WorkerFirstSelect
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
            this.selectWorkerMyListButton = new MetroFramework.Controls.MetroButton();
            this.htmlLabel1 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.mySqlConnection1 = new MySql.Data.MySqlClient.MySqlConnection();
            this.SuspendLayout();
            // 
            // selectReconditionedButton
            // 
            this.selectReconditionedButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.selectReconditionedButton.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.selectReconditionedButton.Location = new System.Drawing.Point(333, 100);
            this.selectReconditionedButton.Name = "selectReconditionedButton";
            this.selectReconditionedButton.Size = new System.Drawing.Size(211, 114);
            this.selectReconditionedButton.TabIndex = 4;
            this.selectReconditionedButton.Text = "재생품 자재 조회";
            this.selectReconditionedButton.UseSelectable = true;
            this.selectReconditionedButton.Click += new System.EventHandler(this.selectReconditionedButton_Click);
            // 
            // selectWorkerMyListButton
            // 
            this.selectWorkerMyListButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.selectWorkerMyListButton.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.selectWorkerMyListButton.Location = new System.Drawing.Point(92, 100);
            this.selectWorkerMyListButton.Name = "selectWorkerMyListButton";
            this.selectWorkerMyListButton.Size = new System.Drawing.Size(211, 114);
            this.selectWorkerMyListButton.TabIndex = 5;
            this.selectWorkerMyListButton.Text = "최근 생성 목록";
            this.selectWorkerMyListButton.UseSelectable = true;
            this.selectWorkerMyListButton.Click += new System.EventHandler(this.selectMyListButton_Click);
            // 
            // htmlLabel1
            // 
            this.htmlLabel1.AutoScroll = true;
            this.htmlLabel1.AutoScrollMinSize = new System.Drawing.Size(80, 25);
            this.htmlLabel1.AutoSize = false;
            this.htmlLabel1.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel1.Location = new System.Drawing.Point(25, 18);
            this.htmlLabel1.Name = "htmlLabel1";
            this.htmlLabel1.Size = new System.Drawing.Size(175, 38);
            this.htmlLabel1.TabIndex = 6;
            this.htmlLabel1.Text = "htmlLabel1";
            // 
            // WorkerFirstSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 294);
            this.Controls.Add(this.htmlLabel1);
            this.Controls.Add(this.selectWorkerMyListButton);
            this.Controls.Add(this.selectReconditionedButton);
            this.Font = new System.Drawing.Font("굴림", 10F);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "WorkerFirstSelect";
            this.Padding = new System.Windows.Forms.Padding(22, 68, 22, 22);
            this.Load += new System.EventHandler(this.SelectRD_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton selectReconditionedButton;
        private MetroFramework.Controls.MetroButton selectWorkerMyListButton;
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel1;
        private MySql.Data.MySqlClient.MySqlConnection mySqlConnection1;
    }
}