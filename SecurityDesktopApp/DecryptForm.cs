using System;
using System.Windows.Forms;

namespace SecurityDesktopApp
{
    public partial class DecryptForm : Form
    {
        private EncryptForm encryptForm; // Declare a private field to store the EncryptForm instance
        private System.Windows.Forms.Timer timerResetIcon = new System.Windows.Forms.Timer();

        public string UserEncryptionKey { get; set; } // Add this property

        private const string DefaultEncryptionKey = "In the eye of the beholder doth lie beauty's true essence, for each gaze doth fashion its own fair visage";
        private readonly byte[] salt = new byte[] { 0x00, 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x0a, 0x0b, 0x0c, 0x0d, 0x0e, 0x0f };

        public DecryptForm(string userEncryptionKey)
        {
            InitializeComponent();
            timerResetIcon.Interval = 1000; // Set the delay to 1 second (adjust as needed)
            timerResetIcon.Tick += TimerResetIcon_Tick;
            UserEncryptionKey = userEncryptionKey; // Store the passed key
        }

        private void TimerResetIcon_Tick(object sender, EventArgs e)
        {
            // Reset the image back to the original form
            pb_CopyEnUser2.Image = Properties.Resources.CopyIcon2; // Replace "OriginalImage" with your original image resource name

            // Stop the Timer
            timerResetIcon.Stop();
        }

        public EncryptForm EncryptForm
        {
            set { encryptForm = value; }
        }

        private void btnEncryptionForm_Click(object sender, EventArgs e)
        {
            // Check if the EncryptForm instance has been set
            if (encryptForm != null)
            {
                // Show the EncryptForm and hide the current form
                encryptForm.Show();
                this.Hide();
            }
        }

        private void ResetForm()
        {
            // Clear the values of the textboxes
            txtUserName2.Clear();
            txtEncryptedUser2.Clear();
        }

        private void btnClearValues2_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            string encryptedUserName = txtUserName2.Text;

            // Use the passed user encryption key if available, otherwise use the default key
            string decryptionKey = !string.IsNullOrWhiteSpace(UserEncryptionKey) ? UserEncryptionKey : DefaultEncryptionKey;

            // Check if the TextBox is not empty
            if (!string.IsNullOrWhiteSpace(encryptedUserName))
            {
                try
                {
                    // Create an instance of the StringEncryptionService with the chosen key and salt
                    var encryptionService = new SecurityService(decryptionKey, salt);

                    // Decrypt the encrypted data
                    string decryptedUserName = encryptionService.Decrypt(encryptedUserName);

                    // Display the decrypted data in the respective textbox
                    txtEncryptedUser2.Text = decryptedUserName;
                }
                catch (Exception ex)
                {
                    // Check if the exception is "The encrypted data is not in the correct format"
                    if (ex.Message == "The encrypted data is not in the correct format.")
                    {
                        // Display a message box with the error message
                        MessageBox.Show(ex.Message, "Decryption Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        // Handle other exceptions as needed
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                // Display a message box if the TextBox is empty
                MessageBox.Show("Please enter encrypted data before decrypting.", "Empty Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void pb_CopyEnUser2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtEncryptedUser2.Text))
            {
                // Copy the text to the clipboard
                Clipboard.SetText(txtEncryptedUser2.Text);
                pb_CopyEnUser2.Image = Properties.Resources.CopiedImage; // Replace "CopiedImage" with your temporary image resource name

                // Start the Timer
                timerResetIcon.Start();
            }
        }

        private void txtUserName2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
