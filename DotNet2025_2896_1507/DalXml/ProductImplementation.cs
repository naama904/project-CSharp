
using System.Xml.Serialization;
using DalApi;
using DO;

namespace Dal;

internal class ProductImplementation : IProduct
{
    public const string FILE_PATH = @"..\xml\products.xml";

    XmlSerializer serializer = new XmlSerializer(typeof(List<Product>));

    //הגדרת האובייקט שיבצע את הסריאליזציה עבור טיפוס מסויים
    public int Create(Product item)
    {
        List<Product> products = new List<Product>();
        
        using (FileStream fileStream = new FileStream(FILE_PATH, FileMode.Open))
        {
            products = serializer.Deserialize(fileStream) as List<Product?>;
        }
        Product p = item with { IdProduct = Config.ProductCode };
        products.Add(p);
        using (FileStream fileStream = new FileStream(FILE_PATH, FileMode.Create))
        {
            serializer.Serialize(fileStream, products);
        }
        return p.IdProduct;



    }
    public void Delete(int id)
    {
        List<Product> products = new List<Product>();
        using (FileStream fileStream = new FileStream(FILE_PATH, FileMode.Open))
        {
            products = serializer.Deserialize(fileStream) as List<Product?>;
        }
        Product p = Read(id);
        products.Remove(p);
        using (FileStream fileStream = new FileStream(FILE_PATH, FileMode.Create))
        {
            serializer.Serialize(fileStream, products);
        }
    }

    public Product? Read(int id)
    {
        List<Product> products = new List<Product>();
        using (FileStream fileStream = new FileStream(FILE_PATH, FileMode.Open))
        {
            products = serializer.Deserialize(fileStream) as List<Product?>;
        }
        Product? p=products.FirstOrDefault(p=>p.IdProduct==id);
        return p?? throw new DalIdNotExist("the product not exist");
    }

    public Product? Read(Func<Product, bool> filter)
    {
        List<Product> products = new List<Product>();
        using (FileStream fileStream = new FileStream(FILE_PATH, FileMode.Open))
        {
            products = serializer.Deserialize(fileStream) as List<Product?>;
        }
        Product? p = products.FirstOrDefault(p => filter(p) == true);
        return p ?? throw new DalIdNotExist("dont have product that exist with this filter");
    }

    public List<Product?> ReadAll(Func<Product, bool>? filter = null)
    {
        List<Product> products = new List<Product>();
        using (FileStream fileStream = new FileStream(FILE_PATH, FileMode.Open))
        {
            products = serializer.Deserialize(fileStream) as List<Product?>;
        }
        if (filter != null)
        {
            products = products.Where(p => filter(p) == true).ToList();

        }
        return products;
    }

    public void Update(Product item)
    {
        Delete(item.IdProduct);
        Create(item);
    }
}
