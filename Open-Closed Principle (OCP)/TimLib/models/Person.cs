namespace TimLib.models
{
   
    public class Person : IPerson
    {
        public string firstName { get; set; }

        public string lastName { get; set; }
        public IAccount accountProcessor { get; set; }=new Account();
    }
}