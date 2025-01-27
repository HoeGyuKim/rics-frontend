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
    public partial class UserInfo : MetroFramework.Forms.MetroForm
    {
        private Member loggerdInMember;
        public UserInfo(Member loggedInMember)
        {
            InitializeComponent();
            this.Load += UserInfo_load;
            this.loggerdInMember = loggedInMember;
        }

        private void UserInfo_load(object sender, EventArgs e)
        {
            if (loggerdInMember.IsManager == true)
            {
                departmentNameTextBox.Text = loggerdInMember.Department.DepartmentName + "(관리자)";
            }
            else
            {
                departmentNameTextBox.Text = loggerdInMember.Department.DepartmentName;
            }
            nameTextBox.Text = loggerdInMember.Name;
            employeeNumTextBox.Text =  loggerdInMember.EmployeeNum.ToString();
            contactNumberTextBox.Text = loggerdInMember.contactNumber;
            this.ActiveControl = null;
        }
        

    }
}
