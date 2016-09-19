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
                Console.WriteLine(product.Quantity.ToString() + "x " + product.Item.Name + "        " + product.Item.Price.ToString("C2"));
            }

            Console.WriteLine("Your total plus tax today will be " + grandTotal.ToString("C2"));

            //string paymentType;
            do
            {
                Console.WriteLine("How will you be paying today? (cash, check, or credit)");

                pay.paymentType = Console.ReadLine();

                // public string payMethod { get { return Payment; } }

                //  public string Payment = { get {return Console.ReadLine() ; } }

                switch (pay.paymentType)
                {
                    case "cash":

                        {
                            double cashReceived;
                            do
                            {
                                Console.WriteLine("Enter the amount paid:");
                                //decimal cashReceived = decimal.Parse(Console.ReadLine());
                                bool result = double.TryParse(Console.ReadLine(), out cashReceived);

                                if (cashReceived <= 0 || cashReceived < grandTotal)
                                {
                                    Console.WriteLine("not enough");
                                }

                                else
                                { Console.WriteLine("Change: " + (cashReceived - grandTotal)); }

                            } while (cashReceived <= 0 || cashReceived < grandTotal);
                            //double total = 2; //need to pull total from michelle's program
                            //  if (cashReceived < total)
                            //  {
                            //      Console.WriteLine("You need to pay more!");
                            //   }

                        }

                        //need cash received - total and display change

                        break;

                    case "check":

                        //double routingNumber, accountNumber;
                        string strRountingNum, strAccountNum;
                        do
                        {
                            Console.WriteLine("Please enter the routing number:");
                            strRountingNum = Console.ReadLine();
                            pay.routingNumber = strRountingNum;
                            //bool routingInput = double.TryParse(strRountingNum, out routingNumber);
                            if (strRountingNum.Length != 9)
                            {
                                Console.Write("Invalid input. ");
                            }

                            //double routingNumber = double.Parse(Console.ReadLine());
                            else
                            {
                                do
                                {
                                    Console.WriteLine("Please enter the account number:");
                                    strAccountNum = Console.ReadLine();
                                    pay.accountNumber = strAccountNum;
                                    //bool accountInput = double.TryParse(strAccountNum, out accountNumber);
                                    if (strAccountNum.Length < 9 || strAccountNum.Length > 12)
                                    {
                                        Console.Write("Invalid input. ");
                                    }
                                } while (strAccountNum.Length < 9 || strAccountNum.Length > 12);
                            }
                        } while (strRountingNum.Length != 9);
                        // Console.WriteLine("Thank you!");
                        break;

                    case "credit":
                        double cvvNumber;
                        string strCardNum, strCVV, strDate;
                        //bool cardNumInput;
                        do
                        {
                            Console.WriteLine("Enter card number(ex. XXXX XXXX XXXX XXXX): ");
                            //double cardNumber = double.Parse(Console.ReadLine());
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

                            
                            //bool cardNumInput = double.TryParse(strCardNum, out pay.cardNumber);

                            if (pay.cardNumber.Length != 19)
                            {
                                Console.Write("Invalid input. ");
                            }
                        } while (pay.cardNumber.Length != 19);

                        /* cardNumInput = double.TryParse(strCardNum, out cardNumber);

                         if (strCardNum.Length != 16 && (!(cardNumInput)))
                         {
                             Console.Write("Invalid input. ");
                         }
                     } while (strCardNum.Length != 16 && (!(cardNumInput)));*/

                        int month, year;
                        DateTime now;
                        //Initialize date validation
                        bool dateIsValid;
                        do
                        {
                            //Set date validation to true :)
                            dateIsValid = true;
                            do
                            {
                                Console.WriteLine("Enter the expiration date (mm/yy format)");
                                strDate = Console.ReadLine();

                                if (strDate.Length != 5)
                                    Console.Write("\nInvalid date format. ");
                            } while (strDate.Length != 5);

                            string[] dateSplit = strDate.Split('/');
                            month = Int32.Parse(dateSplit[0]);
                            year = Int32.Parse(dateSplit[1]);

                            now = DateTime.Now;
                            

                            if ((year + 2000)<now.Year)
                            {
                                Console.Write("Invalid year");
                                //Set invalid date
                                dateIsValid = false;
                            }
                            else
                            {
                                if (year == 16)
                                {
                                    if (month < now.Month)
                                    {
                                        Console.Write("Invalid month");
                                        //Set invalid date
                                        dateIsValid = false;
                                    }
                                }
                            
                            }
                        } while (!dateIsValid);
                        //(year + 2000) <= now.Year && month < now.Month

                        //expirationDate.ToString()[1]==

                        do
                        {
                            Console.WriteLine("Enter the CVV number:");
                            strCVV = Console.ReadLine();
                            bool CVVInput = double.TryParse(strCVV, out cvvNumber);
                            if (strCVV.Length != 3 && strCVV.Length != 4)
                            {
                                Console.Write("Invalid input. ");
                            }
                        } while (strCVV.Length != 3 && strCVV.Length != 4);
                        //  Console.WriteLine("Thank you!");
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

