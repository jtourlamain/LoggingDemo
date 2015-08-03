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
        private readonly ILogger _logger;

        public Calculator(ILogger logger)
        {
            _logger = logger;
        }

        public void Start()
        {
            _logger.Log("Start");
            Console.WriteLine("Found result");
            _logger.Log("End");
            
        }
    }
}
