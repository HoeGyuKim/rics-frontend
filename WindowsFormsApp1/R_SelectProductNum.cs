// 불필요한 클래스 정의 제거
// using System;
// using System.Net.Http;
// using System.Threading.Tasks;
// using System.Windows.Forms;
// using Newtonsoft.Json;

using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;

namespace WindowsFormsApp1
{
    public partial class R_SelectProductNum : Form
    {
        private static readonly HttpClient client = new HttpClient(); // HTTP 클라이언트 인스턴스


        public R_SelectProductNum()
        {
            InitializeComponent();
            searchTextBox.KeyDown += new KeyEventHandler(SearchProductNum_KeyUp);
        }

        private async void R_SelectProductNum_Load(object sender, EventArgs e)
        {
            // 콤보박스 초기화
            comboBox1.Items.Add("자재번호");
            comboBox1.Items.Add("자재명");
            comboBox1.SelectedIndex = 0; // 기본값 설정

            await LoadProducts(); // 폼 로드 시 데이터 로드
        }

        private async Task LoadProducts()
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync("http://localhost:8080/api/products");

                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    var products = JsonConvert.DeserializeObject<SimpleReconditioned[]>(json);

                    // 데이터 그리드 뷰의 데이터 바인딩을 직접 수정
                    dataGridView1.Rows.Clear();
                    if (products != null && products.Length > 0)
                    {
                        foreach (var product in products)
                        {
                            // 디버깅 메시지 추가
                            Console.WriteLine($"ProductNumber: {product.productNum}, ProductName: {product.productName}");
                            dataGridView1.Rows.Add(product.productNum, product.productName);
                        }
                    }
                    else
                    {
                        MessageBox.Show("검색된 제품이 없습니다.");
                    }
                }
                else
                {
                    MessageBox.Show("서버에서 데이터를 불러오는 데 실패했습니다.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"오류 발생: {ex.Message}");
                // 예외를 파일에 기록하거나 로깅 서비스에 기록하는 것도 고려할 수 있습니다.
            }
        }

        private async void searchRProductNum_Click(object sender, EventArgs e)
        {
            // 검색 버튼 클릭 시 데이터 필터링
            await SearchProducts();
        }

        private async Task SearchProducts()
        {
            string searchTerm = searchTextBox.Text;
            string filterBy = comboBox1.SelectedItem?.ToString() == "자재번호" ? "product_num" : "product_name";

            try
            {
                string requestUrl = $"http://localhost:8080/api/products?searchTerm={searchTerm}&filterBy={filterBy}";

                HttpResponseMessage response = await client.GetAsync(requestUrl);

                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    var products = JsonConvert.DeserializeObject<SimpleReconditioned[]>(json);

                    // 데이터 그리드 뷰의 데이터 바인딩을 직접 수정
                    dataGridView1.Rows.Clear();
                    if (products != null && products.Length > 0)
                    {
                        foreach (var product in products)
                        {
                            // 디버깅 메시지 추가
                            Console.WriteLine($"Filtered ProductNumber: {product.productNum}, ProductName: {product.productName}");
                            dataGridView1.Rows.Add(product.productNum, product.productName);
                        }
                    }
                    else
                    {
                        MessageBox.Show("검색된 품목이 없습니다. 추가하려면 [품목추가] 를 선택하세요");
                    }
                }
                else
                {
                    MessageBox.Show("서버에서 데이터를 불러오는 데 실패했습니다.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"오류 발생: {ex.Message}");
                // 예외를 파일에 기록하거나 로깅 서비스에 기록하는 것도 고려할 수 있습니다.
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // 유효한 행 클릭인지 확인
            {
                Reconditioned reconditioned = new Reconditioned();
                reconditioned.Show();
                Hide();
            }
        }

        private void AddRProductList_Click(object sender, EventArgs e)
        {
            AddProductList addProductList = new AddProductList();
            addProductList.ShowDialog();
        }
 
        private void SearchProductNum_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                searchRProductNum_Click(sender, e);
            }
        }
    }
}
