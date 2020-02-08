using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NoteBook.Models;

namespace NoteBook.Models
{
    public class SampleData
    {
        public static void Initialize(NoteContext context)
        {
            if (!context.Notes.Any())
            {
                context.Notes.AddRange(
                    new Note
                    {
                        Day = "Monday",
                        Task = "Read",
                        Time = 10
                    },
                    new Note
                    {
                        Day = "Tuesday",
                        Task = "Footbol",
                        Time = 11
                    },
                    new Note
                    {
                        Day = "Wednesday",
                        Task = "Game",
                        Time = 12
                    }
                ); ;
                context.SaveChanges();
            }
        }
    }
}
