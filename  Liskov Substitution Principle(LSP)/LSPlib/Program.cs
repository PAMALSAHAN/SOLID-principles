using System;

namespace LSPlib
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Hello World!");
          Manager manager =new Manager();
          manager.FirstName="pamal";
          manager.LastName="sahan";
          manager.CalculatePerHourRate(4);

          Employee employee=new Employee();
          employee.FirstName="chamath";
          employee.LastName="deshan";
          employee.AssignManager(manager);
          employee.CalculatePerHourRate(2);

          Console.WriteLine($"{employee.FirstName}'s salary is ${employee.Salary}/hour");

        
       
        
        

        }
    }
}
