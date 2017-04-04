using System.Collections.Generic;

namespace FactoryMethodPattern.Factory.Common
{
    public interface IConfig
    {
        string Read<T>(T key);
        void Write<K,V>(KeyValuePair<K, V> pair);
        string ConnectionParam { get; set; }

    }
}
