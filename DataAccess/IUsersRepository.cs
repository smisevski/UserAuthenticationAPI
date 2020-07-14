using System;
using UserAuthenticationAPI.Models;
using UserAuthenticationAPI.DataAccess.RepositoryBase;

namespace UserAuthenticationAPI.DataAccess
{
    public interface IUsersRepository : IRepositoryBase<User>
    {
        bool CheckUserStatus(Guid Id);
        void UpdateUserStatus(Guid Id);
    }
}