using DataAccessLayer;
using StructureMap.Configuration.DSL;

namespace BusinessLogic
{
    public class BLRegistry: Registry
    {
        public BLRegistry()
        {
            For<IBridge>().Use<Bridge>();

            Forward<ISqlServerAccess, SqlServerAccess>();
        }
    }
}
