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
        static bool validPayment;
        static int month;
        static int year;
        // static string readCheckNumber="";
        static string nextOrder;



        static List<ReceiptClass> customerOrderRecords = new List<ReceiptClass>();
        static List<FinalReceipt> finalCustomerReceipt = new List<FinalReceipt>();

        public static void Main(string[] args)
        {

            do
            {
                Console.WriteLine("Welcome to PowerHouse Restaurant\n");
                Console.WriteLine("Please check out our menu:");
                Helper.DisplayMenu();
                //DisplayMenu();
                string reply = "";
                try
                {
                    Console.Write("\nWhat would you like to order? (Please enter the Menu code): ");
                    customerOrder = Console.ReadLine();
                    if (MenuList.ourMenu.Exists(ll => ll.Letter.StartsWith(customerOrder)))
                    {
                        continueOrder = PlaceOrder();
                    }
                    else
                    {
                        throw new Exception("You have entered an invalid menu code.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

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
                            Helper.DisplayMenu();

                        }
                        Console.Write("\nWhat else would you like to order? (Please enter the Menu code): ");
                        customerOrder = Console.ReadLine();
                        try
                        {
                            if (MenuList.ourMenu.Exists(ll => ll.Letter.StartsWith(customerOrder)))
                            {
                                continueOrder = PlaceOrder();
                            }
                            else
                            {
                                throw new Exception("You have entered an invalid menu code.");
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }


                        Console.Write("\nDo you want to continue?(y/n) ");
                        reply = Console.ReadLine();

                    } while (reply == "y");

                    PrintBill();
                    FinalCustomerReceipt();

                    Console.WriteLine("Thank you for your Business!");

                    Console.ReadLine();

                    Console.Write("\nPress 'enter' for next order...");
                    nextOrder = Console.ReadLine();
                    Console.Clear();
                }
                else
                {

                    PrintBill();
                    FinalCustomerReceipt();

                    Console.WriteLine("Thank you for your Business!");


                    Console.Write("\nPress 'enter' for next order...");
                    nextOrder = Console.ReadLine();
                    Console.Clear();
                }
                customerOrderRecords.Clear();
                finalCustomerReceipt.Clear();
                totalAmount = 0.0f;
                continueOrder = 0.0f;
                grandTotal = 0.0f;


            } while (true);


        }


        /// Method declaration

       
        public static float PlaceOrder()
        {

            Menu m = MenuList.ourMenu.Find(f1 => f1.Letter.StartsWith(customerOrder));

            Console.WriteLine(m.Name + "   " + m.Price);

            Console.Write("\nPlease enter the quantity: ");
            quantity = int.Parse(Console.ReadLine());

            totalAmount = continueOrder + (quantity * m.Price);
            customerOrderRecords.Add(new ReceiptClass(quantity, m.Name, m.Price));
            Console.WriteLine($"\nYou ordered {quantity} quantity of {m.Name} , your total is {totalAmount}");
            return totalAmount;

        }

        public static void PrintBill()
        {
            Console.WriteLine("Thank you for your Order");
            tenderedReceipt();
            Console.WriteLine("\nHow would you like to make the payment?: Cash / Credit / Check");
            string paymentMethod = Console.ReadLine().ToLower().Trim();
            switch (paymentMethod)
            {
                case "cash":
                    Console.Write("\nEnter amount tendered: $");
                    float cashAmount = float.Parse(Console.ReadLine());
                    if (cashAmount < grandTotal)
                    {
                        Console.WriteLine("You have insufficient Funds ");
                    }
                    else
                    {
                        Console.WriteLine("Thank you for your business!\nPlease take your change: " + Math.Round((cashAmount - grandTotal), 2));
                    }
                    finalCustomerReceipt.Add(new FinalReceipt(customerOrderRecords, totalAmount, grandTotal, paymentMethod, cashAmount));

                    break;
                case "credit":
                    bool creditCardValidation;
                    string readCreditCardNumber;
                    do
                    {
                        string letter = "abcdefghijklmnopqrstuvwxyz@#$!%^&*()";
                        char[] let = letter.ToCharArray();
                        Console.Write("Please enter your Debit/Credit card number: ");
                        readCreditCardNumber = Console.ReadLine();
                        if(readCreditCardNumber.Length != 16)
                        {
                            Console.WriteLine("Invalid entry. Please re-enter CC#: ");
                            creditCardValidation = false;
                        }
                        else if (readCreditCardNumber.IndexOfAny(let) != -1)
                        {
                            Console.WriteLine("Invalid entry. Please re-enter CC#: ");
                            creditCardValidation = false;
                        }
                        else
                        {
                            creditCardValidation = true;
                        }
                    } while (!creditCardValidation);

                    Console.Write("\nEnter Expiration date: (mm/yy):  ");
                    string expireDate = Console.ReadLine();
                    //DateTime expirationDate = new DateTime();

                    do
                    {
                        try
                        {
                            string[] splitDate = expireDate.Split("/".ToCharArray());
                            month = int.Parse(splitDate[0]);
                            year = int.Parse(splitDate[1]);

                            //  expirationDate = new DateTime(month,year);
                            validPayment = true;
                        }
                        catch (ArgumentNullException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        catch (FormatException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        catch (OverflowException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        catch (ArgumentOutOfRangeException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        if (year <= 16 && month  <=12)
                        {
                            validPayment = false;
                            Console.WriteLine("Enter a valid date (mm/yy): ");
                            expireDate = Console.ReadLine();
                        }

                    } while (!validPayment);

                    string cvvNumber;
                    do
                    {
                        Console.Write("\nEnter CVV: ");
                        cvvNumber = Console.ReadLine();


                        if (cvvNumber.Length != 3)
                        {
                            Console.Write("\nInvalid entry.  ");
                        }
                    } while (cvvNumber.Length != 3);


                    Console.WriteLine("\nThank You for your business");
                    finalCustomerReceipt.Add(new FinalReceipt(customerOrderRecords, totalAmount, grandTotal, paymentMethod, 0, readCreditCardNumber, ""));

                    break;
                case "check":
                    string readCheckNumber;
                    do
                    {
                        bool checkValidation;

                        do
                        {
                            Console.Write("\nPlease enter your check number: ");

                            readCheckNumber = Console.ReadLine();
                            string letter = "abcdefghijklmnopqrstuvwxyz@#$!%^&*()";
                            char[] let = letter.ToCharArray();
                            if (readCheckNumber.IndexOfAny(let) != -1)
                            {
                                Console.WriteLine("Invalid entry. Please re-enter CC#: ");
                                checkValidation = false;
                            }
                            else
                            {
                                checkValidation = true;
                            }
                        } while (!checkValidation);


                        validPayment = true;
                        if (readCheckNumber.Length < 9 && readCheckNumber.Length > 12)
                        {
                            Console.WriteLine("Invalid entry");
                            validPayment = false;
                        }
                    } while (!validPayment);
                    Console.WriteLine("Thank You for your business");
                    finalCustomerReceipt.Add(new FinalReceipt(customerOrderRecords, totalAmount, grandTotal, paymentMethod, 0, "", readCheckNumber));

                    break;
                default:
                    Console.WriteLine("Please Pay it.");
                    break;
            }



        }


        public static void GetCVV(string cvvNumber)
        {

            if (cvvNumber.Length != 3)
            {
                Console.Write("\nInvalid entry. Please re-enter CVV: ");
            }
            else { 
            GetCVV(cvvNumber);
            }
        }

        public static void tenderedReceipt()
        {
            Console.WriteLine("\nHere is your ordered receipt");
            //int indexOfListMenu = customerOrderRecords.Count();
            Console.WriteLine($"Quantity \t Item Name \t      Price");
            Console.WriteLine("-----------------------------------------------");
            for (int i = 0; i < customerOrderRecords.Count; i++)
            {
                Console.WriteLine(customerOrderRecords[i].Quantity + "\t\t" + customerOrderRecords[i].ItemName + "\t\t" + customerOrderRecords[i].ItemPrice);
            }
            grandTotal = Math.Round((totalAmount * .06) + totalAmount, 2);
            Console.WriteLine("Subtotal..............................." + Math.Round(totalAmount, 2));
            Console.WriteLine("Sales Tax..............................0.6%");
            Console.WriteLine("Grand Total............................" + grandTotal);
            // customerOrderRecords.Clear();
        }


        public static void FinalCustomerReceipt()
        {
            Console.WriteLine("\nHere is your final receipt");
            //int indexOfListMenu = customerOrderRecords.Count();
            Console.WriteLine($"Quantity \t Item Name \t      Price");
            Console.WriteLine("-----------------------------------------------");
            for (int i = 0; i < finalCustomerReceipt.Count; i++)
            {
                // Console.WriteLine(customerOrderRecords[i].Quantity + "\t\t" + customerOrderRecords[i].ItemName + "\t\t" + customerOrderRecords[i].ItemPrice);
                for (int i1 = 0; i1 < customerOrderRecords.Count; i1++)
                {
                    Console.WriteLine(customerOrderRecords[i1].Quantity + "\t\t" + customerOrderRecords[i1].ItemName + "\t\t" + customerOrderRecords[i1].ItemPrice);
                }
                //Console.WriteLine("-----------------------------------------------");
                Console.WriteLine($"Subtotal................................${finalCustomerReceipt[i].SubTotal}");
                Console.WriteLine($"Grandtotal..............................${finalCustomerReceipt[i].GrandTotal}");
                if (finalCustomerReceipt[i].ModeOfPayment == "cash")
                {
                    Console.WriteLine($"Paid by..............{finalCustomerReceipt[i].ModeOfPayment}...............${finalCustomerReceipt[i].CashTender}");
                    Console.WriteLine($" Your cash back.................${finalCustomerReceipt[i].CashTender - finalCustomerReceipt[i].GrandTotal}");
                }
                else if (finalCustomerReceipt[i].ModeOfPayment == "credit")
                {
                    Console.WriteLine($"Credit card number                     {finalCustomerReceipt[i].CreditCardNumber}");
                }
                else if (finalCustomerReceipt[i].ModeOfPayment == "check")
                {
                    Console.WriteLine($"Check number                           {finalCustomerReceipt[i].CheckNumber}");
                }

            }
            finalCustomerReceipt.Clear();
        }
    }
}
