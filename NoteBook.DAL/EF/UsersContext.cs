using Microsoft.EntityFrameworkCore;
using NoteBook.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NoteBook.DAL.EF
{
    class UsersContext
    {
        public class UserContext : DbContext
        {
            public DbSet<Note> Notes { get; set; }
            public UserContext(DbContextOptions<UserContext> options)
                : base(options)
            {
                Database.EnsureCreated();
            }
        }


    }
}
