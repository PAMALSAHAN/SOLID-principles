using System;


namespace main.ISPCorrect
{
    public class InkJetPrinter : IPrinter
    {
        public void Print(string context)
        {
           Console.WriteLine("print this ISP correct");
        }

        public void Scan(string context)
        {
            Console.WriteLine("Scan this ISP correct");
        }
    }
}