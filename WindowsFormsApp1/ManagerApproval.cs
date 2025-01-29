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
                    var response = await client.GetAsync($"ListByManagerApproval?employeeNum={loggedInMember.EmployeeNum}");

                    if (response.IsSuccessStatusCode)
                    {
                        var jsonString = await response.Content.ReadAsStringAsync();
                        var items = JsonConvert.DeserializeObject<List<approvalListItem>>(jsonString);
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
            string[] headers = { "등록번호", "자재번호", "자재명", "시리얼 번호", "상신", "", "1차검토", "", "최종검토", "" };
            string[] properties = { "Id", "productNum","productName", "serialNum", "workerName", "submitTime", "middleManagerName", "firstApprovalTime", "lastManagerName", "lastApprovalTime" };   

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

        private void BindDataToGrid(List<approvalListItem> items)
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
        // ProcessApprovalAsync 메서드 수정
        private async Task ProcessApprovalAsync(bool approveAll)
        {
            var selectedItems = new List<approvalListItem>();

            foreach (DataGridViewRow row in managerApprovalDataGridView.Rows)
            {
                bool isChecked = row.Cells["Select"].Value as bool? ?? false;

                // 체크된 항목 또는 전체 항목 처리
                if (isChecked || approveAll)
                {
                    var item = row.DataBoundItem as approvalListItem; // approvalListItem 사용
                    if (item != null)
                    {
                        selectedItems.Add(item);
                    }
                }
            }

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

                    var approvalRequests = new
                    {
                        employeeNum = loggedInMember.EmployeeNum,
                        approvals = selectedItems.Select(item => new { id = item.id }).ToList()
                    };

                    var json = JsonConvert.SerializeObject(approvalRequests);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");

                    var response = await client.PutAsync("approve", content);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("결재 성공!");
                        LoadDataAsync();
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
                        var item = (approvalListItem)row.DataBoundItem;
                        using (var reconditionedDetail = new ReconditionedDetail((long)item.id))
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
