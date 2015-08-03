using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoggingDemo.Logic;
using Microsoft.Practices.Unity;

namespace LoggingDemo.Host
{
    class Program
    {
        public static IUnityContainer Container;
        static void Main(string[] args)
        {
            Bootstrapper.Initialise();
            ICalculator calcEngine = Container.Resolve<ICalculator>();
            calcEngine.Start();
            Console.ReadLine();
        }
    }
}
