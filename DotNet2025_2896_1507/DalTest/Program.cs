
using DalApi;
using DO;
using System.Diagnostics;
using System.Reflection;
using System.Threading.Channels;
using Tools;

namespace DalTest
{
    internal class Program
    {
        private static readonly IDal s_dal = DalApi.Factory.Get;
        public static int mainOption()
        {
            int choose;
            Console.WriteLine("for products choose 1");
            Console.WriteLine("for sales choose 2");
            Console.WriteLine("for customers choose 3");
            Console.WriteLine("for clear the Log folder choose 4");
            Console.WriteLine("for exit choose 0");
            if (!int.TryParse(Console.ReadLine(), out choose))
                choose = -1;
            return choose;
        }
        public static int subOption(string str) 
        {
            int choose;
            Console.WriteLine($"to create {str} choose 1");
            Console.WriteLine($"to read one {str} choose 2");
            Console.WriteLine($"to read {str} by parameter choose 3");
            Console.WriteLine($"to read all {str} choose 4");
            Console.WriteLine($"to update {str} choose 5");
            Console.WriteLine($"to delete {str} choose 6");
            Console.WriteLine("to back choose 0");
            if (!int.TryParse(Console.ReadLine(), out choose))
                choose = -1;
            return choose;
        }
        private static void productOption()
        {
            int choose;
            choose = subOption("product");
            while (choose != 0)
            {
                switch (choose)
                {
                    case 1:
                        createProduct();
                        break;
                    case 2:
                        readOne(s_dal.Product);
                        break;
                    case 3:
                        readByParam(s_dal.Product,i=>i.Price>100);
                        break;
                    case 4:
                        readAll(s_dal.Product.ReadAll(i=>i.Price<100));
                        break;
                    case 5:
                        updateProduct();
                        break;
                    case 6:
                        delete(s_dal.Product);
                        break;
                    default:
                        Console.WriteLine("error choosing. please choose again");
                        break;
                }
                choose = subOption("product");
            }
        }
        private static void saleOption()
        {
            int choose = subOption("sale");
            while (choose != 0)
            {
                switch (choose)
                {
                    case 1:
                        createSale();
                        break;
                    case 2:
                        readOne(s_dal.Sale);
                        break;
                    case 3:
                        readByParam(s_dal.Sale,i => i.AmountToGetSale<3);
                        break;
                    case 4:
                        readAll(s_dal.Sale.ReadAll(i=>i.IsForAllCustomers==true));
                        break;
                    case 5:
                        updateSale();
                        break;
                    case 6:
                        delete(s_dal.Sale);
                        break;
                    default:
                        Console.WriteLine("error choosing. please choose again");
                        break;
                }
                choose = subOption("sale");
            }
        }
        private static void customerOption()
        {
            int choose;
            choose = subOption("customer");
            while (choose != 0)
            {
                switch (choose)
                {
                    case 1:
                        createCustomer();
                        break;
                    case 2:
                        readOne(s_dal.Customer);
                        break;
                    case 3:
                        readByParam(s_dal.Customer,i => i.Phone[1] == 2);
                        break;
                    case 4:
                        readAll(s_dal.Customer.ReadAll(i => i.Phone[1]==8));
                        break;
                    case 5:
                        updateCustomer();
                        break;
                    case 6:
                        delete(s_dal.Customer);
                        break;
                    default:
                        Console.WriteLine("error choosing. please choose again");
                        break;
                }
                choose = subOption("customer");
            }
        }
        private static Product forCreateUpdateProduct(int id=0)
        {
            string productName;
            Categories Category;
            double Price;
            int AmountInStock;
            Console.WriteLine("enter name of the product");
            productName = Console.ReadLine();
            Console.WriteLine("choose category beetween: 0-3");
            int categ;
            if (!int.TryParse(Console.ReadLine(), out categ))
                Category = 0;
            else
                Category = (Categories)categ;
            Console.WriteLine("enter price of the product");
            if (!double.TryParse(Console.ReadLine(), out Price))
                Price = 10;
            Console.WriteLine("enter count in stock");
            if (!int.TryParse(Console.ReadLine(), out AmountInStock))
                AmountInStock = 0;
           Product p = new Product(id, productName, Category, Price, AmountInStock);
            return p;
        }
        private static void createProduct()
        {
            try { 
            Product p = forCreateUpdateProduct();
            p = p with { IdProduct = s_dal.Product.Create(p) };
            Console.WriteLine("the product added successfully");
            Console.WriteLine(p);
        }
             catch (Exception e)
            {
                LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, e.Message);
                Console.WriteLine(e.Message);
            }
        }
        private static void updateProduct()
        {
            try
            {
                Console.WriteLine("enter id for product to update");
                int productId = int.Parse(Console.ReadLine());
                Product p = forCreateUpdateProduct(productId);
                s_dal.Product.Update(p);
                Console.WriteLine("the product updated successfully");
                Console.WriteLine(p);
            }
            catch(Exception e)
            {
                LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, e.Message);
                Console.WriteLine(e.Message);
            }
           
        }
        private static Sale forCreateUpdateSale(int id = 0)
        {
            int IdProductOfSale;
            int AmountToGetSale;
            double SumPrice;
            bool IsForAllCustomers;
            DateTime StartSale;
            DateTime EndSale;
            Console.WriteLine("enter id of product for sale");
            if (!int.TryParse(Console.ReadLine(), out IdProductOfSale))
            {
                IdProductOfSale = 100;
            }
            Console.WriteLine("enter amount to get the sale");
            if (!int.TryParse(Console.ReadLine(), out AmountToGetSale))
            {
                AmountToGetSale = 1;
            }
            Console.WriteLine("enter sum price in sale");
            if (!double.TryParse(Console.ReadLine(), out SumPrice))
            {
                SumPrice = 10;
            }
            Console.WriteLine("enter if the sale for all customers or just for club customers");
            if (!bool.TryParse(Console.ReadLine(), out IsForAllCustomers))
            {
                IsForAllCustomers = false;
            }
            Console.WriteLine("enter start date for sale");
            if (!DateTime.TryParse(Console.ReadLine(), out StartSale))
            {
                StartSale = DateTime.Today;
            }
            Console.WriteLine("enter end date for sale");
            if (!DateTime.TryParse(Console.ReadLine(), out EndSale))
            {
                EndSale = DateTime.Today.AddDays(1);
            }
            Sale s = new Sale(0, IdProductOfSale, AmountToGetSale, SumPrice, IsForAllCustomers, StartSale, EndSale);
            return s;
        }
        private static void createSale()
        {
            try
            {
                Sale s = forCreateUpdateSale();
                s = s with { IdSale = s_dal.Sale.Create(s) };
                Console.WriteLine("the sale added successfully");
                Console.WriteLine(s);
            }
            catch (Exception e)
            {
                LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, e.Message);
                Console.WriteLine(e.Message);
            }
        }
        private static void updateSale()
        {
            try
            {
                Console.WriteLine("enter id for sale to update");
                int saleId = int.Parse(Console.ReadLine());
                Sale s = forCreateUpdateSale(saleId);
                s_dal.Sale.Update(s);
                Console.WriteLine("the sale updated successfully");
                Console.WriteLine(s);
            }
            catch (Exception e)
            {
                LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, e.Message);
                Console.WriteLine(e.Message);
            }

        }
        private static Customer forCreateUpdateCustomer(int id = 0)
        {
            int Identity;
            string CustomerName;
            string Address;
            string Phone;

            Console.WriteLine("enter identity of customer");
            if (!int.TryParse(Console.ReadLine(), out Identity))
            {
                Identity = 0;
            }
            Console.WriteLine("enter name of customer");
            CustomerName = Console.ReadLine();
            Console.WriteLine("enter address of customer");
            Address = Console.ReadLine();
            Console.WriteLine("enter phone of customer");
            Phone = Console.ReadLine();
            Customer c = new Customer(Identity, CustomerName, Address, Phone);
            return c;
        }
        private static void createCustomer()
        {
            try
            {
                Customer c = forCreateUpdateCustomer();
                s_dal.Customer.Create(c);
                Console.WriteLine("the customer added successfully");
                Console.WriteLine(c);
            }
            catch (Exception e)
            {
                LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, e.Message);
                Console.WriteLine(e.Message);
            }
        }
        private static void updateCustomer()
        {
            try
            {
                Console.WriteLine("enter identity for customer to update");
                int custId = int.Parse(Console.ReadLine());
                Customer c = forCreateUpdateCustomer(custId);
                s_dal.Customer.Update(c);
                Console.WriteLine("the customer updated successfully");
                Console.WriteLine(c);
            }
            catch (Exception e)
            {
                LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, e.Message);
                Console.WriteLine(e.Message);
            }
        }
        private static void readOne<T>(ICrud<T> iCrud)
        {
            try
            {
                int code;
                Console.WriteLine("insert code");
                if (!int.TryParse(Console.ReadLine(), out code))
                {
                    code = 0;
                }
                Console.WriteLine(iCrud.Read(code));
            }
            catch(Exception e)
            {
                LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, e.Message);
                Console.WriteLine(e.Message);  
            }
        }
        private static void readByParam<T>(ICrud<T> iCrud,Func<T,bool>filter)
        {
            try
            {
                Console.WriteLine(iCrud.Read(filter));
            }
            catch (Exception e)
            {
                LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, e.Message);
                Console.WriteLine(e.Message);
            }
        }
        private static void readAll<T>(List<T> list)
        {
                foreach (T t in list)
                {
                    Console.WriteLine(t);
                }
                if (list.Count == 0)
                {
                Console.WriteLine("dont exist");
                }
        }
        private static void delete<T>(ICrud<T> iCrud)
        {
            try
            {
                int code;
                Console.WriteLine("insert code");
                if(!int.TryParse(Console.ReadLine(), out code))
                {
                   code = 0;
                }
                iCrud.Delete(code);
                Console.WriteLine("the deleted succsesfully");
            }
            catch(Exception e)
            {
                LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, e.Message);
                Console.WriteLine(e.Message);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("if you want to initialization press 1");
            int select = int.Parse(Console.ReadLine());
            if (select == 1)
                Initialization.Initialize();
            try
            {
                int choose1 = mainOption();
                while (choose1 != 0) 
                {
                    switch(choose1)
                    {
                        case 1:
                            Console.WriteLine("Product");
                            productOption();
                            break;
                        case 2:
                            Console.WriteLine("Sale");
                            saleOption();
                            break;
                        case 3:
                            Console.WriteLine("Customer");
                            customerOption();
                            break;
                        case 4:
                            Console.WriteLine("clear the Log folder");
                            LogManager.CleanOldFolder();
                            break;
                        default:
                            Console.WriteLine("wrong option, please choose again.");
                            choose1 = mainOption();
                            break;
                    }
                    choose1 = mainOption();
                }
            }
            catch (Exception ex)
            {
                LogManager.WriteToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, ex.Message);
                Console.WriteLine(ex.ToString());
            }
        }
    }
}