using System;
using Microsoft.AspNetCore.Mvc;
using UserAuthenticationAPI.Models;
using UserAuthenticationAPI.DataAccess;

namespace UserAuthenticationAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserRolesController : ControllerBase
    {
        private readonly UserRolesRepository _userRolesRepo;

        public UserRolesController(UserRolesRepository userRolesRepository)
        {
            this._userRolesRepo = userRolesRepository;
        }

        [HttpGet("all")]
        public IActionResult GetAllUserRoles()
        {
            return Ok(this._userRolesRepo.GetAll());
        }

        [HttpGet("{Id}")]
        public IActionResult GetUserRoleById(Guid Id)
        {
            return Ok(this._userRolesRepo.GetById(Id));
        }

        [HttpGet("cond/{Name}")]
        public IActionResult GetUserRolesByName(string Name)
        {
            return Ok(this._userRolesRepo.GetByCondition(x => x.RoleName == Name));
        }

        [HttpPost("add")]
        public IActionResult AddUserRole(UserRole userRole)
        {
            this._userRolesRepo.Add(userRole);

            return Ok(userRole);
        }

        [HttpPost("update")]
        public IActionResult UpdateUserRole(UserRole userRole)
        {
            UserRole userRoleToUpdate = this._userRolesRepo.GetById(userRole.Id);

            if (userRoleToUpdate != null)
            {
                this._userRolesRepo.Update(userRoleToUpdate, userRole);
                return Ok(userRoleToUpdate.Id);
            }
            else return NotFound();
        }

        [HttpPost("remove")]
        public IActionResult RemoveUser(User user)
        {
            UserRole userRoleToDelete = this._userRolesRepo.GetById(user.Id);

            if (userRoleToDelete != null)
            {
                this._userRolesRepo.Remove(userRoleToDelete);
                return Ok(userRoleToDelete.Id);
            }
            else return NotFound();
        }
    }
}