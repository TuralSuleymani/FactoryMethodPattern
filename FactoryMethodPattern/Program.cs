using FactoryMethodPattern.Factory.IniConfig;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IniConfigurator ini = new IniConfigurator();
            
            ini.Config = new IniConfig();
            ini.Config.ConnectionParam = "D:/file.ini";
            Dictionary<string, string> pairs = new Dictionary<string, string>();
            pairs.Add("Simon", "123423ewqd");
            ini.Insert(pairs);
            
           

        }
    }
}
