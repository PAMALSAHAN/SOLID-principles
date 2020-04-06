using System;
using SRPLib.model;
namespace Main
{
    public class MainWithAll
    {
         static void Main(string[] args)
        {
            Console.WriteLine("Welcome To My Application");
            Console.WriteLine("_________________________");


            Console.WriteLine("Enter your first name ");
            var fname=Console.ReadLine();

            Console.WriteLine("Enter your last name");
            var sname=Console.ReadLine();

            Console.WriteLine("Enter your age");
            var age=Console.ReadLine();

            Console.WriteLine("Enter your birthday");
            var bday=Console.ReadLine();


            Person p1=new Person();
            p1.FirstName=fname;
            p1.LastName=sname;
            p1.Age= Convert.ToInt32(age);
            p1.Birthday=Convert.ToDateTime(bday);

            if(string.IsNullOrWhiteSpace(p1.FirstName)){
                Console.WriteLine("You didn't give us a valid First Name!");
                Console.WriteLine("Try Again");
                Console.ReadLine();
            }
            if(string.IsNullOrWhiteSpace(p1.LastName)){
                Console.WriteLine("You didn't give us a valid Last Name!");
                Console.WriteLine("Try Again");
                Console.ReadLine();
            }
            if(p1.Age.Equals(null)){
                Console.WriteLine("You didn't give us a valid First Name!");
                Console.WriteLine("Try Again");
                Console.ReadLine();
            }
            if(IsValidDate)


            Console.WriteLine("Information");
            Console.WriteLine("_____________");

            Console.WriteLine("Your name :"+p1.FirstName+" "+p1.LastName);
            Console.WriteLine("Your age :"+p1.Age);
            Console.WriteLine("Your birthday :"+p1.Birthday.Date.ToString("d"));

            

        }
    }
}