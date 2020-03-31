using System;
using System.Collections.Generic;
using System.Text;
using NoteBook.Common;

namespace NoteBook.BL.Interfaces
{
    public interface IUserService
    {

        void Login(UserDTO model);

        void Register(UserDTO model);

        void Authenticate(string userName);

        void Logout();



    }
}
