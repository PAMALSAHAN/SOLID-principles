using System;

using SRPLib.model;
namespace Main
 {
    // public class MainWithAll
    // {
    //       static void Main(string[] args)
    //     {
    //         //Inital message 
    //         Console.WriteLine("Welcome To My Application");
    //         Console.WriteLine("_________________________");

    //         //message capture
    //         Console.WriteLine("Enter your first name ");
    //         var fname=Console.ReadLine();

    //         Console.WriteLine("Enter your last name");
    //         var sname=Console.ReadLine();

    //         Console.WriteLine("Enter your age");
    //         var age=Console.ReadLine();

    //         Console.WriteLine("Enter your birthday");
    //         DateTime? bday=new DateTime();
    //         bday=Convert.ToDateTime(Console.ReadLine()) ;

    //         //validations
    //         if(string.IsNullOrWhiteSpace(fname)){
    //             Console.WriteLine("You didn't give us a valid First Name!");
    //             Console.WriteLine("Try Again");
    //             Console.ReadLine();
    //         }
    //         if(string.IsNullOrWhiteSpace(sname)){
    //             Console.WriteLine("You didn't give us a valid Last Name!");
    //             Console.WriteLine("Try Again");
    //             Console.ReadLine();
    //         }
    //         if(age.Equals(null)){
    //             Console.WriteLine("You didn't give us a valid First Name!");
    //             Console.WriteLine("Try Again");
    //             Console.ReadLine();
    //         }
           
    //         if(bday.HasValue==false || string.IsNullOrEmpty(Convert.ToString(bday))==false){
    //             Console.WriteLine("You didn't give us a valid  birthday!");
    //             Console.WriteLine("Try Again");
    //             Console.ReadLine();
    //         }

    //         //object making and filling information
    //         Person p1=new Person();
    //         p1.FirstName=fname;
    //         p1.LastName=sname;
    //         p1.Age= Convert.ToInt32(age);
    //         p1.Birthday=(DateTime)bday;

    //         //showing results in cmd line
    //         Console.WriteLine("Information");
    //         Console.WriteLine("_____________");
    //         Console.WriteLine("Your name :"+p1.FirstName+" "+p1.LastName);
    //         Console.WriteLine("Your age :"+p1.Age);
    //         Console.WriteLine("Your birthday :"+p1.Birthday.Date.ToString("d"));
    //            Console.ReadLine();

    //     }
    // }

    
}