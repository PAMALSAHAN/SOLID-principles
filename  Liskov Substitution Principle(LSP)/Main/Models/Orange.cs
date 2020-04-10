using System;

namespace Main.Models
{
    public class Orange : IFruit
    {
        public override void GetColor()
        {
            Console.WriteLine("this is orange");
        }
    }
}