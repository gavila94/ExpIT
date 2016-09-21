using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonocleFile
{
  public   class Receipt
    {



        List<Products>selectedItems;//description of product

        //price of product
            private int  subTotal ;
            private double salesTax;
            private double grandTotal;
            private double balanceAmount;
            private int cashAmount;
            private string paymentType;

            public Receipt(List<Products>SelectedItems,int subTotal,double salesTax,double  grandTotal, int cashAmount,double balanceAmount,string paymentType)

            {

            this.selectedItems = SelectedItems;

            this.subTotal = subTotal;
            this.salesTax = salesTax;
            this.grandTotal = grandTotal;
            this.balanceAmount = balanceAmount;
            this.cashAmount = cashAmount;
            this.paymentType = paymentType;    

            }

          public List<Products> GetSelectedItems()
        {
            return selectedItems;
        }

        public double GetSalesTax()
        {
            return salesTax;
        }

            public int GetsubTotal()
            {
                return subTotal;
            }
            public double GetGrandTotal()
            {
                return grandTotal;

            }
        public double GetcashAmount()
        {
            return cashAmount;

        }

        public double GetbalanceAmount()
        {
            return balanceAmount;

        }

        public string GetpaymentType()
        {
            return paymentType;
        }
    }


    }
