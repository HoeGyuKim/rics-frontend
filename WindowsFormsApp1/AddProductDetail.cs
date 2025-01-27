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
    public partial class AddProductDetail : MetroFramework.Forms.MetroForm
    {
        private string department;
        private string workerName;
        private string middleManagerName;
        private string lastManagerName;
        private int workerId;
        private int middleManagerId;
        private int lastManagerId;
        private string selectedFilePath1 = string.Empty;
        private string selectedFilePath2 = string.Empty;

        private static readonly HttpClient httpClient = new HttpClient { BaseAddress = new Uri("http://localhost:8080/") };

        public AddProductDetail(string productNum, string productName)
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

        private async Task SaveProductDetailAsync(string endpoint, string productNum, string serialNum, DateTime date, string filePath1, string filePath2, long workerId, long middleManagerId, long lastManagerId, string memo)
        {
            using (var content = new MultipartFormDataContent())
            {
                var detailData = new
                {
                    serialNum = serialNum,
                    memo = memo,
                    date = date.ToString("yyyy-MM-dd"),
                    productNum = long.Parse(productNum),
                    workerNum = workerId,
                    middleManagerNum = middleManagerId,
                    lastManagerNum = lastManagerId,
                    approvalStatus = 1 
                };

                // JSON 데이터를 추가
                var json = JsonConvert.SerializeObject(detailData);
                var jsonContent = new StringContent(json, Encoding.UTF8, "application/json");
                content.Add(jsonContent, "detailData");

                // 파일을 추가
                if (!string.IsNullOrEmpty(filePath1))
                {
                    var fileStream1 = new FileStream(filePath1, FileMode.Open, FileAccess.Read);
                    var fileContent1 = new StreamContent(fileStream1);
                    fileContent1.Headers.ContentType = MediaTypeHeaderValue.Parse("application/pdf");
                    content.Add(fileContent1, "file1", Path.GetFileName(filePath1));
                }

                if (!string.IsNullOrEmpty(filePath2))
                {
                    var fileStream2 = new FileStream(filePath2, FileMode.Open, FileAccess.Read);
                    var fileContent2 = new StreamContent(fileStream2);
                    fileContent2.Headers.ContentType = MediaTypeHeaderValue.Parse("application/pdf");
                    content.Add(fileContent2, "file2", Path.GetFileName(filePath2));
                }

                HttpResponseMessage response = await httpClient.PostAsync(endpoint, content);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("데이터가 성공적으로 저장되었습니다.");
                }
                else
                {
                    throw new Exception($"데이터 저장 실패: {response.ReasonPhrase}");
                }
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
            if (middleManagerName == null)
            {
                MessageBox.Show("관리자를 선택해주세요.");
                return;
            }

            try
            {
                this.Enabled = false;
                progressBar.Visible = true;
                progressBar.Style = ProgressBarStyle.Marquee;

                string detailEndpoint = "api/reconditioned/upload";
                await SaveProductDetailAsync(
                    detailEndpoint,
                    productNumLabel.Text,
                    serialNumTextBox.Text,
                    dateTimePicker.Value,
                    selectedFilePath1,
                    selectedFilePath2,
                    workerId,
                    middleManagerId,
                    lastManagerId,
                    memoTextBox.Text
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
        private void searchMiddleManagerButton_Click(object sender, EventArgs e)
        {
            using (var selectWorker = new SelectMember())
            {
                if (selectWorker.ShowDialog() == DialogResult.OK)
                {
                    middleManagerId = selectWorker.SelectedMemberId;
                    middleManagerName = selectWorker.SelectedMemberName;
                    department = selectWorker.DepartmentName;

                    middleManagerTextBox.Text = middleManagerName;
                    departmentLabel.Text = department;
                }
            }
        }

        private void searchLastManagerButton_Click(object sender, EventArgs e)
        {
            using (var selecrLastManager = new SelectMember())
            {
                if (selecrLastManager.ShowDialog() == DialogResult.OK)
                {
                    lastManagerId = selecrLastManager.SelectedMemberId;
                    lastManagerName = selecrLastManager.SelectedMemberName;
                    department = selecrLastManager.DepartmentName;

                    lastManagerTextBox.Text = lastManagerName;
                    departmentLabel.Text = department;
                }
            }
        }

        private void cancleButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
