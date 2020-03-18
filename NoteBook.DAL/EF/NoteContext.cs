using Microsoft.EntityFrameworkCore;
using NoteBook.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NoteBook.DAL.EF
{
    public class NoteContext : DbContext
    {

       

        public DbSet<Note> Notes { get; set; }


        public NoteContext(DbContextOptions<NoteContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }


      

    }
}
