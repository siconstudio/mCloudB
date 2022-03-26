using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;


namespace mCloudB.services.api
{
    internal class mCryptor
    {
        private byte[] iv;
        private byte[] key;
        public mCryptor(byte[] key, byte[] iv)
        {
            this.key = key;
            this.iv = iv;
        }
        public byte[] EncryptRJ128(byte[] input)
        {
            var encoding = new UTF8Encoding();
            byte[] encrypted;
            using (var rj = new RijndaelManaged())
            {
                try
                {
                    rj.Padding = PaddingMode.Zeros;
                    rj.Mode = CipherMode.CBC;
                    rj.KeySize = 128;
                    rj.BlockSize = 128;
                    rj.Key = key;
                    rj.IV = iv;
                    var ms = new MemoryStream();
                    var cs = new CryptoStream(ms, rj.CreateEncryptor(key, iv), CryptoStreamMode.Write);
                    var sr = new StreamWriter(cs);
                    sr.Write(input);
                    sr.Flush();
                    cs.FlushFinalBlock();
                    encrypted = ms.ToArray();
                }
                finally
                {
                    rj.Clear();
                }
            }
            return encrypted;
        }

        public String DecryptRJ128(byte[] input)
        {
            var sRet = "";
            var encoding = new UTF8Encoding();
            using (var rj = new RijndaelManaged())
            {
                try
                {
                    rj.Padding = PaddingMode.Zeros;
                    rj.Mode = CipherMode.CBC;
                    rj.KeySize = 128;
                    rj.BlockSize = 128;
                    rj.Key = key;
                    rj.IV = iv;
                    var ms = new MemoryStream(input);
                    var cs = new CryptoStream(ms, rj.CreateDecryptor(key, iv), CryptoStreamMode.Read);
                    var sr = new StreamReader(cs);
                    sRet = sr.ReadLine();
                }
                finally
                {
                    rj.Clear();
                }
            }
            return sRet;
        }
    }
}
