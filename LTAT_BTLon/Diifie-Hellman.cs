using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LTAT_BTLon
{
    public class Diffie_Hellman : IDisposable
    {
        private Aes aes = null;
        private ECDiffieHellmanCng diffieHellman = null;
        private byte[] publicKey;

        public void DiffieHellman()
        {
            this.aes = new AesCryptoServiceProvider();
            this.diffieHellman = new ECDiffieHellmanCng
            {
                KeyDerivationFunction = ECDiffieHellmanKeyDerivationFunction.Hash,
                HashAlgorithm = CngAlgorithm.Sha256
            };
            // This is the public key we will send to the other party
            this.publicKey = this.diffieHellman.PublicKey.ToByteArray(); //PUBLIC KEY
        }
        //=======================================================================================================

        //=======================================================================================================
        public byte[] PublicKey
        {
            get
            {
                return this.publicKey;
            }
        }
        public byte[] IV
        {
            get
            {
                return this.aes.IV;
            }
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (this.aes != null)
                    this.aes.Dispose();

                if (this.diffieHellman != null)
                    this.diffieHellman.Dispose();
            }
        }

        //=======================================================================================================

        //=======================================================================================================
                                                                                   //Code Key Encrypt and Decrypt
        public byte[] Key(byte[] publicKey)
        {
            var key = CngKey.Import(publicKey, CngKeyBlobFormat.EccPublicBlob);
            var derivedKey = this.diffieHellman.DeriveKeyMaterial(key); //COMMON SECRET
            return derivedKey;
        }
        public byte[] Encrypt(byte[] publicKey, string secretMessage)
        {
            byte[] encryptedMessage;
            var key = CngKey.Import(publicKey, CngKeyBlobFormat.EccPublicBlob);
            var derivedKey = this.diffieHellman.DeriveKeyMaterial(key); //COMMON SECRET

            this.aes.Key = derivedKey;

            using (var cipherText = new MemoryStream())
            {
                using (var encryptor = this.aes.CreateEncryptor())
                {
                    using (var cryptoStream = new CryptoStream(cipherText, encryptor, CryptoStreamMode.Write))
                    {
                        byte[] ciphertextMessage = Encoding.UTF8.GetBytes(secretMessage);
                        cryptoStream.Write(ciphertextMessage, 0, ciphertextMessage.Length);
                    }
                }
                encryptedMessage = cipherText.ToArray();
            }   return encryptedMessage;
        }
        public string Decrypt(byte[] publicKey, byte[] encryptedMessage, byte[] iv)
        {
            string decryptedMessage;
            var key = CngKey.Import(publicKey, CngKeyBlobFormat.EccPublicBlob);
            var derivedKey = this.diffieHellman.DeriveKeyMaterial(key);

            this.aes.Key = derivedKey;
            this.aes.IV = iv;

            using (var plainText = new MemoryStream())
            {
                using (var decryptor = this.aes.CreateDecryptor())
                {
                    using (var cryptoStream = new CryptoStream(plainText, decryptor, CryptoStreamMode.Write))
                    {
                        cryptoStream.Write(encryptedMessage, 0, encryptedMessage.Length);
                    }
                }
                decryptedMessage = Encoding.UTF8.GetString(plainText.ToArray());
            }   return decryptedMessage;
        }
        //=======================================================================================================

        //=======================================================================================================
        //Example for Encrypt and Decrypt
        public void Encrypt_Decrypt()
        {
            string text = "Hello World!";

            using (var bob = new Diffie_Hellman()) //SERVER
            {
                using (var alice = new Diffie_Hellman()) 
                {
                    // Bob uses Alice's public key to encrypt his message.
                    byte[] secretMessage = bob.Encrypt(alice.PublicKey, text);

                    // Alice uses Bob's public key and IV to decrypt the secret message.
                    string decryptedMessage = alice.Decrypt(bob.PublicKey, secretMessage, bob.IV);
                }
            }
        }
    }
}
