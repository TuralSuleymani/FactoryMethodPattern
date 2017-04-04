using FactoryMethodPattern.Factory.Common;
using System.IO;
using System;
using System.Collections.Generic;

namespace FactoryMethodPattern.Factory.IniConfig
{
    public class IniConfigurator : IConfig
    {
        public string ConnectionParam
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public string Read<T>(T key)
        {
            throw new NotImplementedException();
        }

        public void Write<K, V>(KeyValuePair<K, V> pair)
        {
            throw new NotImplementedException();
        }
    }
}
