using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class SelectMember : MetroFramework.Forms.MetroForm
    {
        private static readonly HttpClient client = new HttpClient(); // HTTP 클라이언트 인스턴스
        public int SelectedMemberId { get; set; }
        public string SelectedMemberName { get; private set; }
        public string DepartmentName { get; private set; }
        public SelectMember()
        {
            InitializeComponent();
        }

        private async Task SearchMembers()
        {
            string nameFilter = searchForNameTextBox.Text;  // 검색할 이름

            try
            {
                // 요청 URL에 name 필터를 추가
                string requestUrl = $"http://localhost:8080/api/users?name={nameFilter}";

                HttpResponseMessage response = await client.GetAsync(requestUrl);

                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    var memberInfo = JsonConvert.DeserializeObject<SimpleMembers[]>(json);

                    // 데이터 그리드 뷰의 데이터 바인딩을 직접 수정
                    dataGridView1.Rows.Clear();
                    if (memberInfo != null && memberInfo.Length > 0)
                    {
                        foreach (var member in memberInfo)
                        {
                            // 디버깅 메시지 추가
                            Console.WriteLine($"Filtered Name: {member.Name}, EmployeeNum: {member.EmployeeNum}, Department: {member.Department?.DepartmentName}");
                            dataGridView1.Rows.Add(member.Name, member.EmployeeNum, member.Department?.DepartmentName);
                        }
                    }
                    else
                    {
                        MessageBox.Show("검색된 이름이 없습니다. 관리자에게 문의하세요");
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // 데이터 그리드 뷰에서 셀 클릭 시 호출되는 이벤트 핸들러
            if (e.RowIndex >= 0) // 유효한 행 인덱스인지 확인
            {
                // 클릭된 행의 Name 값을 가져오기
                var selectedRow = dataGridView1.Rows[e.RowIndex];
                SelectedMemberName = selectedRow.Cells["Name"].Value.ToString();
                SelectedMemberId = Convert.ToInt32(selectedRow.Cells["EmployeeNum"].Value);
                DepartmentName = selectedRow.Cells["Department"].Value.ToString();
                MessageBox.Show($"선택된 사원: {SelectedMemberName}");
            }
        }

        private void selectMemberButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(SelectedMemberName))
            {
                this.DialogResult = DialogResult.OK; // 선택된 사원 이름이 있을 경우 OK를 반환
                this.Close(); // 폼을 닫습니다
            }
            else
            {
                MessageBox.Show("회원 선택이 필요합니다.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void searchForNameButton_Click(object sender, EventArgs e)
        {
            await SearchMembers();
        }
    }


}
