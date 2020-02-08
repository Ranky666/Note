using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace NoteBook.Models
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
