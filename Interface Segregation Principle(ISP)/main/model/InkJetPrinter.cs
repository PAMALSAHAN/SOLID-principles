using System;

namespace main.model
{
    public class InkJetPrinter : IPrinterTasks
    {
        public void Fax(string context)
        {
             throw new System.NotImplementedException();
        }

        public void Print(string context)
        {
           Console.WriteLine("Hellow this is Print method from InkjetPrinter ");
        }

        public void PrintDuplex(string context)
        {
            throw new System.NotImplementedException();
        }

        public void Scan(string context)
        {
            Console.WriteLine("Hellow this is Scan method from InkjetPrinter ");
        }
    }
}