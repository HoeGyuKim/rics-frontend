using System;
using System.Diagnostics.Metrics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using WindowsFormsApp1;

namespace WindowsFormsApp
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        private Member loggedInMember;
        // HttpClient는 HTTP 요청을 보내기 위해 사용됩니다. 기본 주소를 설정합니다.
        private static readonly HttpClient client = new HttpClient
        {
            BaseAddress = new Uri("http://localhost:8080/") // 기본 주소를 설정합니다. 이 주소는 Spring Boot 애플리케이션의 URL입니다.
        };

        // 폼의 생성자입니다. 폼이 로드될 때 호출됩니다.
        public Login()
        {
            InitializeComponent(); // Windows Forms 디자이너에서 생성된 초기화 메서드를 호출합니다.
            passwordtxt.KeyUp += new KeyEventHandler(LoginTextBox_KeyUp);
        }
        // 로그인 버튼 클릭 이벤트 핸들러입니다.
        private async void BtnLogin_Click(object sender, EventArgs e)
        {
            string userName = nametxt.Text;
            string password = passwordtxt.Text;
            loggedInMember = await LoginAsync(userName, password);

            if (loggedInMember != null)
            {
                MessageBox.Show($"로그인 성공" + Environment.NewLine + $"이름: {loggedInMember.Name}, 부서: {loggedInMember.Department?.DepartmentName}");

                // 로그인 성공 후 다음 폼에 Member 객체 전달
                open_NextForm(loggedInMember);
            }
            else
            {
                MessageBox.Show("로그인 실패. 아이디 또는 비밀번호를 확인해주세요.");
            }
        }


        // 비동기 로그인 메서드입니다. 서버에 로그인 요청을 보냅니다.
        private async Task<Member> LoginAsync(string name, string employeeNum)
        {
            var user = new { name = name, employeeNum = employeeNum };
            var json = JsonConvert.SerializeObject(user);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            try
            {
                var response = await client.PostAsync("api/users/login", content);

                if (response.IsSuccessStatusCode)
                {
                    // 성공 시 Member 객체로 역직렬화
                    var responseBody = await response.Content.ReadAsStringAsync();
                    var member = JsonConvert.DeserializeObject<Member>(responseBody);
                    return member;
                }
                else
                {
                    // 실패 시 예외 처리
                    throw new Exception($"로그인 실패: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"오류 발생: {ex.Message}");
                return null;
            }
        }



        // 다음 폼을 열고 현재 폼을 숨깁니다.
        private void open_NextForm(Member loggedInMember)
        {   if( loggedInMember.IsManager == false) //작업자의 경우 작업자 선택 form 
            {
                WorkerFirstSelect workerFirstSelect = new WorkerFirstSelect(loggedInMember);
                workerFirstSelect.Show();
            }
            else
            {
                ManagerFirstSelect managweFirstSelect = new ManagerFirstSelect(loggedInMember);
                managweFirstSelect.Show();
            }
            this.Hide();
        }


        private void LoginTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Enter 키의 기본 동작 방지
                BtnLogin_Click(sender, e); // 로그인 버튼 클릭 이벤트 호출
            }
        }
    }
}