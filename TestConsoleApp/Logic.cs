using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleApp
{
    internal class Logic
    {
       public ITest _test;
      public Logic(ITest test)
        {
            _test = test;
        }

        public void Run()
        {
            _test.typing();
        }
    }
}
