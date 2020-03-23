using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using NoteBook.Common;

namespace NoteBook.DAL.Interfaces
{
    public interface IUserRepository
    {
        void Login(UserDTO model);

        void Register(UserDTO model);

        void Authenticate(string userName);

        void Logout();



    }
}
