using System;
using System.Collections.Generic;
using SRPLib.model;
using SRPLib.SRPClasses;
namespace Main
{
    public class MainWithSRP
    {
        static void Main(string[] args)
        {
            StandardedMessages.startMessage();  //StandardedMessage Class

            IDictionary<string, string> person= Capturing.CaptureData(); //Capturing Class capturing person data

            IDictionary<string, string> validatePerson= Validating.validateData(person); //Validating class 

            Person selectedPerson=Information.fillingInformation(validatePerson); //Information class

            Showing.showingData(selectedPerson);


           
            
                
            

           
        }
    }
}