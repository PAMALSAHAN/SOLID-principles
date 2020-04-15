namespace mainCorrect.model
{  
    public class Chore : IChore
    {
        
        private ILogger logger;
        private IMessagesender messagesender;

        public string ChoreName { get; set; }
        public IPerson Owner { get; set; }
        public double HoursWorked { get; set; }
        public bool IsComplete { get; set; }

     

        public Chore(ILogger logger, IMessagesender messagesender)
        {
            this.logger = logger;
            this.messagesender = messagesender;
        }

        public void PerformedWork(double hours)
        {
            HoursWorked += hours;
            
            logger.Log($"performed work on {ChoreName}");

        }
        public void CompleteChore()
        {
            IsComplete = true;
            logger.Log($"completed{ChoreName}");
            messagesender.SendEmailer(Owner,$"the chore is completed by {ChoreName}");

        }
    }
}