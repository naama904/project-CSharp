using BlApi;
using BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Ui
{
    public partial class FormOrder : Form
    {
        private static BlApi.IBl s_bl = BlApi.Factory.Get();
        private Order order = new Order();
        private int custId;
        private bool isPreferredCustomer = false;
        public FormOrder(int identity)
        {
            InitializeComponent();
            try
            {
                custId = identity;
                if (s_bl.Customer.isExistCustomer(custId))
                {
                    order.IsPriorityCustomer = true;
                    isPreferredCustomer = true;
                    BO.Customer c = new BO.Customer();
                    c = s_bl.Customer.Read(custId);
                    label3.Text = c.CustomerName + " שלום ";
                }
                else
                {
                    label3.Text = "שלום לקוח חדש";
                }
                List<Product> listProd = s_bl.Product.ReadAll();
                foreach (BO.Product p in listProd)
                {
                    //cbName.Items.Add(p.ProductName);
                }
                selectnameProduct.DataSource = s_bl.Product.ReadAll().ToList();
                selectnameProduct.DisplayMember = "ProductName"; // מה שמוצג למשתמש
                selectnameProduct.ValueMember = "IdProduct";// המזהה הפנימי
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "שגיאה", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addProductToOrder_Click(object sender, EventArgs e)
        {
            try
            {
                listOrder.Items.Clear();
                int id = int.Parse(selectnameProduct.SelectedValue.ToString());
                s_bl.Order.AddProductToOrder(order, id, (int)AmountToOrder.Value);

                foreach (var product in order.ProductsListInOrder)
                {
                    listOrder.Items.Add("שם מוצר: " + product.ProductName + " , " + "כמות בהזמנה: " + product.AmountInOrder + " , " + "מחיר: " + product.FinalPriceForProduct);
                }

                selectnameProduct.SelectedItem = null;
                AmountToOrder.Value = 1;
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void finishOrder_Click(object sender, EventArgs e)
        {
            try
            {
                // ביצוע ההזמנה
                s_bl.Order.doOrder(order);

                // ניקוי ההזמנה
                order.ProductsListInOrder.Clear();
                priceToPay.Text = $" סכום לתשלום: {order.FinalSumToPay} ₪"; // עדכון התווית למחיר סופי

                // הצגת הודעה למשתמש על סיום ההזמנה
                MessageBox.Show("ההזמנה בוצעה בהצלחה,מחיר סופי להזמנה: " + "₪" + order.FinalSumToPay);

                listOrder.Items.Clear();

                priceToPay.Text = null;
                label3.Text=string.Empty;
                

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
