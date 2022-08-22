using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Models;
using Microsoft.EntityFrameworkCore;

namespace Controller
{
    public class DB
    {
        private ContactsContext _context;
        public DB(string DBconnection)
        {
            _context = new ContactsContext() { ConnectionString = DBconnection };
        }

        public DbSet<Contact> Contacts { get => _context.Contacts; }

        public async Task<int> SaveChanges()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
