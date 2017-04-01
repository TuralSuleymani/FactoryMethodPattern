using FactoryMethodPattern.Factory.Common;

namespace FactoryMethodPattern.Factory.IniConfig
{
    public class IniConfigurator : Configurator
    {
       
        public override IConfig GetConfig()
        {
            return new IniConfig();
        }
    }
}
