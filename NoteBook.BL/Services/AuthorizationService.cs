using Microsoft.AspNetCore.Authentication.Cookies;
using NoteBook.BL.Interfaces;
using NoteBook.Common;
using NoteBook.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace NoteBook.BL.Services
{
    public class AuthorizationService : IAuthorizationService
    {

        private readonly IUserRepository _userRepository;
    

        public AuthorizationService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

       public UserDTO FindUser(UserDTO dto)
        {
            return _userRepository.FindUser(dto);

        }

        public UserDTO FindUserByEmail(UserDTO dto)
        {
            return _userRepository.FindUserByEmail(dto);

        }

        public void AddUser(UserDTO dto)
        {
            _userRepository.AddUser(dto);

        }

    }
}
