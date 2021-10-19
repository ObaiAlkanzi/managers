using AppModels;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace AppSite.Services
{
    public class UserService : IUserService
    {
        private readonly HttpClient httpClient;
        public UserService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public Task<Users> AddUserService(Users user)
        {
            throw new NotImplementedException();
        }

        public  Task<Users> DeleteUserService(int Id)
        {
            throw new NotImplementedException();
            //return await httpClient.DeleteAsync<Users>($"api/Users/{Id}");
        }

        public async Task<Users> EditUserService(Users user)
        {
            return await httpClient.PutJsonAsync<Users>("api/Users",user);
        }

        public async Task<Users> GetUserByIdService(int Id)
        {
            return await httpClient.GetJsonAsync<Users>($"api/Users/{Id}");
        }

        public async Task<IEnumerable<Users>> GetUsersService()
        {
            return await httpClient.GetJsonAsync<Users[]>("api/Users");
        }
    }
}
