using System;

namespace Main.Models
{
    public abstract class IFruit
    {
       public abstract void GetColor();
    }

    public class Apple : IFruit
    {
        public override void GetColor()
        {
            Console.WriteLine("this is red");
        }
    }
}