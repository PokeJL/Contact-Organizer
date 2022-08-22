using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Models;
using System.Text.Json;

namespace Controller.DataAccess
{
    public static class JSONFile
    {
        //Day 2 notes used to produce code
        public static Contacts GetContacts(string path)
        {
            using FileStream fStream =
                new FileStream(path, FileMode.Open, FileAccess.Read);

            var options = new JsonSerializerOptions { IncludeFields = true, WriteIndented = true };
            Contacts contacts =
                JsonSerializer.Deserialize<Contacts>(fStream);


            return contacts;
        }
        public static bool SaveData(Object data, string path)
        {
            // create the file stream 
            using FileStream fStream =
                new FileStream(path, FileMode.Create, FileAccess.Write);

            var options = new JsonSerializerOptions { IncludeFields = true, WriteIndented = true };
            JsonSerializer.Serialize(fStream, data, options);

            return true;
        }
    }

    
}
