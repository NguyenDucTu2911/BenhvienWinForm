using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace benhvien.model
{
    class BaoMat
    {
        public string GetHash(string plainText)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] inputstr = System.Text.Encoding.ASCII.GetBytes(plainText);
            byte[] Hash = md5.ComputeHash(inputstr);
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < Hash.Length; i++)
            {
                sBuilder.Append(Hash[i].ToString("x2"));
            }

            return sBuilder.ToString();
        }
        

    }
}
