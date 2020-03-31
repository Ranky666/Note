using NoteBook.BL.Interfaces;
using NoteBook.Common;
using NoteBook.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NoteBook.BL.Services
{
    public  class NoteService : INoteService
    {
        private readonly INoteRepository _noteRepository;
        private IEnumerable<char> reversed;

        public NoteService(INoteRepository noteRepository)
        {
            _noteRepository = noteRepository;
        }
        public List<NoteDTO> GetNotes(string searchString)
        {

            var notes = _noteRepository.GetNotes();


            if (!String.IsNullOrEmpty(searchString))
            {
                notes = notes.Where(s => s.Task.Contains(searchString)).ToList();
            }

            return notes;
        }

        public void CreateNote(NoteDTO dto)
        {
            _noteRepository.CreateNote(dto);
        }

        public void EditNote(NoteDTO dto)
        {
            _noteRepository.EditNote(dto);
        }


        public void DeleteNote(int id)
        {
            _noteRepository.DeleteNote(id);
        }

        public NoteDTO GetNote(int id)
        {
           return _noteRepository.FindNote(id);


          
        }

        public void DuplicateNote(NoteDTO dto)
        {
            _noteRepository.CreateNote(dto);
        }

        public void DuplicateNoteThree(NoteDTO dto)
        {

            for (int i = 1; i <= 2; i++)
            {
                _noteRepository.CreateNote(dto);

            }

           

        }




    }

    
}
