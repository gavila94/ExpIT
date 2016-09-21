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
            string due =Convert.ToString( DateTime.Now.AddDays(14).ToShortDateString());
            string makeAnotherChoice;
            do
            {

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

                List<ABook> books = AllTheBooks.ReadBooksFromFile();
                switch (userChoice)
                {
                    case 1:

                        foreach (ABook item in books)
                        {
                            Console.WriteLine("Book Number: " + item.Number + " " + item.Title + " , " + item.Author
                                + " - " + item.Status + " Date Due Back: " + item.DueDate);
                        }

                        Console.WriteLine("Please select the book you would like to check out. (Choose a Book Number)");
                        string bookNumberChosen = Console.ReadLine();
                        int chosenBookNumber = int.Parse(bookNumberChosen);

                        foreach (ABook individualBooks in books)
                        {
                            if (chosenBookNumber == individualBooks.Number)
                            {

                                if (individualBooks.Status == "available")
                                {
                                    Console.WriteLine("You have checked out your book selection ");
                                    individualBooks.Status = "unavailable";

                                    individualBooks.DueDate = due;
                                    ABook.UpdateTextFile(books);
                                }
                                else
                                {
                                    Console.WriteLine("Sorry this book is unavialable");
                                   
                                }

                            }

                        }
                        break;
                    //display book list       


                    case 2:
                        Console.WriteLine("Please enter an author or title you would like to search for:");
                        BookSearchMethod.bookSearch();
                        Console.WriteLine("Enter the Book Number you would like to check out");
                        string numberChosenForSearch = Console.ReadLine();
                        int chosenNumberForSearch = int.Parse(numberChosenForSearch);

                        foreach (ABook individualBooks in books)
                        {
                            if (chosenNumberForSearch == individualBooks.Number)
                            {
                                if (individualBooks.Status == "available")
                                {
                                    Console.WriteLine("You have checked out your book selection ");
                                    individualBooks.Status = "unavailable";

                                    individualBooks.DueDate = due;
                                    ABook.UpdateTextFile(books);
                                }
                                else
                                {
                                    Console.WriteLine("Sorry this book is unavialable");

                                }
                                
                            }
                        }
                        break;

                    case 3:
                        
                        
                        foreach(ABook item in books)
                        {
                           Console.WriteLine("Book Number: " + item.Number + " " + item.Title + " , " + item.Author
                                + " - " + item.Status + " Date Due Back: " + item.DueDate);
                        }
                     
                        Console.WriteLine("Which book are you returning?(enter a number)");
                        string returnBookNumberChosen = Console.ReadLine();
                        int returnChosenBookNumber = int.Parse(returnBookNumberChosen);

                        foreach (ABook individualBooks in books)
                        {
                            if (returnChosenBookNumber == individualBooks.Number)
                            {
                                if (individualBooks.Status == "available")
                                {

                                    Console.WriteLine("Sorry this book hasn't been checked out");
                                }

                                if (individualBooks.Status == "unavailable")
                                {
                                    individualBooks.Status = "available";
                                    individualBooks.DueDate = " ";

                                    ABook.UpdateTextFile(books);
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
                makeAnotherChoice = Console.ReadLine();

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
