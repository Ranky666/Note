using NoteBook.DAL.EF;
using NoteBook.DAL.Interfaces;
using NoteBook.DAL.Entities;
using NoteBook.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using AutoMapper;

namespace NoteBook.DAL.Repositories
{
  public  class UserRepository : IUserRepository
    {


        private readonly NoteContext db;

        private readonly IMapper _mapper;


        public UserRepository(NoteContext context, IMapper mapper)
        {
            db = context;
            _mapper = mapper;
        }






    }
}
