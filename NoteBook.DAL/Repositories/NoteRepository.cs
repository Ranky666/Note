using AutoMapper;
using NoteBook.Common;
using NoteBook.DAL.EF;
using NoteBook.DAL.Entities;
using NoteBook.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NoteBook.DAL.Repositories
{

   public class NoteRepository : INoteRepository
    {
        private readonly NoteContext db;
  
        private readonly IMapper _mapper;


        public NoteRepository(NoteContext context, IMapper mapper)
        {
            db = context;
            _mapper = mapper;
        }
        public List<NoteDTO>  GetNotes()
        {
            var models = db.Notes.ToList();
            return _mapper.Map<List<NoteDTO>>(models);

          
        }

        public void CreateNote(NoteDTO noteDto)
        {
            db.Notes.Add(new Note {Task = noteDto.Task});
            db.SaveChanges();
        }

        public void EditNote(NoteDTO dto)
        {
            Note note = db.Notes.FirstOrDefault(n => n.Id == dto.Id);
            if (note != null)
            {
                note.Task = dto.Task;
                db.Notes.Update(note);
                db.SaveChanges();
            }
        }


        public void DeleteNote(int id)
        {
            Note note = db.Notes.FirstOrDefault(n => n.Id == id);
            if (note != null)
            {
                db.Notes.Remove(note);
                db.SaveChanges();
            }
        }

        public NoteDTO FindNote(int id)
        {
            Note noteEntity = db.Notes.FirstOrDefault(p => p.Id == id);
            if (noteEntity != null)
                return new NoteDTO() { Task = noteEntity.Task };
            return null;
        }



      
    }
}
