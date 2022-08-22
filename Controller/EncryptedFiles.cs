using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Models;
using System.Security.Cryptography;
using Models.DataAccess;

namespace Controller
{
    public static class EncryptedFiles
    {
        public static bool SaveFile (Contacts data, string path, string password)
        {
            byte[] key = HashPasswordGen(password);
            return EncryptedFile.SaveContacts(data, path, key);
        }

        public static Contacts OpenFile(string path, string password)
        {
            byte[] key = HashPasswordGen(password);
            return EncryptedFile.OpenContacts(path, key);
        }

        //From Powerpoint
        public static byte[] HashPasswordGen(string password)
        {
            UnicodeEncoding ue = new UnicodeEncoding();

            byte[] messageBytes = ue.GetBytes(password);

            SHA256 shHash = SHA256.Create();

            return shHash.ComputeHash(messageBytes);
        }
    }
}
