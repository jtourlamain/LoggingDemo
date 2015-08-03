using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoggingDemo.Logic;

namespace LoggingDemo.Host
{
    class Program
    {
        static void Main(string[] args)
        {
            ICalculator calcEngine = new Calculator(new Logger());
            calcEngine.Start();
            Console.ReadLine();
        }
    }
}
