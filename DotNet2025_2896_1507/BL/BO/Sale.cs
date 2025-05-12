namespace BO;

/// <summary>
/// רשומה לנתוני מבצע
/// </summary>

public class Sale
{
    public int IdSale { get; init; }
    public int IdProductOfSale { get; set ; }
    public int AmountToGetSale { get; set; }
    public double SumPrice { get; set; }
    public bool IsForAllCustomers { get; set; }
    public DateTime? StartSale { get; set; }
    public DateTime? EndSale { get; set; }
    //public Sale( int idProduct,int ammount,double price,bool forAllCustomer,DateTime start,DateTime end) {
       
    //    IdProductOfSale = idProduct;
    //    AmountToGetSale = ammount;
    //    SumPrice = price;
    //    IsForAllCustomers = forAllCustomer;
    //    StartSale = start;
    //    EndSale = end;
    //}

    public Sale()
    {
    }

    public object ToStringProperty { get; set; }

    public override string ToString() => this.ToStringProperty();

}
