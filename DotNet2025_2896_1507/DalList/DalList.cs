
using DalApi;
using System.ComponentModel;

namespace Dal;

internal sealed class DalList : IDal
{
    public IProduct Product => new ProductImplementation();
    public ICustomer Customer => new CustomerImplementation();
    public ISale Sale => new SaleImplementation();

    public static readonly DalList instance=new DalList();
    
    public static DalList Instance { get { return instance; } }

    private DalList() { }
    
}
