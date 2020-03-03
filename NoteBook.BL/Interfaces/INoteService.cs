using NoteBook.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace NoteBook.BL.Interfaces
{
    public  interface INoteService
    {

        List<NoteDTO>GetNotes(string SearchString);

        void CreateNote(NoteDTO dto);

        void EditNote(NoteDTO dto);

        void DeleteNote(int id);

        NoteDTO GetNote(int id);
        

    }
}
