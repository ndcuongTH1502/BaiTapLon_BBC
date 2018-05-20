﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTAT_BTLon
{
    internal class AESEncrypt
    {
        private static int IVLength = 16;

        public static byte[] AES_Encrypt(byte[] bytesToBeEncrypted, byte[] passwordBytes)
        {
            byte[] encryptedBytes = null;
            byte[] encryptedBytesAndIV = null;
            byte[] saltBytes = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            using (System.IO.MemoryStream ms = new System.IO.MemoryStream())
            {
                using (RijndaelManaged AES = new RijndaelManaged())
                {
                    AES.KeySize = 256;
                    //AES.BlockSize = 128;

                    var key = new Rfc2898DeriveBytes(passwordBytes, saltBytes, 100);
                    AES.Key = key.GetBytes(AES.KeySize / 8);
                    AES.IV = generateIV();

                    AES.Mode = CipherMode.CBC;
                    AES.Padding = PaddingMode.None;

                    using (var cs = new CryptoStream(ms, AES.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(bytesToBeEncrypted, 0, bytesToBeEncrypted.Length);
                        cs.Close();
                    }
                    encryptedBytes = ms.ToArray();
                    encryptedBytesAndIV = new byte[encryptedBytes.Length + AES.IV.Length];
                    AES.IV.CopyTo(encryptedBytesAndIV, 0);
                    encryptedBytes.CopyTo(encryptedBytesAndIV, IVLength);
                }
            }   return encryptedBytesAndIV;
        }

        public static byte[] AES_Decrypt(byte[] bytesToBeDecrypted, byte[] passwordBytes)
        {
            byte[] decryptedBytes = null;

            byte[] saltBytes = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };

            using (MemoryStream ms = new MemoryStream())
            {
                using (RijndaelManaged AES = new RijndaelManaged())
                {
                    AES.KeySize = 256;
                    AES.BlockSize = 128;

                    var key = new Rfc2898DeriveBytes(passwordBytes, saltBytes, 100);
                    AES.Key = key.GetBytes(AES.KeySize / 8);
                    AES.IV = getIV(bytesToBeDecrypted);
                    bytesToBeDecrypted = removeTagAndIV(bytesToBeDecrypted);
                    AES.Mode = CipherMode.CBC;
                    AES.Padding = PaddingMode.None;

                    using (var cs = new CryptoStream(ms, AES.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(bytesToBeDecrypted, 0, bytesToBeDecrypted.Length);
                        cs.Close();
                    }
                    decryptedBytes = ms.ToArray();
                }
            }
            return decryptedBytes;
        }

        

        private static byte[] removeTagAndIV(byte[] arr)
        {
            byte[] enc = new byte[arr.Length - IVLength];
            Array.Copy(arr, IVLength, enc, 0, arr.Length - IVLength);
            return enc;
        }
        private static byte[] getIV(byte[] arr)
        {
            byte[] IV = new byte[IVLength];
            Array.Copy(arr, 0, IV, 0, IVLength);
            return IV;
        }
        private static byte[] generateIV()
        {
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                byte[] nonce = new byte[IVLength];
                rng.GetBytes(nonce);
                return nonce;
            }
        }
        


        public string EncryptText(string input, string password, byte[] iv)
        {
            // Get the bytes of the string
            byte[] bytesToBeEncrypted = Encoding.UTF8.GetBytes(input);
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);

            // Hash the password with SHA256
            passwordBytes = SHA256.Create().ComputeHash(passwordBytes);

            byte[] bytesEncrypted = AES_Encrypt(bytesToBeEncrypted, passwordBytes);

            string result = Convert.ToBase64String(bytesEncrypted);

            return result;
        }
        public string DecryptText(string input, string password, byte[] iv)
        {
            // Get the bytes of the string
            byte[] bytesToBeDecrypted = Convert.FromBase64String(input);
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
            passwordBytes = SHA256.Create().ComputeHash(passwordBytes);

            byte[] bytesDecrypted = AES_Decrypt(bytesToBeDecrypted, passwordBytes);

            string result = Encoding.UTF8.GetString(bytesDecrypted);

            return result;
        }
    }
}
