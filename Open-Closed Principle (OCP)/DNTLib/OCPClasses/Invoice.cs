namespace DNTLib.OCPClasses
{
    public class Invoice
    {
        public virtual double GetInvoiceDiscount(double amount){
            return amount - 10;
        }
    }
}