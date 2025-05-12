namespace BO;

/// <summary>
/// עזר לתיאור מוצר בהזמנה
/// </summary>
public class ProductInOrder
{
    public int IdProduct { get; init; }
    public string ProductName { get; set; }
    public double BasicPriceForProduct { get; set; }
    public int AmountInOrder { get; set; }
    public List<SaleInProduct> SalesListForThisProduct { get ; set ; }
    public double FinalPriceForProduct { get; set; }
    public override string ToString() => this.ToStringProperty();
}
