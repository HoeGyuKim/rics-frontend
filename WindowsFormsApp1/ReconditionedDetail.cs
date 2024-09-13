using System;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ReconditionedDetail : MetroFramework.Forms.MetroForm
    {
        private PictureBox pictureBox;
        private Button fetchButton;
        private TextBox idTextBox;
        private static readonly HttpClient client = new HttpClient();
        private long selectedId;

        public ReconditionedDetail(long id)
        {
            InitializeComponent();
            this.selectedId = id;
            pictureBox = new PictureBox { Width = 200, Height = 200, Location = new Point(10, 50) };
            fetchButton = new Button { Text = "Get QR Code", Location = new Point(10, 10) };
            idTextBox = new TextBox { Location = new Point(120, 10), Width = 100 };

            fetchButton.Click += async (sender, args) => await FetchQRCode();

            Controls.Add(pictureBox);
            Controls.Add(fetchButton);
            Controls.Add(idTextBox);
        }

        private async Task FetchQRCode()
        {
            if (selectedId <= 0)
            {
                MessageBox.Show("Invalid ID.");
                return;
            }

            try
            {
                string url = $"http://localhost:8080/qrcode/{selectedId}"; // 서버의 URL을 설정
                HttpResponseMessage response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    byte[] imageBytes = await response.Content.ReadAsByteArrayAsync();

                    // 이미지 바이트 배열을 PictureBox에 표시
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        pictureBox.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    MessageBox.Show("Failed to fetch QR code: " + response.StatusCode);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private async Task LoadDetails()
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync($"http://localhost:8080/qrcode/{selectedId}");
                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    // JSON 데이터를 처리하는 로직을 추가합니다.
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading details: " + ex.Message);
            }
        }

        private async void ReconditionedDetail_Load(object sender, EventArgs e)
        {
            await LoadDetails();
        }
    }
}
