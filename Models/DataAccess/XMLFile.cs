using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Models;
using System.Xml.Serialization;

namespace Controller.DataAccess
{
    public static class XMLFile
    {
        //Day 1 notes used to make code
        public static Contacts GetContacts(string path)
        {
            using StreamReader reader =
                new(new FileStream(path, FileMode.Open, FileAccess.Read));
 
            XmlSerializer mySerializer = new XmlSerializer(typeof(Contacts));

            Contacts contacts = (Contacts?)mySerializer.Deserialize(reader) ?? new Contacts();


            return contacts;
        }

        //Day 1 and 2 JSON notes used to make code
        public static bool SaveContacts(IList<Contact> contacts, string path)
        {
            using StreamWriter writter =
                new(new FileStream(path, FileMode.Create, FileAccess.Write));

            XmlSerializer mySerializer = new XmlSerializer(typeof(List<Contact>));

            mySerializer.Serialize(writter, contacts);

            return true;
        }
    }
}
