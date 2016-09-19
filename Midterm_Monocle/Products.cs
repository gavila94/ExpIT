using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonocleFile
{
  

            public class Products

        {
            private string ProductNumber;
            private string Name; //name of product
            private string Category; //category of product
            private string Description; //description of product
            private int Price; //price of product


            public Products(String Productnumber, String Name, String Category, String Description, int Price)

            {
                this.ProductNumber = Productnumber;
                this.Name = Name;
                this.Category = Category;
                this.Description = Description;
                this.Price = Price;

            }
            public string GetProductNumber()
            {
                return ProductNumber;
            }


            public string GetCategory()
            {
                return Category;
            }
            public string GetName()
            {
                return Name;
            }



            public string GetDescription()
            {
                return Description;
            }
            public int GetPrice()
            {
                return Price;
            }



        }
    }



    

