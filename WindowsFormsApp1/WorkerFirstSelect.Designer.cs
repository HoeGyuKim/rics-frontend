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
            htmlLabel1 = new MetroFramework.Drawing.Html.HtmlLabel();
            mySqlConnection1 = new MySql.Data.MySqlClient.MySqlConnection();
            selectMyRecnetListButton = new MetroFramework.Controls.MetroTile();
            selectReconditionedButto = new MetroFramework.Controls.MetroTile();
            userInfoButton = new MetroFramework.Controls.MetroTile();
            SuspendLayout();
            // 
            // htmlLabel1
            // 
            htmlLabel1.AutoScroll = true;
            htmlLabel1.AutoScrollMinSize = new System.Drawing.Size(86, 30);
            htmlLabel1.AutoSize = false;
            htmlLabel1.BackColor = System.Drawing.SystemColors.Window;
            htmlLabel1.Location = new System.Drawing.Point(25, 18);
            htmlLabel1.Name = "htmlLabel1";
            htmlLabel1.Size = new System.Drawing.Size(175, 38);
            htmlLabel1.TabIndex = 6;
            htmlLabel1.Text = "htmlLabel1";
            // 
            // selectMyRecnetListButton
            // 
            selectMyRecnetListButton.ActiveControl = null;
            selectMyRecnetListButton.Location = new System.Drawing.Point(121, 144);
            selectMyRecnetListButton.Name = "selectMyRecnetListButton";
            selectMyRecnetListButton.Size = new System.Drawing.Size(250, 150);
            selectMyRecnetListButton.TabIndex = 10;
            selectMyRecnetListButton.Text = "최근 생성 목록";
            selectMyRecnetListButton.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            selectMyRecnetListButton.UseSelectable = true;
            selectMyRecnetListButton.Click += selectMyRecnetListButton_Click;
            // 
            // selectReconditionedButto
            // 
            selectReconditionedButto.ActiveControl = null;
            selectReconditionedButto.Location = new System.Drawing.Point(377, 144);
            selectReconditionedButto.Name = "selectReconditionedButto";
            selectReconditionedButto.Size = new System.Drawing.Size(250, 150);
            selectReconditionedButto.TabIndex = 11;
            selectReconditionedButto.Text = "재생품 자재 조회";
            selectReconditionedButto.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            selectReconditionedButto.UseSelectable = true;
            selectReconditionedButto.Click += selectReconditionedButto_Click;
            // 
            // userInfoButton
            // 
            userInfoButton.ActiveControl = null;
            userInfoButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            userInfoButton.Location = new System.Drawing.Point(497, 98);
            userInfoButton.Name = "userInfoButton";
            userInfoButton.Size = new System.Drawing.Size(130, 40);
            userInfoButton.TabIndex = 14;
            userInfoButton.Text = "회원정보";
            userInfoButton.UseSelectable = true;
            userInfoButton.Click += userInfoButton_Click;
            // 
            // WorkerFirstSelect
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(750, 400);
            Controls.Add(userInfoButton);
            Controls.Add(selectReconditionedButto);
            Controls.Add(selectMyRecnetListButton);
            Controls.Add(htmlLabel1);
            Font = new System.Drawing.Font("굴림", 10F);
            Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            Name = "WorkerFirstSelect";
            Padding = new System.Windows.Forms.Padding(22, 68, 22, 22);
            Load += SelectRD_Load;
            ResumeLayout(false);
        }

        #endregion
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel1;
        private MySql.Data.MySqlClient.MySqlConnection mySqlConnection1;
        private MetroFramework.Controls.MetroTile selectMyRecnetListButton;
        private MetroFramework.Controls.MetroTile selectReconditionedButto;
        private MetroFramework.Controls.MetroTile userInfoButton;
    }
}