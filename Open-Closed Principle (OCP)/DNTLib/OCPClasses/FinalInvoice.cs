namespace DNTLib.OCPClasses
{
    public class FinalInvoice :Invoice
    {
        public override double GetInvoiceDiscount(double amount){
            return base.GetInvoiceDiscount(amount) -70;
        }
    }
}