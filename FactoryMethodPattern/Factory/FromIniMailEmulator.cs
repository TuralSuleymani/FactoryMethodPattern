using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethodPattern.Factory.Common;

namespace FactoryMethodPattern.Factory
{
    public class FromIniMailEmulator : MailEmulator
    {
        public override IConfig GetConfig()
        {
            return new IniConfig.IniConfigurator();
        }
    }
}
