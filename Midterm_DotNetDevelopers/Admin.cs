using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTerminal
{
    class Admin : SuperClassToAdminAndUser
    {
        
 public static List<Books> listOfBooks = new List<Books> {
new Books ("001","Microsoft Visual C# Step by Step","John Sharp",5, "Reference", "yes"),
new Books ("002","The Great Gatsby", "F. Scott Fitzgerald",5, "Fiction", "yes"),
new Books ("003","The Grapes of Wrath", " John Steinbeck",3, "Fiction", "yes"),
new Books ("004","Java: A Beginner's Guide", "Herbert Schildt",2, "Reference", "yes"),
new Books ("005","Milk and Honey", "Rupi Kaur",3,"Fiction", "yes"),
new Books ("006","The 5 Love Languages: The Secret to Love That Lasts", "Gary Chapman",3, "Self-Help", "yes"),
new Books ("007","The Audacity of Hope", "Barack Obama", 2, "Non-Fiction", "yes"),
new Books ("008","Forks Over Knives", "Del Sroufe", 1, "Reference", "yes"),
new Books ("009","Quick Slow Cooking","Kim Laidlaw", 3, "Reference", "yes"),
new Books ("010","Big Magic : Creative Living Beyond Fear", "Elizabeth Gilbert",5, "Self-Help", "yes"),
new Books ("011","Think and Grow Rich", "Napolean Hill",3, "Non-Fiction", "yes"),
new Books ("012","Creativity Inc", "Edwin Catmull",2, "Non-Fiction", "yes"),
new Books ("013","Green Eggs and Ham", "Dr. Seuss", 4, "Children's", "yes"),
new Books ("014","Goodnight Moon", "Margaret Wise Brown", 4, "Children's", "yes"),
 new Books("015","Where the Wild Things Are","Maurice Sendak",5,"Children's", "yes"),
new Books("016","The New Jim Crow", "Michelle Alexander",3, "Non-Fiction", "yes"),
new Books("017","Stone's Revenge", "Sylvia Hubbard", 1, "Fiction", "yes"),
new Books("018","How to Win Friends and Influence People", "Dale Carnegie", 2, "Self-Help", "yes"),
 new Books("019","Who Moved My Cheese", "Spencer Johnson", 5, "Self-Help", "yes"),
 new Books("020","Rushing Waters", "Danielle Steele", 5, "Fiction", "yes")
    };

        public static List<string> categoryList = new List<string>
        {
            "Technology", "Self-Help", "Fiction", "Non-Fiction", "Children's", "Reference"};

        public static List<string> authorList = new List<string>
        {
            "Spencer Johnson", "Dale Carnegie", "Sylvia Hubbard", "Michelle Alexander", "Maurice Sendak", "Margaret Wise Brown",
            "Dr. Seuss", "Charlotte Bronte", "Rupi Kaur", "Edwin Catmull", "John Sharp","F. Scott Fitzgerald", "Napolean Hill",
            "Elizabeth Gilbert", "Barack Obama", "Del Sroufe", "Kim Laidlaw","Gary Chapman", "	John Steinbeck"
        };

       public static List<Books> CheckOutList = new List<Books>();




    }
}
