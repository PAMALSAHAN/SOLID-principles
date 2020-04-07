using System;
using SRPLib.model;

namespace SRPLib.SRPClasses
{
    public class Showing
    {
        public static void showingData(Person p){

             StandardedMessages.showInfoMessage(); //StandardedMessage class

            Console.WriteLine("Full Name :"+p.FirstName+" "+p.LastName);
            Console.WriteLine("Age :"+p.Age);
            Console.WriteLine("Birthday :"+p.Birthday);

            StandardedMessages.endMessage(); //standardMessage class
            
        }
    }
}