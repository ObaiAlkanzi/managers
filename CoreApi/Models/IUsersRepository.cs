using AppModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApi.Models
{
    public interface IUsersRepository
    {
        Task<IEnumerable<Users>> GetUsers_repository();
        Task<Users> GetUserById_repository(int Id);
        Task<Users> AddUser_repository(Users user);
        Task<Users> EditUser_repository(Users user);
        Task<Users> DeleteUser_repository(int Id);
    }
}
