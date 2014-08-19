using System.Data.Entity;
using Identity2.Core.Model;

namespace Identity2.Infrastructure.Data
{
    public class MainDbInitializer : DropCreateDatabaseIfModelChanges<MainDbContext>
    {
        protected override void Seed(MainDbContext context)
        {
            CreateInitialAccounts();
            base.Seed(context);
        }

        private void CreateInitialAccounts()
        {
            var db = new MainDbContext();
            db.Accounts.Add(new Account() {Name = "Acme"});
            db.SaveChanges();
        }
    }
}