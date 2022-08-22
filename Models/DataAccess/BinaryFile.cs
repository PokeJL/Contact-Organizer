using Models.Models;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using Controller;

namespace Models.Models
{
    public static  class BinaryFile
    {
        //Day 1 presentation used to make code
        public static Contacts GetContacts(string path)
        {
            Contacts contacts = new Contacts();

            using BinaryReader binaryIn =
                new BinaryReader(
                new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read));

            while (binaryIn.PeekChar() != -1)
            {
                Contact contact = new Contact();

                contact.Id = binaryIn.ReadInt32();
                contact.Fname = binaryIn.ReadString();
                contact.Lname = binaryIn.ReadString();
                contact.Nickname = binaryIn.ReadString();
                contact.Organization = binaryIn.ReadString();
                contact.Address = binaryIn.ReadString();
                contact.City = binaryIn.ReadString();
                contact.Province = binaryIn.ReadString();
                contact.Phone = binaryIn.ReadString();
                contact.Email = binaryIn.ReadString();
                contact.PostalCode = binaryIn.ReadString();
                contact.UpdatedOn = DateTime.FromBinary(binaryIn.ReadInt64());
                contact.CreatedOn = DateTime.FromBinary(binaryIn.ReadInt64());

                contacts.Add(contact);
            }

            return contacts;
        }

        public static bool SaveContacts(List<Contact> comment, string path)
        {
            using BinaryWriter binaryOut =
                new BinaryWriter(
                new FileStream(path, FileMode.Create, FileAccess.Write));

            for(int i = 0; i < comment.Count; i++)
            {
                binaryOut.Write(comment[i].Id);
                binaryOut.Write(comment[i].Fname);
                binaryOut.Write(comment[i].Lname);
                binaryOut.Write(comment[i].Nickname);
                binaryOut.Write(comment[i].Organization);
                binaryOut.Write(comment[i].Address);
                binaryOut.Write(comment[i].City);
                binaryOut.Write(comment[i].Province);
                binaryOut.Write(comment[i].Phone);
                binaryOut.Write(comment[i].Email);
                binaryOut.Write(comment[i].PostalCode);
                binaryOut.Write(comment[i].CreatedOn.Ticks);
                binaryOut.Write(comment[i].UpdatedOn.Ticks);
            }

            return true;
        }
    }
}
