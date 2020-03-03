using AutoMapper;
using NoteBook.Common;
using NoteBook.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NoteBook.DAL.Mapping
{
   public class NoteProfile : Profile
    {
        public NoteProfile()
        {
            CreateMap<Note,NoteDTO >()
                 .ForMember(x => x.Task, mo => mo.MapFrom(y => y.Task))
                 .ForMember(x => x.Id, mo => mo.MapFrom(y => y.Id))
                 .ReverseMap();
        }
    }
}
