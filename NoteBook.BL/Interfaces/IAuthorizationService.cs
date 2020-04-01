using System;
using System.Collections.Generic;
using System.Text;
using NoteBook.Common;

namespace NoteBook.BL.Interfaces
{
    public interface IAuthorizationService
    {

        UserDTO FindUser(UserDTO dto);

        UserDTO FindUserByEmail(UserDTO dto);

        void AddUser(UserDTO dto);

    }
}
