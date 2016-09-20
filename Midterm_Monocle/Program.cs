using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Linq.I
using System.Collections;

namespace MonocleFile
{
    public class Program
    {
        public static List<Receipt> receiptList = new List<Receipt>();
        public static List<Products> productList = new List<Products>();

     static void Main(string[] args)
        {
            int subTotal = 0;
            string continueYes = "";
            int paymentOption = 0;
            int itemNumber = 0;
            int quantity = 0;
            double salesTax = 0;
            int lineTotal = 0;
            double grandTotal = 0;
            double balanceAmount = 0;
            string creditCardNumber = "";
            int cashAmount = 0;
            string continueToShop = "";
            long creditCard = 0;
            int cvvNumberint = 0;
            long routingNumberLong = 0;
            int expirationDate = 0;
            int receiptCounter = 0;

            string fileRead = @"C:\\Users\\ATHIKUMAR\\Documents\\GitHub\\EXPIT\\DEMOS\\MonocleFile\\MonocleFile\\input.txt";//Read fro the file
            string[] fileContents = System.IO.File.ReadAllLines(fileRead);
            char[] separators = { ',' };
            string[] menuList = null;
            for (int i = 0; i < fileContents.Length; i++)
            {
                menuList = fileContents[i].Split(separators);
                productList.Add(new Products(menuList[0], menuList[1], menuList[2], menuList[3], int.Parse(menuList[4])));

            }
            List<Products> selectedItems = new List<Products>();
            Display monocleDisplay = new Display();
            //New purchase starts here
            
            do
            {

                do  //Additional Purchase starts here
                {
                    monocleDisplay.DisplayMenu(productList);
                    Console.WriteLine("\n\nPlease select an item by Number ");
                    try
                    {
                        itemNumber = int.Parse(Console.ReadLine());//check for the input format
                    }
                    catch(FormatException fx)
                    {
                        Console.WriteLine(fx.Message.ToString());
                        Console.WriteLine("Enter  number only");
                        itemNumber = int.Parse(Console.ReadLine());

                    }
                    while (itemNumber < 0 || itemNumber > 14)
                       {
                        Console.WriteLine("Error: Invalid Entry");
                        Console.WriteLine("Please Select an item by Number \n");
                        itemNumber = int.Parse(Console.ReadLine());
                       
                        }
                    Console.WriteLine("Please Enter  a quantity \n");
                    try
                    {
                        quantity = int.Parse(Console.ReadLine());//Get the quantity 
                    }        
                    catch(Exception ex)
                    {
                        Console.WriteLine(ex.Message.ToString());
                        Console.WriteLine(" Please Enter number only");
                        quantity = int.Parse(Console.ReadLine());
                    }     

                    lineTotal = monocleDisplay.calculateLineTotal(selectedItems, itemNumber, quantity);
                    subTotal = monocleDisplay.calculateSubTotal(lineTotal);
                    monocleDisplay.DisplaySelectedItems(selectedItems);
                    Console.WriteLine($"\nLine total is                                                             ${lineTotal}\n");
                    Console.WriteLine("\n\nDo you want to purchase another item (y/N):\n");
                    continueYes = Console.ReadLine().ToLower();
                 } while (continueYes == "y");

                salesTax = monocleDisplay.SalesTaxCalculation(subTotal);
                grandTotal = monocleDisplay.calculateTotal(subTotal, salesTax);
                Console.WriteLine($"SubTotalAmount=${subTotal}  \nSales Tax =${salesTax}  \nGrandTotal=${grandTotal}");
                Console.WriteLine("\n\nChoose your Method of Payment would you like?  1- Cash, 2- Credit Card, 3 - Check\n");
                try
                {
                    paymentOption = int.Parse(Console.ReadLine());
                }
                catch(FormatException fx)
                {
                    Console.WriteLine(fx.Message.ToString());
                    Console.WriteLine("Please enter number only ");
                    paymentOption = int.Parse(Console.ReadLine());
                }
                while (paymentOption <= 0 || paymentOption > 3)
                {
                    Console.WriteLine("Error: Invalid Entry");
                    Console.WriteLine("Please Select your Method of Payment .Enter numbers between 1 And 3 \n");                 
                    paymentOption = int.Parse(Console.ReadLine());
                                   
                }

                switch (paymentOption)//payment option checking 
                {
                    case 1:

                        Console.WriteLine(" Cash - Enter the Amount");
                        try
                        {
                            cashAmount = int.Parse(Console.ReadLine());
                        }
                        catch(FormatException ex)
                        {
                            Console.WriteLine(ex.Message.ToString());
                            Console.WriteLine("Enter Number only");
                            cashAmount = int.Parse(Console.ReadLine());
                        }
                        balanceAmount = cashAmount - grandTotal;                                         
                        receiptList.Add(new Receipt(selectedItems, subTotal, salesTax, grandTotal, cashAmount, balanceAmount, "Cash Payment"));//Add to receipt list
                        monocleDisplay.PrintReceipt(monocleDisplay, selectedItems, subTotal, salesTax, grandTotal);//Display receiptco
                        Console.WriteLine(" \n    Payment Type: Cash     ");
                        Console.WriteLine($"\nYour balance Amount is  is   ${ balanceAmount}\n\n");               
                        break;

                    case 2:
                        Console.Write(" Enter your Credit Card #");
                        creditCardNumber = Console.ReadLine();
                        while (creditCardNumber.Length != 16)
                        {

                            Console.WriteLine("Error: Invalid Credit Card Entry");
                            Console.WriteLine("Please Re-Enter your Credit Card #:");
                            creditCardNumber = Console.ReadLine();
                        }

                        try
                        {
                            creditCard = long.Parse(creditCardNumber);
                        }
                        catch (FormatException fx)
                        {
                            Console.WriteLine(fx.Message.ToString());
                            Console.WriteLine(" Not a vaid format enter number only");
                            creditCard = long.Parse(Console.ReadLine());

                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Enter numbers only");
                            creditCard = long.Parse(creditCardNumber);
                        }
                       
                       
                                          
                        Console.WriteLine("Enter Expiration Date");
                         //year format (Digit only)validation
                            try                      
                        { 
                           expirationDate = int.Parse(Console.ReadLine());
                        }
                        catch(FormatException fx)
                        {
                            Console.WriteLine(fx.Message.ToString());
                            Console.WriteLine("  Enter number only");

                            expirationDate = int.Parse(Console.ReadLine());
                        }
                        while(expirationDate<2016)    //year validation
                        {
                            Console.WriteLine("Enter valid year");
                            expirationDate = int.Parse(Console.ReadLine());
                        }
                        Console.WriteLine("Enter CVV");
                        string cvvNumber = Console.ReadLine();
                        while(cvvNumber.Length!=3)
                        {
                            Console.WriteLine("Please enter valid cvv number");
                             cvvNumber = Console.ReadLine();
                        }
                        try
                        {
                            cvvNumberint= int.Parse(cvvNumber);
                        }
                        catch (FormatException ex)
                        {
                            Console.WriteLine(ex.Message.ToString());
                            Console.WriteLine("Enter numbers only");
                            cvvNumberint= int.Parse(Console.ReadLine());
                        }
                        monocleDisplay.PrintReceipt(monocleDisplay, selectedItems, subTotal, salesTax, grandTotal);//Call to Receipt method to display
                        Console.WriteLine("Payment Type is Creditcard");
                        receiptList.Add(new Receipt(selectedItems, subTotal, salesTax, grandTotal, 0, 0, "Creditcard Pyment"));
                        
                        break;

                    case 3:
                        Console.WriteLine(" Enter your Routing Number #:");
                        string routingNumber = Console.ReadLine();
                        while (routingNumber.Length != 9)
                        {
                            Console.WriteLine("Error: Invalid Entry");
                            Console.WriteLine("Please Re-Enter your Routing #:");
                            routingNumber = Console.ReadLine();
                        }
                        try
                        {
                             routingNumberLong = long.Parse(routingNumber);
                        }
                        catch(FormatException ex)
                        {
                            Console.WriteLine(ex.Message.ToString());
                            Console.WriteLine("Please enter number only");

                          routingNumberLong=long.Parse(Console.ReadLine());
                        }
                        monocleDisplay.PrintReceipt(monocleDisplay, selectedItems, subTotal, salesTax, grandTotal);

                        receiptList.Add(new Receipt(selectedItems, subTotal, salesTax, grandTotal, 0, 0, "Check  Payment"));
                        break;
                    default:
                        Console.WriteLine(" Invalid selection");
                        Console.ReadLine();

                        break;
                }

                monocleDisplay.DisplayReceiptList(receiptList,receiptCounter);// To print the Receipt List
                Console.WriteLine(" Thank you for shopping with us. Please come back to visit [Monocle] Store again.");
                Console.WriteLine("\n Cant get enough? Enter \"back\" to return to [Monocle] Store:\n");
                continueToShop = Console.ReadLine().ToLower();
               
                receiptList.Clear();

            } while (continueToShop == "back");

                
        }
    }

}
    
