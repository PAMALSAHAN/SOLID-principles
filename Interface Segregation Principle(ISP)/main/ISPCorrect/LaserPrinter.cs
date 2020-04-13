using System;


namespace main.ISPCorrect
{
    public class LaserPrinter : IPrinterFull
    {
        public void Fax(string context)
        {
            Console.WriteLine("fax this ISP correct");
        }

        public void Print(string context)
        {
           Console.WriteLine("print this ISP correct");
        }

        public void PrintDuplex(string context)
        {
            Console.WriteLine("printduplex this ISP correct");
        }

        public void Scan(string context)
        {
            Console.WriteLine("scan this ISP correct");
        }
    }
}