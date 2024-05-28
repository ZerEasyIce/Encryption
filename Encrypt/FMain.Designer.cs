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
            this.txt_outputSalt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_Hashing = new System.Windows.Forms.Button();
            this.ccb_Hashing = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_outputHashing = new System.Windows.Forms.TextBox();
            this.btn_HashingSalt = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_outputHashaSalt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_inputHashSalt = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_Encrypt
            // 
            this.txt_Encrypt.Location = new System.Drawing.Point(6, 89);
            this.txt_Encrypt.Name = "txt_Encrypt";
            this.txt_Encrypt.Size = new System.Drawing.Size(237, 20);
            this.txt_Encrypt.TabIndex = 0;
            // 
            // txt_resEncrypt
            // 
            this.txt_resEncrypt.Location = new System.Drawing.Point(6, 133);
            this.txt_resEncrypt.Name = "txt_resEncrypt";
            this.txt_resEncrypt.Size = new System.Drawing.Size(237, 20);
            this.txt_resEncrypt.TabIndex = 2;
            // 
            // txt_resDecrypt
            // 
            this.txt_resDecrypt.Location = new System.Drawing.Point(6, 177);
            this.txt_resDecrypt.Name = "txt_resDecrypt";
            this.txt_resDecrypt.Size = new System.Drawing.Size(237, 20);
            this.txt_resDecrypt.TabIndex = 3;
            // 
            // btn_Encrypt
            // 
            this.btn_Encrypt.Location = new System.Drawing.Point(33, 213);
            this.btn_Encrypt.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.btn_Encrypt.Name = "btn_Encrypt";
            this.btn_Encrypt.Size = new System.Drawing.Size(75, 23);
            this.btn_Encrypt.TabIndex = 1;
            this.btn_Encrypt.Text = "Encrypt";
            this.btn_Encrypt.UseVisualStyleBackColor = true;
            this.btn_Encrypt.Click += new System.EventHandler(this.btn_Encrypt_Click);
            // 
            // btn_Decrypt
            // 
            this.btn_Decrypt.Location = new System.Drawing.Point(142, 213);
            this.btn_Decrypt.Margin = new System.Windows.Forms.Padding(3, 3, 30, 3);
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
            this.label1.Location = new System.Drawing.Point(6, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Input : Encryption";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Input : Hashing";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 117);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Output : Encrypt";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 161);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Output : Decrypt";
            // 
            // txt_Hashing
            // 
            this.txt_Hashing.Location = new System.Drawing.Point(6, 89);
            this.txt_Hashing.Name = "txt_Hashing";
            this.txt_Hashing.Size = new System.Drawing.Size(237, 20);
            this.txt_Hashing.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 26);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Select : Hashing";
            // 
            // txt_ResHash
            // 
            this.txt_ResHash.Location = new System.Drawing.Point(6, 133);
            this.txt_ResHash.Name = "txt_ResHash";
            this.txt_ResHash.Size = new System.Drawing.Size(237, 20);
            this.txt_ResHash.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 117);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Output : Hashing";
            // 
            // txt_KeyEncrypt
            // 
            this.txt_KeyEncrypt.Location = new System.Drawing.Point(6, 42);
            this.txt_KeyEncrypt.MaxLength = 16;
            this.txt_KeyEncrypt.Name = "txt_KeyEncrypt";
            this.txt_KeyEncrypt.Size = new System.Drawing.Size(237, 20);
            this.txt_KeyEncrypt.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 26);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "KEY: Encryption (16 Chars)";
            // 
            // txt_outputSalt
            // 
            this.txt_outputSalt.Location = new System.Drawing.Point(6, 177);
            this.txt_outputSalt.Name = "txt_outputSalt";
            this.txt_outputSalt.Size = new System.Drawing.Size(237, 20);
            this.txt_outputSalt.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 161);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Output : Salt";
            // 
            // btn_Hashing
            // 
            this.btn_Hashing.Location = new System.Drawing.Point(87, 213);
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
            "SHA-3 (Secure Hash Algorithm 3)"});
            this.ccb_Hashing.Location = new System.Drawing.Point(6, 42);
            this.ccb_Hashing.Name = "ccb_Hashing";
            this.ccb_Hashing.Size = new System.Drawing.Size(237, 21);
            this.ccb_Hashing.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_KeyEncrypt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_Encrypt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_resEncrypt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_resDecrypt);
            this.groupBox1.Controls.Add(this.btn_Decrypt);
            this.groupBox1.Controls.Add(this.btn_Encrypt);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 253);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Encryption";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_ResHash);
            this.groupBox2.Controls.Add(this.txt_Hashing);
            this.groupBox2.Controls.Add(this.btn_Hashing);
            this.groupBox2.Controls.Add(this.ccb_Hashing);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(268, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 253);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hashing";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txt_outputSalt);
            this.groupBox3.Controls.Add(this.txt_inputHashSalt);
            this.groupBox3.Controls.Add(this.txt_outputHashaSalt);
            this.groupBox3.Controls.Add(this.txt_outputHashing);
            this.groupBox3.Controls.Add(this.btn_HashingSalt);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Location = new System.Drawing.Point(524, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(250, 253);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hashing + Salt";
            // 
            // txt_outputHashing
            // 
            this.txt_outputHashing.Location = new System.Drawing.Point(6, 133);
            this.txt_outputHashing.Name = "txt_outputHashing";
            this.txt_outputHashing.Size = new System.Drawing.Size(237, 20);
            this.txt_outputHashing.TabIndex = 1;
            // 
            // btn_HashingSalt
            // 
            this.btn_HashingSalt.Location = new System.Drawing.Point(87, 213);
            this.btn_HashingSalt.Name = "btn_HashingSalt";
            this.btn_HashingSalt.Size = new System.Drawing.Size(75, 23);
            this.btn_HashingSalt.TabIndex = 1;
            this.btn_HashingSalt.Text = "Hashing";
            this.btn_HashingSalt.UseVisualStyleBackColor = true;
            this.btn_HashingSalt.Click += new System.EventHandler(this.btn_HashingSalt_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 117);
            this.label10.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Output : Hashing";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 71);
            this.label9.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Output : Hashing + Salt";
            // 
            // txt_outputHashaSalt
            // 
            this.txt_outputHashaSalt.Location = new System.Drawing.Point(6, 87);
            this.txt_outputHashaSalt.Name = "txt_outputHashaSalt";
            this.txt_outputHashaSalt.Size = new System.Drawing.Size(237, 20);
            this.txt_outputHashaSalt.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 26);
            this.label11.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Input : Hashing";
            // 
            // txt_inputHashSalt
            // 
            this.txt_inputHashSalt.Location = new System.Drawing.Point(6, 42);
            this.txt_inputHashSalt.Name = "txt_inputHashSalt";
            this.txt_inputHashSalt.Size = new System.Drawing.Size(237, 20);
            this.txt_inputHashSalt.TabIndex = 1;
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 281);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Encryption";
            this.Load += new System.EventHandler(this.FMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TextBox txt_outputSalt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_Hashing;
        private System.Windows.Forms.ComboBox ccb_Hashing;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_HashingSalt;
        private System.Windows.Forms.TextBox txt_outputHashing;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_inputHashSalt;
        private System.Windows.Forms.TextBox txt_outputHashaSalt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
    }
}

