using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp;

namespace WindowsFormsApp1
{
    public partial class ManagerFirstSelect : BaseForm
    {
        public bool selectReconditioned = false;
        Member loggedInMember;
        string userName;
        
        public ManagerFirstSelect(Member member)
        {
            InitializeComponent();
            this.loggedInMember = member;
            this.userName = member.Name;
        }
        
        private void SelectRD_Load(object sender, EventArgs e)
        {
            htmlLabel1.Text = $"{userName}님 환영합니다.";
            selectManagerApprovalButton.Text = "전자 결재\r\n(관리자)";
        }

        private void UserImfoButton_Click(object sender, EventArgs e)
        {

        }

        private void selectReconditionedButton_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            SelectProductNum selectProductNum = new SelectProductNum(loggedInMember);
            selectProductNum.Show();
        }
        private void selectManagerApprovalButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerApproval approvalManager = new ManagerApproval(loggedInMember);
            approvalManager.Show();
        }
        private void selectMyListButton_Click(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            UserInfo userInfo = new UserInfo(loggedInMember);
            userInfo.Show();
        }
    }
}
