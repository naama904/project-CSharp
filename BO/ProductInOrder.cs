

namespace BO;
/// <summary>
/// רשומה לנתוני מוצר שבהזמנה
/// </summary>
/// <param name="IdProductInOrder">ברקוד מוצר שבהזמנה</param>
/// <param name="ProductNameInOrder">שם מוצר שבהזמנה</param>
/// <param name="PriceBasicToProduct">מחיר בסיס למוצר שבהזמנה</param>
/// <param name="AmountInOrder">כמות שבהזמנה</param>
/// <param name="ListSaleForProduct">רשימת מבצעים למוצר זה</param>
/// <param name="EndPriceToProduct">מחיר סופי למוצר </param>
public record ProductInOrder
    (int IdProductInOrder,
    string? ProductNameInOrder,
    double? PriceBasicToProduct,
    int? AmountInOrder,
    List<SaleInProduct>ListSaleForProduct,
    double? EndPriceToProduct
    )
{

}
