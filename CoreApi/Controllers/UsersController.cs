using AppModels;
using CoreApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUsersRepository repository;
        public UsersController(IUsersRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult> UsersAll()
        {
            try
            {
                return Ok(await repository.GetUsers_repository());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"interner server error  faild to execute get users Command");
            }
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Users>> GetUser(int Id)
        {
            try
            {
                var tmp = await repository.GetUserById_repository(Id);
                if (tmp == null)
                {
                    return NotFound($"No User with the Id {Id}");
                }
                return tmp;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,$"interner server error  faild to execute get user by id {Id} Command");
            }
        }

        [HttpPost]
        public async Task<ActionResult<Users>> AddUser(Users user)
        {
            try
            {
                var tmpData = await repository.AddUser_repository(user); 
                if(tmpData == null)
                {
                    return StatusCode(StatusCodes.Status400BadRequest,"Bad request for add new user");
                }
                return tmpData;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "error , Failed to add a user");
            }
        }

        [HttpPut]
        public async Task<ActionResult<Users>> EditUser(Users user)
        {
            try
            {
                var tmp = await repository.GetUserById_repository(user.Id);
                if (tmp == null)
                {
                    return StatusCode(StatusCodes.Status400BadRequest, "invalid user to update");
                }
                Users tmpUser = await repository.EditUser_repository(user);
                if(tmpUser == null)
                {
                    return StatusCode(StatusCodes.Status400BadRequest, "failed to update this user");
                }
                return tmpUser;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "error ,internal error to update the user");
            }
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<Users>> DeleteUser(int Id)
        {
            try
            {
                var tmp = await repository.GetUserById_repository(Id);
                if (tmp == null)
                {
                    return StatusCode(StatusCodes.Status400BadRequest, $"Bad request for Delete user {Id}");
                }
                var result = await repository.DeleteUser_repository(Id);
                if(result == null)
                {
                    return StatusCode(StatusCodes.Status400BadRequest, "failed to Delete this user");

                }
                return result;
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "error , internal error to Delete the user");
            }
        }
    }
}
