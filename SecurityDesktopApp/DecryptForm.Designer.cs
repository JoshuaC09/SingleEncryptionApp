namespace SecurityDesktopApp
{
    partial class DecryptForm
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
            this.btnEncryptionForm = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEncryptedUser2 = new System.Windows.Forms.TextBox();
            this.btnClearValues2 = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.txtUserName2 = new System.Windows.Forms.TextBox();
            this.pb_CopyEnUser2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_CopyEnUser2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEncryptionForm
            // 
            this.btnEncryptionForm.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncryptionForm.Location = new System.Drawing.Point(19, 167);
            this.btnEncryptionForm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEncryptionForm.Name = "btnEncryptionForm";
            this.btnEncryptionForm.Size = new System.Drawing.Size(116, 25);
            this.btnEncryptionForm.TabIndex = 27;
            this.btnEncryptionForm.Text = "ENCRYPT?";
            this.btnEncryptionForm.UseVisualStyleBackColor = true;
            this.btnEncryptionForm.Click += new System.EventHandler(this.btnEncryptionForm_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(170, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(284, 24);
            this.label2.TabIndex = 26;
            this.label2.Text = "Decrypt Your Credentials Here";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(277, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 18);
            this.label1.TabIndex = 25;
            this.label1.Text = "Decrypted Text:";
            // 
            // txtEncryptedUser2
            // 
            this.txtEncryptedUser2.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEncryptedUser2.Location = new System.Drawing.Point(398, 68);
            this.txtEncryptedUser2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEncryptedUser2.Name = "txtEncryptedUser2";
            this.txtEncryptedUser2.Size = new System.Drawing.Size(152, 23);
            this.txtEncryptedUser2.TabIndex = 2;
            // 
            // btnClearValues2
            // 
            this.btnClearValues2.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearValues2.Location = new System.Drawing.Point(420, 179);
            this.btnClearValues2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClearValues2.Name = "btnClearValues2";
            this.btnClearValues2.Size = new System.Drawing.Size(116, 25);
            this.btnClearValues2.TabIndex = 23;
            this.btnClearValues2.Text = "CLEAR VALUES";
            this.btnClearValues2.UseVisualStyleBackColor = true;
            this.btnClearValues2.Click += new System.EventHandler(this.btnClearValues2_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.BackColor = System.Drawing.Color.White;
            this.btnDecrypt.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecrypt.Location = new System.Drawing.Point(200, 123);
            this.btnDecrypt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(190, 32);
            this.btnDecrypt.TabIndex = 22;
            this.btnDecrypt.Text = "DECRYPT ";
            this.btnDecrypt.UseVisualStyleBackColor = false;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.AutoSize = true;
            this.lbl_UserName.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserName.Location = new System.Drawing.Point(16, 73);
            this.lbl_UserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(112, 18);
            this.lbl_UserName.TabIndex = 19;
            this.lbl_UserName.Text = "Encrypted Text:";
            // 
            // txtUserName2
            // 
            this.txtUserName2.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName2.Location = new System.Drawing.Point(132, 70);
            this.txtUserName2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUserName2.Name = "txtUserName2";
            this.txtUserName2.Size = new System.Drawing.Size(134, 23);
            this.txtUserName2.TabIndex = 0;
            this.txtUserName2.TextChanged += new System.EventHandler(this.txtUserName2_TextChanged);
            // 
            // pb_CopyEnUser2
            // 
            this.pb_CopyEnUser2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_CopyEnUser2.Image = global::SecurityDesktopApp.Properties.Resources.CopyIcon2;
            this.pb_CopyEnUser2.Location = new System.Drawing.Point(553, 65);
            this.pb_CopyEnUser2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pb_CopyEnUser2.Name = "pb_CopyEnUser2";
            this.pb_CopyEnUser2.Size = new System.Drawing.Size(27, 24);
            this.pb_CopyEnUser2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_CopyEnUser2.TabIndex = 29;
            this.pb_CopyEnUser2.TabStop = false;
            this.pb_CopyEnUser2.Click += new System.EventHandler(this.pb_CopyEnUser2_Click);
            // 
            // DecryptForm
            // 
            this.AcceptButton = this.btnDecrypt;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 241);
            this.Controls.Add(this.pb_CopyEnUser2);
            this.Controls.Add(this.btnEncryptionForm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEncryptedUser2);
            this.Controls.Add(this.btnClearValues2);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.lbl_UserName);
            this.Controls.Add(this.txtUserName2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DecryptForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DecryptionForm";
            ((System.ComponentModel.ISupportInitialize)(this.pb_CopyEnUser2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEncryptionForm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEncryptedUser2;
        private System.Windows.Forms.Button btnClearValues2;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Label lbl_UserName;
        private System.Windows.Forms.TextBox txtUserName2;
        private System.Windows.Forms.PictureBox pb_CopyEnUser2;
    }
}