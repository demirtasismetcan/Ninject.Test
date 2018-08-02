using Ninject.Test.ninLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ninject.Test.ninApp
{
    public class FormHandler : IFormHandler
    {
        private readonly ILog logger;

        public FormHandler(ILog logger)
        {
            this.logger = logger;
        }

        public void Handle(string message)
        {
            logger.Info(message);
        }
    }
}
