using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Security.Cryptography;
using Models.Models;
using System.Text.Json;

namespace Models.DataAccess
{
    public static class EncryptedFile
    {
        public static bool SaveContacts(Contacts data, string file, byte[] key)
        {
            Aes aes = Aes.Create(); //From Powerpoint
            aes.Key = key; //Used Notes demo to solve
            ICryptoTransform transform = aes.CreateEncryptor(); //From Powerpoint
            int lIV = aes.IV.Length; //Used Notes demo to solve
            byte[] LenIV = BitConverter.GetBytes(lIV); //Used Notes demo to solve

            using var outFs = new FileStream(file, FileMode.Create); //From Powerpoint
            {
                outFs.Write(LenIV, 0, 4); //Used Notes demo to solve
                outFs.Write(aes.IV, 0, lIV); //Used Notes demo to solve
                using var outStreamEncrypted =
                                   new CryptoStream(outFs, transform, CryptoStreamMode.Write); //From Powerpoint
                {
                    var options = new JsonSerializerOptions { IncludeFields = true };
                    JsonSerializer.Serialize(outStreamEncrypted, data, options);

                    outStreamEncrypted.FlushFinalBlock(); //Was included in the Note demo and seemed important

                    return true;
                }
            }
            return false;
        }

        public static Contacts OpenContacts(string file, byte[] key)
        {
            Aes aes = Aes.Create(); //From Powerpoint
            Contacts con = null;

            using var inFs = new FileStream(file, FileMode.Open); //From Powerpoint
            {
                //This block is from the Notes demo
                byte[] LenIV = new byte[4];
                inFs.Seek(0, SeekOrigin.Begin);
                inFs.Read(LenIV, 0, 3);
                int lenIV = BitConverter.ToInt32(LenIV, 0);
                int startC = lenIV + 4;
                int lenC = (int)inFs.Length - startC;
                byte[] IV = new byte[lenIV];
                inFs.Seek(4, SeekOrigin.Begin);
                inFs.Read(IV, 0, lenIV);
                ICryptoTransform transform = aes.CreateDecryptor(key, IV);
                //Block end

                using var cryptoStream =
                                 new CryptoStream(inFs, transform, CryptoStreamMode.Read); //From Powerpoint
                {
                    var options = new JsonSerializerOptions { IncludeFields = true };
                    
                    con = JsonSerializer.Deserialize<Contacts>(cryptoStream);
                }
            }
            return con;
        }
    }
}
