namespace WinFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            screenshotButton = new Button();
            preview = new PictureBox();
            sendButton = new Button();
            cancelButton = new Button();
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)preview).BeginInit();
            SuspendLayout();
            // 
            // screenshotButton
            // 
            screenshotButton.BackColor = Color.Black;
            screenshotButton.FlatStyle = FlatStyle.Flat;
            screenshotButton.Font = new Font("Segoe UI", 9F);
            screenshotButton.ForeColor = Color.FromArgb(31, 192, 233);
            screenshotButton.Location = new Point(205, 262);
            screenshotButton.Name = "screenshotButton";
            screenshotButton.Size = new Size(107, 28);
            screenshotButton.TabIndex = 0;
            screenshotButton.Text = "Screenshot";
            screenshotButton.UseVisualStyleBackColor = false;
            screenshotButton.Click += screenshotButton_Click;
            // 
            // preview
            // 
            preview.BackColor = Color.Black;
            preview.Location = new Point(-4, 0);
            preview.Name = "preview";
            preview.Size = new Size(515, 256);
            preview.SizeMode = PictureBoxSizeMode.StretchImage;
            preview.TabIndex = 1;
            preview.TabStop = false;
            // 
            // sendButton
            // 
            sendButton.BackColor = Color.Black;
            sendButton.FlatStyle = FlatStyle.Flat;
            sendButton.Font = new Font("Segoe UI", 9F);
            sendButton.ForeColor = Color.FromArgb(31, 192, 233);
            sendButton.Location = new Point(136, 262);
            sendButton.Name = "sendButton";
            sendButton.Size = new Size(107, 28);
            sendButton.TabIndex = 2;
            sendButton.Text = "Send to Imgur";
            sendButton.UseVisualStyleBackColor = false;
            sendButton.Visible = false;
            sendButton.Click += sendButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.Black;
            cancelButton.FlatStyle = FlatStyle.Flat;
            cancelButton.Font = new Font("Segoe UI", 9F);
            cancelButton.ForeColor = Color.FromArgb(255, 128, 128);
            cancelButton.Location = new Point(272, 262);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(107, 28);
            cancelButton.TabIndex = 3;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Visible = false;
            cancelButton.Click += cancelButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(153, 123);
            label1.Name = "label1";
            label1.Size = new Size(205, 15);
            label1.TabIndex = 4;
            label1.Text = "Preview of the screenshot will be here";
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = SystemColors.ActiveCaption;
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.FromArgb(128, 128, 255);
            linkLabel1.Location = new Point(161, 145);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(0, 15);
            linkLabel1.TabIndex = 5;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 34, 34);
            ClientSize = new Size(509, 302);
            Controls.Add(linkLabel1);
            Controls.Add(label1);
            Controls.Add(cancelButton);
            Controls.Add(sendButton);
            Controls.Add(preview);
            Controls.Add(screenshotButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "Screemgur";
            ((System.ComponentModel.ISupportInitialize)preview).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button screenshotButton;
        private PictureBox preview;
        private Button sendButton;
        private Button cancelButton;
        private Label label1;
        private LinkLabel linkLabel1;
    }
}
