using System;
using UserAuthenticationAPI.Models;
using UserAuthenticationAPI.DataAccess.RepositoryBase;

namespace UserAuthenticationAPI.DataAccess
{
    public interface IUserRolesRepository : IRepositoryBase<UserRole>    {
         
    }
}