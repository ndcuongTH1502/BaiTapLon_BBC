using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;
using System;

namespace LTAT_BTLon
{
    public partial class Form1 : Form
    {
        byte[] IV, keyA, keyB;
        int i = 0;

        Diffie_Hellman A = new Diffie_Hellman(); //Bài làm vẫn chưa hoàn chỉnh!
        Diffie_Hellman B = new Diffie_Hellman(); //Còn nhiều sai sót!

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            txb_TextBoxShowA.Enabled = false;
            txb_TextBoxShowB.Enabled = false;

            if (string.IsNullOrEmpty(txb_PrivateKeyA.Text) && string.IsNullOrEmpty(txb_PrivateKeyB.Text))
            {
                btn_ASendText.Enabled = false;
                btn_BSendText.Enabled = false;
                btn_NoiseA.Enabled = false;
                btn_NoiseB.Enabled = false;
                txb_TextBoxA.Enabled = false;
                txb_TextBoxB.Enabled = false;
            }

            A.DiffieHellman();
            B.DiffieHellman();

            timer1.Interval = 1000;


        }
        //=======================================================================================================
                                                                                                 //SendKey Button
        private void btn_ASendKeyToB_Click(object sender, EventArgs e)
        {
            txb_PublicKeyB.Text = txb_PublicKeyA.Text;
        }
        private void btn_BSendKeyToA_Click(object sender, EventArgs e)
        {
            txb_PublicKeyA.Text = txb_PublicKeyB.Text;
        }
        //=======================================================================================================
                                                                                                     //Key Button
        private void btn_KeyA_Click(object sender, EventArgs e)
        {
            txb_PublicKeyA.Text = Convert.ToBase64String(A.PublicKey);                   //Public Key A (Minitor)
            txb_PublicKeyB.Text = Convert.ToBase64String(B.PublicKey);                   //Public Key B (Minitor)

            txb_PrivateKeyA.Text = Convert.ToBase64String(A.IV);                                  //Private Key A
            txb_PrivateKeyB.Text = Convert.ToBase64String(B.IV);                                  //Private Key B

            //txb_BoxB.Text = Convert.ToBase64String(Combine(B.PublicKey, B.IV));               
            //txb_BoxA.Text = Convert.ToBase64String(Combine(A.PublicKey, A.IV));                

            keyA = A.Key(B.PublicKey); //Common Key
            //string key2 = Encoding.ASCII.GetString(key).Substring(0, 32);
            string ssA = Convert.ToBase64String(keyA);
            txb_CommonKeyA.Text = ssA;

            keyB = B.Key(A.PublicKey); //Common Key
            //string key2 = Encoding.ASCII.GetString(key).Substring(0, 32);
            string ssB = Convert.ToBase64String(keyB);
            txb_CommonKeyB.Text = ssB;

            btn_ASendText.Enabled = true;
            btn_BSendText.Enabled = true;
            btn_NoiseA.Enabled = true;
            btn_NoiseB.Enabled = true;
            txb_TextBoxA.Enabled = true;
            txb_TextBoxB.Enabled = true;
        }
        private void btn_KeyB_Click(object sender, EventArgs e)
        {
            txb_PublicKeyB.Text = Convert.ToBase64String(B.PublicKey);                   //Public Key B (Minitor)
            txb_PublicKeyA.Text = Convert.ToBase64String(A.PublicKey);                   //Public Key A (Minitor)

            txb_PrivateKeyB.Text = Convert.ToBase64String(B.IV);                                  //Private Key B
            txb_PrivateKeyA.Text = Convert.ToBase64String(A.IV);                                  //Private Key A

            //txb_BoxA.Text = Convert.ToBase64String(Combine(A.PublicKey, A.IV));               
            //txb_BoxB.Text = Convert.ToBase64String(Combine(B.PublicKey, B.IV));               

            keyA = A.Key(B.PublicKey); //Common Key
            //string key2 = Encoding.ASCII.GetString(key).Substring(0, 32);
            string ssA = Convert.ToBase64String(keyA);
            txb_CommonKeyA.Text = ssA;

            keyB = B.Key(A.PublicKey); //Common Key
            //string key2 = Encoding.ASCII.GetString(key).Substring(0, 32);
            string ssB = Convert.ToBase64String(keyB);
            txb_CommonKeyB.Text = ssB;

            btn_ASendText.Enabled = true;
            btn_BSendText.Enabled = true;
            btn_NoiseA.Enabled = true;
            btn_NoiseB.Enabled = true;
            txb_TextBoxA.Enabled = true;
            txb_TextBoxB.Enabled = true;
        }
        //=======================================================================================================
                                                                                                    //Send Button
        private void btn_ASendText_Click(object sender, EventArgs e)
        {
            if (txb_TextBoxA.Text != string.Empty)
            {
                txb_TextBoxShowA.Text += Environment.NewLine + "A: " + txb_TextBoxA.Text;

                //Length Padding
                if (txb_TextBoxA.TextLength > 32)
                {   txb_LengthPaddingA.Text = "0";  }
                else
                {
                    int kq = 32 - txb_TextBoxA.TextLength;
                    MessageBox.Show("Do dai text Send: " + txb_TextBoxA.TextLength, "Test and Show");
                    txb_LengthPaddingA.Text = kq.ToString();
                }

                //MessageBox.Show("IV's Length :" + IV.Length, "Test and Show");
                //MessageBox.Show("Key's Length :" + keyA.Length, "Test and Show");

                //NOTE: Độ dài của TEXT không đủ 16bytes nhưng hàm Mã hóa vẫn hoạt động!
                //      Nó tự Padding!

                string MessSend = EncryptString(txb_TextBoxA.Text, keyA, IV); //Mã hóa và Gửi
                MessageBox.Show("Tin nhắn sau khi được mã hóa: " + MessSend, "Test and Show");

                string MessReceive = DecryptString(MessSend, keyB, IV); //Nhận và Giải mã
                txb_TextBoxShowB.Text += Environment.NewLine + "A: " + MessReceive;

                txb_TextBoxA.Text = ""; //Xoa tn o khung SEND khi tn da gui thanh cong.
            }
            timer1.Start();
        }
        private void btn_BSendText_Click(object sender, EventArgs e)
        {
            if (txb_TextBoxB.Text != string.Empty)
            {
                txb_TextBoxShowB.Text += Environment.NewLine + "B: " + txb_TextBoxB.Text;

                if (txb_TextBoxB.TextLength > 32)
                {   txb_LengthPaddingB.Text = "0";  }
                else
                {
                    int kq = 32 - txb_TextBoxB.TextLength;
                    MessageBox.Show(txb_TextBoxA.TextLength + kq + "");
                    txb_LengthPaddingB.Text = kq.ToString();
                }

                //MessageBox.Show("IV's Length :" + IV.Length);
                //MessageBox.Show("Key's Length :" + keyA.Length);

                string MessSend = EncryptString(txb_TextBoxB.Text, keyB, IV); //Mã hóa và Gửi
                MessageBox.Show("Tin nhắn sau khi được mã hóa: " + MessSend, "Test and Show");

                string MessReceive = DecryptString(MessSend, keyA, IV); //Nhận và Giải mã
                txb_TextBoxShowA.Text += Environment.NewLine + "B: " + MessReceive;

                txb_TextBoxB.Text = ""; //Xoa tn o khung SEND khi tn da gui thanh cong.
            }
            timer1.Start();
        }
        //=======================================================================================================
                                                                                                    //Hash Button
        private void btn_HashA_Click(object sender, EventArgs e)
        {
            string hashDateTime = MD5Hash(DateTime.Now.ToString());

            txb_ivA.Text = hashDateTime; //IV A
            txb_ivA.Text = txb_ivA.Text.Substring(0, 16);

            txb_PaddingA.Text = hashDateTime; //Padding A
            txb_PaddingA.Text = txb_PaddingA.Text.Substring(0, 16);

            IV = Encoding.ASCII.GetBytes(txb_ivA.Text);

            MessageBox.Show("IV's Length :" + IV.Length, "Test and Show");
            MessageBox.Show("Key's Length :" + keyA.Length, "Test and Show");


        }
        private void btn_HashB_Click(object sender, EventArgs e)
        {
            string hashDateTime = MD5Hash(DateTime.Now.ToString());

            txb_ivB.Text = hashDateTime; //IV B
            txb_ivB.Text = txb_ivB.Text.Substring(0, 16);

            IV = Encoding.ASCII.GetBytes(txb_ivB.Text);
        }
        //=======================================================================================================
                                                                                                   //Noise Button
        private void btn_NoiseA_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            string data = null;
            byte[] key;

            if (txb_TextBoxA.Text != string.Empty)
            {
                txb_TextBoxShowA.Text += Environment.NewLine + "A: " + txb_TextBoxA.Text;


                key = Combine(Combine(B.PublicKey, B.IV), A.IV);
                string key2 = Encoding.ASCII.GetString(key).Substring(0, 32);
                key = Encoding.ASCII.GetBytes(key2);

                if (txb_TextBoxA.TextLength < 32)
                {
                    data = txb_TextBoxA.Text;
                    for (int x = 0; x < 16; x++)
                    {
                        data += txb_PaddingA.Text;
                    }
                }

                string MessSend = EncryptString(data, key, IV); //Mã hóa và Gửi

                string MessReceive = DecryptString(data, key, IV); //Nhận và Giải mã
                txb_TextBoxShowB.Text += Environment.NewLine + "A: " + MessReceive;

                txb_TextBoxA.Text = "";

                if (txb_TextBoxA.TextLength > 32)
                {
                    txb_LengthPaddingA.Text = "0";
                }
                else { int kq = 32 - txb_TextBoxA.TextLength; txb_LengthPaddingA.Text = kq.ToString(); }

                timer1.Start();

                //Noise
                string SendNoise = MD5Hash(MessSend) + rd.Next(0, 10);

                if (SendNoise != MD5Hash(MessSend)) { MessageBox.Show("The Message have been changed!", "Notices!"); }
            }

        }
        private void btn_NoiseB_Click(object sender, EventArgs e)
        {

        }
        //=======================================================================================================
                                                                                                //Supports Method
        public static byte[] Combine(byte[] first, byte[] second)
        {
            byte[] ret = new byte[first.Length + second.Length];
            Buffer.BlockCopy(first, 0, ret, 0, first.Length);
            Buffer.BlockCopy(second, 0, ret, first.Length, second.Length);
            return ret;
        }                                //Combine Key
        public static string MD5Hash(string input)
        {
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }
            return hash.ToString();
        }                                               //Hash Method
        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;

            lbl_TimeA.Text = i + "(s)";
            if (i == 10)
            {
                timer1.Stop(); i = 0;
                MessageBox.Show("Time Over! Press Key Again!", "Notices!");
                btn_ASendText.Enabled = false;
                btn_BSendText.Enabled = false;
                btn_NoiseA.Enabled = false;
                btn_NoiseB.Enabled = false;
                txb_TextBoxA.Enabled = false;
                txb_TextBoxB.Enabled = false;
            }
        }                                           //Timer
        //=======================================================================================================
                                                                                                          //Trash
        private static string ToHexString(string asciiString)
        {
            string hex = "";
            foreach (char c in asciiString)
            {
                int tmp = c;
                hex += String.Format("{0:X2}", (uint)System.Convert.ToUInt32(tmp.ToString()));
            }
            return hex;
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        //=======================================================================================================
        //=======================================================================================================
                                                                                                 //AES_ECBEncrypt
        public string EncryptString(string plainText, byte[] key, byte[] iv)
        {
            // Instantiate a new Aes object to perform string symmetric encryption
            Aes encryptor = Aes.Create();

            encryptor.Mode = CipherMode.CBC;
            encryptor.KeySize = 256;
            encryptor.BlockSize = 128;
            encryptor.Padding = PaddingMode.Zeros;

            // Set key and IV
            encryptor.Key = key;
            encryptor.IV = iv;

            // Instantiate a new MemoryStream object to contain the encrypted bytes
            MemoryStream memoryStream = new MemoryStream();

            // Instantiate a new encryptor from our Aes object
            ICryptoTransform aesEncryptor = encryptor.CreateEncryptor();

            // Instantiate a new CryptoStream object to process the data and write it to the 
            // memory stream
            CryptoStream cryptoStream = new CryptoStream(memoryStream, aesEncryptor, CryptoStreamMode.Write);

            // Convert the plainText string into a byte array
            byte[] plainBytes = Encoding.ASCII.GetBytes(plainText);

            // Encrypt the input plaintext string
            cryptoStream.Write(plainBytes, 0, plainBytes.Length);

            // Complete the encryption process
            cryptoStream.FlushFinalBlock();

            // Convert the encrypted data from a MemoryStream to a byte array
            byte[] cipherBytes = memoryStream.ToArray();

            // Close both the MemoryStream and the CryptoStream
            memoryStream.Close();
            cryptoStream.Close();

            // Convert the encrypted byte array to a base64 encoded string
            string cipherText = Convert.ToBase64String(cipherBytes, 0, cipherBytes.Length);

            // Return the encrypted data as a string
            return cipherText;
        }
        public string DecryptString(string cipherText, byte[] key, byte[] iv)
        {
            // Instantiate a new Aes object to perform string symmetric encryption
            Aes encryptor = Aes.Create();

            encryptor.Mode = CipherMode.CBC;
            encryptor.KeySize = 256;
            encryptor.BlockSize = 128;
            encryptor.Padding = PaddingMode.Zeros;

            // Set key and IV
            encryptor.Key = key;
            encryptor.IV = iv;

            // Instantiate a new MemoryStream object to contain the encrypted bytes
            MemoryStream memoryStream = new MemoryStream();

            // Instantiate a new encryptor from our Aes object
            ICryptoTransform aesDecryptor = encryptor.CreateDecryptor();

            // Instantiate a new CryptoStream object to process the data and write it to the 
            // memory stream
            CryptoStream cryptoStream = new CryptoStream(memoryStream, aesDecryptor, CryptoStreamMode.Write);

            // Will contain decrypted plaintext
            string plainText = String.Empty;

            try
            {
                // Convert the ciphertext string into a byte array
                byte[] cipherBytes = Convert.FromBase64String(cipherText);

                // Decrypt the input ciphertext string
                cryptoStream.Write(cipherBytes, 0, cipherBytes.Length);

                // Complete the decryption process
                cryptoStream.FlushFinalBlock();

                // Convert the decrypted data from a MemoryStream to a byte array
                byte[] plainBytes = memoryStream.ToArray();

                // Convert the decrypted byte array to string
                plainText = Encoding.ASCII.GetString(plainBytes, 0, plainBytes.Length);
            }
            finally
            {
                // Close both the MemoryStream and the CryptoStream
                memoryStream.Close();
                cryptoStream.Close();
            }

            // Return the decrypted data as a string
            return plainText;
        }
        //=======================================================================================================
    }
}
