namespace BO;

/// <summary>
/// עזר לתיאור מבצע של מוצר
/// </summary>
public class SaleInProduct
{
    public int IdSale { get; init; }
    public int AmountToSale { get; set; }
    public double Price { get; set; }
    public bool IsForAllCustomers { get; set; }
    public override string ToString() => this.ToStringProperty();

}
