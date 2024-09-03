using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;


namespace WindowsFormsApp1
{
    
    public partial class ReconditionedList : Form
    {
        
        private int selectedReconditionedProductNum;
        private string selectedReconditionedProductName;
        private static readonly HttpClient client = new HttpClient
        {
            BaseAddress = new Uri("http://localhost:8080/")
        };

        public ReconditionedList(int selectedProductNum, string selectedProductName)
        {
            InitializeComponent();
            this.selectedReconditionedProductNum = selectedProductNum;
            this.selectedReconditionedProductName = selectedProductName;
            SelectedProductNumTextBox.Text = selectedProductNum.ToString();
            SelectedProductNameTextBox.Text = selectedProductName;
            this.Load += new EventHandler(this.Reconditioned_Load);
        }

        private async void Reconditioned_Load(object sender, EventArgs e)
        {
            InitializeDataGridView();
            SetInitialDatePickers();
            await LoadDataAsync();
        }
        private void SetInitialDatePickers()
        {
            StartDateTimePicker.Value = DateTime.Now.AddMonths(-1); // 초기 시작 날짜 한 달 전으로 설정
            EndDateTimePicker.Value = DateTime.Now; // 초기 끝 날짜 현재로 설정
        }
        private async Task LoadDataAsync()
        {
            try
            {
                string url = BuildUrl();
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();
                Console.WriteLine("Server Response: " + responseBody);

                if (responseBody.StartsWith("["))
                {
                    var items = JsonConvert.DeserializeObject<List<ReconditionedListItem>>(responseBody);
                    FilterAndDisplayItems(items);
                }
                else
                {
                    MessageBox.Show("서버 응답이 배열 형태가 아닙니다.");
                }
            }
            catch (HttpRequestException ex)
            {
                HandleException("Request error", ex);
            }
            catch (Exception ex)
            {
                HandleException("Error", ex);
            }
        }
        private string BuildUrl()
        {
            string url = $"api/reconditioned/details?productNum={selectedReconditionedProductNum}";

            if (selectBox?.SelectedItem != null)
            {
                string filterBy = selectBox.SelectedItem.ToString();
                switch (filterBy)
                {
                    case "시리얼번호":
                        url = $"api/reconditioned/detailsBySerialNum?productNum={selectedReconditionedProductNum}&serialNum={searchTextBox.Text}";
                        break;
                    case "완료일자":
                        // 완료일자 필터가 있는 경우 URL을 추가로 변경하는 로직 필요
                        break;
                    case "작업자":
                        url += $"&worker={searchTextBox.Text}";
                        break;
                }
            }

            return url;
        }

        private void FilterAndDisplayItems(List<ReconditionedListItem> items)
        {
            if (StartDateTimePicker != null && EndDateTimePicker != null)
            {
                DateTime startDate = StartDateTimePicker.Value.Date;
                DateTime endDate = EndDateTimePicker.Value.Date;
                var filteredItems = items.Where(item => item.Date >= startDate && item.Date <= endDate).ToList();
                dataGridView1.DataSource = filteredItems;
            }
            else
            {
                dataGridView1.DataSource = items;
            }
        }

        private void HandleException(string message, Exception ex)
        {
            MessageBox.Show($"{message}: {ex.Message}");
        }

        // ReconditionedListItem 클래스는 별도의 파일에 정의하는 것이 좋습니다

        private void button1_Click(object sender, EventArgs e)
        {
            AddProductDetail productInfo = new AddProductDetail(selectedReconditionedProductNum.ToString(), selectedReconditionedProductName);
            productInfo.ShowDialog();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                long id = Convert.ToInt64(selectedRow.Cells["id"].Value);

                try
                {
                    string url = $"api/reconditioned/{id}";
                    HttpResponseMessage response = await client.DeleteAsync(url);
                    response.EnsureSuccessStatusCode();

                    MessageBox.Show($"아이템 ID {id}가 삭제되었습니다.");
                    await LoadDataAsync(); // 데이터 새로 고침
                }
                catch (HttpRequestException ex)
                {
                    HandleException("삭제 요청 중 오류 발생", ex);
                }
                catch (Exception ex)
                {
                    HandleException("오류 발생", ex);
                }
            }
            else
            {
                MessageBox.Show("삭제할 항목을 선택하세요.");
            }
        }
        private void InitializeDataGridView()
        {
            string[] headers = { "완료일자", "자재번호", "자재명", "시리얼 번호", "점검자", "관리자", "발생부서" };
            string[] properties = { "Date", "ProductNum", "ProductName", "SerialNum", "Worker", "Manager", "DepartmentName" };

            for (int i = 0; i < headers.Length; i++)
            {
                dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = properties[i],
                    HeaderText = headers[i],
                    Name = properties[i]
                });
            }
        }

        private void PrevButton_Click(object sender, EventArgs e)
        {
            this.Close();
            using (var r_SelectProductNum = new R_SelectProductNum())
            {
                r_SelectProductNum.ShowDialog();
            }
        }

        private async void searchButton_Click(object sender, EventArgs e)
        {
            await LoadDataAsync();
        }
    }
}
