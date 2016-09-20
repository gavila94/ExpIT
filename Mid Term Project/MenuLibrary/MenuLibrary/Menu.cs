using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSTerminal
{
    public class Menu
    {
        string letter ;
        string name = "";
        string category = "";
        float price = 0.0f;

        public Menu(string Letter, string Name, string Category, float Price)
        {
            this.letter = Letter;
            this.name = Name;
            this.category = Category;
            this.price = Price;
        }

        public string Letter
        {
            get { return letter; }
        }
        public string Name
        {
            get { return name; }
        }
        public string Category
        {
            get { return category; }
        }
        public float Price
        {
            get { return price; }
        }

    }
}
