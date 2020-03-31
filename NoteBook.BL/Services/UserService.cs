using NoteBook.BL.Interfaces;
using NoteBook.Common;
using NoteBook.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NoteBook.BL.Services
{
    public class UserService :IUserService
    {

        private readonly IUserRepository _userRepository;
        private IEnumerable<char> reversed;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }



        public void Login(UserDTO model)
        {
            _userRepository.Login(model);
        }

        public void Logout()
        {
            throw new NotImplementedException();
        }

        public void Register(UserDTO model)
        {
            _userRepository.Register(model);
        }

        public void Authenticate(string userName)
        {
            _userRepository.Authenticate(userName);

        }
    }
}
