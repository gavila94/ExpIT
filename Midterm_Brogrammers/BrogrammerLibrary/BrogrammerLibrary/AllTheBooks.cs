using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrogrammerLibrary
{
   public class AllTheBooks
    {
        public static List<ABook> getBooks()
        {
            List<ABook> Catalog = new List<ABook>();

            Catalog.Add(new ABook(00, "The Tales of Beedle the Bard", "Leonardo da Vinci", "unavailable"));
            Catalog.Add(new ABook(01, "Magna Carta Original exemplar", "King John", "avilable"));

            Catalog.Add(new ABook(02, "St Cuthbert Gospel", "The Stonehurst Gospel", "available"));
            Catalog.Add(new ABook(03, "Rothschild Prayerbook", "Rothchild", "available"));
            Catalog.Add(new ABook(04, "Gospels of Henry the Lion Original and only copy", "Order of Saint Benedict", "available"));
            Catalog.Add(new ABook(05, "The Birds of America", "John James Audubon", "available"));
            Catalog.Add(new ABook(06, "The Da Vinci Code", "Dan Brown", "available"));
            Catalog.Add(new ABook(07, "Harry Potter and the deathly hollows", "JK Rawling", "available"));
            Catalog.Add(new ABook(08, "Fifty Shades of grey", "EL James", "available"));

            Catalog.Add(new ABook(09, "Angels and Demons", "Dan Brown", "available"));
            Catalog.Add(new ABook(10, "Twilight", "Stephany Mayer", "available"));
            Catalog.Add(new ABook(11, "Girl who kicked the hornet's nest", "Stieg larsson", "available"));
            Catalog.Add(new ABook(12, "Atonement", "Ian McEwan", "available"));
            Catalog.Add(new ABook(13, "Life of pi", "Yann Martel", "available"));
            Catalog.Add(new ABook(14, "Labyrinth", "Kate Mosse", "available"));
            Catalog.Add(new ABook(15, "The Island", "Victoria Hislop", "available"));
            return Catalog;
        }
    }

}


