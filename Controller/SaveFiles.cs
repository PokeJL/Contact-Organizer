using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controller.DataAccess;
using Models.Models;

namespace Controller
{
    public class SaveFiles
    {
        //Save code modified from Note example
        public bool SaveFile(System.Collections.IList data, string file)
        {
            List<Contact> contacts = new List<Contact>();

            for (int i = 0; i < data.Count; i++)
                contacts.Add((Contact)data[i]);

            if (file.ToLower().EndsWith("json"))
            {
                return JSONFile.SaveData(contacts, file);
            }
            if (file.ToLower().EndsWith("xml"))
            {
                return XMLFile.SaveContacts(contacts, file);
            }
            if (file.ToLower().EndsWith("dat"))
            {
                return BinaryFile.SaveContacts(contacts, file);
            }
            return false;
        }
        public Contacts OpenFile(string file)
        {
            if (file.ToLower().EndsWith("json"))
            {
                return JSONFile.GetContacts(file);
            }
            if (file.ToLower().EndsWith("xml"))
            {
                return XMLFile.GetContacts(file);
            }
            if (file.ToLower().EndsWith("dat"))
            {
                return BinaryFile.GetContacts(file);
            }
            return null;
        }
    }
}
