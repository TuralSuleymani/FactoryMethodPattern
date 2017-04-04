using FactoryMethodPattern.Factory.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.Factory
{
   public abstract class MailEmulator
    {
        protected string mailTo;
        protected string mailData;
        protected virtual void Configurate()
        {
            mailTo = GetConfig().Read<string>("mailTo");
            mailData = GetConfig().Read<string>("maildata");
          
        }

        public virtual void Send()
        {
            //send infos from mailTo and mailData;
            throw new NotImplementedException();
        }


        public abstract IConfig GetConfig();
    }
}
