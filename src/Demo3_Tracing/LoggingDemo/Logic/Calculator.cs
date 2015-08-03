using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace LoggingDemo.Logic
{
    public class Calculator: ICalculator
    {
        public void Start()
        {
            Console.WriteLine("Calculating something");
            Console.WriteLine("Found result");
        }
    }
}
