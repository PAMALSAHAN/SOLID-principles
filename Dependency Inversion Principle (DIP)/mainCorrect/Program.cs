using System;
using mainCorrect.model;
namespace mainCorrect
{
    class Program
    {
        static void Main(string[] args)
        {
           IPerson person=Factory.CreatePerson();
                person.FirstName="pamal";
                person.LastName="sahan";
                person.EmailAddress="p.s.jayawickrama@gmail.com";
                person.PhoneNumber="0782916090";
            

            IChore chore=Factory.CreateChore();
            chore.ChoreName="get trash";
            chore.Owner=person;
            
            chore.PerformedWork(3);
            chore.PerformedWork(1.3);
            chore.CompleteChore();
            
                    
        }
    }
}
