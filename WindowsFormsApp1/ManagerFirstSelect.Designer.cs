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
            htmlLabel1 = new MetroFramework.Drawing.Html.HtmlLabel();
            selectReconditionedButton = new MetroFramework.Controls.MetroTile();
            selectManagerApprovalButton = new MetroFramework.Controls.MetroTile();
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
            // selectReconditionedButton
            // 
            selectReconditionedButton.ActiveControl = null;
            selectReconditionedButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            selectReconditionedButton.ForeColor = System.Drawing.SystemColors.ControlText;
            selectReconditionedButton.Location = new System.Drawing.Point(377, 143);
            selectReconditionedButton.Name = "selectReconditionedButton";
            selectReconditionedButton.Size = new System.Drawing.Size(250, 150);
            selectReconditionedButton.TabIndex = 9;
            selectReconditionedButton.Text = "재생품 자재 조회";
            selectReconditionedButton.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            selectReconditionedButton.UseSelectable = true;
            selectReconditionedButton.Click += selectReconditionedButton_Click_1;
            // 
            // selectManagerApprovalButton
            // 
            selectManagerApprovalButton.ActiveControl = null;
            selectManagerApprovalButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            selectManagerApprovalButton.Location = new System.Drawing.Point(121, 143);
            selectManagerApprovalButton.Name = "selectManagerApprovalButton";
            selectManagerApprovalButton.Size = new System.Drawing.Size(250, 150);
            selectManagerApprovalButton.TabIndex = 10;
            selectManagerApprovalButton.Text = "metroTile1";
            selectManagerApprovalButton.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            selectManagerApprovalButton.UseSelectable = true;
            selectManagerApprovalButton.Click += selectManagerApprovalButton_Click;
            // 
            // userInfoButton
            // 
            userInfoButton.ActiveControl = null;
            userInfoButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            userInfoButton.Location = new System.Drawing.Point(497, 97);
            userInfoButton.Name = "userInfoButton";
            userInfoButton.Size = new System.Drawing.Size(130, 40);
            userInfoButton.TabIndex = 12;
            userInfoButton.Text = "회원정보";
            userInfoButton.UseSelectable = true;
            userInfoButton.Click += metroTile1_Click;
            // 
            // ManagerFirstSelect
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(750, 400);
            Controls.Add(userInfoButton);
            Controls.Add(selectManagerApprovalButton);
            Controls.Add(selectReconditionedButton);
            Controls.Add(htmlLabel1);
            Font = new System.Drawing.Font("굴림", 10F);
            Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            Name = "ManagerFirstSelect";
            Padding = new System.Windows.Forms.Padding(22, 68, 22, 22);
            Load += SelectRD_Load;
            ResumeLayout(false);
        }

        #endregion
        private MetroFramework.Drawing.Html.HtmlLabel htmlLabel1;
        private MetroFramework.Controls.MetroTile selectReconditionedButton;
        private MetroFramework.Controls.MetroTile selectManagerApprovalButton;
        private MetroFramework.Controls.MetroTile userInfoButton;
    }
}