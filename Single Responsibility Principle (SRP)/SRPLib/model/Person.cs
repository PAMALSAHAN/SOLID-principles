using System;

namespace SRPLib.model
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }  

        
        public DateTime Birthday { get; set; }

        public static void hellowWorld(){
            Console.WriteLine("this is from person");
        }

    }
}