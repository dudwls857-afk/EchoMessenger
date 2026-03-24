namespace EchoMessenger
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            EchoMessenger = new Label();
            txtInput = new TextBox();
            btnSend = new Button();
            lstChat = new ListBox();
            SuspendLayout();
            // 
            // EchoMessenger
            // 
            EchoMessenger.AutoSize = true;
            EchoMessenger.Font = new Font("맑은 고딕", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            EchoMessenger.ForeColor = Color.FromArgb(0, 0, 64);
            EchoMessenger.Location = new Point(135, 9);
            EchoMessenger.Name = "EchoMessenger";
            EchoMessenger.Size = new Size(283, 50);
            EchoMessenger.TabIndex = 0;
            EchoMessenger.Text = "EchoMessenger";
            // 
            // txtInput
            // 
            txtInput.Font = new Font("맑은 고딕", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            txtInput.Location = new Point(135, 494);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(606, 54);
            txtInput.TabIndex = 1;
            // 
            // btnSend
            // 
            btnSend.BackColor = Color.Gray;
            btnSend.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnSend.ForeColor = Color.Black;
            btnSend.Location = new Point(807, 416);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(251, 132);
            btnSend.TabIndex = 2;
            btnSend.Text = "전송";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;
            // 
            // lstChat
            // 
            lstChat.BackColor = Color.Cyan;
            lstChat.Font = new Font("맑은 고딕", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lstChat.FormattingEnabled = true;
            lstChat.Location = new Point(135, 71);
            lstChat.Name = "lstChat";
            lstChat.Size = new Size(923, 304);
            lstChat.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1193, 628);
            Controls.Add(lstChat);
            Controls.Add(btnSend);
            Controls.Add(txtInput);
            Controls.Add(EchoMessenger);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label EchoMessenger;
        private TextBox txtInput;
        private Button btnSend;
        private ListBox lstChat;
    }
}
