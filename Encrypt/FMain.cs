using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Encryption
{
    public partial class FMain : Form
    {
        //string encryptionKey;
        public FMain()
        {
            InitializeComponent();
        }
        private void FMain_Load(object sender, EventArgs e)
        {
            //encryptionKey = "SecretEncryptKey"; // Change this to your own secret key (16 chars) : รหัสลับของเรา 16 ตัวอักษร
            txt_KeyEncrypt.Text = "@AutoMotionWorks";
        }

        #region ### Encrypt ###
        private void btn_Encrypt_Click(object sender, EventArgs e)
        {
            string encryptedText = Encrypt(txt_Encrypt.Text, txt_KeyEncrypt.Text);
            txt_resEncrypt.Text = encryptedText;
        }
        public static string Encrypt(string text, string Key)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Encoding.UTF8.GetBytes(Key);
                aesAlg.IV = new byte[16]; // Initialization Vector (IV) should be, but for simplicty, we use a static IV.
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(text);
                        }
                    }
                    return Convert.ToBase64String(msEncrypt.ToArray());
                }
            }
        }
        #endregion

        #region ### Decrypt ###
        private void btn_Decrypt_Click(object sender, EventArgs e)
        {
            //string decryptedText = Decrypt(txt_Decrypt.Text, encryptionKey);
            string decryptedText = Decrypt(txt_resEncrypt.Text, txt_KeyEncrypt.Text);
            txt_resDecrypt.Text = decryptedText;
        }

        public static string Decrypt(string encryptedText, string Key)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Encoding.UTF8.GetBytes(Key);
                aesAlg.IV = new byte[16]; // Initialization Vector (IV) should be the same as used for encryption.
                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msDecrypt = new MemoryStream(Convert.FromBase64String(encryptedText)))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            return srDecrypt.ReadToEnd();
                        }
                    }
                }
            }
        }
        #endregion

        #region ### Hashing ###
        private void btn_Hashing_Click(object sender, EventArgs e)
        {
            string data = txt_Hashing.Text;
            string resHash = "";
            if (ccb_Hashing.SelectedIndex == 0)  // Hashing MD5
            {
                byte[] hashBytes = MD5.Create().ComputeHash(Encoding.UTF8.GetBytes(data));
                resHash = BitConverter.ToString(hashBytes).Replace("-", "");    // แปลงค่า Hashing เป็นค่า hexadecimal
            }
            else if (ccb_Hashing.SelectedIndex == 1)  // Hashing SHA-1
            {
                byte[] hashBytes = SHA1.Create().ComputeHash(Encoding.UTF8.GetBytes(data));
                resHash = BitConverter.ToString(hashBytes).Replace("-", "");
            }
            else if (ccb_Hashing.SelectedIndex == 2)  // Hashing SHA-256 ประเภท SHA-2
            {
                byte[] hashBytes = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(data));
                resHash = BitConverter.ToString(hashBytes).Replace("-", "");
            }
            else if (ccb_Hashing.SelectedIndex == 3)  // Hashing SHA-384 ประเภท SHA-2
            {
                byte[] hashBytes = SHA384.Create().ComputeHash(Encoding.UTF8.GetBytes(data));
                resHash = BitConverter.ToString(hashBytes).Replace("-", "");
            }
            else if (ccb_Hashing.SelectedIndex == 4)  // Hashing SHA-512
            {
                byte[] hashBytes = SHA512.Create().ComputeHash(Encoding.UTF8.GetBytes(data));
                resHash = BitConverter.ToString(hashBytes).Replace("-", "");
            }
            else if (ccb_Hashing.SelectedIndex == 5)  // Hashing SHA-3
            {
                MessageBox.Show("ต้องใช้ Library จากบุคคลที่ 3");
            }
            else
            {
                MessageBox.Show("กรุณาเลือกวิธีการ Hash");
            }
            txt_ResHash.Text = resHash;
        }
        #endregion

        #region ### Hashing + Salt ###
        private void btn_HashingSalt_Click(object sender, EventArgs e)
        {

        }

        private string HashingSalt()
        {
            // Salt
            byte[] salt = new byte[128 / 8];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }
            return $"{Convert.ToBase64String(salt)}";
        }
        private byte[] GenerateSalt()
        {
            using (var rng = new RNGCryptoServiceProvider())
            {
                byte[] salt = new byte[16]; // Adjust the size based on your security requirements
                rng.GetBytes(salt);
                return salt;
            }
        }

        #endregion
    }
}