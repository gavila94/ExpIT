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

        //method to calculate the Menu to console 
        //Read from the List in ProductIO class
        public void DisplayMenu(List<Products> d1)
        {

            Console.WriteLine("                     Welcome to Store [Monocle]            \n\n ");
            for (int i = 0; i < d1.Count; i++)
            {
                Console.WriteLine($"    {d1[i].GetProductNumber()}  {d1[i].GetName() }                ${ d1[i].GetPrice()}");
            }

        }

        //Method to calculate sub total

        /*     public int calculateSubTotal(List<Products> SelectedItem, int item1, int quantity)
             {
                 SelectedItem.Add(ProductIO.Product_Catalog[--item1]);
                 lineTotal = quantity * (ProductIO.Product_Catalog[item1].GetPrice());
                 subTotalAmount += lineTotal;
                 Console.WriteLine($"Your Line Total  is :   {lineTotal}");
                 return subTotalAmount;
             }*/
        public int calculateLineTotal(List<Products> SelectedItem, int item1, int quantity)
        {
             SelectedItem.Add(ProductIO.Product_Catalog[--item1]);
            //SelectedItem.Add(ProductIO.Product_Catalog[--item1]);

            lineTotal = quantity * (ProductIO.Product_Catalog[item1].GetPrice());
            return lineTotal;

        }

        public int calculateSubTotal(int lineTotal)
        {
            subTotalAmount += lineTotal;
            return subTotalAmount;
        }



        //method to display only the selected  items in console

        public void DisplaySelectedItems(List<Products> SelectedItems)
        {
            for (int i = 0; i < SelectedItems.Count; i++)
            {
                int j = i + 1;
                Console.WriteLine("        Items selected by you    ");
                Console.WriteLine($"{j}   {SelectedItems[i].GetName()}              {SelectedItems[i].GetPrice()}");
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
        public void Receipt(Display objectNew, List<Products> SelectedItems, int subTotal, double salesTax, double Total)
        {
            objectNew.DisplaySelectedItems(SelectedItems);
            Console.WriteLine($"SubTotal                                           ${subTotal}");
            Console.WriteLine($"SalesTax                                           ${salesTax}");
            Console.WriteLine($"Grand Total                                        ${Total}  ");

        }





    }
}

    
