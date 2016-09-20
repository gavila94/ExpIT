using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSTerminal
{
    public  class ReceiptClass
    {
        int quantity = 0;
        string itemName = "";
        float itemPrice = 0.0f;
        //float subTotal = 0.0f;
        //float grandTotal = 0.0f;
        //string modeOfPayment = "";
        //float cashTender = 0.0f;
        //string creditCardNumber = "";
        //string checkNumber = "";

        //float SubTot, float GTot, string ModPay, float CTend = 0.0f, string CCNumber = "", string CheckNumber = ""
        public ReceiptClass(int Q, string N, float P)
        {

            this.quantity = Q;
            this.itemName = N;
            this.itemPrice = P;
            //this.subTotal = SubTot;
            //this.grandTotal = GTot;
            //this.modeOfPayment = ModPay;
            //this.cashTender = CTend;
            //this.creditCardNumber = CCNumber;
            //this.checkNumber = CheckNumber;
        }

        public int Quantity
        {
            get { return quantity; }
        }
        public string ItemName
        {
            get { return itemName; }
        }
        public float ItemPrice
        {
            get { return itemPrice; }
        }
        //public float SubTotal
        //{
        //    get { return subTotal; }
        //}
        //public float GrandTotal
        //{
        //    get { return grandTotal; }
        //}
        //public float CashTender
        //{
        //    get { return cashTender; }
        //}

        //public string ModeOfPayment
        //{
        //    get { return modeOfPayment; }
        //}
        //public string CreditCardNumber
        //{
        //    get { return creditCardNumber; }
        //}
        //public string CheckNumber
        //{
        //    get { return checkNumber; }
        //}


    }
}
