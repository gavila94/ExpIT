using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace point_of_sale_midterm
{
    public class Receipt
    {
        public static void printReceipt(List<cartItem> shoppingList, Payment pay)
        {
            //int quantity = 1; string itemName = "Coffee"; double itemPrice = 2;
            double total = 0;
            const double TAX_RATE = 0.06;

            foreach (cartItem subtotal in shoppingList)
            {
                total += subtotal.Subtotal;
            }

            double grandTotal = (total * TAX_RATE) + total;

            Console.WriteLine("Thank you!\n");
                        
            Console.WriteLine("Here's a Copy of Your receipt:\n");

            Console.WriteLine("=====================");
            Console.WriteLine("Codester Coffee Shop");
            Console.WriteLine("=====================");
            foreach (cartItem product in shoppingList)
            {
                //Console.WriteLine(quantity + "x " + itemName + "        " + "$" + itemPrice);
                Console.WriteLine(product.Quantity.ToString() + "x " + product.Item.Name + "\t\t\t" + product.Item.Price.ToString("C2"));
            }
            
            Console.WriteLine("\nSubtotal: " + total.ToString("C2"));
            Console.WriteLine("Total Tax: " + (total * 0.06).ToString("C2"));
            Console.WriteLine("Grand Total: " + grandTotal.ToString("C2"));

         //   foreach (Payment payMethod in total)
          //  { }
          //      Console.WriteLine("Cash:" +Payment.paymentMethod);
          //  Console.WriteLine(change + "Change");
//
       //     Console.WriteLine(cardtype xxxxxxxxxxxx3253);
           
            Console.WriteLine("\nYou paid with " + pay.paymentType);
            if (pay.paymentType == "credit")
            {
                string[] carNumArr = pay.cardNumber.Split(' ');
                Console.Write("XXXX-XXXX-XXXX-" + carNumArr[3]);
            }

            //Console.Read();
        }

    }
}

