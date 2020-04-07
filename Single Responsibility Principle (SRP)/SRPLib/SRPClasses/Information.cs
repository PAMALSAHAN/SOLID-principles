using System;
using System.Collections.Generic;
using SRPLib.model;

namespace SRPLib.SRPClasses
{
    public class Information
    {
        public static Person fillingInformation(IDictionary<string, string> validatePerson){

            Person p1=new Person();
            p1.FirstName=validatePerson["fname"];
            p1.LastName=validatePerson["sname"];
            p1.Age=int.Parse(validatePerson["age"]);
            p1.Birthday=DateTime.Parse(validatePerson["bday"]);

            return p1;
        }
    }
}