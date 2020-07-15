using System;
using UserAuthenticationAPI.Models;
using UserAuthenticationAPI.DataAccess.RepositoryBase;

namespace UserAuthenticationAPI.DataAccess
{
    public class UserRolesRepository : RepositoryBase<UserRole>
    {
        RepositoryContext _userRoleRepoCtx { get; set; } 
        public UserRolesRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
            _userRoleRepoCtx = repositoryContext;
        }
    }
}