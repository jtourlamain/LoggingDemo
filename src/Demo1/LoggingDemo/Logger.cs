using System;

namespace LoggingDemo
{
    public class Logger:ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}