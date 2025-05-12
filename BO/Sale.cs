
namespace BO;

public record Sale
        (int IdSale,
    int? IdProductOfSale,
    int? AmountToGetSale,
    double? SumPrice,
    bool? IsForAllCustomers,
    DateTime? StartSale,
    DateTime? EndSale)
{
}
