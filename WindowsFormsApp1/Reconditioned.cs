using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace WindowsFormsApp1
{
    public partial class Reconditioned : Form
    {
        // HttpClient를 static으로 정의하여 재사용
        private static readonly HttpClient client = new HttpClient
        {
            BaseAddress = new Uri("http://localhost:8080/") // 스프링 부트 애플리케이션의 기본 주소
        };
        private int productnum = 123;
        public Reconditioned()
        {
            InitializeComponent();
    
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
                string url = "api/reconditioned"; // 데이터 요청 URL
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                
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

        // ReconditionedItem 클래스는 별도의 파일에 정의하는 것이 좋습니다
        public class ReconditionedItem
        {
            public long r_id { get; set; }
            public DateTime r_date { get; set; }
            public int r_productNum { get; set; }
            public string r_productName { get; set; }
            public string r_serialNum { get; set; }




        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            ProductInfo productInfo = new ProductInfo(productnum);
            productInfo.Show();
        }
        private async void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                long id = Convert.ToInt64(selectedRow.Cells["r_id"].Value);

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
            // 기존 자동 생성 컬럼 제거
            dataGridView1.AutoGenerateColumns = false;

            // 컬럼 추가
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "id",
                HeaderText = "순번",
                Name = "id"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "date",
                HeaderText = "완료일자",
                Name = "date"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "product_num",
                HeaderText = "자재번호",
                Name = "productNum"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "product_name",
                HeaderText = "자재명",
                Name = "product_name"
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "serial_num",
                HeaderText = "시리얼 번호",
                Name = "serial_num"
            });
            
        }

        private void R_Regener_Load(object sender, EventArgs e)
        {

        }


        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            R_SelectProductNum r_SelectProductNum = new R_SelectProductNum();
            r_SelectProductNum.ShowDialog();
        }
    }
}

