using Ninject.Modules;
using Ninject.Test.ninApp;
using Ninject.Test.ninLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ninject.Test.ninBinding
{
    public class Bindings : NinjectModule
    {
        public override void Load()
        {
            Bind<ILog>().To<ConsoleLog>();
            Bind<IFormHandler>().To<FormHandler>();
        }
    }
}
