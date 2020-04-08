namespace TimLib.models
{
    public class Manager :IPerson
    {
        public string firstName { get; set; }

        public string lastName { get; set; }
        public IAccount accountProcessor { get; set; }=new ManagerAccount();
    }
}