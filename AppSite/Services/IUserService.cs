using AppModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppSite.Services
{
    public interface IUserService
    {
        Task<Users> AddUserService(Users user);
        Task<IEnumerable<Users>> GetUsersService();
        Task<Users> GetUserByIdService(int Id);
        Task<Users> EditUserService(Users user);
        Task DeleteUserService(int Id);
    }
}
