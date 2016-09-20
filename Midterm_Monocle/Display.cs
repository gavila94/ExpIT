using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonocleFile
{





    public class Display
    {

        int subTotalAmount = 0;
        int lineTotal = 0;

        
        //Read from the List in ProductIO class
        public void DisplayMenu(List<Products> d1)
        {

            Console.WriteLine("                     Welcome to Store Monocle            \n\n ");
            for (int i = 0; i < d1.Count; i++)
            {
                int j = i +1;
           Console.WriteLine($" {j}    {d1[i].GetName() }                  ${ d1[i].GetPrice()}");
            }

        }

        
        public int calculateLineTotal(List<Products> selectedItem, int item1, int quantity)
        {
            
            selectedItem.Add(Program.productList[--item1]);
            lineTotal = quantity * (Program.productList[item1].GetPrice());
            return lineTotal;

        }

        public int calculateSubTotal(int lineTotal)
        {
            subTotalAmount += lineTotal;
            return subTotalAmount;
        }



        //method to display only the selected  items in console

        public void DisplaySelectedItems(List<Products> selectedItems)
        {
            
            Console.WriteLine("No.                Selected Items                                        price                \n");
            Console.WriteLine("*****************************************************************************");
            for (int i = 0; i < selectedItems.Count; i++)
            {
                int j = i + 1;
                   
            Console.WriteLine($"{j}         {selectedItems[i].GetName()}                                ${selectedItems[i].GetPrice()}");
            }
        }

        //Method to calculate salesTax

        public double SalesTaxCalculation(int subTotal)
        {
            double salesTax = Math.Round((subTotal * 0.06), 3);

            return salesTax;

        }

        //Method to calculate the Grand total(subtotal added to salestax)

        public double calculateTotal(int subTotal, double salesTax)
        {
            double Total = Math.Round((subTotal + salesTax), 3);// Adding taxes to subtotal 

            return Total;
        }



        //To display the receipt to console 
        public void PrintReceipt(Display objectNew, List<Products> selectedItems, int subTotal, double salesTax, double Total)
        {
            Console.Write("\n\n                                      Receipt -Customer copy                                                         \n \n  ");
            objectNew.DisplaySelectedItems(selectedItems);
            Console.WriteLine("\n*****************************************************************************");
            Console.WriteLine($"\n\nSubTotal                                                                 ${subTotal}");
            Console.WriteLine($"SalesTax                                                                  ${salesTax}");
            Console.WriteLine($"Grand Total                                                              ${Total}  ");
            Console.WriteLine("\n\n*****************************************************************************");

        }



        public void DisplayReceiptList(List<Receipt> receiptList, int counter)
        {
            List<Products> selectedList;
           
             for (int i =0; i < receiptList.Count; i++)
            {

                int subTotal1 = receiptList[i].GetsubTotal();
                double salesTax1 = receiptList[i].GetSalesTax();
                double grandTotal1 = receiptList[i].GetGrandTotal();
                selectedList = receiptList[i].GetSelectedItems();
                Console.WriteLine(" \n                               Receipt- Store copy                            ");
                Console.WriteLine("\n\n*****************************************************************************");
                for (int j = 0; j < selectedList.Count; j++)
                {


                    Console.WriteLine($"\n {j + 1}        {selectedList[j].GetName()}                               ${selectedList[j].GetPrice()}\n");

                }
                Console.WriteLine("\n\n*****************************************************************************");
                Console.WriteLine($"SubTotal                                                              ${subTotal1}");
                Console.WriteLine($"SalesTax                                                              ${salesTax1}");
                Console.WriteLine($"Grand Total                                                           ${grandTotal1}");
                Console.WriteLine($" \n\nPayment Type       {receiptList[counter].GetpaymentType()}");
                Console.WriteLine("************************************************************************************");

            }
        }

            }



        }
    


