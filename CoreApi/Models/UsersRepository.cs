using AppModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApi.Models
{
    public class UsersRepository : IUsersRepository
    {
        private readonly AppDbContext context;
        public UsersRepository(AppDbContext context)
        {
            this.context = context;
        }

        public async Task<Users> AddUser_repository(Users user)
        {
            //adding user code
            var tmp = await context.DbUsers.AddAsync(user);
            await context.SaveChangesAsync();
            return tmp.Entity;
        }

        public async Task<Users> DeleteUser_repository(int Id)
        {
            Users tmp = await context.DbUsers.FirstOrDefaultAsync(c => c.Id == Id);
            context.DbUsers.Remove(tmp);
            await context.SaveChangesAsync();
            return tmp;
        }

        public async Task<Users> EditUser_repository(Users user)
        {
            var tmp = await context.DbUsers.FirstOrDefaultAsync(c => c.Id == user.Id);
            tmp.Name = user.Name;
            tmp.Password = user.Password;
            tmp.Email = user.Email;
            tmp.DepartId = user.DepartId;
            await context.SaveChangesAsync();
            return tmp;
        }

        public async Task<Users> GetUserById_repository(int Id)
        {
            return await context.DbUsers.FirstOrDefaultAsync(c => c.Id == Id);
        }

        public async Task<IEnumerable<Users>> GetUsers_repository()
        {
            return await context.DbUsers.ToListAsync();
        }
    }
}
