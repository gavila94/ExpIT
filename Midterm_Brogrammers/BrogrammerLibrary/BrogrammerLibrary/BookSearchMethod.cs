using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrogrammerLibrary
{
    public class BookSearchMethod
    {
        public static void bookSearch()
        {
            string toContinue;
            
                List<ABook> bookCatalog = AllTheBooks.getBooks();
                string userInputForBookSearch = Console.ReadLine();
                foreach (ABook individualBooks in bookCatalog)
                {
                    if (individualBooks.Title.ToLower() == userInputForBookSearch.ToLower())
                    {
                        Console.WriteLine(individualBooks.Number + " Title: " + individualBooks.Title + " Author: " + individualBooks.Author);
                    }

                    if (individualBooks.Author.ToLower() == userInputForBookSearch.ToLower())
                    {
                        Console.WriteLine(individualBooks.Number + " Author: " + individualBooks.Author + " Title: " + individualBooks.Title);
                    }
                    else
                    {
                        Console.WriteLine("I'm sorry, we do not have that book in our collection");
                        
                    }
                 
                }
 
        }
    }
}
        
    

