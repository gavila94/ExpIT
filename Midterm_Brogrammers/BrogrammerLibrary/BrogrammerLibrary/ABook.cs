using System;
using System.Collections.Generic;
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
        public ABook(int number, string title, string author, string status)
        {
            Title = title;
            Author = author;
            Number = number;
            Status = status;
        }

    }
}

