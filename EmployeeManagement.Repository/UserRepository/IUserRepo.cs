﻿using EmployeeManagement.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Repository.UserRepository
{
    public interface IUserRepo
    {
        Task<long> CreateUsers(Users user);
        Task<IEnumerable<Users>> GetAllUsers();
        Task<Users> GetUsersById(int id);
        Task<Users> GetUserByEmail(string email);
    }
}
