
namespace BlApi;

public interface IOrder
{
    BO.Order createOrder();
    List<BO.SaleInProduct> AddProductToOrder(BO.Order order,int idProduct,int amountToOrder);
    void CalcTotalPriceForProduct(BO.ProductInOrder product);
    void CalcTotalPrice(BO.Order order);
    void doOrder(BO.Order order);
    void searchSaleForProduct(BO.ProductInOrder product, bool isPriorityCustomer);
}
