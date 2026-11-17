namespace AddisEats.Models
{
    public class Menuitem
    {
        public Menuitem(int id, string name, string category, decimal price)
        {
            Id = id;
            Name = name;
            Category = category;
            Price = price;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public decimal PricewithVat => Price * 0.15m; // 15% VAT
    }
}