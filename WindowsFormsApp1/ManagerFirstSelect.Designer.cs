using Org.BouncyCastle.Bcpg;

namespace WindowsFormsApp1
{
    partial class ManagerFirstSelect
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
            this.selectReconditionedButton = new MetroFramework.Controls.MetroTile();
            this.selectManagerApprovalButton = new MetroFramework.Controls.MetroTile();
            this.selectMyListButton = new MetroFramework.Controls.MetroTile();
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
            // selectReconditionedButton
            // 
            this.selectReconditionedButton.ActiveControl = null;
            this.selectReconditionedButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.selectReconditionedButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.selectReconditionedButton.Location = new System.Drawing.Point(309, 106);
            this.selectReconditionedButton.Name = "selectReconditionedButton";
            this.selectReconditionedButton.Size = new System.Drawing.Size(220, 125);
            this.selectReconditionedButton.TabIndex = 9;
            this.selectReconditionedButton.Text = "재생품 자재 조회";
            this.selectReconditionedButton.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.selectReconditionedButton.UseSelectable = true;
            this.selectReconditionedButton.Click += new System.EventHandler(this.selectReconditionedButton_Click_1);
            // 
            // selectManagerApprovalButton
            // 
            this.selectManagerApprovalButton.ActiveControl = null;
            this.selectManagerApprovalButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.selectManagerApprovalButton.Location = new System.Drawing.Point(90, 106);
            this.selectManagerApprovalButton.Name = "selectManagerApprovalButton";
            this.selectManagerApprovalButton.Size = new System.Drawing.Size(213, 59);
            this.selectManagerApprovalButton.TabIndex = 10;
            this.selectManagerApprovalButton.Text = "metroTile1";
            this.selectManagerApprovalButton.UseSelectable = true;
            this.selectManagerApprovalButton.Click += new System.EventHandler(this.selectManagerApprovalButton_Click);
            // 
            // selectMyListButton
            // 
            this.selectMyListButton.ActiveControl = null;
            this.selectMyListButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.selectMyListButton.Location = new System.Drawing.Point(90, 171);
            this.selectMyListButton.Name = "selectMyListButton";
            this.selectMyListButton.Size = new System.Drawing.Size(213, 60);
            this.selectMyListButton.TabIndex = 11;
            this.selectMyListButton.Text = "월/년 누계";
            this.selectMyListButton.UseSelectable = true;
            this.selectMyListButton.Click += new System.EventHandler(this.selectMyListButton_Click);
            // 
            // userInfoButton
            // 
            this.userInfoButton.ActiveControl = null;
            this.userInfoButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userInfoButton.Location = new System.Drawing.Point(442, 58);
            this.userInfoButton.Name = "userInfoButton";
            this.userInfoButton.Size = new System.Drawing.Size(87, 42);
            this.userInfoButton.TabIndex = 12;
            this.userInfoButton.Text = "회원정보";
            this.userInfoButton.UseSelectable = true;
            this.userInfoButton.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // ManagerFirstSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 287);
            this.Controls.Add(this.userInfoButton);
            this.Controls.Add(this.selectMyListButton);
            this.Controls.Add(this.selectManagerApprovalButton);
            this.Controls.Add(this.selectReconditionedButton);
            this.Controls.Add(this.htmlLabel1);
            this.Font = new System.Drawing.Font("굴림", 10F);
            this.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.Name = "ManagerFirstSelect";
            this.Padding = new System.Windows.Forms.Padding(22, 68, 22, 22);
            this.Load += new System.EventHandler(this.SelectRD_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel1;
        private MySql.Data.MySqlClient.MySqlConnection mySqlConnection1;
        private MetroFramework.Controls.MetroTile selectReconditionedButton;
        private MetroFramework.Controls.MetroTile selectManagerApprovalButton;
        private MetroFramework.Controls.MetroTile selectMyListButton;
        private MetroFramework.Controls.MetroTile userInfoButton;
    }
}