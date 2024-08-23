using Newtonsoft.Json;
using System;
using System.IO;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class ProductInfo : Form
    {
        private string department;
        private string workerName;
        private string managerName;
        private int workerId;
        private int managerId;
        private string selectedFilePath1 = string.Empty;
        private string selectedFilePath2 = string.Empty;

        private static readonly HttpClient httpClient = new HttpClient { BaseAddress = new Uri("http://localhost:8080/") };

        public ProductInfo(string productNum, string productName)
        {
            InitializeComponent();
            productNumLabel.Text = productNum;
            productNameLabel.Text = productName;

            openFileDialog1.Filter = "PDF Files|*.pdf";
            openFileDialog1.Title = "Select a PDF File";

            progressBar.Visible = false; // ProgressBar 초기 상태 설정
        }

        private void fileUpLoadButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                selectedFilePath1 = openFileDialog1.FileName;
                fileInfo.Text = Path.GetFileName(selectedFilePath1);
            }
        }

        private void fileUpLoadButton2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                selectedFilePath2 = openFileDialog1.FileName;
                fileInfo2.Text = Path.GetFileName(selectedFilePath2);
            }
        }

        private async Task<string> UploadFileAsync(string endpoint, string filePath, string fileParamName)
        {
            using (var content = new MultipartFormDataContent())
            using (var fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                var fileName = Path.GetFileName(filePath);
                var fileContent = new StreamContent(fileStream);
                fileContent.Headers.ContentType = MediaTypeHeaderValue.Parse("application/pdf");
                content.Add(fileContent, fileParamName, fileName);

                HttpResponseMessage response = await httpClient.PostAsync(endpoint, content);
                if (response.IsSuccessStatusCode)
                {
                    string result = await response.Content.ReadAsStringAsync();
                    return result; // 서버에서 반환된 파일 URL
                }
                else
                {
                    throw new Exception($"파일 업로드 실패: {response.ReasonPhrase}");
                }
            }
        }


        private async Task SaveProductDetailAsync(string endpoint, string productNum, string serialNum, DateTime date, string fileUrl1, string fileUrl2, int workerId, int managerId)
        {
            var detailData = new
            {
                rd = true, // 또는 false로 설정
                date = date.ToString("yyyy-MM-dd"),
                serialNum = serialNum,
                fileUrl1 = fileUrl1,
                fileUrl2 = fileUrl2,
                productNum = int.Parse(productNum),
                workerId = workerId,
                managerId = managerId
            };

            var jsonContent = new StringContent(JsonConvert.SerializeObject(detailData), Encoding.UTF8, "application/json");

            HttpResponseMessage response = await httpClient.PostAsync(endpoint, jsonContent);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("데이터가 성공적으로 저장되었습니다.");
            }
            else
            {
                throw new Exception($"데이터 저장 실패: {response.ReasonPhrase}");
            }
        }


        private async void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(serialNumTextBox.Text))
            {
                MessageBox.Show("시리얼 번호를 입력해주세요.");
                return;
            }
            if (workerName == null)
            {
                MessageBox.Show("점검자를 선택해주세요.");
                return;
            }
            if (managerName == null)
            {
                MessageBox.Show("관리자를 선택해주세요.");
                return;
            }
            if (string.IsNullOrEmpty(selectedFilePath1) || string.IsNullOrEmpty(selectedFilePath2))
            {
                MessageBox.Show("두 개의 파일을 모두 첨부해주세요.");
                return;
            }

            try
            {
                this.Enabled = false;
                progressBar.Visible = true;
                progressBar.Style = ProgressBarStyle.Marquee;

                string uploadEndpoint = "api/upload";
                string uploadedFileUrl1 = await UploadFileAsync(uploadEndpoint, selectedFilePath1, "file1");
                string uploadedFileUrl2 = await UploadFileAsync(uploadEndpoint, selectedFilePath2, "file2");

                string detailEndpoint = "api/reconditioned/upload";
                await SaveProductDetailAsync(
                    detailEndpoint,
                    productNumLabel.Text,
                    serialNumTextBox.Text,
                    dateTimePicker.Value,
                    uploadedFileUrl1,
                    uploadedFileUrl2,
                    workerId,
                    managerId
                );

                MessageBox.Show("모든 작업이 성공적으로 완료되었습니다.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"오류 발생: {ex.Message}");
            }
            finally
            {
                this.Enabled = true;
                progressBar.Visible = false;
            }
        }

        private void searchWorkerButton_Click(object sender, EventArgs e)
        {
            using (var selectWorker = new SelectMember())
            {
                if (selectWorker.ShowDialog() == DialogResult.OK)
                {
                    workerId = selectWorker.SelectedMemberId;
                    workerName = selectWorker.SelectedMemberName;
                    department = selectWorker.DepartmentName;

                    workerTextBox.Text = workerName;
                    departmentLabel.Text = department;
                }
            }
        }

        private void searchManagerButton_Click(object sender, EventArgs e)
        {
            using (var selectManager = new SelectMember())
            {
                if (selectManager.ShowDialog() == DialogResult.OK)
                {
                    managerId = selectManager.SelectedMemberId;
                    managerName = selectManager.SelectedMemberName;
                    department = selectManager.DepartmentName;

                    managerTextBox.Text = managerName;
                    departmentLabel.Text = department;
                }
            }
        }
    }
}
