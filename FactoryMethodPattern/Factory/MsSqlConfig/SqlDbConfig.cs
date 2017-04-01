using FactoryMethodPattern.Factory.Common;
using System;
using System.Collections.Generic;

namespace FactoryMethodPattern.Factory.MsSqlConfig
{
    public class SqlDbConfig : IConfig
    {
        public string ConnectionParam
        {
            get;set;
        }

        public string Read<T>(T key)
        {
            throw new NotImplementedException();
        }

        public void Write<K,V>(KeyValuePair<K,V> pair)
        {
            throw new NotImplementedException();
        }
    }
}
