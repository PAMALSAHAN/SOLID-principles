namespace DNTLib.OCPClasses
{
    public class RecurringInvoice :Invoice
    {
         public override double GetInvoiceDiscount(double amount){
            return base.GetInvoiceDiscount(amount) -40;
        }
    }
}