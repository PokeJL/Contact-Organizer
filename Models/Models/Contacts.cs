using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Models.Models
{
    public class Contacts : BindingList<Contact>
    {
        public int GenerateID(BindingList<Contact> con)
        {
            int id = 0;
            if (con != null)
            {
                for (int i = 1; ; i++)
                {
                    if (con.Any(e => e.Id == i) == false)
                    {
                        id = i;
                        break;
                    }
                }
            }
            else
                id = 1;

            return id;
        }

        public Contacts SearchFName(BindingList<Contact> con, string search)
        {
            Contacts newContact = new Contacts();
            IEnumerable<Contact> query = from contact in con select contact;
            if (!string.IsNullOrEmpty(search))  // If there is a search term 
                query = from contact in query          // Modify the query to include the search term
                        where contact.Fname.ToLower() == search.ToLower()
                        select contact;
            foreach (var contact in query) newContact.Add(contact);
            return newContact;
        }

        public Contacts SearchFNameContains(BindingList<Contact> con, string search)
        {
            Contacts newContact = new Contacts();
            IEnumerable<Contact> query = from contact in con select contact;
            if (!string.IsNullOrEmpty(search))  // If there is a search term 
                query = from contact in query          // Modify the query to include the search term
                        where contact.Fname.ToLower().Contains(search.ToLower())
                        select contact;
            foreach (var contact in query) newContact.Add(contact);
            return newContact;
        }

        public Contacts SearchFNameStart(BindingList<Contact> con, string search)
        {
            Contacts newContact = new Contacts();
            IEnumerable<Contact> query = from contact in con select contact;
            if (!string.IsNullOrEmpty(search))  // If there is a search term 
                query = from contact in query          // Modify the query to include the search term
                        where contact.Fname.ToLower().StartsWith(search.ToLower())
                        select contact;
            foreach (var contact in query) newContact.Add(contact);
            return newContact;
        }

        public Contacts SearchFNameEnds(BindingList<Contact> con, string search)
        {
            Contacts newContact = new Contacts();
            IEnumerable<Contact> query = from contact in con select contact;
            if (!string.IsNullOrEmpty(search))  // If there is a search term 
                query = from contact in query          // Modify the query to include the search term
                        where contact.Fname.ToLower().EndsWith(search.ToLower())
                        select contact;
            foreach (var contact in query) newContact.Add(contact);
            return newContact;
        }

        public Contacts SearchLName(BindingList<Contact> con, string search)
        {
            Contacts newContact = new Contacts();
            IEnumerable<Contact> query = from contact in con select contact;
            if (!string.IsNullOrEmpty(search))  // If there is a search term 
                query = from contact in query          // Modify the query to include the search term
                        where contact.Lname.ToLower() == search.ToLower()
                        select contact;
            foreach (var contact in query) newContact.Add(contact);
            return newContact;
        }

        public Contacts SearchLNameContains(BindingList<Contact> con, string search)
        {
            Contacts newContact = new Contacts();
            IEnumerable<Contact> query = from contact in con select contact;
            if (!string.IsNullOrEmpty(search))  // If there is a search term 
                query = from contact in query          // Modify the query to include the search term
                        where contact.Lname.ToLower().Contains(search.ToLower())
                        select contact;
            foreach (var contact in query) newContact.Add(contact);
            return newContact;
        }

        public Contacts SearchLNameStart(BindingList<Contact> con, string search)
        {
            Contacts newContact = new Contacts();
            IEnumerable<Contact> query = from contact in con select contact;
            if (!string.IsNullOrEmpty(search))  // If there is a search term 
                query = from contact in query          // Modify the query to include the search term
                        where contact.Lname.ToLower().StartsWith(search.ToLower())
                        select contact;
            foreach (var contact in query) newContact.Add(contact);
            return newContact;
        }

        public Contacts SearchLNameEnds(BindingList<Contact> con, string search)
        {
            Contacts newContact = new Contacts();
            IEnumerable<Contact> query = from contact in con select contact;
            if (!string.IsNullOrEmpty(search))  // If there is a search term 
                query = from contact in query          // Modify the query to include the search term
                        where contact.Lname.ToLower().EndsWith(search.ToLower())
                        select contact;
            foreach (var contact in query) newContact.Add(contact);
            return newContact;
        }

        public Contacts SearchPhone(BindingList<Contact> con, string search)
        {
            Contacts newContact = new Contacts();
            IEnumerable<Contact> query = from contact in con select contact;
            if (!string.IsNullOrEmpty(search))  // If there is a search term 
                query = from contact in query          // Modify the query to include the search term
                        where contact.Phone == search
                        select contact;
            foreach (var contact in query) newContact.Add(contact);
            return newContact;
        }

        public Contacts SearchPhoneContains(BindingList<Contact> con, string search)
        {
            Contacts newContact = new Contacts();
            IEnumerable<Contact> query = from contact in con select contact;
            if (!string.IsNullOrEmpty(search))  // If there is a search term 
                query = from contact in query          // Modify the query to include the search term
                        where contact.Phone.Contains(search)
                        select contact;
            foreach (var contact in query) newContact.Add(contact);
            return newContact;
        }

        public Contacts SearchCity(BindingList<Contact> con, string search)
        {
            Contacts newContact = new Contacts();
            IEnumerable<Contact> query = from contact in con select contact;
            if (!string.IsNullOrEmpty(search))  // If there is a search term 
                query = from contact in query          // Modify the query to include the search term
                        where contact.City == search
                        select contact;
            foreach (var contact in query) newContact.Add(contact);
            return newContact;
        }

        public Contacts SearchProvince(BindingList<Contact> con, string search)
        {
            Contacts newContact = new Contacts();
            IEnumerable<Contact> query = from contact in con select contact;
            if (!string.IsNullOrEmpty(search))  // If there is a search term 
                query = from contact in query          // Modify the query to include the search term
                        where contact.Province == search
                        select contact;
            foreach (var contact in query) newContact.Add(contact);
            return newContact;
        }

        public Contacts SearchOrganization(BindingList<Contact> con, string search)
        {
            Contacts newContact = new Contacts();
            IEnumerable<Contact> query = from contact in con select contact;
            if (!string.IsNullOrEmpty(search))  // If there is a search term 
                query = from contact in query          // Modify the query to include the search term
                        where contact.Organization == search
                        select contact;
            foreach (var contact in query) newContact.Add(contact);
            return newContact;
        }

        public Contacts SearchNickname(BindingList<Contact> con, string search)
        {
            Contacts newContact = new Contacts();
            IEnumerable<Contact> query = from contact in con select contact;
            if (!string.IsNullOrEmpty(search))  // If there is a search term 
                query = from contact in query          // Modify the query to include the search term
                        where contact.Nickname.ToLower() == search.ToLower()
                        select contact;
            foreach (var contact in query) newContact.Add(contact);
            return newContact;
        }

        public Contacts SearchNicknameContains(BindingList<Contact> con, string search)
        {
            Contacts newContact = new Contacts();
            IEnumerable<Contact> query = from contact in con select contact;
            if (!string.IsNullOrEmpty(search))  // If there is a search term 
                query = from contact in query          // Modify the query to include the search term
                        where contact.Nickname.ToLower().Contains(search.ToLower())
                        select contact;
            foreach (var contact in query) newContact.Add(contact);
            return newContact;
        }

        public Contacts SearchNicknameStart(BindingList<Contact> con, string search)
        {
            Contacts newContact = new Contacts();
            IEnumerable<Contact> query = from contact in con select contact;
            if (!string.IsNullOrEmpty(search))  // If there is a search term 
                query = from contact in query          // Modify the query to include the search term
                        where contact.Nickname.ToLower().StartsWith(search.ToLower())
                        select contact;
            foreach (var contact in query) newContact.Add(contact);
            return newContact;
        }

        public Contacts SearchNicknameEnds(BindingList<Contact> con, string search)
        {
            Contacts newContact = new Contacts();
            IEnumerable<Contact> query = from contact in con select contact;
            if (!string.IsNullOrEmpty(search))  // If there is a search term 
                query = from contact in query          // Modify the query to include the search term
                        where contact.Fname.ToLower().EndsWith(search.ToLower())
                        select contact;
            foreach (var contact in query) newContact.Add(contact);
            return newContact;
        }

        public Contacts SortFNameAcc(BindingList<Contact> con)
        {
            Contacts newContact = new Contacts();
            Contacts tempContact = new Contacts();
            IEnumerable<Contact> query = from contact in con select contact;

            foreach (var contact in query) newContact.Add(contact);

            IEnumerable<Contact> orderedByFirstName = newContact.OrderBy(n => n.Fname);

            //newContact.Clear();
            foreach (var contact in orderedByFirstName) tempContact.Add(contact);

            return tempContact;
        }

        public Contacts SortFNameDec(BindingList<Contact> con)
        {
            Contacts newContact = new Contacts();
            Contacts tempContact = new Contacts();
            IEnumerable<Contact> query = from contact in con select contact;

            foreach (var contact in query) newContact.Add(contact);

            IEnumerable<Contact> orderedByFirstName = newContact.OrderBy(n => n.Fname).Reverse();

            foreach (var contact in orderedByFirstName) tempContact.Add(contact);

            return tempContact;
        }

        public Contacts SortLNameAcc(BindingList<Contact> con)
        {
            Contacts newContact = new Contacts();
            Contacts tempContact = new Contacts();
            IEnumerable<Contact> query = from contact in con select contact;

            foreach (var contact in query) newContact.Add(contact);

            IEnumerable<Contact> orderedByFirstName = newContact.OrderBy(n => n.Lname);

            //newContact.Clear();
            foreach (var contact in orderedByFirstName) tempContact.Add(contact);

            return tempContact;
        }

        public Contacts SortLNameDec(BindingList<Contact> con)
        {
            Contacts newContact = new Contacts();
            Contacts tempContact = new Contacts();
            IEnumerable<Contact> query = from contact in con select contact;

            foreach (var contact in query) newContact.Add(contact);

            IEnumerable<Contact> orderedByFirstName = newContact.OrderBy(n => n.Lname).Reverse();

            foreach (var contact in orderedByFirstName) tempContact.Add(contact);

            return tempContact;
        }
    }
}
