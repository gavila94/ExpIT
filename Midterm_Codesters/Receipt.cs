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
            double total = 0;
            const double TAX_RATE = 0.06;

            foreach (cartItem subtotal in shoppingList)
            {
                total += subtotal.Subtotal;
            }

            double grandTotal = (total * TAX_RATE) + total;

            Console.WriteLine("Thank you!\n");
                        
            Console.WriteLine("Here's a Copy of Your Receipt:\n");

            Console.WriteLine("=====================");
            Console.WriteLine("Codester Coffee Shop");
            Console.WriteLine("=====================");
            foreach (cartItem product in shoppingList)
            {
                Console.WriteLine(product.Quantity.ToString() + "x " + product.Item.Name + "\t\t\t" + product.Item.Price.ToString("C2"));
            }
            
            Console.WriteLine("\nSubtotal: " + total.ToString("C2"));
            Console.WriteLine("Total Tax: " + (total * 0.06).ToString("C2"));
            Console.WriteLine("Grand Total: " + grandTotal.ToString("C2"));
           
            Console.Write("\nYou paid with " + pay.paymentType);
            if (pay.paymentType.ToLower() == "credit")
            {
                string[] carNumArr = pay.cardNumber.Split(' ');
                Console.Write(" XXXX-XXXX-XXXX-" + carNumArr[3]+"\n");
            }
            
            if (pay.paymentType.ToLower() == "cash")
            {
                Console.WriteLine(" $" + pay.cashReceived.ToString());
                Console.WriteLine("Change: " + (pay.cashReceived-grandTotal).ToString("C2"));
            }
        }
    }
}
