using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql;
using UserAuthenticationAPI.Models;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace UserAuthenticationAPI.DataAccess.RepositoryBase
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions opt) : base(opt)
        {
            
        }

        public DbSet<User> Users {get; set;}
    }
}