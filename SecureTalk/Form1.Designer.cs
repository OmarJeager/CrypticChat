namespace SecureTalk
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.TextBox txtCryptedMessage;
        private System.Windows.Forms.Label lblDecryptedMessage;
        private System.Windows.Forms.Button btnHashMessage;
        private System.Windows.Forms.Button btnDecryptMessage;

        private void InitializeComponent()
        {
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.txtCryptedMessage = new System.Windows.Forms.TextBox();
            this.lblDecryptedMessage = new System.Windows.Forms.Label();
            this.btnHashMessage = new System.Windows.Forms.Button();
            this.btnDecryptMessage = new System.Windows.Forms.Button();

            this.SuspendLayout();
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(12, 12);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(200, 20);
            this.txtMessage.TabIndex = 0;
            // 
            // txtCryptedMessage
            // 
            this.txtCryptedMessage.Location = new System.Drawing.Point(12, 60);
            this.txtCryptedMessage.Name = "txtCryptedMessage";
            this.txtCryptedMessage.Size = new System.Drawing.Size(200, 20);
            this.txtCryptedMessage.TabIndex = 1;
            // 
            // lblDecryptedMessage
            // 
            this.lblDecryptedMessage.Location = new System.Drawing.Point(12, 120);
            this.lblDecryptedMessage.Name = "lblDecryptedMessage";
            this.lblDecryptedMessage.Size = new System.Drawing.Size(200, 20);
            this.lblDecryptedMessage.TabIndex = 2;
            // 
            // btnHashMessage
            // 
            this.btnHashMessage.Location = new System.Drawing.Point(12, 40);
            this.btnHashMessage.Name = "btnHashMessage";
            this.btnHashMessage.Size = new System.Drawing.Size(100, 23);
            this.btnHashMessage.TabIndex = 3;
            this.btnHashMessage.Text = "Hash & Encrypt";
            this.btnHashMessage.UseVisualStyleBackColor = true;
            this.btnHashMessage.Click += new System.EventHandler(this.btnHashMessage_Click);
            // 
            // btnDecryptMessage
            // 
            this.btnDecryptMessage.Location = new System.Drawing.Point(12, 150);
            this.btnDecryptMessage.Name = "btnDecryptMessage";
            this.btnDecryptMessage.Size = new System.Drawing.Size(100, 23);
            this.btnDecryptMessage.TabIndex = 4;
            this.btnDecryptMessage.Text = "Decrypt Message";
            this.btnDecryptMessage.UseVisualStyleBackColor = true;
            this.btnDecryptMessage.Click += new System.EventHandler(this.btnDecryptMessage_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 181);
            this.Controls.Add(this.btnDecryptMessage);
            this.Controls.Add(this.btnHashMessage);
            this.Controls.Add(this.lblDecryptedMessage);
            this.Controls.Add(this.txtCryptedMessage);
            this.Controls.Add(this.txtMessage);
            this.Name = "Form1";
            this.Text = "Hashing & Decryption App";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
