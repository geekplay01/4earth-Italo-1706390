using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using _4earth_Italo_1706390.Classes;

namespace _4earth_italo_1706390.classes
{
    public class CriarMd5: Login
    {
        public string RetornarMD5(string Senha)
        {
           using ( MD5 md5Hash = MD5.Create())
            {
                return RetonarHash(md5Hash, Senha);
            }


            
        }
        public bool ComparaMD5(string senhabanco, string Senha_MD5)
        {
            using (MD5 md5Hash = MD5.Create())
            {
                var senha = RetornarMD5(senhabanco);
                if (VerificarHash(md5Hash, Senha_MD5, senha))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        private string RetonarHash(MD5 md5Hash, string input)
        {
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            StringBuilder sBuilder = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            return sBuilder.ToString();
        }

        private bool VerificarHash(MD5 md5Hash, string input, string hash)
        {
            StringComparer comparar = StringComparer.OrdinalIgnoreCase;

            if (0 == comparar.Compare(input, hash))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
