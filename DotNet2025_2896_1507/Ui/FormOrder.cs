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

namespace Ui
{
    public partial class finiishOrder : Form
    {

        private static BlApi.IBl s_bl = BlApi.Factory.Get();
        Order order;
        public finiishOrder()
        {
            InitializeComponent();
            order = new Order();

            selectnameProduct.DataSource = s_bl.Product.ReadAll().ToList();
            selectnameProduct.DisplayMember = "ProductName"; // מה שמוצג למשתמש
            selectnameProduct.ValueMember = "IdProduct";// המזהה הפנימי

        }

        private void addProductToOrder_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(selectnameProduct.SelectedValue.ToString());

                s_bl.Order.AddProductToOrder(order, id, (int)AmountToOrder.Value);

                // ניקוי הרשימה הקיימת
                listOrder.Items.Clear();

                // הוספת המוצרים לרשימה המוצגת ב-listOrder
                foreach (var product in order.ProductsListInOrder) // הנחה שיש לך רשימה של מוצרים בהזמנה
                {
                    listOrder.Items.Add("שם מוצר " + ":" + product.ProductName + " , " + "כמות בהזמנה" + ":" + product.AmountInOrder + " , " + "מחיר " + ":" + product.FinalPriceForProduct); // או כל תכונה אחרת שתרצה להציג
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
                //חישוב המחיר הסופי של ההזמנה לפני ביצוע
                s_bl.Order.CalcTotalPrice(order);

                // ביצוע ההזמנה
                s_bl.Order.doOrder(order);

                // ניקוי ההזמנה
                order.ProductsListInOrder.Clear();
                priceToPay.Text = $" סכום לתשלום: {order.FinalSumToPay} ₪"; // עדכון התווית למחיר סופי

                // הצגת הודעה למשתמש על סיום ההזמנה
                MessageBox.Show("ההזמנה בוצעה בהצלחה,מחיר סופי להזמנה: " + "₪" + order.FinalSumToPay);

                listOrder.Items.Clear();

                priceToPay.Text = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void identity_TextChanged(object sender, EventArgs e)
        {

            //if (s_bl.Customer.isExistCustomer(int.Parse(identity.Text)))
            //{
            //    Customer c=
            //    witchCustomer.Text = $"שלום :{c.CustomerName}";
            //}
        }
    }
}
