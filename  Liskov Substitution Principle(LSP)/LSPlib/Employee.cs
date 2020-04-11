namespace LSPlib
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Employee Manager { get; set; }=null;
        public decimal Salary { get; set; }

        public virtual void AssignManager(Employee manager){
            //property ekata assign karana eka thama wenne methana 
            Manager=manager;
        }

        public virtual decimal CalculatePerHourRate(int rank){
            decimal baseAmount=23.34M;
            Salary=baseAmount+(rank *2);

        }


    }
}