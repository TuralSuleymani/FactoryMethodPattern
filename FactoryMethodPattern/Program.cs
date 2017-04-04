using FactoryMethodPattern.Factory;
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
            FromIniMailEmulator fime = new Factory.FromIniMailEmulator();
            fime.Send();
            
        }
    }
}
