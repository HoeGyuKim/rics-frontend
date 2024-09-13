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
    public partial class SelectRD : MetroFramework.Forms.MetroForm
    {
        public bool selectReconditioned = false;
        string userName;
        public SelectRD(string name)
        {
            InitializeComponent();
            this.userName = name;
        }

        private void SelectRD_Load(object sender, EventArgs e)
        {
            htmlLabel1.Text = $"{userName}님 환영합니다.";
        }

        private void selectReconditionedButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            R_SelectProductNum r_SelectProductNum = new R_SelectProductNum();
            r_SelectProductNum.Show();
        }
    }
}
