using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryTerminal
{
    class Admin //: SuperClassToAdminAndUser
    {
        
 public static List<Books> listOfBooks = new List<Books> {
new Books ("01","Microsoft Visual C# Step by Step","John Sharp","5", "Reference", "Available"),
new Books ("02","The Great Gatsby", "F. Scott Fitzgerald","5", "Fiction", "Available"),
new Books ("03","The Grapes of Wrath", "John Steinbeck","3", "Fiction", "Available"),
new Books ("04","Java: A Beginner's Guide", "Herbert Schildt","2", "Reference", "Available"),
new Books ("05","Milk and Honey", "Rupi Kaur","3","Fiction", "Available"),
new Books ("06","The 5 Love Languages: The Secret to Love That Lasts", "Gary Chapman","3", "Self-Help", "Available"),
new Books ("07","The Audacity of Hope", "Barack Obama", "2", "Non-Fiction", "Available"),
new Books ("08","Forks Over Knives", "Del Sroufe", "1", "Reference", "Available"),
new Books ("09","Quick Slow Cooking","Kim Laidlaw", "3", "Reference", "Available"),
new Books ("10","Big Magic : Creative Living Beyond Fear", "Elizabeth Gilbert","5", "Self-Help", "Available"),
new Books ("11","Think and Grow Rich", "Napolean Hill","3", "Non-Fiction", "Available"),
new Books ("12","Creativity Inc", "Edwin Catmull","2", "Non-Fiction", "Available"),
new Books ("13","Green Eggs and Ham", "Dr. Seuss", "4", "Children's", "Available"),
new Books ("14","Goodnight Moon", "Margaret Wise Brown", "4", "Children's", "Available"),
 new Books("15","Where the Wild Things Are","Maurice Sendak","5","Children's", "Available"),
new Books("16","The New Jim Crow", "Michelle Alexander","3", "Non-Fiction", "Available"),
new Books("17","Stone's Revenge", "Sylvia Hubbard", "1", "Fiction", "Available"),
new Books("18","How to Win Friends and Influence People", "Dale Carnegie", "2", "Self-Help", "Available"),
 new Books("19","Who Moved My Cheese", "Spencer Johnson", "5", "Self-Help", "Available"),
 new Books("20","Rushing Waters", "Danielle Steele", "5", "Fiction", "Available")
    };

        public static List<string> categoryList = new List<string>
        {
            "Self-Help", "Fiction", "Non-Fiction", "Children's", "Reference"};

        public static List<string> authorList = new List<string>
        {
            "Spencer Johnson", "Dale Carnegie", "Sylvia Hubbard", "Michelle Alexander", "Maurice Sendak", "Margaret Wise Brown",
            "Dr. Seuss", "Charlotte Bronte", "Rupi Kaur", "Edwin Catmull", "John Sharp","F. Scott Fitzgerald", "Napolean Hill",
            "Elizabeth Gilbert", "Barack Obama", "Del Sroufe", "Kim Laidlaw","Gary Chapman", "	John Steinbeck"
        };

       public static List<Books> CheckOutList = new List<Books>();




    }
}
