using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggingDemo.Logic
{
    public class TracingCalculator: ICalculator
    {
        private readonly ICalculator _interceptor;

        public TracingCalculator(ICalculator interceptor)
        {
            _interceptor = interceptor;
        }

        public void Start()
        {
            Console.WriteLine("Start calculation");
            _interceptor.Start();
            Console.WriteLine("End calculation");
        }
    }
}
