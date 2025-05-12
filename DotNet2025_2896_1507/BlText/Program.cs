using BO;
using DalTest;
using System.ComponentModel;
using Tools;

namespace BlText
{
    internal class Program
    {
        static readonly BlApi.IBl s_bl = BlApi.Factory.Get();
        public static int mainOption2()
        {
            Console.WriteLine("to add product to the order choose 1");
            Console.WriteLine("to finish the order choose 2");
            Console.WriteLine("to exit choose 0");
            int choose;
            if (!int.TryParse(Console.ReadLine(), out choose))
                choose = -1;
            return choose;
        }
        public static void newOrder(bool isCustomer)
        {
            try
            {
                BO.Order o = s_bl.Order.createOrder();
                o.IsPriorityCustomer = isCustomer;
                int select1 = mainOption2();
                while (select1 != 0)
                {
                    switch (select1)
                    {
                        case 1:
                            Console.WriteLine("AddProduct");
                            addProductToOrder(o);
                            break;
                        case 2:
                            Console.WriteLine("EndOrder");
                            endOrder(o);
                            break;
                        default:
                            Console.WriteLine("wrong,please choode again");
                            select1 = mainOption2();
                            break;
                    }
                    select1 = mainOption2();
                }
                select1 = mainOption2();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + "------------");
            }
        }
        public static void addProductToOrder(BO.Order ord)
        {
            
                Console.WriteLine("enter id of the product");
                int idProduct;
                if (!int.TryParse(Console.ReadLine(), out idProduct))
                    idProduct = 0;
                Console.WriteLine("enter amount from the product");
                int count;
                if (!int.TryParse(Console.ReadLine(), out count))
                    count = -1;
                List<SaleInProduct> sales = s_bl.Order.AddProductToOrder(ord, idProduct, count);
                Console.WriteLine("the finalSumToPay:");
                Console.WriteLine(ord.FinalSumToPay);
                if(sales!=null)
                {
                    foreach (var item in sales)
                    {
                        Console.WriteLine(item);
                    }
                }
                else { Console.WriteLine("eroro in one from the inputs"); }
          
        }
        public static void endOrder(BO.Order ord)
        {
            Console.WriteLine("if you want new order choose 1 if you want to exit choose 2");
            int choose;
            if (!int.TryParse(Console.ReadLine(), out choose))
                choose = 1;
            if (choose == 1)
            {
                newOrder(ord.IsPriorityCustomer);
            }
        }
        static void Main(string[] args)
        {
            Initialization.Initialize();
            Console.WriteLine("enter the id of the user");

            int userId;
            if (!int.TryParse(Console.ReadLine(), out userId))
                userId = -1;

            bool isCustomer = s_bl.Customer.isExistCustomer(userId);

            newOrder(isCustomer);
        }
    }
}