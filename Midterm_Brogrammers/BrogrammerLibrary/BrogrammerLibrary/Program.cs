using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrogrammerLibrary
{
    class Program
    {
        static void Main(string[] args)
        {

            string makeAnotherChoice;
            do {
                
                Console.WriteLine("Welcome to the Brogrammer Library\n");
                Console.WriteLine("Select an option:");
                Console.WriteLine("1)Display book List");
                Console.WriteLine("2)Search by title or author");
                Console.WriteLine("3)Return book\n");
                Console.Write("Enter(1, 2, or 3):");
                string userSelection = Console.ReadLine();
                int userChoice = int.Parse(userSelection);
                userChoice = Convert.ToInt32(userSelection);
                List<ABook> bookCatalog = AllTheBooks.getBooks();


                switch (userChoice)
                {
                    case 1:

                        DisplayListMethod.displayBookList();

                        Console.WriteLine("Would you like to check out a book from this list? (choose a number)");
                        string bookNumberChosen = Console.ReadLine();
                        int chosenBookNumber = int.Parse(bookNumberChosen);

                        foreach (ABook individualBooks in bookCatalog)
                        {
                            if (chosenBookNumber == individualBooks.Number)
                            {
                                if (individualBooks.Status == "available")
                                {
                                    Console.WriteLine("You have checked out " );
                                }
                                else
                                {
                                    Console.WriteLine("Sorry this book is unavialable");
                                }
                            }
                        }
                            //display book list       
                            break;
                    case 2:
                        Console.WriteLine("Search by author or title:");                        
                        BookSearchMethod.bookSearch();
                        break;
                    case 3:
                        DisplayListMethod.displayBookList();

                        Console.WriteLine("Which book are you returning?(enter a number)");
                        string returnBookNumberChosen = Console.ReadLine();
                        int returnChosenBookNumber = int.Parse(returnBookNumberChosen);

                        foreach (ABook individualBooks in bookCatalog)
                        {
                            if (returnChosenBookNumber == individualBooks.Number)
                            {
                                if (individualBooks.Status == "available")
                                {
                                    Console.WriteLine("Sorry this book hasn't been checked out");
                                }
                                if(individualBooks.Status == "unavailable")
                                {
                                    Console.WriteLine("You have returned this book");
                                }
                            }
                        }
                        // return book method 
                        break;
                    default:
                        Console.WriteLine("Make another selection");
                        //loop back 
                        break;
                       
                }
                Console.WriteLine("Would you like to make another choice? (y/n):");
                 makeAnotherChoice= Console.ReadLine();
                
            } while (makeAnotherChoice == "y");
        }
    }
}

    
                //List<ABook> bookCatalog = AllTheBooks.getBooks();
                //Console.WriteLine("what book?");
                //string userInputForBookSearch = Console.ReadLine();
                //foreach (ABook individualBooks in bookCatalog)
                //{
                //    //if (individualBooks.Title.ToLower() == userInputForBookSearch.ToLower())
                //    //{
                //    //    Console.WriteLine(individualBooks.Title);
                //    //}

                //    //if (individualBooks.Author.ToLower() == userInputForBookSearch.ToLower())
                //    //{
                //    //    Console.WriteLine(individualBooks.Title + " " +individualBooks.Author);
                //    //}
