using System.Collections.Generic;

namespace FactoryMethodPattern.Factory.Common
{
    /// <summary>
    /// Configuration for multiple containers
    /// Contaner can be DB,XML,JSON etc.
    /// </summary>
    public abstract class Configurator:IConfig
    {
        public string Read<T>(T key)
        {
           return Config.Read(key);
        }

        public abstract IConfig GetConfig();
        protected IConfig _config;

        public IConfig Config
        {
            set { _config = GetConfig(); }
            get { return _config == null ? _config = GetConfig() : _config; }
        }

        public string ConnectionParam
        {
            get;set;
        }

        public  void Write<K,V>(KeyValuePair<K,V> pair)
        {
            Config.Write(pair);
        }

        public void Insert<K,V>(Dictionary<K,V> pairs)
        {
            foreach (KeyValuePair<K,V> pair in pairs)
            {
                Config.Write(pair);
            }
        }

     
    }
}
