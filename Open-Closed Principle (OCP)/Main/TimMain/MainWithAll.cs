using System;
using System.Collections.Generic;
using TimLib.models;

namespace Main.TimMain
{
    public class MainWithAll
    {
       static void Main(string[] args)
        {
           // Console.WriteLine("Hello World! this from tim main");
            
            //workers la list eka
            List<IPerson> people=new List<IPerson>(){
                new Person(){firstName="Pamal",lastName="Sahan"},
                new Manager(){firstName="Chamath",lastName="Deshan"},
                new Person(){firstName="Ishanka",lastName="Janani"}
            };

            // emp list ekak hadala ganna one
            List<Employee> employeesList=new List<Employee>();

            //account ekak hadanna one
           // Account account =new Account();

            //emp list ekata add karaganna one 
            foreach(var i in people){
                employeesList.Add(i.accountProcessor.createAccount(i));
            }

            foreach(var i in employeesList){
                Console.WriteLine(i.IsManager);
            }


            

        }
        
    }
}