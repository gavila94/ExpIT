using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTermProject_Brogrammers
{
    class BookCatalog
    {
        public string title;
        public string author;
        public int bookNumberInCatalog;
        public string status;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        public int BookNumberInCatalog
        {
            get { return bookNumberInCatalog; }
            set { bookNumberInCatalog = value; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public BookCatalog()
        {
            BookNumberInCatalog = 0;
            Title = "Title";
            Author = "John Doe";
            Status = "Available";


        }

        public void DisplayInformation()
        {
            Console.WriteLine("Book Number {0}", BookNumberInCatalog);
            Console.WriteLine("Title: {0}", Title);
            Console.WriteLine("Author: {0}", Author);
            Console.WriteLine("Status: {0}", Status);
            Console.WriteLine("____________________________________");

        }
    
                //METHODS

                //LOADS THE DATA FROM TEXTFILE
            

        public static void LoadData(ref BookCatalog[] objBook)
        {
            StreamReader reader = new StreamReader("Books.txt"); //setting up stream reader
            int size = Convert.ToInt32(reader.ReadLine());
            objBook = new BookCatalog[size]; //dynamic array

            for (int i = 0; i < objBook.Length; i++)
            {
                objBook[i] = new BookCatalog();
                //objBook[i].BookNumberInCatalog = Convert.ToInt16(reader.ReadLine());
                objBook[i].Title = reader.ReadLine();
                objBook[i].Author = reader.ReadLine();
                objBook[i].Status = reader.ReadLine();
            }

            reader.Close();


            //DESPLAYS ALL BOOKS TO SCREEN
        }

        public static void DisplayAllBooks(BookCatalog[] objBooks)
        {
            Console.Clear(); // Clears screen for user

            for (int i = 0; i < objBooks.Length; i++)
            {
                objBooks[i].DisplayInformation(); //Method we created in class
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        //RETURN BOOKS
        public static void ReturnBook(ref BookCatalog[] objBooks)
        {
           // StreamWriter write = new StreamWriter("Books.txt"); // Allows you to write over
  
            //writ(objBooks.Length + 1); // Allows to write a new book to text file

            Console.WriteLine("Thank you for choosing the Brogrammer's Library. To return your book press any key...");
            Console.ReadKey();

            BookCatalog temp = new BookCatalog(); // creates new object of book

            Console.WriteLine("Enter Title: ");
            temp.Title = Console.ReadLine(); // takes user input and store it in the variable

            Console.WriteLine("Enter Author: ");
            temp.Author = Console.ReadLine(); // takes user input and store it in the variable

            //Console.WriteLine("Enter Book Number: ");
            //temp.BookNumberInCatalog = Convert.ToInt32(Console.ReadLine()); // takes user input and store it in the variable

            Console.WriteLine("Enter Status: ");
            temp.Status = Console.ReadLine(); // takes user input and store it in the variable

            //write new data to text file
           
            System.IO.File.WriteAllText(@"C:\Users\Student\Documents\Visual Studio 2015\Projects\MidTermProject_Brogrammers\MidTermProject_Brogrammers/Books.txt", temp.Title);
            System.IO.File.WriteAllText(@"C:\Users\Student\Documents\Visual Studio 2015\Projects\MidTermProject_Brogrammers\MidTermProject_Brogrammers/Books.txt", temp.Author);
            System.IO.File.WriteAllText(@"C:\Users\Student\Documents\Visual Studio 2015\Projects\MidTermProject_Brogrammers\MidTermProject_Brogrammers/Books.txt", temp.Status);
            // write.WriteLine(temp.Title);
            //write.WriteLine(temp.Author);
            //write.WriteLine(temp.BookNumberInCatalog);
            //write.WriteLine(temp.Status);

            ////put old Books back in the text file
            //for (int i = 0; i < objBooks.Length; i++)
            //{
            //    write.WriteLine(objBooks[i].Title);
            //    write.WriteLine(objBooks[i].Author);
            //    write.WriteLine(objBooks[i].BookNumberInCatalog);
            //    write.WriteLine(objBooks[i].Status);

            //}
            //write.Flush();
            //write.Close(); // close the file after the write

            LoadData(ref objBooks); // updates the array
        }


        //SEARCH FOR THE BOOK BY TITLE AND AUTHOR

        public static void BookSearchAuthorOrTitle(ref BookCatalog[] objBooks)
        {
            string userInputForBookSearch = Console.ReadLine();
            for (int i = 0; i < objBooks.Length; i++)
            {
                if (objBooks[i].Title.ToLower() == userInputForBookSearch.ToLower())
                {
                    Console.WriteLine("\n" +objBooks[i].BookNumberInCatalog + " Author: " + objBooks[i].Author + " Title: " + objBooks[i].Title+ "\n");
                }

                if (objBooks[i].Author.ToLower() == userInputForBookSearch.ToLower())
                {
                    Console.WriteLine("\n" + objBooks[i].BookNumberInCatalog + " Author: " + objBooks[i].Author + " Title: " + objBooks[i].Title+ "\n");
                }
            }
        }


        // CHECK OUT A BOOK
        public static void BookCheckout(ref BookCatalog[] objBooks)
        {


            int userInputForBookNumber = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < objBooks.Length; i++)
            {
                if (userInputForBookNumber == objBooks[i].BookNumberInCatalog)
                {
                    if (objBooks[i].Status == "Available")
                    {
                        StreamWriter write = new StreamWriter("Books.txt", true); // Allows you to Append the text file
                        write.WriteLine(objBooks[i].Status);
                        write.Close();


                    }



                }

            }
        }
    }
}

            
