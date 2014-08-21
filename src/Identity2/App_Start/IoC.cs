using Identity2.Core.Interfaces;
using Identity2.Infrastructure.Data;
using StructureMap;
using StructureMap.Graph;

namespace Identity2
{
    public class IoC
    {
        public static IContainer Initialize()
        {
            ObjectFactory.Initialize(x =>
            {
                x.Scan(scan =>
                {
                    scan.TheCallingAssembly();
                    scan.WithDefaultConventions();
                });
                x.For<IAccountsRepository>().Use<AccountsRepository>();
            });
            return ObjectFactory.Container;
        }
    }
}