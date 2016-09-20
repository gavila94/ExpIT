using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace point_of_sale_midterm
{
    public class Payment
    {
        public string cardNumber;
        public string paymentType;
        public string routingNumber, accountNumber;
        public double cashReceived;

        public static Payment paymentMethod(List<cartItem> shoppingList)
        {
            Payment pay = new Payment();

            double total = 0;
            const double TAX_RATE = 0.06;

            foreach (cartItem subtotal in shoppingList)
            {
                total += subtotal.Subtotal;
            }

            double grandTotal = (total * TAX_RATE) + total;

            foreach (cartItem product in shoppingList)
            {
                Console.WriteLine(product.Quantity.ToString() + "x " + product.Item.Name + "\t\t\t" + product.Item.Price.ToString("C2"));
            }

            Console.WriteLine("\nYour total plus tax today will be " + grandTotal.ToString("C2"));

            do
            {
                Console.WriteLine("\nHow will you be paying today? (cash, check, or credit)");

                pay.paymentType = Console.ReadLine();

                switch (pay.paymentType)
                {
                    case "cash":                      
                        {                        
                            do
                            {
                                Console.WriteLine("\nEnter the amount paid:");
                                                                
                                bool result = double.TryParse(Console.ReadLine(), out pay.cashReceived);
                                
                                if (pay.cashReceived <= 0 || pay.cashReceived < grandTotal)
                                {
                                    Console.WriteLine("not enough");
                                }

                                else
                                { Console.WriteLine("\nChange: " + (pay.cashReceived - grandTotal).ToString("C2")); }

                            } while (pay.cashReceived <= 0 || pay.cashReceived < grandTotal);
                        }
                    
                        break;

                    case "check":
                        string strRountingNum, strAccountNum;
                        do
                        {
                            Console.WriteLine("\nPlease enter the routing number:");
                            strRountingNum = Console.ReadLine();
                            pay.routingNumber = strRountingNum;

                            if (strRountingNum.Length != 9)
                            {
                                Console.Write("Invalid input. ");
                            }

                            else
                            {
                                do
                                {
                                    Console.WriteLine("\nPlease enter the account number:");
                                    strAccountNum = Console.ReadLine();
                                    pay.accountNumber = strAccountNum;
                                 
                                    if (strAccountNum.Length < 9 || strAccountNum.Length > 12)
                                    {
                                        Console.Write("Invalid input. ");
                                    }
                                } while (strAccountNum.Length < 9 || strAccountNum.Length > 12);
                            }
                        } while (strRountingNum.Length != 9);
                        
                        break;

                    case "credit":
                        double cvvNumber;
                        string strCardNum, strCVV, strDate;
               
                        do
                        {
                            Console.WriteLine("\nEnter card number(ex. XXXX XXXX XXXX XXXX): ");

                            pay.cardNumber = Console.ReadLine();
                                                        
                            try
                            {
                                string[] temp = pay.cardNumber.Split(' ');
                                strCardNum = temp[0] + temp[1] + temp[2] + temp[3];
                            }
                            catch
                            {
                                Console.Write("Invalid card number. ");
                            }

                            if (pay.cardNumber.Length != 19)
                            {
                                Console.Write("Invalid input. ");
                            }
                        } while (pay.cardNumber.Length != 19);
                                               
                        int month, year;
                        DateTime now;

                        bool dateIsValid;
                        do
                        {
                            dateIsValid = true;
                            do
                            {
                                Console.WriteLine("\nEnter the expiration date (mm/yy format)");
                                strDate = Console.ReadLine();

                                if (strDate.Length != 5)
                                    Console.Write("\nInvalid date format. ");
                            } while (strDate.Length != 5);

                            string[] dateSplit = strDate.Split('/');
                            month = Int32.Parse(dateSplit[0]);
                            year = Int32.Parse(dateSplit[1]);

                            now = DateTime.Now;
                            if ((year + 2000) < now.Year)
                            {
                                Console.Write("Invalid year. ");
                                dateIsValid = false;
                            }

                            if (month <= 0 || month > 12)
                            {
                                Console.Write("Invalid month. ");
                                dateIsValid = false;
                            }

                            else
                            {
                                if (year == 16)
                                {
                                    if (month < now.Month || month > 12 || month < 0)
                                    {
                                        Console.Write("Invalid month. ");
                                        dateIsValid = false;
                                    }
                                }

                            }
                        } while (!dateIsValid);

                        do
                        {
                            Console.WriteLine("\nEnter the CVV number: ");
                            strCVV = Console.ReadLine();
                            bool CVVInput = double.TryParse(strCVV, out cvvNumber);
                            if (strCVV.Length != 3 && strCVV.Length != 4)
                            {
                                Console.Write("Invalid input. ");
                            }
                        } while (strCVV.Length != 3 && strCVV.Length != 4);
                        break;

                    default:
                        Console.WriteLine("Invalid input. ");
                        break;
                }
            } while (pay.paymentType.ToLower() != "cash" && pay.paymentType.ToLower() != "check" && pay.paymentType.ToLower() != "credit");

            return pay;
        }
    }
}

