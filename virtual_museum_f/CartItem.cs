namespace virtual_museum_f
{
    public class CartItem
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public CartItem(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
    }
}
