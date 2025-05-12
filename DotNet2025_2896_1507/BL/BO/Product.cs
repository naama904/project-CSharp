namespace BO;

/// <summary>
/// רשומה לנתוני מוצר
/// </summary>
public class Product
{
    public int IdProduct { get; init; }
    public string? ProductName { get; set; }
    public Categories? Category { get; set; }
    public double? Price { get; set; }
    public int? AmountInStock { get; set; }
    public List<SaleInProduct> SalesListForProduct { get; set; }

    public object ToStringProperty { get; set; }

    public override string ToString() => this.ToStringProperty();
}
