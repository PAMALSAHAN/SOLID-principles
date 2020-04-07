using System;
using System.Collections.Generic; // generic wala tama tinne

namespace SRPLib.SRPClasses
{
    public class Capturing
    {
       public static IDictionary<string, string> CaptureData(){
         //  List<string> personInfo=new List<string>();
           IDictionary<string, string> personInfo = new Dictionary<string, string>();
           Console.WriteLine("Enter your first name ");
            var fname=Console.ReadLine();
            personInfo.Add("fname",fname);


            Console.WriteLine("Enter your last name");
            var sname=Console.ReadLine();
            personInfo.Add("sname",sname);

            Console.WriteLine("Enter your age");
            var age=Console.ReadLine();
            personInfo.Add("age",age);

            Console.WriteLine("Enter your birthday");
            
            var bday=Console.ReadLine() ;
            personInfo.Add("bday",bday);

            return personInfo; // returning personInfo
       }
    }
}