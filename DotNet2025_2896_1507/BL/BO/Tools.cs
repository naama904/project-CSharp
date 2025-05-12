
using System.Collections;
using System.Net;
using System.Numerics;
using System.Reflection;
using System.Security.Principal;
using System.Text;
using BlApi;
using DalApi;
using DO;

namespace BO;
internal static class Tools
{
    public static BO.Product convertProductToBo(this DO.Product productDo)
    {
         BO.Product pBo = new BO.Product()
        {
            IdProduct = productDo.IdProduct,
            ProductName = productDo.ProductName,
            Category = (BO.Categories)productDo.Category,
            Price = productDo.Price,
            AmountInStock = productDo.AmountInStock
        };
        return pBo;   
    }
    public static BO.Customer convertCustomerToBo(this DO.Customer customerDo)
    {
        BO.Customer cBo = new BO.Customer(
            customerDo.Identity,
            customerDo.CustomerName,
            customerDo.Address,
            customerDo.Phone
            );

        return cBo;
    }
    public static BO.Sale convertSaleToBo(this DO.Sale saleDo)
    {
        BO.Sale sBo = new BO.Sale
        {
           IdSale=saleDo.IdSale,
           IdProductOfSale=saleDo.IdProductOfSale ?? 0,
           AmountToGetSale=saleDo.AmountToGetSale ?? 1,
           SumPrice=saleDo.SumPrice ?? 0,
           IsForAllCustomers=saleDo.IsForAllCustomers ?? true,
           StartSale=saleDo.StartSale ?? DateTime.Now,
           EndSale=saleDo.EndSale ?? DateTime.Now.AddDays(1),
        };
        return sBo;
    }
    public static DO.Product convertProductToDo(this BO.Product productBo)
    {
        DO.Product pDo = new DO.Product
        {
            IdProduct = productBo.IdProduct,
            ProductName = productBo.ProductName,
            Category =(DO.Categories) productBo.Category,
            Price = productBo.Price,
            AmountInStock = productBo.AmountInStock
        };
        return pDo;
    }
    public static DO.Customer convertCustomerToDo(this BO.Customer customerDo)
    {
        DO.Customer cDo = new DO.Customer
        {
            Identity = customerDo.Identity,
            CustomerName = customerDo.CustomerName,
            Address = customerDo.Address,
            Phone = customerDo.Phone
        };
        return cDo;
    }
    public static DO.Sale convertSaleToDo( this BO.Sale saleDo)
    {
        DO.Sale sDo = new DO.Sale
        {
            IdSale = saleDo.IdSale,
            IdProductOfSale = saleDo.IdProductOfSale ,
            AmountToGetSale = saleDo.AmountToGetSale,
            SumPrice = saleDo.SumPrice,
            IsForAllCustomers = saleDo.IsForAllCustomers ,
            StartSale = saleDo.StartSale ?? DateTime.Now,
            EndSale = saleDo.EndSale ?? DateTime.Now.AddDays(1),
        };
        return sDo;
    }
    //public static string ToStringProperty<T>(this T obj)
    //{
    //    StringBuilder sb = new StringBuilder();
    //    Type t = obj.GetType();
    //    foreach (PropertyInfo prop in t.GetProperties())
    //    {
    //        sb.AppendLine($"{prop.Name} = {prop.GetValue(obj)}");
    //    }
    //    return sb.ToString();
    //}

    public static string ToStringProperty<T>(this T obj)

    {
        StringBuilder str = new StringBuilder();
        foreach (PropertyInfo item in obj.GetType().GetProperties())
        {
            str.AppendLine($"{item.Name} :{item.GetValue(obj)}");
        }
        return str.ToString();

    }

    //public static string ToStringProperty<T>(this T obj)
    //{
    //    string str = "";
    //    Type Ttype = obj.GetType();
    //    PropertyInfo[] info = Ttype.GetProperties();
    //    foreach (PropertyInfo item in info)
    //    {
    //        if (typeof(IEnumerable).IsAssignableFrom(item.PropertyType) && item.PropertyType != typeof(string))
    //        {
    //            IEnumerable collection = item.GetValue(obj) as IEnumerable;
    //            foreach (var x in collection)
    //            {
    //                str += x.ToStringProperty();
    //            }
    //        }
    //        else
    //            str += string.Format("name: {0,-15} value: {1,-15}\n", item.Name, item.GetValue(obj, null));
    //    }
    //    return str;

    //}
}
