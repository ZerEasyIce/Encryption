namespace Encryption
{
    partial class FMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMain));
            this.txt_Encrypt = new System.Windows.Forms.TextBox();
            this.txt_resEncrypt = new System.Windows.Forms.TextBox();
            this.txt_resDecrypt = new System.Windows.Forms.TextBox();
            this.btn_Encrypt = new System.Windows.Forms.Button();
            this.btn_Decrypt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Hashing = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_ResHash = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_KeyEncrypt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Salt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_Hashing = new System.Windows.Forms.Button();
            this.ccb_Hashing = new System.Windows.Forms.ComboBox();
            this.txt_KeyHash = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_Encrypt
            // 
            this.txt_Encrypt.Location = new System.Drawing.Point(12, 46);
            this.txt_Encrypt.Name = "txt_Encrypt";
            this.txt_Encrypt.Size = new System.Drawing.Size(237, 20);
            this.txt_Encrypt.TabIndex = 0;
            // 
            // txt_resEncrypt
            // 
            this.txt_resEncrypt.Location = new System.Drawing.Point(12, 148);
            this.txt_resEncrypt.Name = "txt_resEncrypt";
            this.txt_resEncrypt.Size = new System.Drawing.Size(237, 20);
            this.txt_resEncrypt.TabIndex = 2;
            // 
            // txt_resDecrypt
            // 
            this.txt_resDecrypt.Location = new System.Drawing.Point(12, 199);
            this.txt_resDecrypt.Name = "txt_resDecrypt";
            this.txt_resDecrypt.Size = new System.Drawing.Size(237, 20);
            this.txt_resDecrypt.TabIndex = 3;
            // 
            // btn_Encrypt
            // 
            this.btn_Encrypt.Location = new System.Drawing.Point(27, 244);
            this.btn_Encrypt.Name = "btn_Encrypt";
            this.btn_Encrypt.Size = new System.Drawing.Size(75, 23);
            this.btn_Encrypt.TabIndex = 1;
            this.btn_Encrypt.Text = "Encrypt";
            this.btn_Encrypt.UseVisualStyleBackColor = true;
            this.btn_Encrypt.Click += new System.EventHandler(this.btn_Encrypt_Click);
            // 
            // btn_Decrypt
            // 
            this.btn_Decrypt.Location = new System.Drawing.Point(141, 244);
            this.btn_Decrypt.Name = "btn_Decrypt";
            this.btn_Decrypt.Size = new System.Drawing.Size(75, 23);
            this.btn_Decrypt.TabIndex = 1;
            this.btn_Decrypt.Text = "Decrypt";
            this.btn_Decrypt.UseVisualStyleBackColor = true;
            this.btn_Decrypt.Click += new System.EventHandler(this.btn_Decrypt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Input : Encryption";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Input : Hashing";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Output : Encrypt";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Output : Decrypt";
            // 
            // txt_Hashing
            // 
            this.txt_Hashing.Location = new System.Drawing.Point(281, 46);
            this.txt_Hashing.Name = "txt_Hashing";
            this.txt_Hashing.Size = new System.Drawing.Size(237, 20);
            this.txt_Hashing.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(278, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Select : Hashing";
            // 
            // txt_ResHash
            // 
            this.txt_ResHash.Location = new System.Drawing.Point(281, 148);
            this.txt_ResHash.Name = "txt_ResHash";
            this.txt_ResHash.Size = new System.Drawing.Size(237, 20);
            this.txt_ResHash.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(278, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Output : Hashing";
            // 
            // txt_KeyEncrypt
            // 
            this.txt_KeyEncrypt.Location = new System.Drawing.Point(12, 97);
            this.txt_KeyEncrypt.MaxLength = 16;
            this.txt_KeyEncrypt.Name = "txt_KeyEncrypt";
            this.txt_KeyEncrypt.Size = new System.Drawing.Size(237, 20);
            this.txt_KeyEncrypt.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "KEY: Encryption (16 Chars)";
            // 
            // txt_Salt
            // 
            this.txt_Salt.Location = new System.Drawing.Point(281, 199);
            this.txt_Salt.Name = "txt_Salt";
            this.txt_Salt.Size = new System.Drawing.Size(237, 20);
            this.txt_Salt.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(278, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Output : Salt";
            // 
            // btn_Hashing
            // 
            this.btn_Hashing.Location = new System.Drawing.Point(442, 244);
            this.btn_Hashing.Name = "btn_Hashing";
            this.btn_Hashing.Size = new System.Drawing.Size(75, 23);
            this.btn_Hashing.TabIndex = 1;
            this.btn_Hashing.Text = "Hashing";
            this.btn_Hashing.UseVisualStyleBackColor = true;
            this.btn_Hashing.Click += new System.EventHandler(this.btn_Hashing_Click);
            // 
            // ccb_Hashing
            // 
            this.ccb_Hashing.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ccb_Hashing.FormattingEnabled = true;
            this.ccb_Hashing.Items.AddRange(new object[] {
            "MD5 (Message Digest 5)",
            "SHA-1 (Secure Hash Algorithm 1)",
            "SHA-256 (Secure Hash Algorithm 2)",
            "SHA-384 (Secure Hash Algorithm 384)",
            "SHA-512 (Secure Hash Algorithm 512)",
            "SHA-3 (Secure Hash Algorithm 3)",
            "HMAC (Hash-based Message Authentication Code)"});
            this.ccb_Hashing.Location = new System.Drawing.Point(281, 97);
            this.ccb_Hashing.Name = "ccb_Hashing";
            this.ccb_Hashing.Size = new System.Drawing.Size(237, 21);
            this.ccb_Hashing.TabIndex = 4;
            this.ccb_Hashing.SelectedIndexChanged += new System.EventHandler(this.ccb_Hashing_SelectedIndexChanged);
            // 
            // txt_KeyHash
            // 
            this.txt_KeyHash.Enabled = false;
            this.txt_KeyHash.Location = new System.Drawing.Point(280, 245);
            this.txt_KeyHash.MaxLength = 16;
            this.txt_KeyHash.Name = "txt_KeyHash";
            this.txt_KeyHash.Size = new System.Drawing.Size(156, 20);
            this.txt_KeyHash.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(277, 229);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "KEY: Hashing (16 Chars)";
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 277);
            this.Controls.Add(this.ccb_Hashing);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Hashing);
            this.Controls.Add(this.btn_Decrypt);
            this.Controls.Add(this.btn_Encrypt);
            this.Controls.Add(this.txt_Salt);
            this.Controls.Add(this.txt_KeyEncrypt);
            this.Controls.Add(this.txt_resDecrypt);
            this.Controls.Add(this.txt_KeyHash);
            this.Controls.Add(this.txt_ResHash);
            this.Controls.Add(this.txt_Hashing);
            this.Controls.Add(this.txt_resEncrypt);
            this.Controls.Add(this.txt_Encrypt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Encryption";
            this.Load += new System.EventHandler(this.FMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Encrypt;
        private System.Windows.Forms.TextBox txt_resEncrypt;
        private System.Windows.Forms.TextBox txt_resDecrypt;
        private System.Windows.Forms.Button btn_Encrypt;
        private System.Windows.Forms.Button btn_Decrypt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Hashing;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_ResHash;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_KeyEncrypt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Salt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_Hashing;
        private System.Windows.Forms.ComboBox ccb_Hashing;
        private System.Windows.Forms.TextBox txt_KeyHash;
        private System.Windows.Forms.Label label9;
    }
}

