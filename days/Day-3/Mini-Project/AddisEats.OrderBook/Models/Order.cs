namespace AddisEats.OrderBook.Models;

public class Order
{
    public string Customer { get; set; }
    public string Area { get; set; }
    public List<OrderLine> Lines { get; set; }

    public Order(string customer, string area, List<OrderLine> lines)
    {
        Customer = customer;
        Area = area;
        Lines = lines;
    }

    public decimal Total
    {
        get
        {
            return Lines.Sum(line => line.Subtotal);
        }
    }
}