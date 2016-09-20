using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrogrammerLibrary
{
    public class ABook
    {
        public string Title = "";
        public string Author = "";
        public int Number = 0;
        public string Status = "";
        public string DueDate = " ";
        public ABook(int number, string title, string author, string status, string dueDate)
        {
            Number = number;
            Title = title;
            Author = author;
            Status = status;
            DueDate = dueDate;
        }



        public static void DisplayBooks()
        {


            string readtext = File.ReadAllText(@"C: \Users\Student\Documents\Visual Studio 2015\Projects\BrogrammerLibrary\BrogrammerLibrary\LibraryOfBooks.txt");
            Console.WriteLine(readtext);



        }
        public static void UpdateTextFile(List<ABook> books)
        {
            string saveFileContent = "";
            foreach (var book in books)
            {
                saveFileContent = saveFileContent + book.Number + "\n" + book.Title + "\n" + book.Author + "\n" + book.Status + "\n"+ book.DueDate+ "\n";
            }

             File.WriteAllText(@"C: \Users\Student\Documents\Visual Studio 2015\Projects\BrogrammerLibrary\BrogrammerLibrary\LibraryOfBooks.txt", saveFileContent);
        }
        }
    }


