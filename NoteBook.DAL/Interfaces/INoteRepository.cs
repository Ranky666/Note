using NoteBook.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace NoteBook.DAL.Interfaces
{
    public interface INoteRepository
    {
        List<NoteDTO> GetNotes();
        void CreateNote(NoteDTO noteDto);
        void EditNote(NoteDTO noteDto);

        void DeleteNote(int id);
        NoteDTO FindNote(int id);
        
    }
}
