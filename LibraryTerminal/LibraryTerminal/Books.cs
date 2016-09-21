using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTerminal
{
  public  class Books
    {
      public  string title;
      public string author;
     public string copies;
      public  string category;
      public string availability;
       public string BookNumber;
        
    

        public Books(string Index, string title, string author,string copies , string category, string availability)
        {
            this.title = title;
            this.author = author;
            this.copies = copies;
            this.category = category;
            this.availability = availability;
            this.BookNumber = Index;
            
        }
        

    }
}
