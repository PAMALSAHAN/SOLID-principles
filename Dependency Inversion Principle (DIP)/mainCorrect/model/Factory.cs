using System;
namespace mainCorrect.model
{
    static public class Factory
    {
        public static IPerson CreatePerson()
        {
            return new Person();
        }
        public static IChore CreateChore()
        {
            return new Chore(CreateLogger(),CreateMessage());
        }
        public static IMessagesender CreateMessage()
        {
            return new Texter();
        }
         public static ILogger CreateLogger()
        {
            return new Logger();
        }


    }
}