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
    public partial class WorkerFirstSelect : MetroFramework.Forms.MetroForm
    {
        public bool selectReconditioned = false;
        Member loggedInMember;
        string userName;
        
        public WorkerFirstSelect(Member member)
        {
            InitializeComponent();
            this.loggedInMember = member;
            this.userName = member.Name;
        }
        
        private void SelectRD_Load(object sender, EventArgs e)
        {
            htmlLabel1.Text = $"{userName}님 환영합니다.";
        }

        private void selectReconditionedButto_Click(object sender, EventArgs e)
        {
            this.Hide();
            SelectProductNum selectProductNum = new SelectProductNum(loggedInMember);
            selectProductNum.Show();
        }

        private void selectMyRecnetListButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            WorkerRecentCreatedList recentCreatedList = new WorkerRecentCreatedList(loggedInMember);
            recentCreatedList.Show();
        }

        private void userInfoButton_Click(object sender, EventArgs e)
        {
            UserInfo userInfo = new UserInfo(loggedInMember);
            userInfo.Show();
        }
    }
}
