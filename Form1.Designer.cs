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
            textBox1 = new TextBox();
            button1 = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // EchoMessenger
            // 
            EchoMessenger.AutoSize = true;
            EchoMessenger.Location = new Point(135, 39);
            EchoMessenger.Name = "EchoMessenger";
            EchoMessenger.Size = new Size(39, 15);
            EchoMessenger.TabIndex = 0;
            EchoMessenger.Text = "label1";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("맑은 고딕", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            textBox1.Location = new Point(135, 494);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(606, 54);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(807, 416);
            button1.Name = "button1";
            button1.Size = new Size(251, 132);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(135, 74);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(923, 319);
            listBox1.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1169, 613);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(EchoMessenger);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label EchoMessenger;
        private TextBox textBox1;
        private Button button1;
        private ListBox listBox1;
    }
}
