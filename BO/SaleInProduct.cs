

namespace BO;
/// <summary>
/// רשומה לנתוני מבצעים על מוצרים שבהזמנות
/// </summary>
/// <param name="IdSaleIn">מזהה למבצע שבהזמנה</param>
/// <param name="AmountToGetSaleIn">כמות למבצע</param>
/// <param name="SumPriceIn">מחיר</param>
/// <param name="IsForAllCustomersIn">האם מיועד לכל הלקוחות</param>
public record SaleInProduct
    (int IdSaleIn,
    int? AmountToGetSaleIn,
    double? SumPriceIn,
    bool? IsForAllCustomersIn)
{

}
