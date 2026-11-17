namespace Store.Domain.Entities;
    public class OrderItem
{
    public int OrderId { get; set; }
    public int ProductId { get; set; }
    public int  Quntity {  get; set; }
    public decimal UnitPrice {  get; set; }



public Order Order { get; set; }

    public Product Product { get; set; } = null;

}
