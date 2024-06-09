namespace SecurityDesktopApp
{
    partial class EncryptForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnClearValues = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEncryptedUser = new System.Windows.Forms.TextBox();
            this.btnDecryptionForm = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pb_CopyEnUser = new System.Windows.Forms.PictureBox();
            this.SecretKeyUserInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_CopyEnUser)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(105, 64);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(134, 23);
            this.txtUserName.TabIndex = 0;
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.AutoSize = true;
            this.lbl_UserName.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserName.Location = new System.Drawing.Point(15, 67);
            this.lbl_UserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(77, 18);
            this.lbl_UserName.TabIndex = 4;
            this.lbl_UserName.Text = "Plain Text:";
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.BackColor = System.Drawing.Color.White;
            this.btnEncrypt.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncrypt.Location = new System.Drawing.Point(193, 130);
            this.btnEncrypt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(190, 32);
            this.btnEncrypt.TabIndex = 9;
            this.btnEncrypt.Text = "ENCRYPT ";
            this.btnEncrypt.UseVisualStyleBackColor = false;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click_1);
            // 
            // btnClearValues
            // 
            this.btnClearValues.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearValues.Location = new System.Drawing.Point(419, 189);
            this.btnClearValues.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClearValues.Name = "btnClearValues";
            this.btnClearValues.Size = new System.Drawing.Size(116, 25);
            this.btnClearValues.TabIndex = 11;
            this.btnClearValues.Text = "CLEAR VALUES";
            this.btnClearValues.UseVisualStyleBackColor = true;
            this.btnClearValues.Click += new System.EventHandler(this.btnClearValues_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(261, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "Encrypted Text:";
            // 
            // txtEncryptedUser
            // 
            this.txtEncryptedUser.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEncryptedUser.Location = new System.Drawing.Point(397, 62);
            this.txtEncryptedUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEncryptedUser.Name = "txtEncryptedUser";
            this.txtEncryptedUser.Size = new System.Drawing.Size(152, 23);
            this.txtEncryptedUser.TabIndex = 2;
            // 
            // btnDecryptionForm
            // 
            this.btnDecryptionForm.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecryptionForm.Location = new System.Drawing.Point(18, 189);
            this.btnDecryptionForm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDecryptionForm.Name = "btnDecryptionForm";
            this.btnDecryptionForm.Size = new System.Drawing.Size(116, 25);
            this.btnDecryptionForm.TabIndex = 15;
            this.btnDecryptionForm.Text = "DECRYPT?";
            this.btnDecryptionForm.UseVisualStyleBackColor = true;
            this.btnDecryptionForm.Click += new System.EventHandler(this.btnDecryptionForm_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(169, 13);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "Encrypt Your Credentials Here";
            // 
            // pb_CopyEnUser
            // 
            this.pb_CopyEnUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_CopyEnUser.Image = global::SecurityDesktopApp.Properties.Resources.CopyIcon2;
            this.pb_CopyEnUser.Location = new System.Drawing.Point(551, 59);
            this.pb_CopyEnUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pb_CopyEnUser.Name = "pb_CopyEnUser";
            this.pb_CopyEnUser.Size = new System.Drawing.Size(27, 24);
            this.pb_CopyEnUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_CopyEnUser.TabIndex = 18;
            this.pb_CopyEnUser.TabStop = false;
            this.pb_CopyEnUser.Click += new System.EventHandler(this.pb_CopyEnUser_Click);
            // 
            // SecretKeyUserInput
            // 
            this.SecretKeyUserInput.Location = new System.Drawing.Point(18, 24);
            this.SecretKeyUserInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SecretKeyUserInput.Name = "SecretKeyUserInput";
            this.SecretKeyUserInput.Size = new System.Drawing.Size(76, 20);
            this.SecretKeyUserInput.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 7);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Change Key?";
            // 
            // EncryptForm
            // 
            this.AcceptButton = this.btnEncrypt;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 241);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SecretKeyUserInput);
            this.Controls.Add(this.pb_CopyEnUser);
            this.Controls.Add(this.btnDecryptionForm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEncryptedUser);
            this.Controls.Add(this.btnClearValues);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.lbl_UserName);
            this.Controls.Add(this.txtUserName);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "EncryptForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EncryptionForm";
            ((System.ComponentModel.ISupportInitialize)(this.pb_CopyEnUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lbl_UserName;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnClearValues;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEncryptedUser;
        private System.Windows.Forms.Button btnDecryptionForm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pb_CopyEnUser;
        private System.Windows.Forms.TextBox SecretKeyUserInput;
        private System.Windows.Forms.Label label3;
    }
}

