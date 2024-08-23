using Newtonsoft.Json;
using System;
using System.IO;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ProductInfo : Form
    {
        private string workerName;
        private string managerName;
        private string selectedFilePath1 = string.Empty;
        private string selectedFilePath2 = string.Empty;

        public ProductInfo(string productNum, string productName)
        {
            InitializeComponent();
            productNumLabel.Text = productNum;
            productNameLabel.Text = productName;

            openFileDialog1.Filter = "PDF Files|*.pdf"; // PDF 파일만 선택 가능하도록 설정
            openFileDialog1.Title = "Select a PDF File"; // 다이얼로그 제목 설정
        }

        // 파일 첨부1 버튼 클릭 이벤트 핸들러
        private void fileUpLoadButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                selectedFilePath1 = openFileDialog1.FileName;
                fileInfo.Text = Path.GetFileName(selectedFilePath1);
            }
        }

        // 파일 첨부2 버튼 클릭 이벤트 핸들러
        private void fileUpLoadButton2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                selectedFilePath2 = openFileDialog1.FileName;
                fileInfo2.Text = Path.GetFileName(selectedFilePath2);
            }
        }

        private async Task<string> UploadFileAsync(string url, string filePath)
        {
            using (var client = new HttpClient())
            using (var content = new MultipartFormDataContent())
            using (var fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                var fileName = Path.GetFileName(filePath);
                var fileContent = new StreamContent(fileStream);
                fileContent.Headers.ContentType = MediaTypeHeaderValue.Parse("application/pdf");
                content.Add(fileContent, "file", fileName);

                HttpResponseMessage response = await client.PostAsync(url, content);
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsStringAsync(); // 서버에서 반환된 파일 경로를 받아옵니다.
                }
                else
                {
                    MessageBox.Show("파일 업로드에 실패했습니다: " + response.ReasonPhrase);
                    return null;
                }
            }
        }

        private async Task SaveProductDetailAsync(string apiUrl, string productNum, string serialNum, DateTime date, string fileUrl1, string fileUrl2)
        {
            using (var client = new HttpClient())
            {
                // 필요한 데이터들을 익명 객체로 묶어서 JSON으로 변환합니다.
                var detailData = new
                {
                    ProductNum = productNum,
                    SerialNum = serialNum,
                    Date = date.ToString("yyyy-MM-dd"),  // 날짜 형식을 문자열로 변환
                    FileUrl1 = fileUrl1,
                    FileUrl2 = fileUrl2,
                };

                // JSON 컨텐츠 생성
                var jsonContent = new StringContent(JsonConvert.SerializeObject(detailData), Encoding.UTF8, "application/json");

                // POST 요청
                HttpResponseMessage response = await client.PostAsync(apiUrl, jsonContent);

                // 응답 확인
                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show("저장 실패: " + response.ReasonPhrase);
                }
            }
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            // 서버의 파일 업로드 API 경로
            string uploadUrl = "http://localhost:8080/api/upload";

            // 첫 번째 파일 업로드
            string uploadedFileUrl1 = null;
            if (!string.IsNullOrEmpty(selectedFilePath1))
            {
                uploadedFileUrl1 = await UploadFileAsync(uploadUrl, selectedFilePath1);
            }

            // 두 번째 파일 업로드
            string uploadedFileUrl2 = null;
            if (!string.IsNullOrEmpty(selectedFilePath2))
            {
                uploadedFileUrl2 = await UploadFileAsync(uploadUrl, selectedFilePath2);
            }

            // 서버로 데이터 전송
            string apiUrl = "http://localhost:8080/api/details";
            await SaveProductDetailAsync(apiUrl, productNumLabel.Text, serialNumTextBox.Text, dateTimePicker.Value, uploadedFileUrl1, uploadedFileUrl2);
        }

        private void searchWorkerButton_Click(object sender, EventArgs e)
        {
            using (var selectWorker = new SelectMember())
            {
                if (selectWorker.ShowDialog() == DialogResult.OK)
                {
                    workerName = selectWorker.SelectedMemberName;
                    workerTextBox.Text = workerName; // 텍스트박스에 사원 이름 설정
                }
            }
        }

        private void searchManagerButton_Click(object sender, EventArgs e)
        {
            using (var selectManager = new SelectMember())
            {
                if (selectManager.ShowDialog() == DialogResult.OK)
                {
                    managerName = selectManager.SelectedMemberName;
                    managerTextBox.Text = managerName; // 텍스트박스에 사원 이름 설정
                }
            }
        }
    }
}
