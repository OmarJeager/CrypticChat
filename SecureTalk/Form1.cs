using System;
using System.Windows.Forms;

namespace SecureTalk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHashMessage_Click(object sender, EventArgs e)
        {
            // Get the entered message
            string message = txtMessage.Text;
            if (string.IsNullOrEmpty(message))
            {
                MessageBox.Show("Please enter a message to hash.");
                return;
            }

            // Hash the message
            string hashedMessage = CryptographyHelper.HashMessage(message);

            // Encrypt the message
            string encryptedMessage = CryptographyHelper.EncryptMessage(message);

            // Show the encrypted message in the second input field
            txtCryptedMessage.Text = encryptedMessage;

            // Display the hashed message (this can be optional)
            MessageBox.Show($"Hashed Message: {hashedMessage}");
        }

        private void btnDecryptMessage_Click(object sender, EventArgs e)
        {
            // Get the entered encrypted message
            string encryptedMessage = txtCryptedMessage.Text;
            if (string.IsNullOrEmpty(encryptedMessage))
            {
                MessageBox.Show("Please enter a crypted message to decrypt.");
                return;
            }

            // Decrypt the message
            string decryptedMessage = CryptographyHelper.DecryptMessage(encryptedMessage);

            // Display the decrypted message
            lblDecryptedMessage.Text = $"Decrypted Message: {decryptedMessage}";
        }
    }
}
