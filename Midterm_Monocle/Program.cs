using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Linq.I
using System.Collections;

namespace MonocleFile
{
    class Program
    {
        static List<Products> SelectedItems = new List<Products>();
        //static int  subTotal=0;
        static void Main(string[] args)
        {

            int subTotal = 0;
            string continueYes = "";
            int paymentOption = 0;
            int itemNumber = 0;
            int quantity = 0;
            double salesTax = 0;
           int lineTotal = 0;
           // int subTotal = 0;
            double grandTotal = 0;
            double balance = 0;
            int creditCardNumber = 0;

            string fileRead = @"C:\\Users\\ATHIKUMAR\\Documents\\GitHub\\EXPIT\\DEMOS\\MonocleFile\\MonocleFile\\input.txt";
            string[] fileContents = System.IO.File.ReadAllLines(fileRead);
          List<Products> productList = ProductIO.Product_Catalog;
           // List<Products> productList = 
            char[] separators = { ',' };
             string[] data = null;
            for (int i = 0; i < fileContents.Length; i++)
            {
                data = fileContents[i].Split(separators);
                productList.Add(new Products(data[0], data[1], data[2], data[3], int.Parse(data[4])));

            }
           
      //    static  List<Products> SelectedItems = new List<Products>();
           
            Display monocleDisplay = new Display();
            monocleDisplay.DisplayMenu(productList);//calling to disply items


            do
            {
                Console.WriteLine("Please select an item by Number \n");
                itemNumber = int.Parse(Console.ReadLine());//Get the item number
                Console.WriteLine("Please Enter   quantity \n");
                quantity = int.Parse(Console.ReadLine());//Get the quantity
                // subTotal = monocleDisplay.calculateSubTotal(SelectedItems, itemNumber, quantity);//calcuate subTotal amount
                lineTotal = monocleDisplay.calculateLineTotal(SelectedItems, itemNumber, quantity);
                  subTotal = monocleDisplay.calculateSubTotal(lineTotal);
               // Console.WriteLine($"Subtotal amount is {subTotal}");
                monocleDisplay.DisplaySelectedItems(SelectedItems);
                Console.WriteLine($"Line total is                ${lineTotal}\n");
                Console.WriteLine("\nDo you want to purchase another item (y/N):\n");
                continueYes = Console.ReadLine().ToLower();
            } while (continueYes == "y");

            salesTax = monocleDisplay.SalesTaxCalculation(subTotal);
            grandTotal = monocleDisplay.calculateTotal(subTotal, salesTax);
            Console.WriteLine($"SubTotalAmount=${subTotal}  \nSales Tax =${salesTax}  \nGrandTotal=${grandTotal}");
            Console.WriteLine("Choose your Method of Payment would you like?  1- Cash, 2- Credit Card, 3 - Check\n");//Calvin Program starts
            paymentOption = int.Parse(Console.ReadLine());
            if (paymentOption > 0 && paymentOption < 4)
                switch (paymentOption)
                {
                    case 1:

                        Console.WriteLine(" Cash - Enter the Amount");
                        int cashAmount = int.Parse(Console.ReadLine());
                        balance = cashAmount - grandTotal;
                        monocleDisplay.Receipt(monocleDisplay, SelectedItems, subTotal, salesTax, grandTotal);
                        Console.WriteLine($"Your balance Amount is  is   ${ balance}\n\n");
                        monocleDisplay.DisplayMenu(productList);
                        Console.ReadLine();

                        break;

                    case 2:
                        // Console.WriteLine(" Credit Card");

                        Console.Write(" Enter your Credit Card #");
                        creditCardNumber = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Expiration Date");
                        string expirationDate = Console.ReadLine();
                        Console.WriteLine("Enter CVV");
                        string cvvNumber = Console.ReadLine();
                        monocleDisplay.Receipt(monocleDisplay, SelectedItems, subTotal, salesTax, grandTotal);
                        monocleDisplay.DisplayMenu(productList);
                        break;

                    case 3:

                        Console.WriteLine(" Check");
                        Console.WriteLine(" Enter your check Number # " + Console.ReadLine());
                        monocleDisplay.Receipt(monocleDisplay, SelectedItems, subTotal, salesTax, grandTotal);
                        //  Console.WriteLine(" Enter your check Account # ");
                        monocleDisplay.DisplayMenu(productList);
                        break;

                    default:
                        Console.WriteLine(" Invalid selection");
                        Console.ReadLine();

                        break;
                }
            


        }







    }

}





           







