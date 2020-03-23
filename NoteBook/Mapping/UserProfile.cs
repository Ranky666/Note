using AutoMapper;
using NoteBook.Common;
using NoteBook.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoteBook.Mapping
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserDTO>()
                 .ForMember(x => x.Email, mo => mo.MapFrom(y => y.Email))
                 .ForMember(x => x.Id, mo => mo.MapFrom(y => y.Id))
                 .ForMember(x => x.Password, mo => mo.MapFrom(y => y.Password))
                 .ReverseMap();
        }
    }
}
