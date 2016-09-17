using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrogrammerLibrary
{
   public class DisplayListMethod
    {
        public static void displayBookList()
        {
            List<ABook> bookCatalog = AllTheBooks.getBooks();

            foreach (ABook individualBooks in bookCatalog)
            {
                Console.WriteLine(individualBooks.Number + " Title: " + individualBooks.Title + " Author: " + individualBooks.Author);
            }
        }
    }
}
