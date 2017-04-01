using FactoryMethodPattern.Factory.Common;
using System;
using System.Collections.Generic;
using System.IO;

namespace FactoryMethodPattern.Factory.IniConfig
{
    public class IniConfig : IConfig
    {
        public string ConnectionParam
        {
            get;set;
        }

        /// <summary>
        /// implementation simplified .must TODO:
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <returns></returns>
        public string Read<T>(T key)
        {
            string allData = File.ReadAllText(ConnectionParam);
            //here we will parse it... and then return
            //it's demonstration only..
            return allData;
        }

        /// <summary>
        /// implementation simplified. must TODO:
        /// </summary>
        /// <typeparam name="K"></typeparam>
        /// <typeparam name="V"></typeparam>
        /// <param name="pair"></param>
        public void Write<K,V>(KeyValuePair<K,V> pair)
        {
            //demonstration only...
            File.WriteAllText(ConnectionParam, String.Format("{0} = {1}", pair.Key, pair.Value));
        }
    }
}
