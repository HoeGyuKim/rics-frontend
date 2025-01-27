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
            this.htmlLabel1 = new MetroFramework.Drawing.Html.HtmlLabel();
            this.mySqlConnection1 = new MySql.Data.MySqlClient.MySqlConnection();
            this.selectMyRecnetListButton = new MetroFramework.Controls.MetroTile();
            this.selectReconditionedButto = new MetroFramework.Controls.MetroTile();
            this.userInfoButton = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
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
            // selectMyRecnetListButton
            // 
            this.selectMyRecnetListButton.ActiveControl = null;
            this.selectMyRecnetListButton.Location = new System.Drawing.Point(88, 108);
            this.selectMyRecnetListButton.Name = "selectMyRecnetListButton";
            this.selectMyRecnetListButton.Size = new System.Drawing.Size(222, 114);
            this.selectMyRecnetListButton.TabIndex = 10;
            this.selectMyRecnetListButton.Text = "최근 생성 목록";
            this.selectMyRecnetListButton.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.selectMyRecnetListButton.UseSelectable = true;
            this.selectMyRecnetListButton.Click += new System.EventHandler(this.selectMyRecnetListButton_Click);
            // 
            // selectReconditionedButto
            // 
            this.selectReconditionedButto.ActiveControl = null;
            this.selectReconditionedButto.Location = new System.Drawing.Point(316, 108);
            this.selectReconditionedButto.Name = "selectReconditionedButto";
            this.selectReconditionedButto.Size = new System.Drawing.Size(214, 114);
            this.selectReconditionedButto.TabIndex = 11;
            this.selectReconditionedButto.Text = "재생품 자재 조회";
            this.selectReconditionedButto.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.selectReconditionedButto.UseSelectable = true;
            this.selectReconditionedButto.Click += new System.EventHandler(this.selectReconditionedButto_Click);
            // 
            // userInfoButton
            // 
            this.userInfoButton.ActiveControl = null;
            this.userInfoButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userInfoButton.Location = new System.Drawing.Point(440, 60);
            this.userInfoButton.Name = "userInfoButton";
            this.userInfoButton.Size = new System.Drawing.Size(90, 42);
            this.userInfoButton.TabIndex = 14;
            this.userInfoButton.Text = "회원정보";
            this.userInfoButton.UseSelectable = true;
            this.userInfoButton.Click += new System.EventHandler(this.userInfoButton_Click);
            // 
            // WorkerFirstSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 277);
            this.Controls.Add(this.userInfoButton);
            this.Controls.Add(this.selectReconditionedButto);
            this.Controls.Add(this.selectMyRecnetListButton);
            this.Controls.Add(this.htmlLabel1);
            this.Font = new System.Drawing.Font("굴림", 10F);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "WorkerFirstSelect";
            this.Padding = new System.Windows.Forms.Padding(22, 68, 22, 22);
            this.Load += new System.EventHandler(this.SelectRD_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel1;
        private MySql.Data.MySqlClient.MySqlConnection mySqlConnection1;
        private MetroFramework.Controls.MetroTile selectMyRecnetListButton;
        private MetroFramework.Controls.MetroTile selectReconditionedButto;
        private MetroFramework.Controls.MetroTile userInfoButton;
    }
}