namespace EchoMessenger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string msg = txtInput.Text;   // 입력값 가져오기

            if (string.IsNullOrWhiteSpace(msg))
                return;
            
            lstChat.Items.Add(msg);       // 리스트에 추가

            txtInput.Clear();             // 입력창 비우기
        }

        private void lstChat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSend.PerformClick(); // 버튼 대신 실행
            }
        }
    }
}
