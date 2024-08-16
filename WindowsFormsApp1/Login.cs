using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using WindowsFormsApp1;

namespace WindowsFormsApp
{
    public partial class Login : Form
    {
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
            // 텍스트 박스에서 사용자 ID와 비밀번호를 가져옵니다.
            var name = nametxt.Text;
            var password = passwordtxt.Text;

            // 비동기 로그인 메서드를 호출하여 결과를 가져옵니다.
            var loginResult = await LoginAsync(name, password);

            // 로그인 결과를 메시지 박스로 표시합니다.
            MessageBox.Show(loginResult);

            // 로그인 성공 시 다음 폼을 열고 현재 폼을 숨깁니다.
            if (loginResult == "로그인 성공")
            {
                open_NextForm();
            }
        }
        // 비동기 로그인 메서드입니다. 서버에 로그인 요청을 보냅니다.
        private async Task<string> LoginAsync(string name, string password)
        {
            // 로그인 정보를 JSON 객체로 만듭니다. 필드 이름은 서버의 필드 이름과 일치해야 합니다.
            var user = new { name = name, password = password };
            var json = JsonConvert.SerializeObject(user); // JSON 문자열로 직렬화합니다.
            var content = new StringContent(json, Encoding.UTF8, "application/json"); // HTTP 요청의 본문을 생성합니다.

            try
            {
                // POST 요청을 서버의 로그인 엔드포인트로 보냅니다.
                var response = await client.PostAsync("api/users/login", content);

                // 요청이 성공하면 응답 본문을 문자열로 반환합니다.
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsStringAsync();
                }
                else
                {
                    // 요청이 실패하면 상태 코드와 에러 내용을 포함한 메시지를 반환합니다.
                    var errorContent = await response.Content.ReadAsStringAsync();
                    return $"로그인 실패: {response.StatusCode} - {errorContent}";
                }
            }
            catch (HttpRequestException ex)
            {
                // HTTP 요청 중 예외가 발생하면 예외 메시지를 반환합니다.
                return $"HTTP 요청 예외 발생: {ex.Message}";
            }
            catch (Exception ex)
            {
                // 다른 예외가 발생하면 예외 메시지를 반환합니다.
                return $"예외 발생: {ex.Message}";
            }
        }

        // 다음 폼을 열고 현재 폼을 숨깁니다.
        private void open_NextForm()
        {
            Select select = new Select(); // 새로운 폼을 생성합니다.
            select.Show(); // 새로운 폼을 표시합니다.
            this.Hide(); // 현재 폼을 숨깁니다.
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