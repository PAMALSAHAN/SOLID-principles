using System;
using LSPcorrect.model;
namespace LSPlib
{
    public class CEO : Employee ,IManager
    {
        public override void CalculatePerHourRate(int rank){
            decimal baseAmount=150M;
            Salary=baseAmount * rank;

        }
        
       
        public void GeneratePerformanceReview(){
            Console.WriteLine("I'm reviewing a direct report's performance");

        }
        public void FireSomeone(){
            Console.WriteLine("You're Fired!");
        }
    }
}