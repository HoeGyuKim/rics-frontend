using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace WindowsFormsApp
{
    public class BaseForm : MetroForm
    {
        private static Icon appIcon;

        static BaseForm()
        {
            try
            {
                // ✅ 바로 아이콘 객체를 가져와서 사용
                appIcon = WindowsFormsApp1.Properties.Resources.icon;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"리소스에서 아이콘을 로드할 수 없습니다: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                appIcon = SystemIcons.Application; // 기본 아이콘 설정
            }
        }

        public BaseForm()
        {
            this.Icon = appIcon; // 모든 MetroForm에 자동 적용
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login()); // 모든 폼이 자동으로 아이콘 적용됨
        }
    }
}
