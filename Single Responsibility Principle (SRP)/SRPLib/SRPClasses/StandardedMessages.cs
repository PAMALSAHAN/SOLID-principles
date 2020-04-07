using System;

namespace SRPLib.SRPClasses
{
    public class StandardedMessages
    {
        public static void startMessage(){
           // Inital message 
            Console.WriteLine("Welcome To My Application");
            Console.WriteLine("_________________________");
        }

        public static void endMessage(){
            //end message
            Console.WriteLine("_______________");
            Console.ReadLine();
            Environment.Exit(0); //close from the terminal
        }

        public static void showInfoMessage(){

            Console.WriteLine("Selected Person");
            Console.WriteLine("_______________");
        }
    }
}