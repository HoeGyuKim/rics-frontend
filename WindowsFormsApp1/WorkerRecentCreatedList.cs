using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using Newtonsoft.Json.Converters;
using WindowsFormsApp;
using System.Drawing;

namespace WindowsFormsApp1
{
    public partial class WorkerRecentCreatedList : BaseForm
    {
        private const string ApiUrl = "http://localhost:8080/api/reconditioned/WorkerList";
        private Member loggedInMember;

        public WorkerRecentCreatedList(Member loggedInMember)
        {
            InitializeComponent();
            this.loggedInMember = loggedInMember;
            InitializeDataGridView();
            this.Load += RecentCreatedList_Load;
            this.Size = new Size(850, 500);  // 원하는 크기로 설정
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private async void RecentCreatedList_Load(object sender, EventArgs e)
        {
            long workerNum = loggedInMember.EmployeeNum; // 작업자 번호

            // API 호출 및 데이터 가져오기
            var items = await GetDetailsByWorkerAsync(workerNum);

            if (items != null && items.Count > 0)
            {
                BindDataToGrid(items); // 데이터를 그리드에 바인딩
            }
            else
            {
                MessageBox.Show("데이터를 찾을 수 없습니다.", "결과 없음", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private async Task<List<ReconditionedListItem>> GetDetailsByWorkerAsync(long workerNum)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var url = $"{ApiUrl}?employeeNum={workerNum}";
                    var response = await client.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        var responseContent = await response.Content.ReadAsStringAsync();

                        // JSON 역직렬화
                        var settings = new JsonSerializerSettings();
                        settings.Converters.Add(new IsoDateTimeConverter { DateTimeFormat = "yyyy-MM-dd" });
                        var items = JsonConvert.DeserializeObject<List<ReconditionedListItem>>(responseContent, settings);

                        // 디버깅 출력
                        foreach (var item in items)
                        {
                            Console.WriteLine($"ID: {item.id}, ProductName: {item.productName}, ApprovalStatus: {item.approvalStatusText}");
                        }

                        return items;
                    }
                    else
                    {
                        MessageBox.Show("API 호출에 실패했습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"오류 발생: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void InitializeDataGridView()
        {
            myDataGridView.AutoGenerateColumns = false;
            myDataGridView.ReadOnly = false;

            // 선택 열에 체크박스 설정
            if (myDataGridView.Columns.Contains("Select"))
            {
                DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn
                {
                    Name = "Select",
                    HeaderText = "선택",
                    Width = 50,
                    ReadOnly = false, // 체크박스는 편집 가능
                    FalseValue = false,
                    TrueValue = true
                };

                // 선택 열을 체크박스 열로 대체
                int columnIndex = myDataGridView.Columns["Select"].Index;
                myDataGridView.Columns.RemoveAt(columnIndex);
                myDataGridView.Columns.Insert(columnIndex, checkBoxColumn);
            }

            // EditMode 설정
            myDataGridView.EditMode = DataGridViewEditMode.EditOnEnter;

            // AutoGenerateColumns 사용 설정
            myDataGridView.AutoGenerateColumns = false;

        }

        private void BindDataToGrid(List<ReconditionedListItem> items)
        {
            // 데이터 바인딩
            var bindingSource = new BindingSource { DataSource = items };
            myDataGridView.DataSource = bindingSource;

            // 체크박스 열 상태 초기화
            foreach (DataGridViewRow row in myDataGridView.Rows)
            {
                row.Cells["Select"].ReadOnly = false; // 체크박스 열은 편집 가능
            }
        }

        private void prevButton_Click(object sender, EventArgs e)
        {
            this.Close();


            if (loggedInMember.IsManager == false)
            {
                WorkerFirstSelect workerFirstSelect = new WorkerFirstSelect(loggedInMember);
                workerFirstSelect.ShowDialog();
            }
            else
            {
                ManagerFirstSelect managerFirstSelect = new ManagerFirstSelect(loggedInMember);
                managerFirstSelect.ShowDialog();
            }
        }

        private async void downloadQRAll_Click(object sender, EventArgs e)
        {
            // 선택된 항목의 ID 목록 가져오기
            var selectedIds = new List<long>();

            foreach (DataGridViewRow row in myDataGridView.Rows)
            {
                var isSelected = row.Cells["Select"].Value as bool? ?? false; // 체크 여부 확인
                if (isSelected)
                {
                    var item = row.DataBoundItem as ReconditionedListItem;
                    if (item != null)
                    {
                        selectedIds.Add(item.id); // 선택된 항목의 ID 추가
                    }
                }
            }

            // 선택된 항목이 없을 경우 처리
            if (selectedIds.Count == 0)
            {
                MessageBox.Show("QR 코드를 다운로드할 항목을 선택하세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    // 요청 URL 구성
                    var url = "http://localhost:8080/api/reconditioned/downloadMultipleQRCodes";
                    var queryParams = string.Join(",", selectedIds);
                    var fullUrl = $"{url}?ids={queryParams}";

                    // 서버로 GET 요청 보내기
                    var response = await client.GetAsync(fullUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        // 응답 데이터 가져오기
                        var zipData = await response.Content.ReadAsByteArrayAsync();

                        // ZIP 파일 저장
                        SaveFileDialog saveFileDialog = new SaveFileDialog
                        {
                            FileName = "QRCodes.zip",
                            Filter = "ZIP Files (*.zip)|*.zip"
                        };

                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            File.WriteAllBytes(saveFileDialog.FileName, zipData);
                            MessageBox.Show("QR 코드 ZIP 파일이 성공적으로 다운로드되었습니다.", "성공", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        var errorMessage = await response.Content.ReadAsStringAsync();
                        MessageBox.Show($"QR 코드 다운로드 중 오류가 발생했습니다.\n{errorMessage}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"QR 코드 다운로드 중 예외가 발생했습니다.\n{ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private async void createQRAll_Click(object sender, EventArgs e)
        {
            // 선택된 항목의 ID 목록 가져오기
            var selectedIds = new List<long>();

            foreach (DataGridViewRow row in myDataGridView.Rows)
            {
                var isSelected = row.Cells["Select"].Value as bool? ?? false; // 체크 여부 확인
                if (isSelected)
                {
                    var item = row.DataBoundItem as ReconditionedListItem;
                    if (item != null)
                    {
                        selectedIds.Add(item.id); // 선택된 항목의 ID 추가
                    }
                }
            }

            // 선택된 항목이 없을 경우 처리
            if (selectedIds.Count == 0)
            {
                MessageBox.Show("QR 코드를 생성할 항목을 선택하세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 선택된 ID를 서버로 전송하여 QR 코드 생성 요청
            try
            {
                using (var client = new HttpClient())
                {
                    var url = "http://localhost:8080/api/reconditioned/createMultipleQRCodes";
                    var json = JsonConvert.SerializeObject(selectedIds);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");

                    var response = await client.PostAsync(url, content);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("선택한 항목의 QR 코드가 성공적으로 생성되었습니다.", "성공", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        var errorMessage = await response.Content.ReadAsStringAsync();
                        MessageBox.Show($"QR 코드 생성 중 오류가 발생했습니다.\n{errorMessage}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"QR 코드 생성 중 예외가 발생했습니다.\n{ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}