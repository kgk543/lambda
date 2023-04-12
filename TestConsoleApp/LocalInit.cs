using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleApp
{
    internal class LocalInit
    {
        
        public void init()
        {
            //setup our DI
            var serviceProvider = new ServiceCollection()
                .AddScoped<ITest, TestService>()
                .BuildServiceProvider();

            var bar = serviceProvider.GetService<ITest>();
            bar.typing();
        }
    }
}
