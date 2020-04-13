namespace main.model
{
    public interface IPrinterTasks
    {
         void Print(string context);
         void Scan(string context);
         void Fax(string context);
         void PrintDuplex(string context);
         
    }
}