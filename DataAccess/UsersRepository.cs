using UserAuthenticationAPI.DataAccess.RepositoryBase;
using UserAuthenticationAPI.Models;

namespace UserAuthenticationAPI.DataAccess
{
    public class UsersRepository : RepositoryBase<User>
    {
        public RepositoryContext _userRepoCtx { get; set; }
        public UsersRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
            _userRepoCtx = repositoryContext;
        }

    }
}