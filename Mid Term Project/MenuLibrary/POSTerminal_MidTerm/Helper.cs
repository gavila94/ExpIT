using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POSTerminal;

namespace POSTerminal_MidTerm
{
    class Helper
    {
        public static void DisplayMenu()
        {
            Console.WriteLine("Code     ItemName        Category \t Price");
            Console.WriteLine("------------------------------------------------------");

            foreach (Menu itemList in MenuList.ourMenu)
            {
                Console.WriteLine(itemList.Letter + "   -  " + itemList.Name + "    \t " + itemList.Category + "   \t " + itemList.Price);
            }
        }

       

    }
}
