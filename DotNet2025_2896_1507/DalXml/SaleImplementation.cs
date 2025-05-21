

using DalApi;
using DO;
using System.Reflection;
using System.Xml.Serialization;

namespace Dal;

internal class SaleImplementation : ISale
{
    public const string FILE_PATH_s = @"..\xml\sales.xml";

    static XmlSerializer serializer_s = new XmlSerializer(typeof(List<Sale>));
    public int Create(Sale item)
    {
        try
        {
            List<Sale> sales = new List<Sale>();
            using (FileStream fileStream = new FileStream(FILE_PATH_s, FileMode.Open))
            {
                sales = serializer_s.Deserialize(fileStream) as List<Sale?>;
            }
            Sale s = item with { IdSale = Config.SaleCode };
            sales.Add(s);
            using (FileStream fileStream = new FileStream(FILE_PATH_s, FileMode.Create))
            {
                serializer_s.Serialize(fileStream, sales);
            }
            return s.IdSale;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }

    }

    public void Delete(int id)
    {
        List<Sale> sales = new List<Sale>();
        using (FileStream fileStream = new FileStream(FILE_PATH_s, FileMode.Open))
        {
            sales = serializer_s.Deserialize(fileStream) as List<Sale?>;
        }
        Sale s= Read(id);
        sales.Remove(s);
        using (FileStream fileStream = new FileStream(FILE_PATH_s, FileMode.Create))
        {
            serializer_s.Serialize(fileStream, sales);
        }
    }

    public Sale? Read(int id)
    {
        try
        {
            List<Sale> sales = new List<Sale>();
            using (FileStream fileStream = new FileStream(FILE_PATH_s, FileMode.Open))
            {
                sales = serializer_s.Deserialize(fileStream) as List<Sale?>;
            }
            Sale? s = sales.FirstOrDefault(s => s.IdSale == id);
            return s ?? throw new DalIdNotExist("The sale not exist");
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public Sale? Read(Func<Sale, bool> filter)
    {
        try
        {
            List<Sale> sales = new List<Sale>();
            using (FileStream fileStream = new FileStream(FILE_PATH_s, FileMode.Open))
            {
                sales = serializer_s.Deserialize(fileStream) as List<Sale?>;
            }
            Sale? s = sales.FirstOrDefault(s => filter(s) == true);
            return s ?? throw new DalIdNotExist("No have sale that exist with this filter");
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public List<Sale?> ReadAll(Func<Sale, bool>? filter = null)
    {
        try
        {
            List<Sale> sales = new List<Sale>();
            using (FileStream fileStream = new FileStream(FILE_PATH_s, FileMode.Open))
            {
                sales = serializer_s.Deserialize(fileStream) as List<Sale?>;
            }
            if (filter != null)
            {
                sales = sales.Where(s => filter(s) == true).ToList();
            }
            return sales;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    public void Update(Sale item)
    {
        try
        {
            List<Sale> sales = new List<Sale>();
            using (FileStream fileStream = new FileStream(FILE_PATH_s, FileMode.Open))
            {
                sales = serializer_s.Deserialize(fileStream) as List<Sale?>;
            }
            int index = sales.FindIndex(s => s.IdSale == item.IdSale);
            sales[index] = item;
            using (FileStream fileStream = new FileStream(FILE_PATH_s, FileMode.Create, FileAccess.Write))
            {
                serializer_s.Serialize(fileStream, sales);
            }
        }
        catch
        {
            throw new DalIdNotExist("sale id not found");
        }
    }
}
