using System.Data.Entity;
using Identity2.Core.Model;

namespace Identity2.Infrastructure.Data
{
    public class MainDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Account> Accounts { get; set; }

        public MainDbContext() : base("MainConnection")
        {
        }
    }
}