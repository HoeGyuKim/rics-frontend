using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ManagerFirstSelect : MetroFramework.Forms.MetroForm
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
            if (loggedInMember.IsManager == true)
            {
                selectDefectiveButton.Text = "전자 결재\r\n(관리자)";
            }
            else if (loggedInMember.IsManager == false)
            {
                selectDefectiveButton.Text = "전자 결재\r\n(작업자)";
            }
        }

        private void selectReconditionedButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SelectProductNum selectProductNum = new SelectProductNum(loggedInMember);
            selectProductNum.Show();
        }

        private void selectDefectiveButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerApproval approvalManager = new ManagerApproval(loggedInMember);
            approvalManager.Show();
        }
            private void selectMyListButton_Click(object sender, EventArgs e)
            {
                this.Hide();
                RecentCreatedList createdList = new RecentCreatedList(loggedInMember);
                createdList.Show();
            }
        
    }
}
