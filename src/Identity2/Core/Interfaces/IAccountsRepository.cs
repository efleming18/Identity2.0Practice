using System.Collections.Generic;
using Identity2.Core.Model;

namespace Identity2.Core.Interfaces
{
    public interface IAccountsRepository
    {
        IEnumerable<Account> GetAllAccounts();
    }
}