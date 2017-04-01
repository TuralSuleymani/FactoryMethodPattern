using FactoryMethodPattern.Factory.Common;

namespace FactoryMethodPattern.Factory.JsonConfig
{
    public class JsonConfigurator : Configurator
    {
        public override IConfig GetConfig()
        {
            return new JsonConfig();
        }
    }
}
