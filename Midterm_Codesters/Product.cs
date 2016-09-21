using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace point_of_sale_midterm
{
    public class Product
    {
        private string _name;
        private string _category;
        private string _description;
        private double _price;
        private int _prodNum;
               
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Category
        {
            get { return _category; }
            set { _category = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public int ProdNum
        {
            get { return _prodNum; }
            set { _prodNum = value; }
        }
    }
}
