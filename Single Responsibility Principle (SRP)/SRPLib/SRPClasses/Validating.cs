using System;
using System.Collections.Generic;
using System.Linq; //use karanne count eka ganna
using System.Text.RegularExpressions;
using SRPLib.model;


namespace SRPLib.SRPClasses
{
    public class Validating
    {
        public static IDictionary<string, string> validateData(IDictionary<string, string> person)
        {

            if (person.ContainsKey("fname") == true)
            {
                //Regex.IsMatch(input, @"^[a-zA-Z0-9]+$"); number and letters
                if (!Regex.IsMatch(person["fname"], @"^[a-zA-Z]+$"))
                {
                    Console.WriteLine("You didn't give us a valid First Name!");
                    Console.WriteLine("Try Again");
                    StandardedMessages.endMessage(); //StandardedMessage class
                }
            }
            if (person.ContainsKey("sname") == true)
            {
                
                if (!Regex.IsMatch(person["sname"],@"^[a-zA-Z]+$"))

                {
                    Console.WriteLine("You didn't give us a valid Last Name!");
                    Console.WriteLine("Try Again");
                    StandardedMessages.endMessage(); //StandardedMessage class
                }
            }
            if (person.ContainsKey("age") == true)
            {   
                
                //int.TryParse(person["age"], out int age)
               
                if ((int.TryParse(person["age"], out int age)==false) || (person["age"].Count(c=>char.IsDigit(c)) >2)) // only numbers
                {
                    Console.WriteLine("You didn't give us a valid age!");
                    Console.WriteLine("Try Again");
                   
                    StandardedMessages.endMessage(); //StandardedMessage class
                    
                }
            }
            if (person.ContainsKey("bday") == true)
            {

                if (DateTime.TryParse(person["bday"], out DateTime Temp) == false)
                    {
                        Console.WriteLine("You didn't give us a valid Birthday!");
                        Console.WriteLine("Try Again");
                        StandardedMessages.endMessage(); //StandardedMessage class
                    }

            }

            return person;


        }
    }
}