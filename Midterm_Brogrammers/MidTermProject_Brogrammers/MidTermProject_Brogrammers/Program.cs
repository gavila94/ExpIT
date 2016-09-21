using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace MidTermProject_Brogrammers
{
    class BookLibraryProgram
    {
        public static void Main(string[] args)
        {
            BookCatalog[] objBook = new BookCatalog[1];
            int userChoice;
            //menu

            Console.WriteLine("Welcome to the Brogrammer Library\n");

            do
            {
                Console.WriteLine("1)Display Book List");
                Console.WriteLine("2)Search by Title or Author");
                Console.WriteLine("3)Return Book");
                Console.WriteLine("4)Checkout Book");
                Console.WriteLine("5) Exit");
                //Console.WriteLine("Please Press 1 to load the data");
                Console.Write("Enter Choice (1 - 5):");
                userChoice = Convert.ToInt32(Console.ReadLine());

                switch (userChoice)
                {
                    //Displays List Of Books
                    case 1:
                        BookCatalog.LoadData(ref objBook); //pass by reference

                        BookCatalog.DisplayAllBooks(objBook); //pass by value 

                        break;
                        //Search by Title or Author
                    case 2:
                        BookCatalog.LoadData(ref objBook); //pass by reference
                        Console.WriteLine("Please enter an author or book title");
                        BookCatalog.BookSearchAuthorOrTitle(ref objBook);
                        Console.WriteLine("___________________________");
                        break;

                    case 3:
                        BookCatalog.ReturnBook(ref objBook);

                        break;
                    case 4:
                        BookCatalog.BookCheckout(ref objBook);
                        break;


                    default:
                        break;
                }

            } while (userChoice != 5);
        }
    }
}



















