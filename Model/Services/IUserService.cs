﻿using Memorizer.DbModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Services
{
    public interface IUserService
    {
        Task AddUserAsync(User user);
        Task<User> GetUserAsync(int id);
        Task UpdateUserAsync(User user);
        Task DeleteUserAsync(int id);
    }
}
