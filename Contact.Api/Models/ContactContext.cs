﻿using Microsoft.EntityFrameworkCore;

namespace Contact.Api.Models
{
    public class ContactContext : DbContext
    {
        public ContactContext(DbContextOptions<ContactContext> options) : base(options)
        {

        }

        public DbSet<Contact> Contacts { get; set; }
    }
}
