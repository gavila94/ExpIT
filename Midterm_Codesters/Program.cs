using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace point_of_sale_midterm
{
    class Program
    {
        static void Main(string[] args)
        {
            string newOrder;

            do
            {
                displayGreeting();

                int userType = getUserType();

                if (userType == 2)
                {
                    addToMenu();
                }

                List<string> unformattedMenu = inputMenu();

                List<Product> menu = createProducts(unformattedMenu);

                displayMenu(menu);

                List<cartItem> shoppingList = getUserInput(menu);

                shoppingList = getInfo(shoppingList, menu);

                Payment pay = Payment.paymentMethod(shoppingList);

                Console.WriteLine("\nWould you like a copy of your receipt?");
                string needReceipt = Console.ReadLine();

                if (needReceipt.ToLower() == "y" || needReceipt.ToLower() == "yes")
                {
                    Console.Clear();
                    Receipt.printReceipt(shoppingList, pay);
                }
                else
                {
                    Console.WriteLine("\nThanks for visiting us!");
                }

                Console.Write("\nIs there another order?(y/n):\t");
                newOrder = Console.ReadLine();
            } while (newOrder.ToLower() == "yes" || newOrder.ToLower() == "y");
        }

        static void displayGreeting()
        {
            Console.Write("*****************************************");
            Console.Write("\n*   Welcome To Codesters Coffee Shop!   *");
            Console.Write("\n*****************************************\n");
        }

        static int getUserType()
        {
            int input;
            do
            {
                Console.Write("\nAre you a 1) Customer or 2) Employee?:\t");
                bool result = Int32.TryParse(Console.ReadLine(), out input);

                if (input < 1 || input > 2)
                    Console.Write("\nEnter 1 for Customer or 2 for Employee");
            } while (input < 1 || input > 2);

            return input;
        }

        static void addToMenu()
        {
            Console.Write("\nWould you like to add a new item to the menu? (y/n)\t");
            string menuAdd = Console.ReadLine();

            if (menuAdd.ToLower() == "yes" || menuAdd.ToLower() == "y")
            {
                Console.Write("\nEnter item name:\t");
                string itemName = Console.ReadLine();

                Console.Write("\nEnter item category (foods, drinks, sweets):\t");
                string itemCategory = Console.ReadLine();

                Console.Write("\nEnter item description:\t");
                string itemDescription = Console.ReadLine();

                Console.Write("\nEnter item price:\t");
                string itemPrice = Console.ReadLine();

                string itemLine = itemName + ";" + itemCategory + ";" + itemDescription + ";" + itemPrice + ";";

                try
                {
                    StreamWriter outputFile;
                    outputFile = File.AppendText(@"C:\Users\Mo\Desktop\Codester Group Project\point_of_sale_midterm\menu.txt");
                    outputFile.WriteLine(itemLine);

                    outputFile.Close();
                }
                catch
                {
                    Console.Write("\n<---Error--->File could not be updated.");
                }
            }
        }

        static List<string> inputMenu()
        {
            List<string> unformattedMenu = new List<string>();

            try
            {
                StreamReader inputFile = File.OpenText(@"C:\Users\Mo\Desktop\Codester Group Project\point_of_sale_midterm\menu.txt");

                unformattedMenu.Add(inputFile.ReadToEnd());

                inputFile.Close();
            }
            catch
            {
                Console.Write("\n\n<---Error--->File was not found");
            }

            return unformattedMenu;
        }

        static List<Product> createProducts(List<string> unformattedMenu)
        {
            //line count
            var lineCount = 0;
            using (var reader = File.OpenText(@"C:\Users\Mo\Desktop\Codester Group Project\point_of_sale_midterm\menu.txt"))
            {
                while(reader.ReadLine() != null)
                {
                    lineCount++;
                }
            }

            List<Product> menu = new List<Product>();
            Product[] tempMenu = new Product[lineCount];

            for (int i = 0; i < lineCount; i++)
                tempMenu[i] = new Product();

            char[] delim = { ';' };

            List<string[]> temp = new List<string[]>();

            foreach (string line in unformattedMenu)
                temp.Add(line.Split(delim));

            foreach (string[] x in temp)
            {
                int i = 0;

                for (int j = 0; j < lineCount; j++)
                {
                    tempMenu[j].ProdNum = (j + 1);
                    tempMenu[j].Name = x[i].Replace("\r\n", "").Trim();
                    i++;
                    tempMenu[j].Category = x[i++].Replace("\r\n\n", "").Trim();
                    tempMenu[j].Description = x[i++].Replace("\r\n", "").Trim();
                    tempMenu[j].Price = double.Parse(x[i++].Replace("\r\n", "").Trim());
                }
            }

            foreach (Product item in tempMenu)
                menu.Add(item);

            return menu;
        }

        static void displayMenu(List<Product> menu)
        {
            List<Product> food = new List<Product>();
            List<Product> drink = new List<Product>();
            List<Product> sweets = new List<Product>();

            foreach (Product item in menu)
            {
                if (item.Category.ToLower() == "foods")
                    food.Add(item);
                else if (item.Category.ToLower() == "drinks")
                    drink.Add(item);
                else if (item.Category.ToLower() == "sweets")
                    sweets.Add(item);
            }

            Console.Write("\nFood");
            Console.Write("\n==========");
            foreach (Product item in food)
            {
                Console.Write("\n" + item.ProdNum.ToString() + ") " + item.Name);
                Console.Write("\n\t" + item.Description + "............." + item.Price.ToString("C2"));
            }

            Console.Write("\n\nDrinks");
            Console.Write("\n==========");
            foreach (Product item in drink)
            {
                Console.Write("\n" + item.ProdNum.ToString() + ") " + item.Name);
                Console.Write("\n\t" + item.Description + "............." + item.Price.ToString("C2"));
            }

            Console.Write("\n\nSweets");
            Console.Write("\n==========");
            foreach (Product item in sweets)
            {
                Console.Write("\n" + item.ProdNum.ToString() + ") " + item.Name);
                Console.Write("\n\t" + item.Description + "............." + item.Price.ToString("C2"));
            }

            Console.Write("\n\n");
        }

        static List<cartItem> getUserInput(List<Product> menu)
        {
            int userInput, quantity;
            string addMore, redisplayMenu;
            List<int> userItems = new List<int>();
            List<int> quantites = new List<int>();

            List<cartItem> userCart = new List<cartItem>();

            var lineCount = 0;
            using (var reader = File.OpenText(@"C:\Users\Mo\Desktop\Codester Group Project\point_of_sale_midterm\menu.txt"))
            {
                while (reader.ReadLine() != null)
                {
                    lineCount++;
                }
            }

            do
            {
                do
                {
                    Console.Write("\nPlease select your items(1-" + lineCount.ToString() + "):\t");
                    bool result = Int32.TryParse(Console.ReadLine(), out userInput);

                    if (userInput < 1 || userInput > lineCount)
                        Console.Write("\nInput was not correct, please enter 1-12\n");
                } while (userInput < 1 || userInput > lineCount);

                do
                {
                    Console.Write("\nPlease enter a quantity:\t");
                    bool result_ = Int32.TryParse(Console.ReadLine(), out quantity);
                    if (quantity < 1)
                        Console.Write("\nIntput was not correct, please enter a whole number\n");
                } while (quantity < 1);

                userItems.Add(userInput);
                quantites.Add(quantity);

                Console.Write("\nYou've ordered: ");
                
                for(int i = 0; i < userItems.Count; i++)
                {
                    Console.Write("\n" + quantites.ElementAt(i).ToString() + " of item #" + userItems.ElementAt(i).ToString());
                }

                Console.Write("\n\nWould you like to add another item?(y/n):\t");
                addMore = Console.ReadLine();

                if (addMore.ToLower() == "y" || addMore.ToLower() == "yes")
                {
                    Console.Write("\nWould you like to see the menu?(y/n):\t");
                    redisplayMenu = Console.ReadLine();
                    if (redisplayMenu.ToLower() == "y" || redisplayMenu.ToLower() == "yes")
                    {
                        Console.Clear();
                        displayMenu(menu);
                    }
                }
            } while (addMore.ToLower() == "y" || addMore.ToLower() == "yes");

            Console.Clear();

            Product[] choosenProducts = new Product[userItems.Count];

            for (int i = 0; i < choosenProducts.Length; i++)
            {
                choosenProducts[i] = new Product();
            }

            int j = 0;
            foreach (Product item in choosenProducts)
            {
                item.ProdNum = userItems.ElementAt(j);
                j++;
            }

            cartItem[] newItems = new cartItem[choosenProducts.Length];

            for (int i = 0; i < newItems.Length; i++)
            {
                newItems[i] = new cartItem();
            }

            int k = 0;
            foreach (cartItem product in newItems)
            {
                product.Item = choosenProducts[k];
                product.Quantity = quantites.ElementAt(k);
                k++;

                userCart.Add(product);
            }
            return userCart;
        }

        static List<cartItem> getInfo(List<cartItem> shoppingList, List<Product> menu)
        {
            foreach (cartItem info in shoppingList)
            {
                for (int i = 0; i <= menu.Count; i++)
                {
                    if (info.Item.ProdNum == (i + 1))
                    {
                        info.Item.Name = menu.ElementAt(i).Name;
                        info.Item.Price = menu.ElementAt(i).Price;
                        info.Item.Category = menu.ElementAt(i).Category;
                        info.Item.Description = menu.ElementAt(i).Description;
                    }
                }
            }

            return shoppingList;
        }
    }
}
