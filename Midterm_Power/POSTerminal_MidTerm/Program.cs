using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POSTerminal;

namespace POSTerminal_MidTerm
{
    class Program
    {
        static float totalAmount = 0.0f;
        static int quantity = 0;
        static string customerOrder = "";
        static float continueOrder = 0.0f;
        static double grandTotal = 0.0f;


        static List<ReceiptClass> customerOrderRecords = new List<ReceiptClass>();

        public static void Main(string[] args)
        {

            Console.WriteLine("Welcome to PowerHouse Restaurant\n");
            Console.WriteLine("Please check out our menu:");

            DisplayMenu();
            string reply = "";

            Console.Write("\nWhat would you like to order? (Please enter the Menu code): ");
            customerOrder = Console.ReadLine();
            continueOrder = PlaceOrder();

            Console.Write("\nWould you like to order something else? (y/n) : ");
            customerOrder = Console.ReadLine();
            if (customerOrder == "y")
            {
                do
                {
                    Console.Write("Would you like to see the menu again? (y/n)");
                    customerOrder = Console.ReadLine();
                    if (customerOrder == "y")
                    {
                        DisplayMenu();

                    }
                    Console.Write("\nWhat else would you like to order? (Please enter the Menu code): ");
                    customerOrder = Console.ReadLine();
                    continueOrder = PlaceOrder();
                    Console.Write("\nDo you want to continue?(y/n) ");
                    reply = Console.ReadLine();

                } while (reply == "y");

                PrintFinalReceipt();

            }
            else
            {

                PrintFinalReceipt();

            }
            string paymentMethod = Console.ReadLine();
            switch (paymentMethod)
            {
                case "Cash":
                    Console.Write("\nEnter amount tendered: $");
                    float cashAmount = float.Parse(Console.ReadLine());
                    if (cashAmount < grandTotal)
                    {
                        Console.WriteLine("You have insufficient Funds ");
                    }
                    else {
                    Console.WriteLine("Thank you for your payment!\nPlease take your change: " + (cashAmount - grandTotal));
                    }
                    break;
                case "Credit":
                    Console.WriteLine("Please enter your Debit/Credit card number, expiration and CVV");
                    Console.ReadLine();
                    Console.WriteLine("Thank You for your business");
                    break;
                case "Check":
                    Console.WriteLine("Please enter your check number");

                    Console.ReadLine();
                    Console.WriteLine("Thank You for your business");
                    break;
                default:
                    Console.WriteLine("Please Pay it.");
                    break;
            }
          
        }


        /// Method declaration

        public static void DisplayMenu()
        {
            foreach (Menu itemList in MenuList.ourMenu)
            {
                Console.WriteLine(itemList.letter + "- " + itemList.name + "   " + itemList.category + "   " + itemList.price);
            }
        }



        public static float PlaceOrder()
        {
            if (MenuList.ourMenu.Exists(ll => ll.letter.StartsWith(customerOrder)))
            {
                Menu m = MenuList.ourMenu.Find(f1 => f1.letter.StartsWith(customerOrder));

                Console.WriteLine(m.name + "   " + m.price);
                // customerOrderRecords.Add(m.name);
                Console.Write("\nPlease enter the quantity: ");
                quantity = int.Parse(Console.ReadLine());
                customerOrderRecords.Add(new ReceiptClass(quantity, m.name, m.price));
                totalAmount = continueOrder + (quantity * m.price);
                Console.WriteLine($"\nYou ordered {quantity} quantity of {m.name} , your total is {totalAmount}");

            }
            else
            {
                Console.WriteLine("\nPlease enter a valid menu code : ");
            }
            return totalAmount;
        }

        public static void PrintFinalReceipt()
        {
            Console.WriteLine("Thank you for your Order");
            tenderedReceipt();
            Console.WriteLine("\nHow would you like to make the payment?: Cash / Credit / Check");
        } 
        public static void tenderedReceipt()
        {
            Console.WriteLine("\nHere is your final receipt");
            //int indexOfListMenu = customerOrderRecords.Count();
            Console.WriteLine($"Quantity \t Item Name \t Price");
            Console.WriteLine("-----------------------------------------------");
            for (int i = 0; i < customerOrderRecords.Count; i++)
            {
                Console.WriteLine(customerOrderRecords[i].quantity + "\t\t" + customerOrderRecords[i].ItemName + "\t\t" + customerOrderRecords[i].ItemPrice);
            }
            grandTotal = Math.Round((totalAmount * .06) + totalAmount,2);
            Console.WriteLine("Subtotal..............................." + Math.Round(totalAmount,2));
            Console.WriteLine("Sales Tax..............................6%");
            Console.WriteLine("Grand Total............................" + grandTotal);
        }
        
    }
}
