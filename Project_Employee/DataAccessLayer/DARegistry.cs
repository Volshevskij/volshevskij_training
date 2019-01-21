using DataAccessLayer;
using StructureMap.Configuration.DSL;

namespace DataAccess
{
    public class DARegistry : Registry
    {
        public DARegistry()
        {
            For<ISqlServerAccess>().Use<SqlServerAccess>();
        }
    }
}
