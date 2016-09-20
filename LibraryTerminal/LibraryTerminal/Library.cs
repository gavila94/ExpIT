using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTerminal
{
    public class Library

    {
        Admin admin = new Admin();

        public void takeBook(string selectedBook)
        {
          foreach (Books value in Admin.listOfBooks)
            {
                if (value.BookNumber == selectedBook || value.title == selectedBook)
                {
                                

                    if (value.availability == "Available")
                    {
                        Admin.CheckOutList.Add(value);
                        Console.WriteLine("Book {0} added to the cart", value.title);
                        value.availability = "Unavailable";
                    }
                    else
                        Console.WriteLine("Book is not available");
                }
           }

        }
        public void displayCheckout(string name, int accnum)
        {
            if (Admin.CheckOutList.Count != 0)
            {
                Console.WriteLine("Name:\t" + name + "\tAccount Number:\t" + accnum);

                foreach (Books value in Admin.CheckOutList)
                {
                    
                    Console.WriteLine(value.title + "\t" + value.author);
                    

                }

                DateTime checkedDate = DateTime.Now;
                DateTime Duedate = checkedDate.AddDays(14);
                Console.WriteLine("The books due date is:\t" + Duedate);
            }
            else
                Console.WriteLine("No books to check-out");
        }
                
        public void submitBook(string takenBook)
        {
            foreach (Books item in Admin.listOfBooks)
            {
                if(item.BookNumber == takenBook || item.title == takenBook)
                {
                    item.availability = "yes";
                }
          }
     }
        

        public void displayBooks()
        {
            foreach (Books book in Admin.listOfBooks.OrderBy(m => m.title))
                Console.WriteLine( book.BookNumber + "\t Book Title:" + book.title);
        }
        public void displayCategories()
        {
            foreach (string value in Admin.categoryList)
                Console.WriteLine(value);
        }
        public void displayAuthorList()
        {
            foreach (string value in Admin.authorList)
                Console.WriteLine(value);
        }
    }
}




        




            

       