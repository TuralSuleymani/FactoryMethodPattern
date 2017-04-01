using FactoryMethodPattern.Factory.Common;

namespace FactoryMethodPattern.Factory.MsSqlConfig
{
    public class SqlDbConfigurator : DbConfigurator
    {
        public override IConfig GetConfig()
        {
            return new SqlDbConfig();
        }
    }
}
