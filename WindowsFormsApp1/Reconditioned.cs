using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Reconditioned : Form
    {
        private int selectedReconditionedProductNum;
        
        // HttpClient를 static으로 정의하여 재사용
        private static readonly HttpClient client = new HttpClient
        {
            BaseAddress = new Uri("http://localhost:8080/") // 스프링 부트 애플리케이션의 기본 주소
        };

        public Reconditioned(int selectedProductNum)
        {
            InitializeComponent();
            this.selectedReconditionedProductNum = selectedProductNum;
            this.Load += new System.EventHandler(this.Reconditioned_Load);
        }


        private async void Reconditioned_Load(object sender, EventArgs e)
        {
            InitializeDataGridView();
            await LoadDataAsync();
        }
        private async Task LoadDataAsync()
        {
            try
            {
                string url = $"http://localhost:8080/api/reconditioned/details?productNum={selectedReconditionedProductNum}";
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();

                // 디버깅: 서버 응답 내용 확인
                Console.WriteLine("Server Response: " + responseBody);

                List<ReconditionedItem> items = JsonConvert.DeserializeObject<List<ReconditionedItem>>(responseBody);
                dataGridView1.DataSource = items;
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Request error: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        private async Task SearchProducts()
        {
            string searchTerm = searchTextBox.Text;
            string filterBy = "";
            
            if (selectBox.SelectedItem?.ToString() == "시리얼번호") { filterBy = "serialNum"; }
            else if (selectBox.SelectedItem?.ToString() == "완료일자") { filterBy = "date"; }
            else if (selectBox.SelectedItem?.ToString() == "작업자") { filterBy = "worker"; }

            try
            {
                string requestUrl = $"http://localhost:8080/api/reconditioned?searchTerm={searchTerm}&filterBy={filterBy}";

                HttpResponseMessage response = await client.GetAsync(requestUrl);

                string json = await response.Content.ReadAsStringAsync();
                List<ReconditionedItem> items = JsonConvert.DeserializeObject<List<ReconditionedItem>>(json);
                dataGridView1.DataSource = items;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"오류 발생: {ex.Message}");
                // 예외를 파일에 기록하거나 로깅 서비스에 기록하는 것도 고려할 수 있습니다.
            }
        }

        // ReconditionedItem 클래스는 별도의 파일에 정의하는 것이 좋습니다
        public class ReconditionedItem
        {
            public DateTime date { get; set; }
            public long productNum { get; set; }
            public string productName { get; set; }
            public string serialNum { get; set; }
            public string worker { get; set; }
            public string manager { get; set; }
            public string deaprtmentName { get; set; }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            var selectedRow = dataGridView1.Rows[0];
            string productNum = selectedRow.Cells["productNum"].Value.ToString();
            string productName = selectedRow.Cells["productName"].Value.ToString();
            ProductInfo productInfo = new ProductInfo(productNum, productName);
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
                    // 삭제 요청을 서버에 보냅니다
                    string url = $"api/reconditioned/{id}";
                    HttpResponseMessage response = await client.DeleteAsync(url);
                    response.EnsureSuccessStatusCode();

                    // 데이터 삭제 성공 시 DataGridView 새로 고침
                    MessageBox.Show($"아이템 ID {id}가 삭제되었습니다.");
                    await LoadDataAsync(); // 데이터 새로 고침
                }
                catch (HttpRequestException ex)
                {
                    MessageBox.Show($"삭제 요청 중 오류 발생: {ex.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"오류 발생: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("삭제할 항목을 선택하세요.");
            }
        }

        private void InitializeDataGridView()
        {
  
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "date", 
                HeaderText = "완료일자",
                Name = "date"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "productNum",
                HeaderText = "자재번호",
                Name = "productNum"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "productName",
                HeaderText = "자재명",
                Name = "productName"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "serialNum",
                HeaderText = "시리얼 번호",
                Name = "serialNum"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "worker",
                HeaderText = "점검자",
                Name = "worker"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "manager",
                HeaderText = "관리자",
                Name = "manager"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "deaprtmentName",
                HeaderText = "발생부서",
                Name = "deaprtmentName"
            });
        }
        private void PrevButton_Click(object sender, EventArgs e)
        {
            this.Close();
            R_SelectProductNum r_SelectProductNum = new R_SelectProductNum();
            r_SelectProductNum.ShowDialog();
        }

        private async void searchButton_Click(object sender, EventArgs e)
        {
            await SearchProducts();
        }
    }
}

