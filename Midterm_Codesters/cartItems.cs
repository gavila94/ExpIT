namespace point_of_sale_midterm
{
    public class cartItem
    {
        private Product item = new Product();
        private int quantity;
        //private double subtotal;

        public double Subtotal { get { return item.Price * quantity; } }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public Product Item
        {
            get { return item; }
            set { item = value; }
        }

    }
}
