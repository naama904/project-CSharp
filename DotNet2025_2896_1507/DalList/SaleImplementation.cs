namespace Dal;
using DO;
using DalApi;
using Tools;
using System.Linq;
using System.Reflection;

internal class SaleImplementation:ISale
{
    /// <summary>
    /// הוספת מבצע לרשימה
    /// </summary>
    /// <param name="sale">המבצע להוספה</param>
    /// <returns>מחזיר את קוד המבצע שנוסף</returns>
    /// 
    public int Create(Sale sale)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "start");
        Sale s = sale with { IdSale = DataSource.Config.SaleId };
        DataSource.Sales.Add(s);
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "end");
        return s.IdSale;
    }

    /// <summary>
    /// שליפת המבצע שהקוד שלו התקבל
    /// </summary>
    /// <param name="id">קוד המבצע</param>
    /// <returns>מחזיר את המבצע</returns>
    /// <exception cref="Exception">שגיאה אם המבצע לא קיים</exception>
    public Sale? Read(int id)
    {
        try
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "start");
            Sale s = DataSource.Sales.First(s => s.IdSale == id);
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "end");
            return s;
        }
        catch
        {
            throw new DalIdNotExist("the id of sale not found");
        }
    }

    public Sale? Read(Func<Sale, bool> filter)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "start");
        Sale s = DataSource.Sales.FirstOrDefault(filter);
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "end");
        return s;
    }

    /// <summary>
    /// שליפת כל המבצעים שברשימה
    /// </summary>
    /// <returns>מחזיר את רשימת המבצעים</returns>
    public List<Sale?> ReadAll(Func<Sale, bool>? filter = null)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "start");
        if (filter == null)
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "end");
            return new List<Sale?>(DataSource.Sales);
        }
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "end");
        return DataSource.Sales.Where(filter).ToList();
    }

    /// <summary>
    /// עדכון המבצע ברשימה - שהתקבל
    /// </summary>
    /// <param name="sale">המבצע לעדכון</param>
    /// <exception cref="Exception">שגיאה אם המבצע לא קיים</exception>
    public void Update(Sale sale)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "start");
        Delete(sale.IdSale);
        DataSource.Sales.Add(sale);
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "end");
    }

    /// <summary>
    /// מחיקת מבצע מהרשימה לפי הקוד שהתקבל
    /// </summary>
    /// <param name="id">קוד המבצע למחיקה</param>
    public void Delete(int id)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "start");
        Sale s = Read(id);
        DataSource.Sales.Remove(s);
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "end");
    }
}
