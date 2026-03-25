namespace chatbot
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
            lblTitle = new Label();
            rtbChat = new RichTextBox();
            txtInput = new TextBox();
            btnSend = new Button();
            lblStatus = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(329, 55);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(155, 15);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Kicsit Ai Langauge Asistent";
            // 
            // rtbChat
            // 
            rtbChat.BackColor = Color.WhiteSmoke;
            rtbChat.Dock = DockStyle.Top;
            rtbChat.Location = new Point(0, 0);
            rtbChat.Name = "rtbChat";
            rtbChat.Size = new Size(800, 266);
            rtbChat.TabIndex = 1;
            rtbChat.Text = "chatbot";
            // 
            // txtInput
            // 
            txtInput.Location = new Point(0, 409);
            txtInput.Multiline = true;
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(691, 40);
            txtInput.TabIndex = 2;
            // 
            // btnSend
            // 
            btnSend.BackColor = SystemColors.ActiveCaption;
            btnSend.FlatStyle = FlatStyle.Flat;
            btnSend.Location = new Point(697, 409);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(75, 40);
            btnSend.TabIndex = 3;
            btnSend.Text = "Ask Gemini";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(357, 269);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(82, 15);
            lblStatus.TabIndex = 5;
            lblStatus.Text = "Ai is thinking..";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(800, 450);
            Controls.Add(lblStatus);
            Controls.Add(btnSend);
            Controls.Add(txtInput);
            Controls.Add(rtbChat);
            Controls.Add(lblTitle);
            Name = "Form1";
            Text = "Kicsit AI Assistent";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private RichTextBox rtbChat;
        private TextBox txtInput;
        private Button btnSend;
        private Label lblStatus;
    }
}
