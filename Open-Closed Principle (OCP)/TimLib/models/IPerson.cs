namespace TimLib.models
{
    public interface IPerson
    {
        string firstName { get; set; }
        string lastName { get; set; }
        IAccount accountProcessor { get; set; }
    }

}