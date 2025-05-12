namespace BO;

/// <summary>
/// רשומה לנתוני הזמנה
/// </summary>
public class Order
{
    public bool IsPriorityCustomer { get; set; }
    public List<BO.ProductInOrder> ProductsListInOrder { get; set; }
    public double FinalSumToPay { get; set; }


    public Order()
    {
        ProductsListInOrder = new List<BO.ProductInOrder>();
    }

}
