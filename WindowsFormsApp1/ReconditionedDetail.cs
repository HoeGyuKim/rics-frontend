using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ReconditionedDetail : MetroFramework.Forms.MetroForm
    {
        private static readonly HttpClient client = new HttpClient();
        private long selectedId;
        private int selectedApprovalStatus;

        public ReconditionedDetail(long id, int approvalStatus)
        {
            this.WindowState = FormWindowState.Maximized;                   // 전체화면으로 설정
            this.Bounds = Screen.PrimaryScreen.Bounds;                      // 화면 크기에 맞춤

            InitializeComponent();
            this.selectedId = id;
            this.selectedApprovalStatus = approvalStatus;
        }

        private async Task LoadDetails()
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync($"http://localhost:8080/api/reconditioned/allDetailsAndApproval?id={selectedId}");
                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    var details = JsonSerializer.Deserialize<List<DetailDTO>>(json);

                    if (details != null && details.Count > 0)
                    {
                        BindDetailsToUI(details[0]);
                    }
                }
                else
                {
                    MessageBox.Show("Failed to load details.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading details: " + ex.Message);
            }
        }

        private void BindDetailsToUI(DetailDTO detail)
        {
            productNumTextBox.Text = detail.productNum.ToString();
            productNameTextBox.Text = detail.productName;
            DateTextBox.Text = detail.date ?? "N/A";  // 만약 Date가 null이면 "N/A" 출력
            serialNumTextBox.Text = detail.serialNum;
            memoTextBox.Text = detail.memo;
            workerNameTextBox.Text = detail.workerName;
            lastManagerNameTextBox.Text = detail.lastManagerName;
            middleManagerNameTextBox.Text = detail.middleManagerName;
            departMentNameTextBox.Text = detail.departmentName;
            approvalStatusTextBox.Text = detail.approvalStatusText.ToString();

            // DateTime? 값을 처리할 때 null을 확인
            firstApprovalDateTextBox.Text = detail.firstApprovalTime?.ToString("yyyy-MM-dd HH:mm:ss") ?? "N/A";
            lastApprovalDateTextBox.Text = detail.lastApprovalTime?.ToString("yyyy-MM-dd HH:mm:ss") ?? "N/A";
            submitDateTextBox.Text = detail.submitTime?.ToString("yyyy-MM-dd HH:mm:ss") ?? "N/A";
        }

        private async void ReconditionedDetail_Load(object sender, EventArgs e)
        {
            await LoadDetails();
            await LoadPdfFiles();
        }

        private void downLoadFile1Button_Click(object sender, EventArgs e)
        {

        }

        private void downLoadFile2Button_Click(object sender, EventArgs e)
        {

        }

        private async void DownQRCodeButton_Click(object sender, EventArgs e)
        {
            try
            {
                // QR 코드 다운로드를 위한 요청
                HttpResponseMessage response = await client.GetAsync($"http://localhost:8080/api/reconditioned/downloadQRCode/{selectedId}");

                if (response.IsSuccessStatusCode)
                {
                    // 서버에서 반환한 QR 코드 파일 다운로드
                    var content = await response.Content.ReadAsByteArrayAsync();
                    SaveFileDialog saveFileDialog = new SaveFileDialog
                    {
                        Filter = "PNG files (*.png)|*.png",
                        FileName = $"QRCode_{selectedId}.png"
                    };

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        System.IO.File.WriteAllBytes(saveFileDialog.FileName, content);
                        MessageBox.Show("QR 코드가 성공적으로 다운로드되었습니다.");
                    }
                }
                else
                {
                    MessageBox.Show("QR 코드 다운로드에 실패했습니다.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("QR 코드 다운로드 중 오류가 발생했습니다: " + ex.Message);
            }
        }

        private async void creatQRCodeButton_Click(object sender, EventArgs e)
        {
            if (selectedApprovalStatus == 3)
            {
                try
                {
                    // QR 코드 생성 요청
                    HttpResponseMessage response = await client.PostAsync($"http://localhost:8080/api/reconditioned/createQRCode/{selectedId}", null);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("QR 코드가 성공적으로 생성되었습니다.");
                    }
                    else if (response.StatusCode == System.Net.HttpStatusCode.Conflict)
                    {
                        MessageBox.Show("QR 코드 생성 실패: 이미 QR 코드가 존재합니다.");
                    }
                    else if (response.StatusCode == System.Net.HttpStatusCode.BadRequest)
                    {
                        MessageBox.Show("QR 코드 생성 실패: 승인되지 않았거나 잘못된 상태입니다.");
                    }
                    else
                    {
                        MessageBox.Show("QR 코드 생성 중 오류가 발생했습니다.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("QR 코드 생성 중 오류가 발생했습니다: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("QR 코드 생성 실패: 승인되지 않았거나 잘못된 상태입니다.");
            }
        }
        private async Task LoadPdfFiles()
        {
            try
            {
                // API 호출로 파일 URL 가져오기
                HttpResponseMessage response = await client.GetAsync($"http://localhost:8080/api/reconditioned/getFileUrls/{selectedId}");
                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    var fileUrls = JsonSerializer.Deserialize<List<string>>(json);

                    if (fileUrls != null && fileUrls.Count > 0)
                    {
                        // 첫 번째 PDF 파일 로드
                        if (!string.IsNullOrEmpty(fileUrls[0]))
                        {
                            PDFViewer1.LoadFile(fileUrls[0]);
                        }
                        else
                        {
                            MessageBox.Show("첫 번째 PDF 파일 URL이 비어있습니다.");
                        }

                        // 두 번째 PDF 파일 로드
                        if (fileUrls.Count > 1 && !string.IsNullOrEmpty(fileUrls[1]))
                        {
                            PDFViewer2.LoadFile(fileUrls[1]);
                        }
                        else
                        {
                            MessageBox.Show("두 번째 PDF 파일 URL이 비어있습니다.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("PDF 파일 URL을 찾을 수 없습니다.");
                    }
                }
                else
                {
                    MessageBox.Show("파일 URL을 가져오지 못했습니다.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PDF 파일 로드 중 오류가 발생했습니다: " + ex.Message);
            }
        }
    }



}
