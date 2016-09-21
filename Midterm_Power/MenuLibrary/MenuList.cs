using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSTerminal
{
    public class MenuList
    {
        public static List<Menu> MenuFromExternalFile()
        {

            return
        }
        public static List<Menu> ourMenu = new List<Menu>()
        {
            new Menu("a", "Hamburger", "Burger", 2.99f),
            new Menu("b", "Cheeseburger", "Burger", 3.99f),
            new Menu("c", "Cheese Fries", "Fries", 3.49f),
            new Menu("d","Cajun Fries", "Fries", 3.69f),
            new Menu("e","Soda", "Beverage", 1.99f),
            new Menu("f","Milkshake", "Beverage", 3.99f),
            new Menu("g","Cheese dog", "Hotdog", 1.99f),
            new Menu("h","Bacon dog", "Hotdog", 1.99f),
            new Menu("i","Veggie Sandwich", "Sandwich", 4.99f),
            new Menu("j","BLT", "Sandwich", 4.49f),
            new Menu("k","Cheese Pizza", "Pizza", 4.99f),
            new Menu("l","Pepperoni Pizza", "Pizza", 5.99f),
        };
           // public static List<Menu> FullMenu { get { return ourMenu; } }

    }
}
