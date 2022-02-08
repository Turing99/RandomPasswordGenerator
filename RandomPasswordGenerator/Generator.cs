using System;
using System.Security.Cryptography;
using System.Text;

namespace RandomPasswordGenerator
{
    public class Generator
    {
        private static readonly char[] chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!#$%'()*+`-./".ToCharArray();
        public static string Generate(int size)
        {
            byte[] data = new byte[size * 10];
            using (RNGCryptoServiceProvider cryptoProvider = new RNGCryptoServiceProvider())
                cryptoProvider.GetBytes(data);

            StringBuilder builder = new StringBuilder(size);

            for (int i = 0; i < size; i++)
            {
                long random = BitConverter.ToUInt32(data, i * 10) % chars.Length;
                builder.Append(chars[random]);
            }
            return builder.ToString();
        }
    }
}
