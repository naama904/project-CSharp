namespace BO;

/// <summary>
/// רשומה לנתוני לקוח
/// </summary>
public class Customer
{
    public int Identity { get; init; }
    public string CustomerName { get; set; }
    public string? Address { get; set; }
    public string Phone { get; set; }
    public object ToStringProperty { get; set; }

    public Customer() { }
    public Customer(int identity,string name,string address,string phone) { 
        Identity =  identity;
        CustomerName = name;
        Address = address;
        Phone = phone;
    }

    public override string ToString() => this.ToStringProperty();

}
