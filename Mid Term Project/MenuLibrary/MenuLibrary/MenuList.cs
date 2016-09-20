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
            string[] MenuFromTextFile = System.IO.File.ReadAllLines(@"C:\Users\PCUser\Documents\Mid Term Project\MenuLibrary\MenuLibrary\MenuFile.txt");
            List<Menu> listofMenuItem = new List<Menu>();
            for (int i = 0; i < MenuFromTextFile.Length; i++)
            {
                string[] NamePrice = MenuFromTextFile[i].Split(',');

                listofMenuItem.Add(new Menu(NamePrice[0], NamePrice[1], NamePrice[2], float.Parse(NamePrice[3])));

            }
            return listofMenuItem;
        }
        public static List<Menu> ourMenu = MenuFromExternalFile();


   
    }
}
