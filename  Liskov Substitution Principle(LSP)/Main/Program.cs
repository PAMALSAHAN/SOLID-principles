﻿using System;
using Main.Models;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            IFruit apple=new Orange();
            apple.GetColor();
            apple=new Apple();
            apple.GetColor();
        }
    }
}
