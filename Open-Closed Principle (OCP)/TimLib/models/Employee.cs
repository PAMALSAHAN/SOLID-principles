namespace TimLib.models
{
    public class Employee
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        
        public bool IsManager { get; set; }=false;
        public bool IsExecutive { get; set; }=false;
        public bool IsDirector { get; set; }=false;

        public bool IsStaff { get; set; }=false;
    }
}