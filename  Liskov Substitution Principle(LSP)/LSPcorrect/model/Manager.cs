using System;
using LSPcorrect.model;
namespace LSPlib
{
    public class Manager :Employee ,IManager
    {
        public override void CalculatePerHourRate(int rank){
            decimal baseAmount=19.34M;
            Salary=baseAmount + (rank * 4);
        }

        public void GeneratePerformanceReview(){

            //Simulate reviewing a direct report
            Console.WriteLine("I am reviewing a direct report's performance");
            
        }

    }
}