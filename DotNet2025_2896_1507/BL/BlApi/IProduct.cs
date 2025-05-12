
namespace BlApi;

public interface IProduct
{
    int Create(BO.Product item);
    BO.Product? Read(int id);
    //T? Read(Func<T, bool> filter);
    List<BO.Product?> ReadAll(Func<BO.Product, bool>? filter = null);
    void Update(BO.Product item);
    void Delete(int id);
    
    List<BO.SaleInProduct> saleInForce(int idProduct,bool isPriorityCustomer);
}
