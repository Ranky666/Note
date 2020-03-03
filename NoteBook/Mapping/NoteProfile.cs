using AutoMapper;
using NoteBook.Common;
using NoteBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace NoteBook.Mapping
{
    public class NoteProfile : Profile
    {
        public NoteProfile()
        {
            CreateMap<Note, NoteDTO>()
         .ForMember(x => x.Task, mo => mo.MapFrom(y => y.Task))
         .ForMember(x => x.Id, mo => mo.MapFrom(y => y.Id))
         .ReverseMap();
        }
    }
}

