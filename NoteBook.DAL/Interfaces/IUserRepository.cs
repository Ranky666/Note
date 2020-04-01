﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using NoteBook.Common;

namespace NoteBook.DAL.Interfaces
{
    public interface IUserRepository
    {
        UserDTO FindUser(UserDTO dto);

        UserDTO FindUserByEmail(UserDTO dto);

        void AddUser(UserDTO dto);


    }
}
