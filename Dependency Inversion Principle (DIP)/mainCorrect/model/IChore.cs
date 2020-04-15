namespace mainCorrect.model
{
   public interface IChore
    {
        string ChoreName { get; set; }
        IPerson Owner { get; set; }
        double HoursWorked { get; set; }
        bool IsComplete { get; set; }
        void CompleteChore();
        void PerformedWork(double hours);
        
    }
}