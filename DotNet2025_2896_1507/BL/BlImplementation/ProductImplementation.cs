using BlApi;

namespace BlImplementation;

internal class ProductImplementation : IProduct
{
    private DalApi.IDal _dal = DalApi.Factory.Get;
    public int Create(BO.Product item)
    {
        DO.Product product = BO.Tools.convertProductToDo(item);
        return _dal.Product.Create(product);
    }

    public void Delete(int id)
    {
        _dal.Product.Delete(id);
    }

    public BO.Product Read(int id)
    {
        return BO.Tools.convertProductToBo(_dal.Product.Read(id));
    }

    public List<BO.Product?> ReadAll(Func<BO.Product, bool>? filter = null)
    {
        return _dal.Product.ReadAll()
            .Select(p => BO.Tools.convertProductToBo(p))
            .Where(p=>filter==null||filter(p))
            .ToList();
    }
    public void Update(BO.Product item)
    {
        DO.Product product = BO.Tools.convertProductToDo(item);
        _dal.Product.Update(product);
    }
    public List<BO.SaleInProduct> saleInForce(int idProduct, bool isPriorityCustomer)
    {
        return _dal.Sale.ReadAll(sale =>idProduct==sale.IdProductOfSale && (isPriorityCustomer==true ||(isPriorityCustomer==false && sale.IsForAllCustomers==true)) && DateTime.Now>=sale.StartSale  && DateTime.Now <= sale.EndSale )
           .Select(s => new BO.SaleInProduct()
           {
               IdSale = s.IdSale,
               AmountToSale = s.AmountToGetSale ?? 0,
               IsForAllCustomers = s.IsForAllCustomers == false,
               Price=s.SumPrice ?? 0
           } ).ToList();
    }

}
