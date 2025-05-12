namespace Dal;
using DO;
using DalApi;
using Tools;
using System.Reflection;

internal class ProductImplementation:IProduct
{
    /// <summary>
    /// הוספת מוצר לרשימה
    /// </summary>
    /// <param name="item">המוצר להוספה</param>
    /// <returns>מחזיר את קוד המוצר שנוסף</returns>
    public int Create(Product item)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "start");
        Product p = item with { IdProduct = DataSource.Config.ProductId };
        DataSource.Products.Add(p);
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "end");
        return p.IdProduct;
    }

    /// <summary>
    /// שליפת המוצר שהקוד שלו התקבל
    /// </summary>
    /// <param name="id">קוד המוצר</param>
    /// <returns>מחזיר את המוצר</returns>
    /// <exception cref="Exception">שגיאה אם המוצר לא נמצא</exception>
    public Product? Read(int id)
    {
        try
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "start");
            Product p = DataSource.Products.First(p => p.IdProduct == id);
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "end");
            return p;
        }
        catch
        {
            throw new DalIdNotExist("the  product not found");
        }
    }

    public Product? Read(Func<Product, bool> filter)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "start");
        Product p=DataSource.Products.FirstOrDefault(filter);
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "end");
        return p;
    }

    /// <summary>
    /// שליפת כל מוצרי הרשימה
    /// </summary>
    /// <returns>מחזיר את רשימת המוצרים</returns>
    public List<Product?> ReadAll(Func<Product, bool>? filter = null)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "start");
        if (filter == null)
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "end");
            return new List<Product?>(DataSource.Products);
        }
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "end");
        return DataSource.Products.Where(filter).ToList();
    }

    /// <summary>
    /// עדכון המוצר ברשימה - שהתקבל
    /// </summary>
    /// <param name="item">המוצר לעדכון</param>
    /// <exception cref="Exception">שגיאה אם המוצר לא נמצא</exception>
    public void Update(Product item)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "start");
        Delete(item.IdProduct);
        DataSource.Products.Add(item);
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "end");
    }

    /// <summary>
    /// מחיקת מוצר מהרשימה לפי הקוד שהתקבל
    /// </summary>
    /// <param name="id">קוד המוצר למחיקה</param>
    public void Delete(int id)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "start");
        Product p = Read(id);
        DataSource.Products.Remove(p);
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "end");
    }
}
