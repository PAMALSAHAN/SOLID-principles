namespace mainCorrect.model
{
    public class Emailer :IMessagesender
    {
        public Emailer()
        {
        }

        public void SendEmailer(IPerson person,string message)
        {
            System.Console.WriteLine($"sending an email to{person.EmailAddress}");
            
        }

    }

    
}