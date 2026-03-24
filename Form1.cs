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
            string msg = txtInput.Text.Trim();   // 입력값 가져오기

            if (string.IsNullOrWhiteSpace(msg))
                return;

            if (msg.Length > 50)
            {
                MessageBox.Show("50자 이하로 입력하세요.");
                return;
            }

            string time = DateTime.Now.ToString("HH:mm:ss");
            string result = $"[{time}] {msg}";

            lstChat.Items.Add(result);       // 리스트에 추가

            txtInput.Clear();             // 입력창 비우기

            chatcount.Text = $"현재 대화: {lstChat.Items.Count}개";
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

        private void lstChat_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void EchoMessenger_Click(object sender, EventArgs e)
        {

        }

        private void chatcount_Click(object sender, EventArgs e)
        {

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (lstChat.SelectedIndex != -1)
            {
                lstChat.Items.RemoveAt(lstChat.SelectedIndex);

                chatcount.Text = $"현재 대화: {lstChat.Items.Count}개";
            }
            else
            {
                MessageBox.Show("삭제할 항목을 선택하세요.");
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            lstChat.Items.Clear();
            chatcountsda.Text = "현재 대화: 0개";
        }
    }
}
