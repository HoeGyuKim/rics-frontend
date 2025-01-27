using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace WindowsFormsApp1
{
    public partial class ReconditionedList : MetroFramework.Forms.MetroForm
    {
        private readonly Member loggedInMember;
        private readonly int selectedProductNum;
        private readonly string selectedReconditionedProductName;
        private static readonly HttpClient client = new HttpClient
        {
            BaseAddress = new Uri("http://localhost:8080/"),
            Timeout = TimeSpan.FromSeconds(30) // 타임아웃 30초
        };

        public ReconditionedList(Member user, int selectedProductNum, string selectedProductName)
        {
            InitializeComponent();
            this.selectedProductNum = selectedProductNum;
            this.selectedReconditionedProductName = selectedProductName;
            this.loggedInMember = user;

            SelectedProductNumTextBox.Text = selectedProductNum.ToString();
            SelectedProductNameTextBox.Text = selectedProductName;

            this.Load += async (sender, e) => await InitializeAsync();
        }

        private async Task InitializeAsync()
        {
            SetInitialDatePickers();
            await LoadDataAsync();
        }

        private void SetInitialDatePickers()
        {
            StartDateTimePicker.Value = DateTime.Now.AddMonths(-1);
            EndDateTimePicker.Value = DateTime.Now;
        }

        private async Task LoadDataAsync()
        {
            try
            {
                string url = BuildUrl();
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();
                if (responseBody.StartsWith("["))
                {
                    var items = JsonConvert.DeserializeObject<List<ReconditionedListItem>>(responseBody);
                    DisplayFilteredItems(items);
                }
                else
                {
                    MessageBox.Show("서버 응답이 배열 형태가 아닙니다.");
                }
            }
            catch (Exception ex)
            {
                HandleException("데이터 로드 중 오류 발생", ex);
            }
        }

        private string BuildUrl()
        {
            string baseUrl = "/api/reconditioned/List"; // 공통된 URL 부분

            // 기본적으로 날짜순 정렬 목록 조회로 설정
            string fullUrl = $"{baseUrl}?productNum={selectedProductNum}";

            if (selectBox?.SelectedItem != null && !string.IsNullOrWhiteSpace(searchTextBox.Text))
            {
                string filterBy = selectBox.SelectedItem.ToString();

                switch (filterBy)
                {
                    case "시리얼번호":
                        fullUrl = $"{baseUrl}BySerialNum?productNum={selectedProductNum}&serialNum={searchTextBox.Text}";
                        break;
                    case "작업자":
                        fullUrl = $"{baseUrl}ByWorker?productNum={selectedProductNum}&workerName={searchTextBox.Text}";
                        break;
                }
            }

            return fullUrl;
        }

        private void DisplayFilteredItems(List<ReconditionedListItem> items)
        {
            // 날짜 필터링
            DateTime startDate = StartDateTimePicker.Value.Date;
            DateTime endDate = EndDateTimePicker.Value.Date;

            var filteredItems = items.Where(item => item.date >= startDate && item.date <= endDate).ToList();

            // DataGridView의 컬럼이 이미 설정되어 있다면 중복 생성 방지
            if (dataGridView1.Columns.Count == 0 || !dataGridView1.Columns.Contains("Select"))
            {
                // 체크박스 컬럼 추가
                DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn
                {
                    Name = "Select",
                    HeaderText = "선택",
                    TrueValue = true,
                    FalseValue = false,
                    ThreeState = false,  // 세 상태 지원 안함 (체크, 체크 안함)
                    CellTemplate = new DataGridViewCheckBoxCell()
                };
                dataGridView1.Columns.Insert(0, checkBoxColumn);  // 첫 번째 열에 추가
            }

            // DataSource를 설정
            dataGridView1.DataSource = filteredItems;

            // 컬럼 이름 변경
            dataGridView1.Columns["select"].HeaderText = "선택"; // 이미 체크박스 컬럼
            dataGridView1.Columns["id"].HeaderText = "등록번호"; // 예시: 'Id' 컬럼을 '아이디'로 변경
            dataGridView1.Columns["workerName"].HeaderText = "작업자"; // 예시: 'Worker' 컬럼을 '작업자'로 변경
            dataGridView1.Columns["middleManagerName"].HeaderText = "관리자";
            dataGridView1.Columns["date"].HeaderText = "완료일자"; // 예시: 'Date' 컬럼을 '날짜'로 변경
            dataGridView1.Columns["approvalStatusText"].HeaderText = "결재상태"; // 예시: 'approvalStatus' 컬럼을 '승인 상태'로 변경
            dataGridView1.Columns["ProductNum"].HeaderText = "자재번호";
            dataGridView1.Columns["ProductName"].HeaderText = "자재명";
            dataGridView1.Columns["SerialNum"].HeaderText = "시리얼번호";
            dataGridView1.Columns["departmentName"].HeaderText = "발생부서";

            
            dataGridView1.Columns["approvalStatus"].Visible = false; // 'Worker' 컬럼 숨기기
            
            dataGridView1.Columns[0].Width = 50; // 첫 번째 열
            dataGridView1.Columns[5].Width = 110;
            dataGridView1.Columns["departmentName"].Width = 200;

            // 체크박스 값 설정 (필요시 수정 가능)
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Cells["Select"].Value = false; // 기본값은 false로 설정
            }

            // 컬럼의 DataPropertyName을 미리 설정한 값과 맞추기
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                // Ensure proper column bindings, avoiding conflicts with the checkbox
                if (column.Name != "Select")
                {
                    column.DataPropertyName = column.Name; // 컬럼의 이름을 데이터 소스 속성과 맞추기
                    column.SortMode = DataGridViewColumnSortMode.Automatic; // 열 정렬 기능 
                }
            }
        }

        private void HandleException(string message, Exception ex)
        {
            MessageBox.Show($"{message}: {ex.Message}");
        }

        private async void SearchButton_Click(object sender, EventArgs e)
        {
            await LoadDataAsync();
        }


        private async void DeleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("삭제할 항목을 선택하세요.");
                return;
            }

            var selectedRow = dataGridView1.SelectedRows[0];
            long id = Convert.ToInt64(selectedRow.Cells["Id"].Value);

            try
            {
                string url = $"api/reconditioned/{id}";
                HttpResponseMessage response = await client.DeleteAsync(url);
                response.EnsureSuccessStatusCode();

                MessageBox.Show($"아이템 ID {id}가 삭제되었습니다.");
                await LoadDataAsync();
            }
            catch (Exception ex)
            {
                HandleException("삭제 요청 중 오류 발생", ex);
            }
        }

        private void ShowDetailButton_Click(object sender, EventArgs e)
        {
            var checkedRows = dataGridView1.Rows.Cast<DataGridViewRow>()
                .Where(row => Convert.ToBoolean(((DataGridViewCheckBoxCell)row.Cells["Select"]).Value))
                .ToList();

            if (checkedRows.Count != 1)
            {
                MessageBox.Show("하나의 항목만 선택하세요.");
                return;
            }

            var item = (ReconditionedListItem)checkedRows[0].DataBoundItem;
            var detailForm = new ReconditionedDetail(item.id, item.approvalStatus);
            detailForm.ShowDialog();
        }

        private void PrevButton_Click(object sender, EventArgs e)
        {
            Close();
            var selectProductNumForm = new SelectProductNum(loggedInMember);
            selectProductNumForm.ShowDialog();
        }

        private void UpLoadDetailButton_Click(object sender, EventArgs e)
        {
            var addProductDetail = new AddProductDetail(selectedProductNum.ToString(), selectedReconditionedProductName);
            addProductDetail.ShowDialog();
        }
    }
}
