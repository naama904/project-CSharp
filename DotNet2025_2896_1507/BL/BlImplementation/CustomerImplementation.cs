

using BlApi;


namespace BlImplementation;

internal class CustomerImplementation : ICustomer
{
    private DalApi.IDal _dal = DalApi.Factory.Get;
    public int Create(BO.Customer item)
    {
        DO.Customer customer = BO.Tools.convertCustomerToDo(item);
        return _dal.Customer.Create(customer);
    }

    public void Delete(int id)
    {
        _dal.Customer.Delete(id);
    }

    public bool isExistCustomer(int id)
    {
        try
        {
            BO.Tools.convertCustomerToBo(_dal.Customer.Read(id));
            return true;
        }
        catch
        { return false; }
    }

    public BO.Customer? Read(int id)
    {
        return BO.Tools.convertCustomerToBo(_dal.Customer.Read(id));
    }

    //public List<BO.Customer?> ReadAll(Func<BO.Customer, bool>? filter = null)
    //{
    //    return _dal.Customer.ReadAll(cust=> filter(BO.Tools.convertCustomerToBo(cust)))
    //        .Select(p=>BO.Tools.convertCustomerToBo(p)).ToList();
   //}

    public List<BO.Customer?> ReadAll(Func<BO.Customer, bool>? filter = null)
    {
        return _dal.Customer.ReadAll()
              .Select(c=> BO.Tools.convertCustomerToBo(c))
              .Where(c => filter == null || filter(c))
              .ToList();

    }

    public void Update(BO.Customer item)
    {
        DO.Customer customer = BO.Tools.convertCustomerToDo(item);
        _dal.Customer.Update(customer);
    }
}
