using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSTerminal
{
    public class FinalReceipt
    {
        List<ReceiptClass> customerOrderRecords = new List<ReceiptClass>();
        float subTotal = 0.0f;
        double grandTotal = 0.0;
        string modeOfPayment = "";
        float cashTender = 0.0f;
        string creditCardNumber = "";
        string checkNumber = "";

        public FinalReceipt(List<ReceiptClass> CustOrdRec,float SubTot, double GTot, string ModPay, float CTend = 0.0f, string CCNumber = "", string CheckNumber = "")
        {
            this.customerOrderRecords = CustOrdRec;
            this.subTotal = SubTot;
            this.grandTotal = GTot;
            this.modeOfPayment = ModPay;
            this.cashTender = CTend;
            this.creditCardNumber = CCNumber;
            this.checkNumber = CheckNumber;
        }


        public float SubTotal
        {
            get { return subTotal; }
        }
        public double GrandTotal
        {
            get { return grandTotal; }
        }
        public float CashTender
        {
            get { return cashTender; }
        }

        public string ModeOfPayment
        {
            get { return modeOfPayment; }
        }
        public string CreditCardNumber
        {
            get { return creditCardNumber; }
        }
        public string CheckNumber
        {
            get { return checkNumber; }
        }
    }
}
