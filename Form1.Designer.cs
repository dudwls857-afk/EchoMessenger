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
            btnsend = new Button();
            Mylistbox = new ListBox();
            name = new Label();
            Mytextbox = new TextBox();
            SuspendLayout();
            // 
            // btnsend
            // 
            btnsend.FlatStyle = FlatStyle.System;
            btnsend.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnsend.ForeColor = SystemColors.ControlText;
            btnsend.Location = new Point(747, 414);
            btnsend.Name = "btnsend";
            btnsend.Size = new Size(276, 142);
            btnsend.TabIndex = 0;
            btnsend.Text = "전송";
            btnsend.UseVisualStyleBackColor = true;
            btnsend.Click += btnsend_Click;
            // 
            // Mylistbox
            // 
            Mylistbox.FormattingEnabled = true;
            Mylistbox.Location = new Point(147, 66);
            Mylistbox.Name = "Mylistbox";
            Mylistbox.Size = new Size(876, 319);
            Mylistbox.TabIndex = 1;
            Mylistbox.SelectedIndexChanged += Mylistbox_SelectedIndexChanged;
            // 
            // name
            // 
            name.AutoSize = true;
            name.Font = new Font("맑은 고딕", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            name.Location = new Point(147, 12);
            name.Name = "name";
            name.Size = new Size(235, 40);
            name.TabIndex = 2;
            name.Text = "Echo Messenger";
            name.Click += name_Click;
            // 
            // Mytextbox
            // 
            Mytextbox.Font = new Font("맑은 고딕", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            Mytextbox.Location = new Point(147, 499);
            Mytextbox.Name = "Mytextbox";
            Mytextbox.Size = new Size(588, 57);
            Mytextbox.TabIndex = 3;
            Mytextbox.TextChanged += Mytextbox_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1094, 582);
            Controls.Add(Mytextbox);
            Controls.Add(name);
            Controls.Add(Mylistbox);
            Controls.Add(btnsend);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnsend;
        private ListBox Mylistbox;
        private Label name;
        private TextBox Mytextbox;
    }
}
