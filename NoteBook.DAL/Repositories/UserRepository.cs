using NoteBook.DAL.EF;
using NoteBook.DAL.Interfaces;
using NoteBook.DAL.Entities;
using NoteBook.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using System.Threading.Tasks;
using NoteBook.Common;
using System.Web.Mvc;

namespace NoteBook.DAL.Repositories
{
    public class UserRepository : IUserRepository
    {


        private readonly NoteContext db;

        private readonly IMapper _mapper;


        public UserRepository(NoteContext context, IMapper mapper)
        {
            db = context;
            _mapper = mapper;
        }

    

        public void Login(UserDTO model)
        {
           
            db.Users.FirstOrDefaultAsync(u => u.Email == model.Email && u.Password == model.Password);
             
        }


        public void Register(UserDTO model)
        {

            db.Users.FirstOrDefaultAsync(u => u.Email == model.Email);

        }    

        public void Authenticate(string userName)
        {
        
        }

        public void Logout()
        {
            throw new NotImplementedException();
        }
    }
}
