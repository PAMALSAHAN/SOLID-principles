namespace LSPcorrect.model
{
    public  class BaseEmployee :IEmployee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; set; }


        public virtual void CalculatePerHourRate(int rank)
        {

            decimal baseAmount = 23.34M;
            Salary = baseAmount + (rank * 2);

        }

    }
}