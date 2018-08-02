using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ninject.Test.ninLog
{
    public class Log : ILog
    {
        public void Info(string message)
        {
            Console.WriteLine(message);
        }
    }
}
