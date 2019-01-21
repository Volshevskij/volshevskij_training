using BusinessLogic;
using DataAccess;
using StructureMap.Configuration.DSL;

namespace DI
{
    public class MainRegistry : Registry
    {
        public MainRegistry()
        {
            Scan(
                scan => {
                    scan.WithDefaultConventions();
                    scan.AssemblyContainingType<BLRegistry>();
                    scan.AssemblyContainingType<DARegistry>();
                    scan.LookForRegistries();
                });
        }
    }
}
