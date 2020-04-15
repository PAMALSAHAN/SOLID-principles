using System;

namespace mainCorrect.model
{
    public class Logger :ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Console :{message}");
        }
    }
}