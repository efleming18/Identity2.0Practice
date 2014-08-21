using System.Collections.Generic;
using System.Linq;
using Identity2.Core.Interfaces;
using Identity2.Core.Model;

namespace Identity2.Infrastructure.Data
{
    public class AccountsRepository : IAccountsRepository
    {
        private MainDbContext db = new MainDbContext();

        public virtual IEnumerable<Account> GetAllAccounts()
        {
            return db.Accounts.ToList();
        }
    }
}
