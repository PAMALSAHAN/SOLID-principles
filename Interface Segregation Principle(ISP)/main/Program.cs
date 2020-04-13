using System;
using main.ISPCorrect;


namespace main
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            IPrinterFull ipf=new LaserPrinter();
            ipf.Scan("pamal");
            

            IPrinter i=new InkJetPrinter();
            i.Print("sahan");
        }
    }
}
