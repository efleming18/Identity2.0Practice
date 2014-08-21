using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Identity2.Controllers;
using Identity2.Core.Model;
using NUnit.Framework;

namespace Identity2.Tests.AccountsControllerTests
{
    [TestFixture]
    public class IndexShould
    {
        private AccountsController _accountsController;

        [SetUp]
        public void SetUp()
        {
            //pass in repo
            _accountsController = new AccountsController(null);
        }

        [Test]
        public void ReturnAllAccountsAvailable()
        {
            var result = _accountsController.Index() as ViewResult;
            var accounts = result.Model as IQueryable<Account>;
            
            Assert.AreEqual(3, accounts.ToList().Count);
        }
    }
}