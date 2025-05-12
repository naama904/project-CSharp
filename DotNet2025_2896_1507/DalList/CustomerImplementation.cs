namespace Dal;
using DO;
using DalApi;
using Tools;
using System.Reflection;

internal class CustomerImplementation:ICustomer
{
    /// <summary>
    /// הוספת לקוח לרשימה
    /// </summary>
    /// <param name="customer">הלקוח להוספה</param>
    /// <returns>מחזיר את ת"ז הלקוח שנוסף</returns>
    /// <exception cref="Exception">שגיאה אם כבר קיים לקוח עם מס' ת"ז כזה</exception>
    public int Create(Customer customer)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "start");
        if (DataSource.Customers.Any(c => c.Identity == customer.Identity)) { 
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "end");
            throw new DalIdExist("the id of customer exist,the customer not added");
        }
        else
            {
                DataSource.Customers.Add(customer);
                LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "end");
                return customer.Identity;
            }
    }

        /// <summary>
        /// שליפת הלקוח שהת"ז שלו התקבל
        /// </summary>
        /// <param name="id">ת"ז הלקוח</param>
        /// <returns>מחזיר את הלוקוח</returns>
        /// <exception cref="Exception">שגיאה אם הלקוח לא קיים</exception>
        public Customer? Read(int id)
    {
        try
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "start");
            Customer c = DataSource.Customers.First(c => c.Identity == id);
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "end");
            return c;
        }
        catch
        {
            throw new DalIdNotExist("the id of customer not found");
        }
    }

    public Customer? Read(Func<Customer, bool> filter)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "start");
        Customer c = DataSource.Customers.FirstOrDefault(filter);
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "end");
        return c;
    }

    /// <summary>
    /// שליפת כל הלקוחות שברשימה
    /// </summary>
    /// <returns>מחזיר את רשימת הלקוחות</returns>
    public List<Customer?> ReadAll(Func<Customer, bool>? filter = null)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "start");
        if (filter == null)
        {
            LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "end");
            return new List<Customer?>(DataSource.Customers);
        }
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "end");
        return DataSource.Customers.Where(filter).ToList();

    }

    /// <summary>
    /// עדכון הלקוח ברשימה - שהתקבל
    /// </summary>
    /// <param name="customer">הלקוח לעדכון</param>
    /// <exception cref="Exception">שגיאה אם הלקוח לא קיים</exception>
    public void Update(Customer customer)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "start");
        Delete(customer.Identity);
        DataSource.Customers.Add(customer);
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "end");
    }

    /// <summary>
    /// מחיקת לקוח מהרשימה לפי הת"ז שהתקבל
    /// </summary>
    /// <param name="id">ת"ז הלקוח למחיקה</param>
    public void Delete(int id)
    {
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "start");
        Customer c = Read(id);
        DataSource.Customers.Remove(c);
        LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "end");
    }
}
