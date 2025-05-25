using BlApi;
using DalApi;
using BO;
using System;
using System.Security.Cryptography;

namespace BlImplementation;
internal class OrderImplementation : IOrder
{
    private DalApi.IDal _dal = DalApi.Factory.Get;

    public List<BO.SaleInProduct> AddProductToOrder(BO.Order order, int idProduct, int amountToOrder)
    {
            BO.Product p = _dal.Product.Read(idProduct).convertProductToBo();
            if (p == null)
            {
                throw new BlIdNotExist("product not exist");
            }
            List<BO.SaleInProduct> salesThatUsed = new List<BO.SaleInProduct>();
            //חיפוש המוצר ברשימת המוצרים שבהזמנה
            BO.ProductInOrder isProductInOrder = order.ProductsListInOrder.FirstOrDefault(pr => pr.IdProduct == idProduct);
            //אם המוצר קיים בהזמנה
            if (isProductInOrder != null)
            {
                //בדיקה אם יש כמות מספיקה במלאי כדי להוסיף להזמנה
                if (p.AmountInStock >= isProductInOrder.AmountInOrder + amountToOrder)
                {
                    order.ProductsListInOrder.Remove(isProductInOrder);
                    isProductInOrder.AmountInOrder += amountToOrder;
                    order.ProductsListInOrder.Add(isProductInOrder);
                }
                //אם הכמות במלאי אינה מספיקה
                else
                {
                    throw new BO.BlNotEnoughInStock("not enough in stock");
                }
            }
            //אם המוצר לא קיים בהזמנה
            else
            {
                if (p.AmountInStock >= amountToOrder)
                {
                    //  אם יש מספיק-הוספת מוצר חדש להזמנה
                    isProductInOrder = new BO.ProductInOrder() {IdProduct = idProduct };
                    isProductInOrder.ProductName = p.ProductName;
                    isProductInOrder.BasicPriceForProduct = p.Price ?? 0;
                    p.AmountInStock-= amountToOrder;
                    isProductInOrder.AmountInOrder = amountToOrder;
                    isProductInOrder.SalesListForThisProduct = new List<BO.SaleInProduct>();
                    order.ProductsListInOrder.Add(isProductInOrder);
                }
                //אם אין מספיק במלאי
                else
                {
                    throw new BO.BlNotEnoughInStock("not enough in stock");
                }
            }
            searchSaleForProduct(isProductInOrder, order.IsPriorityCustomer);
            CalcTotalPriceForProduct(isProductInOrder);
            salesThatUsed = isProductInOrder.SalesListForThisProduct;
            CalcTotalPrice(order);
            return salesThatUsed;
        return null;
    }
    public void CalcTotalPrice(BO.Order order)
    {
        order.FinalSumToPay = order.ProductsListInOrder.Sum(p => p.FinalPriceForProduct);
    }
    public void CalcTotalPriceForProduct(BO.ProductInOrder product)
    {
        int count = product.AmountInOrder;
        List<BO.SaleInProduct> listSalesUsed = new();
        foreach (BO.SaleInProduct sale in product.SalesListForThisProduct)
        {
            if (count >= sale.AmountToSale)
            {
                product.FinalPriceForProduct += ((count / sale.AmountToSale) * sale.Price);
                count = count % sale.AmountToSale;
                listSalesUsed.Add(sale);
            }
        }
        product.FinalPriceForProduct += (count * product.BasicPriceForProduct);
        product.SalesListForThisProduct = listSalesUsed;
    }
    public void doOrder(BO.Order order)
    {

            foreach (BO.ProductInOrder product in order.ProductsListInOrder)
            {
                DO.Product p = _dal.Product.Read(product.IdProduct);
                if (p == null)
                {
                    throw new BlIdNotExist("product not exist");
                }
                _dal.Product.Update(p with { AmountInStock = p.AmountInStock - product.AmountInOrder });
            }
        
    }
    public void searchSaleForProduct(BO.ProductInOrder product, bool isPriorityCustomer)
    {
        try
        {
            product.SalesListForThisProduct = _dal.Sale.ReadAll(sale => product.IdProduct == sale.IdProductOfSale && (isPriorityCustomer == true || (isPriorityCustomer == false && sale.IsForAllCustomers == true)) && DateTime.Now >= sale.StartSale && DateTime.Now <= sale.EndSale)
            .Select(s => new BO.SaleInProduct()
             {
                 IdSale = s.IdSale,
                AmountToSale = s.AmountToGetSale ?? 0,
                IsForAllCustomers = s.IsForAllCustomers == false,
                Price = s.SumPrice ?? 0
             }).OrderBy(s => product.FinalPriceForProduct / product.AmountInOrder).ToList();
        }
        catch (Exception ex)
        {
            throw new BlIdNotExist(ex.Message);
        }
    }
}
