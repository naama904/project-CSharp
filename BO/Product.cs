

using DO;

namespace BO;
/// <summary>
/// מוצר להזמנה
/// </summary>
/// <param name="IdProduct"></param>
/// <param name="ProductName"></param>
/// <param name="Category"></param>
/// <param name="Price"></param>
/// <param name="AmountInStock"></param>
/// <param name="ListSaleToProduct">רשימת מבצעים למוצר</param>
public record Product
    (int IdProduct,
    string? ProductName,
    Categories? Category,
    double? Price,
    int? AmountInStock,
    List<SaleInProduct>ListSaleToProduct)
{
}
