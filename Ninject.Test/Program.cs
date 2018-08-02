using Ninject.Test.ninApp;
using Ninject.Test.ninLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Ninject.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //use Bindings.cs for loading methods..
            var kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());
            var mailSender = kernel.Get<ILog>();

            var fh = new FormHandler(mailSender);
            fh.Handle("Using Ninject...");

            Console.ReadLine();
        }
    }
}
