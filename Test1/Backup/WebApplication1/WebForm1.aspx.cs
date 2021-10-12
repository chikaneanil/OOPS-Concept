using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Security.Cryptography;
using System.Text;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private const string AesIV256 = @"!QAZ2WSX#EDC4RFV";
        private const string AesKey256 = @"5TGB&YHN7UJM(IK<5TGB&YHN7UJM(IK<";
        protected void Page_Load(object sender, EventArgs e)
        {
            string text = "Anil Chikane";
            string encrpttext = Encryption(text);
            string Final = Decrypt(encrpttext);
            Console.WriteLine(Final);
        }

        private string Encryption(string text)
        {
            try
            {
                AesCryptoServiceProvider aes = new AesCryptoServiceProvider();
                aes.BlockSize = 128;
                aes.KeySize = 256;
                aes.IV = System.Text.Encoding.UTF8.GetBytes(AesIV256);
                aes.Key = System.Text.Encoding.UTF8.GetBytes(AesKey256);
                aes.Mode = CipherMode.CBC;
                aes.Padding = PaddingMode.PKCS7;

                byte[] src = Encoding.Unicode.GetBytes(text);

                using (ICryptoTransform encrypt = aes.CreateEncryptor())
                {
                    byte[] dest = encrypt.TransformFinalBlock(src, 0, src.Length);
                    return Convert.ToBase64String(dest);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private string Decrypt(string encrpttext)
        {
            try
            {
                AesCryptoServiceProvider aes = new AesCryptoServiceProvider();
                aes.BlockSize = 128;
                aes.KeySize = 256;
                aes.IV = System.Text.Encoding.UTF8.GetBytes(AesIV256);
                aes.Key = System.Text.Encoding.UTF8.GetBytes(AesKey256);
                aes.Mode = CipherMode.CBC;
                aes.Padding = PaddingMode.PKCS7;

                byte[] src = System.Convert.FromBase64String(encrpttext);

                using (ICryptoTransform decrypt = aes.CreateDecryptor())
                {
                    byte[] dest = decrypt.TransformFinalBlock(src, 0, src.Length);
                    return Encoding.Unicode.GetString(dest);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}