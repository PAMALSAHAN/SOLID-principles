namespace main.model
{
    public class Emailer
    {
        public void SendEmailer(Person person,string message)
        {
            System.Console.WriteLine($"sending an email to{person.EmailAddress}");
            
        }
    }

    
}