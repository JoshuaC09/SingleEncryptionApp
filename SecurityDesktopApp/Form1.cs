using System;
using System.Text;
using System.Windows.Forms;

namespace SecurityDesktopApp
{
    public partial class EncryptForm : Form
    {
        private DecryptForm decryptForm;
        private System.Windows.Forms.Timer timerResetIcon = new System.Windows.Forms.Timer();
        private const string DefaultEncryptionKey = "In the eye of the beholder doth lie beauty's true essence, for each gaze doth fashion its own fair visage";
        //Salt use to price verifier
        // private readonly byte[] salt = new byte[] { 0x00, 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x0a, 0x0b, 0x0c, 0x0d, 0x0e, 0x0f };

        private readonly byte[] salt = Encoding.UTF8.GetBytes("The only way to guarantee peace is by making the prospect of war seem hopeless");

        public EncryptForm()
        {
            InitializeComponent();
            this.AcceptButton = btnEncrypt;
            timerResetIcon.Interval = 1000; // Set the delay to 1 second (adjust as needed)
            timerResetIcon.Tick += TimerResetIcon_Tick;
        }

        private void TimerResetIcon_Tick(object sender, EventArgs e)
        {
       
            pb_CopyEnUser.Image = Properties.Resources.CopyIcon2; 

         
            timerResetIcon.Stop();
        }

        private void btnEncrypt_Click_1(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string secretKey = SecretKeyUserInput.Text;

         
            string encryptionKey = !string.IsNullOrWhiteSpace(secretKey) ? secretKey : DefaultEncryptionKey;

       
            if (!string.IsNullOrWhiteSpace(userName))
            {
                try
                {
                  
                    var encryptionService = new SecurityService(encryptionKey, salt);

                
                    string encryptedUserName = encryptionService.Encrypt(userName);

                 
                    txtEncryptedUser.Text = encryptedUserName;
                }
                catch (Exception ex)
                {
                  
                    MessageBox.Show($"An error occurred during encryption: {ex.Message}", "Encryption Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
             
                MessageBox.Show("Please enter a username before encrypting.", "Empty Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClearValues_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void ResetForm()
        {
         
            txtUserName.Clear();
            txtEncryptedUser.Clear();
            SecretKeyUserInput.Clear();
        }

        private void btnDecryptionForm_Click(object sender, EventArgs e)
        {
            string secretKey = SecretKeyUserInput.Text;

        
            if (decryptForm == null || decryptForm.IsDisposed)
            {
                decryptForm = new DecryptForm(secretKey); 
                decryptForm.EncryptForm = this; 
            }
            else
            {
              
                decryptForm.UserEncryptionKey = secretKey;
            }

      
            decryptForm.Show();
            this.Hide();
        }

        private void pb_CopyEnUser_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtEncryptedUser.Text))
            {
              
                Clipboard.SetText(txtEncryptedUser.Text);
                pb_CopyEnUser.Image = Properties.Resources.CopiedImage;

                timerResetIcon.Start();
            }
        }

    }
}
