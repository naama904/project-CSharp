
namespace BO;
/// <summary>
/// רשומה לנתוני לקוח שהזמין
/// </summary>
/// <param name="Identity">זהות</param>
/// <param name="CustomerName">שם לקוח</param>
/// <param name="Address">כתובת לקוח</param>
/// <param name="Phone">טלפון לקוח</param>
public record Customer
        (int Identity,
    string? CustomerName,
    string? Address,
    string? Phone)
{
}
