using System;
using main.model;

namespace main
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person=new Person(){
                FirstName="pamal",
                LastName="sahan",
                EmailAddress="p.s.jayawickrama@gmail.com",
                PhoneNumber="0782916090"
            };

            Chore chore=new Chore();
            chore.ChoreName="get trash";
            chore.Owner=person;
            chore.PerformedWork(3);
            chore.PerformedWork(1.3);
            chore.CompleteChore();
            
                    
        }
    }
}
