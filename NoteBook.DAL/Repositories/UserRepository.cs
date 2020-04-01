using AutoMapper;
using NoteBook.Common;
using NoteBook.DAL.EF;
using NoteBook.DAL.Entities;
using NoteBook.DAL.Interfaces;
using System.Linq;

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

        public  UserDTO FindUser(UserDTO dto)
        {
            return  _mapper.Map<UserDTO>( db.Users.FirstOrDefault(u => u.Email == dto.Email && u.Password == dto.Password));
        }

        public UserDTO FindUserByEmail(UserDTO dto)
        {
            return _mapper.Map<UserDTO>(db.Users.FirstOrDefault(u => u.Email == dto.Email));
        }

        public void AddUser(UserDTO dto)
        {
            db.Users.Add(_mapper.Map<User>(dto));
            db.SaveChanges();
        }

    }
}
