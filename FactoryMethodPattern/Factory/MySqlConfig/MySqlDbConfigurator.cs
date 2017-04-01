using FactoryMethodPattern.Factory.Common;

namespace FactoryMethodPattern.Factory.MySqlDbConfig
{
    public class MySqlDbConfigurator : DbConfigurator
    {
        public override IConfig GetConfig()
        {
            return new MySqlDbConfig();
        }
    }
}
