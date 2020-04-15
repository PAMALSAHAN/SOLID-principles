namespace main.model
{
    public class Chore
    {
        public string ChoreName { get; set; }
        public Person Owner { get; set; }
        public double HoursWorked { get; set; }
        public bool IsComplete { get; set; }

        public void PerformedWork(double hours)
        {
            HoursWorked+=hours;
            Logger logger=new Logger();
            logger.Log($"performed work on {ChoreName}");

        }
        public void CompleteChore( )
        {
            IsComplete=true;
            Logger logger=new Logger();
            logger.Log($"completed :{ChoreName}");
            

        }
    }
}