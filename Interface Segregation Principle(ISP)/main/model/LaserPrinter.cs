using System;

namespace main.model
{
    public class LaserPrinter : IPrinterTasks
    {
        public void Fax(string context)
        {
            Console.WriteLine("Hellow this is Fax method ");
        }

        public void Print(string context)
        {
            Console.WriteLine("Hellow this is Fax Print ");
        }

        public void PrintDuplex(string context)
        {
            Console.WriteLine("Hellow this is Fax PrintDuplex ");
        }

        public void Scan(string context)
        {
            Console.WriteLine("Hellow this is Fax Scan ");
        }
    }
}