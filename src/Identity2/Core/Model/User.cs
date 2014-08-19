using System.Collections.Generic;

namespace Identity2.Core.Model
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string IdentityUserId { get; set; }

        IList<Account> AccountsManaged { get; set; }

        public User()
        {
            AccountsManaged = new List<Account>();
        }
    }
}