using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace WindowsFormsApp1
{
    public partial class AddProductList : Form
    {
        private static readonly HttpClient client = new HttpClient(); // HTTP 클라이언트 인스턴스

        public AddProductList()
        {
            InitializeComponent();
            // 버튼 클릭 이벤트 핸들러 등록
        }

        private async void AcceptApp_Click(object sender, EventArgs e)
        {
            string productNumText = addProductNumTextBox.Text;
            string productName = addProductNameTextBox.Text;

            if (string.IsNullOrWhiteSpace(productNumText) || string.IsNullOrWhiteSpace(productName))
            {
                MessageBox.Show("자재번호와 자재명을 모두 입력해 주세요.");
                return;
            }

            if (!int.TryParse(productNumText, out int productNum))
            {
                MessageBox.Show("자재번호는 숫자로만 입력해야 합니다.");
                return;
            }

            // 자재번호가 이미 존재하는지 확인
            bool exists = await CheckProductExists(productNum);
            if (exists)
            {
                MessageBox.Show("입력한 자재번호는 이미 존재합니다.");
                return;
            }

            var newProduct = new SimpleReconditioned
            {
                productNum = productNum,
                productName = productName
            };

            try
            {
                var jsonContent = JsonConvert.SerializeObject(newProduct);
                var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync("http://localhost:8080/api/products", content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("품목이 추가되었습니다.");
                    this.Close(); // 폼 닫기
                }
                else
                {
                    MessageBox.Show("서버에 품목을 추가하는 데 실패했습니다.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"오류 발생: {ex.Message}");
            }
            
        }

        private async Task<bool> CheckProductExists(int productNum)
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync($"http://localhost:8080/api/products/exists?productNum={productNum}");

                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    bool exists = JsonConvert.DeserializeObject<bool>(json);
                    return exists;
                }
                else
                {
                    MessageBox.Show("서버에서 자재번호 확인에 실패했습니다.");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"오류 발생: {ex.Message}");
                return false;
            }
        }

        private void CancelAdd_Click(object sender, EventArgs e)
        {
            this.Close(); // 폼 닫기
        }
    }

    // 자재 정보 클래스
    public class SimpleReconditioned
    {
        public int productNum { get; set; }
        public string productName { get; set; }
    }
}
