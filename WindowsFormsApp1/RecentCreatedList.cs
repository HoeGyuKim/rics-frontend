using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace WindowsFormsApp1
{
    public partial class RecentCreatedList : MetroFramework.Forms.MetroForm
    {
        private const string ApiUrl = "http://localhost:8080/api/reconditioned/detailsByWorker";
        private Member loggedInMember;

        public RecentCreatedList(Member loggedInMember)
        {
            InitializeComponent();
            this.loggedInMember = loggedInMember;

            InitializeDataGridView();
            this.Load += RecentCreatedList_Load;
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

                        // DateTime 포맷 변환을 위해 JsonConverter를 추가하여 파싱
                        var settings = new JsonSerializerSettings();
                        settings.Converters.Add(new IsoDateTimeConverter { DateTimeFormat = "yyyy-MM-dd" });
                        return JsonConvert.DeserializeObject<List<ReconditionedListItem>>(responseContent, settings);
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
            // 전체 읽기 전용 해제
            myDataGridView.ReadOnly = false;
            myDataGridView.AutoGenerateColumns = false;
            // 체크박스 열 추가
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn
            {
                Name = "Select",
                HeaderText = "선택",
                Width = 50,
                ReadOnly = false // 체크박스 열만 편집 가능
            };
            myDataGridView.Columns.Add(checkBoxColumn);

            // 텍스트 열 추가
            string[] headers = { "완료일자", "자재번호", "시리얼 번호", "결재상태" };
            string[] properties = { "date", "productNum", "serialNum", "ApprovalStatusText" };

            for (int i = 0; i < headers.Length; i++)
            {
                myDataGridView.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = properties[i],
                    HeaderText = headers[i],
                    Name = properties[i],
                    ReadOnly = true // 텍스트 열은 읽기 전용
                });
            }

            // EditMode 설정
            myDataGridView.EditMode = DataGridViewEditMode.EditOnEnter;

            // Dock 설정
            myDataGridView.Dock = DockStyle.Fill;

            // CellClick 이벤트 핸들러 등록
            myDataGridView.CellClick += MyDataGridView_CellClick;
        }

        private void MyDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // 체크박스 열인 경우 상태 변경
            if (e.RowIndex >= 0 && myDataGridView.Columns[e.ColumnIndex].Name == "Select")
            {
                var cell = myDataGridView[e.ColumnIndex, e.RowIndex] as DataGridViewCheckBoxCell;
                if (cell != null)
                {
                    bool isChecked = cell.Value == null ? false : (bool)cell.Value;
                    cell.Value = !isChecked; // 체크박스 값 토글
                }
            }
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
    }
}
