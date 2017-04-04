using System.Collections.Generic;

namespace FactoryMethodPattern.Factory.Common
{
    /// <summary>
    /// Configuration for multiple containers
    /// Contaner can be DB,XML,JSON etc.
    /// </summary>
    public class Configurator
    {
        protected IConfig _config;
        public Configurator(IConfig conf)
        {
            this._config = conf;
        }
        public string Read<T>(T key)
        {
           return this._config.Read(key);
        }

        public string ConnectionParam
        {
            get;set;
        }

        public  void Write<K,V>(KeyValuePair<K,V> pair)
        {
            this._config.Write(pair);
        }

        public void Insert<K,V>(Dictionary<K,V> pairs)
        {
            foreach (KeyValuePair<K,V> pair in pairs)
            {
                this._config.Write(pair);
            }
        }

     
    }
}
