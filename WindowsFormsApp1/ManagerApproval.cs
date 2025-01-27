using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ManagerApproval : MetroFramework.Forms.MetroForm
    {
        private readonly Member loggedInMember;

        public ManagerApproval(Member loggedInMember)
        {
            InitializeComponent();
            this.loggedInMember = loggedInMember;
            InitializeDataGridView();
            LoadDataAsync();
        }

        private async void LoadDataAsync()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:8080/api/reconditioned/");
                    var response = await client.GetAsync($"detailsByManager?employeeNum={loggedInMember.EmployeeNum}");

                    if (response.IsSuccessStatusCode)
                    {
                        var jsonString = await response.Content.ReadAsStringAsync();
                        var items = JsonConvert.DeserializeObject<List<ReconditionedListItem>>(jsonString);
                        BindDataToGrid(items);
                    }
                    else
                    {
                        MessageBox.Show("데이터를 불러오는데 실패했습니다.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void InitializeDataGridView()
        {
            managerApprovalDataGridView.ReadOnly = false;
            managerApprovalDataGridView.AutoGenerateColumns = false;

            // 체크박스 열 추가
            var checkBoxColumn = new DataGridViewCheckBoxColumn
            {
                Name = "Select",
                HeaderText = "선택",
                Width = 50,
                ReadOnly = false,
                FalseValue = false,
                TrueValue = true
            };
            managerApprovalDataGridView.Columns.Add(checkBoxColumn);

            // 텍스트 열 추가
            string[] headers = { "Id", "작업자", "완료일자", "자재번호", "시리얼 번호", "결재상태" };
            string[] properties = { "Id", "workerName", "date", "productNum", "serialNum", "approvalStatusText" };

            for (int i = 0; i < headers.Length; i++)
            {
                managerApprovalDataGridView.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = properties[i],
                    HeaderText = headers[i],
                    Name = properties[i],
                    ReadOnly = true
                });
            }

            managerApprovalDataGridView.EditMode = DataGridViewEditMode.EditOnEnter;
            managerApprovalDataGridView.Columns[1].Width = 50;
            managerApprovalDataGridView.RowHeadersVisible = false;

        }

        private void BindDataToGrid(List<ReconditionedListItem> items)
        {
            var bindingSource = new BindingSource { DataSource = items };
            managerApprovalDataGridView.DataSource = bindingSource;
        }

        private async void waitingDeleteButton_Click(object sender, EventArgs e)
        {
            await ProcessApprovalAsync(false); // 선택된 항목만 처리
        }

        private async void approvalAll_Click(object sender, EventArgs e)
        {
            await ProcessApprovalAsync(true); // 전체 항목 처리
        }
        private async Task ProcessApprovalAsync(bool approveAll)
        {
            var selectedItems = new List<ReconditionedListItem>();

            // DataGridView의 모든 행을 순회하면서 선택된 항목을 찾음
            foreach (DataGridViewRow row in managerApprovalDataGridView.Rows)
            {
                // 체크박스 값이 null일 수 있으므로 안전하게 처리
                bool isChecked = row.Cells["Select"].Value as bool? ?? false;


                // approveAll이 true이면 전체 항목을 처리, 아니면 체크된 항목만 처리
                if (isChecked)
                {
                    var item = row.DataBoundItem as ReconditionedListItem;
                    if (item != null)
                    {
                        selectedItems.Add(item);
                    }
                }
            }

            // 선택된 항목이 없으면 경고 메시지 표시
            if (selectedItems.Count == 0)
            {
                MessageBox.Show("결재할 항목을 선택하세요.");
                return;
            }

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://localhost:8080/api/approval/");

                    // 승인 요청 객체 생성
                    var approvalRequests = new
                    {
                        employeeNum = loggedInMember.EmployeeNum,
                        approvals = selectedItems.Select(item => new
                        {
                            id = item.id
                        }).ToList()
                    };

                    // JSON 직렬화
                    var json = JsonConvert.SerializeObject(approvalRequests);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");

                    // PUT 요청 보내기
                    var response = await client.PutAsync("approve", content);

                    // 응답 상태에 따른 처리
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("결재 성공!");
                        LoadDataAsync();  // 데이터 새로고침
                    }
                    else
                    {
                        MessageBox.Show($"결재 실패! 상태 코드: {response.StatusCode}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
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

        private void ShowDetailButton_Click(object sender, EventArgs e)
        {
            if (GetCheckedRowCount() == 1)
            {
                foreach (DataGridViewRow row in managerApprovalDataGridView.Rows)
                {
                    DataGridViewCheckBoxCell checkBoxCell = (DataGridViewCheckBoxCell)row.Cells["Select"];
                    if (Convert.ToBoolean(checkBoxCell.Value))
                    {
                        var item = (ReconditionedListItem)row.DataBoundItem;
                        using (var reconditionedDetail = new ReconditionedDetail((long)item.id, (int)item.approvalStatus))
                        {
                            reconditionedDetail.ShowDialog();
                        }
                        return;
                    }
                }
                MessageBox.Show("상세 정보를 볼 항목을 선택하세요.");
            }
            else
            {
                MessageBox.Show("하나의 행을 선택하세요.");
            }
        }
        private int GetCheckedRowCount()
        {
            int checkedCount = 0;
            foreach (DataGridViewRow row in managerApprovalDataGridView.Rows)
            {
                DataGridViewCheckBoxCell checkBoxCell = (DataGridViewCheckBoxCell)row.Cells["Select"];
                if (Convert.ToBoolean(checkBoxCell.Value))
                {
                    checkedCount++;
                }
            }
            return checkedCount;
        }
    }
}
