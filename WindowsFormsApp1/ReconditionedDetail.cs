using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WindowsFormsApp1
{
    public partial class ReconditionedDetail : BaseForm
    {
        private static readonly HttpClient client = new HttpClient();
        private long selectedId;
        private int selectedApprovalStatus;
        private Member loggedInMember;

        private static readonly HttpClient httpClient = new HttpClient { BaseAddress = new Uri("http://localhost:8080/") };
        public ReconditionedDetail(long id, Member loggedInMember)
        {
            this.WindowState = FormWindowState.Maximized; // 전체화면 설정
            this.Bounds = Screen.PrimaryScreen.Bounds;    // 화면 크기에 맞춤

            InitializeComponent();
            this.selectedId = id;
            this.loggedInMember = loggedInMember;
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
            this.selectedApprovalStatus = detail.approvalStatus;
            productNumTextBox.Text = detail.productNum.ToString();
            productNameTextBox.Text = detail.productName;
            DateTextBox.Text = detail.date ?? "N/A"; // Date가 null이면 "N/A" 출력
            serialNumTextBox.Text = detail.serialNum;
            memoTextBox.Text = detail.memo;
            workerNameTextBox.Text = detail.workerName;
            lastManagerNameTextBox.Text = detail.lastManagerName;
            middleManagerNameTextBox.Text = detail.middleManagerName;
            departMentNameTextBox.Text = detail.departmentName;
            approvalStatusTextBox.Text = detail.approvalStatusText.ToString();
            contactNumberTextBox.Text = detail.contactNumber.ToString();
            firstApprovalDateTextBox.Text = detail.firstApprovalTime?.ToString("yyyy-MM-dd HH:mm:ss") ?? "N/A";
            lastApprovalDateTextBox.Text = detail.lastApprovalTime?.ToString("yyyy-MM-dd HH:mm:ss") ?? "N/A";
            submitDateTextBox.Text = detail.submitTime?.ToString("yyyy-MM-dd HH:mm:ss") ?? "N/A";
        }
        private async void ReconditionedDetail_Load(object sender, EventArgs e)
        {
            await LoadDetails();
            await LoadPdfFiles();
            await LoadQRCodeToPictureBox();
        }

        private async Task LoadPdfFiles()
        {
            try
            {
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
                            string localPath = DownloadFile(fileUrls[0]);
                            PDFViewer1.LoadFile(localPath);
                        }
                        else
                        {
                            MessageBox.Show("첫 번째 PDF 파일이 비어있습니다.");
                        }

                        // 두 번째 PDF 파일 로드
                        if (fileUrls.Count > 1 && !string.IsNullOrEmpty(fileUrls[1]))
                        {
                            string localPath = DownloadFile(fileUrls[1]);
                            PDFViewer2.LoadFile(localPath);
                        }
                        else
                        {
                            MessageBox.Show("두 번째 PDF 파일이 비어있습니다.");
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

        private string DownloadFile(string url)
        {
            try
            {
                HttpResponseMessage response = client.GetAsync(url).Result;
                if (response.IsSuccessStatusCode)
                {
                    byte[] fileBytes = response.Content.ReadAsByteArrayAsync().Result;

                    // 임시 파일 생성
                    string tempFile = Path.Combine(Path.GetTempPath(), Path.GetFileName(url));
                    File.WriteAllBytes(tempFile, fileBytes);

                    return tempFile;
                }
                else
                {
                    throw new Exception($"파일 다운로드 실패: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"파일 다운로드 중 오류 발생: {ex.Message}");
            }
        }
        private async Task DeleteProductDetailAsync(long detailId) 
        {
            try
            {
                using (HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Delete, $"api/approval/delete/{detailId}"))
                {
                    request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json")); // JSON 형식 요청

                    HttpResponseMessage response = await httpClient.SendAsync(request);

                    string responseContent = await response.Content.ReadAsStringAsync(); // 🔥 응답 확인

                    if (!response.IsSuccessStatusCode)
                    {
                        throw new Exception($"기존 데이터 삭제 실패: {response.ReasonPhrase} | 응답 내용: {responseContent}");
                    }

                    MessageBox.Show("기존 데이터 삭제 성공: " + responseContent);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"데이터 삭제 중 오류 발생: {ex.Message}");
                throw;
            }
        }
        private async Task LoadQRCodeToPictureBox()
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync($"http://localhost:8080/api/reconditioned/getQRCodeUrl/{selectedId}");
                if (response.IsSuccessStatusCode)
                {
                    string qrCodeUrl = await response.Content.ReadAsStringAsync();
                    if (!string.IsNullOrEmpty(qrCodeUrl))
                    {
                        QRCodePictureBox.ImageLocation = qrCodeUrl; // QR 코드 이미지 로드

                    }
                    else
                    {
                        MessageBox.Show("QR 코드 URL을 가져오지 못했습니다.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("QR 코드 로드 중 오류가 발생했습니다: " + ex.Message);
            }
        }
        private async void CreatQRCodeButton_Click(object sender, EventArgs e)
        {
            if (selectedApprovalStatus == 3)
            {
                try
                {
                    HttpResponseMessage response = await client.PostAsync($"http://localhost:8080/api/reconditioned/createQRCode/{selectedId}", null);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("QR 코드가 성공적으로 생성되었습니다.");
                    }
                    else if (response.StatusCode == System.Net.HttpStatusCode.Conflict)
                    {
                        MessageBox.Show("QR 코드 생성 실패: 이미 QR 코드가 존재합니다.");
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
                MessageBox.Show("QR 코드 생성 실패: 승인되지 않은 상태입니다.");
            }
            await LoadQRCodeToPictureBox();
        }

        private async void DownQRCodeButton_Click(object sender, EventArgs e)
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync($"http://localhost:8080/api/reconditioned/downloadQRCode/{selectedId}");

                if (response.IsSuccessStatusCode)
                {
                    byte[] content = await response.Content.ReadAsByteArrayAsync();
                    SaveFileDialog saveFileDialog = new SaveFileDialog
                    {
                        Filter = "PNG files (*.png)|*.png",
                        FileName = $"QRCode_{selectedId}.png"
                    };

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllBytes(saveFileDialog.FileName, content);
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

        private async void editButton_Click(object sender, EventArgs e)
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync($"http://localhost:8080/api/approval/{selectedId}/editable");
                string　 jsonResponse = await response.Content.ReadAsStringAsync();
                var responseData = JsonSerializer.Deserialize<Dictionary<string, string>>(jsonResponse);

                if (responseData != null && responseData.ContainsKey("message"))
                {
                    string message = responseData["message"];
                    MessageBox.Show(message, "수정 여부 확인", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (response.IsSuccessStatusCode && message == "수정 가능")
                    {
                        var addProductDetail = new AddProductDetail(productNumTextBox.Text, productNameTextBox.Text, serialNumTextBox.Text, memoTextBox.Text, selectedId);
                        addProductDetail.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("서버 응답이 올바르지 않습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"수정 가능 여부 체크 중 오류 발생: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void deleteButton_Click(object sender, EventArgs e)
        {
            if (loggedInMember.Name == workerNameTextBox.Text || loggedInMember.Name == middleManagerNameTextBox.Text || loggedInMember.Name == lastManagerNameTextBox.Text)
            {
                if (selectedApprovalStatus == 1)
                {
                    if (MessageBox.Show("결재 대기 중이므로 즉시 삭제 가능합니다. \n 삭제하시겠습니까?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        await DeleteProductDetailAsync(selectedId);
                        this.Close();
                    }
                }
                else if (selectedApprovalStatus == 4)
                {
                    if (MessageBox.Show("반려된 건이므로 즉시 삭제 가능합니다.\n삭제하시겠습니까?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        await DeleteProductDetailAsync(selectedId);
                        this.Close();
                    }
                }
                else if (selectedApprovalStatus == 3)
                {
                    if (MessageBox.Show($"승인 된 건입니다.\n삭제신청 하시겠습니까?\n결재 라인 : {workerNameTextBox.Text} -> {middleManagerNameTextBox.Text} -> {lastManagerNameTextBox.Text}", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        await DeleteProductDetailAsync(selectedId);
                        this.Close();
                    }
                }
                else if (selectedApprovalStatus == 2)
                {
                    MessageBox.Show("결재 진행중이므로 삭제할 수 없습니다.");
                }
            }
            else
            {
                MessageBox.Show("권한이 없습니다.");
            }
        }
    }
}
