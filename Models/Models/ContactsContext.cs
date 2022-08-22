using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Models.Models
{
    public partial class ContactsContext : DbContext
    {
        public ContactsContext()
        {
        }

        public ContactsContext(DbContextOptions<ContactsContext> options)
            : base(options)
        {
        }
        public string? ConnectionString { get; set; } = null;
        public virtual DbSet<Contact> Contacts { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                //                optionsBuilder.UseSqlServer("Data Source=localhost\\SQLEXPRESS;Initial Catalog=ContactOrgDB; Integrated security=True");
                if (string.IsNullOrEmpty(ConnectionString)) // Check if there is no connection string 
                    throw new Exception("DB Connection string must be supplied.");

                optionsBuilder.UseSqlServer(ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
