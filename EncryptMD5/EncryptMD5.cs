using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Security.Cryptography;
//using System.Text;

namespace EncryptMD5
{
    public class Md5Password
    {
        public static String GetMd5Pass(String pass)
        {
            Byte[] oldEnc;
            Byte[] newEnc;
            MD5 md;

            oldEnc = ASCIIEncoding.Default.GetBytes(pass);
            md = new MD5CryptoServiceProvider();
            newEnc = md.ComputeHash(oldEnc);
            return BitConverter.ToString(newEnc);

        }
    }
}
