using System;
using DNTLib.OCPClasses;
using static DNTLib.Enums;

namespace DNTLib
{
    public class Invoice
    {
       public static double getInvoiceDiscount(double amount,InvoiceType type ){

           double finalAmount=0;
           
           if(type==InvoiceType.FinalInvoice){
               finalAmount=amount-100;
           }

           if(type==InvoiceType.ProposedInvoice){
               finalAmount=amount-50;
           }
           return finalAmount;
       }

        public static implicit operator Invoice(RecurringInvoice v)
        {
            throw new NotImplementedException();
        }
    }
}