namespace mainCorrect.model
{
    public class Texter : IMessagesender
    {
        void IMessagesender.SendEmailer(IPerson owner, string v)
        {
            System.Console.WriteLine($"sending text to {owner.FirstName} ");
        }
    }
}