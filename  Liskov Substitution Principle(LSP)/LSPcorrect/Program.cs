using System;
using LSPcorrect.model;
namespace LSPcorrect
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World! this is LSP correct lib");

            //   Manager manager =new Manager();
            //   manager.FirstName="pamal";
            //   manager.LastName="sahan";
            //   manager.CalculatePerHourRate(4);

            //   Employee employee=new Employee();
            //   employee.FirstName="chamath";
            //   employee.LastName="deshan";
            //   employee.AssignManager(manager);
            //   employee.CalculatePerHourRate(2);

            //   Console.WriteLine($"{employee.FirstName}'s salary is ${employee.Salary}/hour");

            // LSPcorrect.model. Manager manager =new Manager();
            // manager.FirstName="pamal";
            // manager.LastName="sahan";
            // manager.CalculatePerHourRate(4);

            BaseEmployee employee=new Manager();
            employee.FirstName="pamal";
            employee.LastName="sahan";
            employee.CalculatePerHourRate(4);
            
            Console.WriteLine($"{employee.FirstName}'s salary is ${employee.Salary}/hour");



        }
    }
}
