
using DalApi;
using DalXml;
using DO;
using System.Reflection;
using System.Security.Principal;
using System.Xml.Linq;

namespace Dal;

internal class CustomerImplementation : ICustomer
{
    public const string FILE_PATH = @"..\xml\customers.xml";
    private const string CUSTOMER = "Customer";
    private const string IDENTITY = "Identity";
    private const string CUSTOMER_NAME = "CustomerName";
    private const string ADDRESS = "Address";
    private const string PHONE = "Phone";
    //הוספת אטריביוט עבור שם הסמינר

    public int Create(Customer item)
    {
        XElement customerxml = XElement.Load(FILE_PATH);
        if (customerxml.Descendants(IDENTITY).Any(c => int.Parse(c.Value) == item.Identity))
            throw new DalIdExist("The customer already exists");

        XElement newCustomer = new XElement(CUSTOMER,
                       new XElement(IDENTITY, item.Identity),
                       new XElement(CUSTOMER_NAME, item.CustomerName),
                       new XElement(ADDRESS, item.Address),
                       new XElement(PHONE,item.Phone));

        customerxml.Add(newCustomer);
        customerxml.Save(FILE_PATH);
        return item.Identity;
    }

    public void Delete(int id)
    {
        XElement customerxml = XElement.Load(FILE_PATH);
        Customer c = Read(id);
        XElement idxml = customerxml.Descendants(IDENTITY).Single(c => int.Parse(c.Value) == id);
        XElement customerXml = idxml.Parent;
        customerXml.Remove();
        customerxml.Save(FILE_PATH);
    }

    public Customer? Read(int id)
    {
        XElement customerxml = XElement.Load(FILE_PATH);
        XElement idxml = customerxml.Descendants(IDENTITY).Single(c => int.Parse(c.Value) == id);
        XElement customerXml = idxml.Parent;
        Customer customer = new Customer()
        {
            Identity = int.Parse(customerXml.Element(IDENTITY).Value),
            CustomerName = customerXml.Element(CUSTOMER_NAME).Value,
            Address = customerXml.Element(ADDRESS).Value,
            Phone = customerXml.Element(PHONE).Value
        };
        return customer?? throw new DalIdNotExist("the customer dont exist") ;
    }

    public Customer? Read(Func<Customer, bool> filter)
    {
        XElement customerxml = XElement.Load(FILE_PATH);
        List<Customer?> customers = customerxml.Element(CUSTOMER).Elements().Where(c1 => filter(new Customer()
        {
            Identity = int.Parse(c1.Element(IDENTITY).Value),
            CustomerName = c1.Element(CUSTOMER_NAME).Value,
            Address = c1.Element(ADDRESS).Value,
            Phone = c1.Element(PHONE).Value
        }) == true).Select(c => new Customer()
        {
            Identity = int.Parse(c.Element(IDENTITY).Value),
            CustomerName = c.Element(CUSTOMER_NAME).Value,
            Address = c.Element(ADDRESS).Value,
            Phone = c.Element(PHONE).Value
        }).ToList();
        Customer? c = customers.FirstOrDefault();
        return c ?? throw new DalIdNotExist("The customer not exist");
    }

    public List<Customer?> ReadAll(Func<Customer, bool>? filter = null)
    {
        XElement customerxml = XElement.Load(FILE_PATH);
        if (filter != null)
        {
            List<Customer?> customers = customerxml.Element(CUSTOMER).Elements().Where(c1 => filter(new Customer()
            {
                Identity = int.Parse(c1.Element(IDENTITY).Value),
                CustomerName = c1.Element(CUSTOMER_NAME).Value,
                Address = c1.Element(ADDRESS).Value,
                Phone = c1.Element(PHONE).Value
            }) == true).Select(c => new Customer()
            {
                Identity = int.Parse(c.Element(IDENTITY).Value),
                CustomerName = c.Element(CUSTOMER_NAME).Value,
                Address = c.Element(ADDRESS).Value,
                Phone = c.Element(PHONE).Value
            }).ToList();
            return customers;
        }
        List<Customer> list = new List<Customer?>(customerxml.Elements().Select(c => new Customer()
        {
            Identity = int.Parse(c.Element(IDENTITY).Value),
            CustomerName = c.Element(CUSTOMER_NAME).Value,
            Address = c.Element(ADDRESS).Value,
            Phone = c.Element(PHONE).Value
        }).ToList());
        return list;
    }

    public void Update(Customer item)
    {
        XElement customerxml = XElement.Load(FILE_PATH);
        Delete(item.Identity);
        Create(item);
    }
}
