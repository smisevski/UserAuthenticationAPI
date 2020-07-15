using System;
using Microsoft.AspNetCore.Mvc;
using UserAuthenticationAPI.Models;
using UserAuthenticationAPI.DataAccess;

namespace UserAuthenticationAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase 
    {
        private readonly UsersRepository _usersRepo;
        public UsersController(UsersRepository usersRepository)
        {
            this._usersRepo = usersRepository;
        }

        [HttpGet("all")]
        public IActionResult GetAllUsers()
        {
            return Ok(this._usersRepo.GetAll());
        }

        [HttpGet("{Id}")]
        public IActionResult GetUserById(Guid Id)
        {
            return Ok(this._usersRepo.GetById(Id));
        }

        [HttpGet("cond/{username}")]
        public IActionResult GetUserByUsername(string username)
        {
            return Ok(this._usersRepo.GetByCondition(x => x.Username == username));
        }

        [HttpPost("add")]
        public IActionResult AddUser(User user)
        {
            this._usersRepo.Add(user);

            return Ok(user);
        }

        [HttpPost("update")]
        public IActionResult UpdateUser(User user)
        {
            User userToUpdate = this._usersRepo.GetById(user.Id);

            if (userToUpdate != null)
            {
                this._usersRepo.Update(userToUpdate, user);
                return Ok(userToUpdate.Id);
            }
            else return NotFound(); 
            
        }

        [HttpPost("remove")]
        public IActionResult RemoveUser(User user)
        {       
            User userToDelete = this._usersRepo.GetById(user.Id);

            if (userToDelete != null)
            {
                this._usersRepo.Remove(userToDelete);
                return Ok(userToDelete.Id);
            }
            else return NotFound();
        }
    }
}