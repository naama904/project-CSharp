
namespace BO;

public record Order
    (bool?IsSpecialCustomer,
    List<Product>ListProductInOrder,
    double? EndPriceToPay)
{
}
