using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSTerminal
{
    public class Menu
    {
        public string letter ;
        public string name = "";
        public string category = "";
        public float price = 0.0f;

        public Menu(string Letter, string Name, string Category, float Price)
        {
            this.letter = Letter;
            this.name = Name;
            this.category = Category;
            this.price = Price;
        }

        //public string Name
        //{
        //    get { return Name; }
        //}
        //public string Category
        //{
        //    get { return Category; }
        //}
        //public float Price
        //{
        //    get { return Price; }
        //}

    }
}
