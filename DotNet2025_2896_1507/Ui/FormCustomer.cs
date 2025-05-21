using BlApi;
using BO;
using DalApi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


namespace Ui
{
    public partial class FormCustomer : Form
    {
        private static BlApi.IBl s_bl = BlApi.Factory.Get();
        public FormCustomer()
        {
            InitializeComponent();
            selectIdentity.DataSource = s_bl.Customer.ReadAll().ToList();
            selectIdentity.DisplayMember = "Identity"; // מה שמוצג למשתמש
            selectIdentity.ValueMember = "Identity";// המזהה הפנימי

            selectCustomer.DataSource = s_bl.Customer.ReadAll().ToList();
            selectCustomer.DisplayMember = "Identity"; // מה שמוצג למשתמש
            selectCustomer.ValueMember = "Identity";// המזהה הפנימי

            selectCustomerUpdate.DataSource = s_bl.Customer.ReadAll().ToList();
            selectCustomerUpdate.DisplayMember = "Identity"; // מה שמוצג למשתמש
            selectCustomerUpdate.ValueMember = "Identity";// המזהה הפנימי

        }

        private void buttonSaveCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                Customer cus = new Customer(
                  int.Parse(identity.Text),
                  nameCustomer.Text,
                  address.Text,
                  phone.Text
                    );
                s_bl.Customer.Create(cus);
                MessageBox.Show("the customer added succsesfuly");

                identity.Text = string.Empty;
                nameCustomer.Text = string.Empty;
                address.Text = string.Empty;
                phone.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonDeleteC_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(selectCustomer.SelectedValue.ToString());
                s_bl.Customer.Delete(id);
                MessageBox.Show("deleted successfully");
                selectCustomer.SelectedItem = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonReadAllC_Click(object sender, EventArgs e)
        {
            try
            {
                listCustomer.Items.Clear();
                List<Customer> customers = new List<Customer>();
                customers = s_bl.Customer.ReadAll();
                foreach (Customer customer in customers)
                {
                    //listProduct.Items.Add(product);
                    listCustomer.Items.Add(customer);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonReadByParamC_Click(object sender, EventArgs e)
        {
            try
            {
                listCustomer.Items.Clear();
                List<Customer> customers = new List<Customer>();
                customers = s_bl.Customer.ReadAll(i => i.Phone[1] == '8');
                foreach (Customer customer in customers)
                {
                    listCustomer.Items.Add(customer);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonReadOneC_Click(object sender, EventArgs e)
        {
            try
            {
                listCustomer.Items.Clear();
                int id = int.Parse(selectIdentity.SelectedValue.ToString());
                Customer customer = new Customer();
                customer = s_bl.Customer.Read(id);
                listCustomer.Items.Add(customer);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void selectCustomerUpdate_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(selectCustomerUpdate.SelectedValue.ToString(), out id))
            {
                MessageBox.Show("בחרת לקוחות");
                return;
            }

         

            Customer customer = s_bl.Customer.Read(id);
            if (customer != null)
            {
                // עדכון השדות עם פרטי הלקוח
                nameToUpdate.Text = customer.CustomerName;
                addressToUpdate.Text = customer.Address;
                phoneToUpdate.Text = customer.Phone;
            }
            else
            {
                MessageBox.Show("לקוח לא נמצא");
            }
        }

        private void buttonSaveUpdate_Click_1(object sender, EventArgs e)
        {
            try
            {

                int id = int.Parse(selectCustomerUpdate.SelectedValue.ToString());


                Customer customer = s_bl.Customer.Read(id);

                customer.CustomerName = nameToUpdate.Text;
                customer.Address = addressToUpdate.Text;
                customer.Phone = phoneToUpdate.Text;

                s_bl.Customer.Update(customer);

                MessageBox.Show("השינווים נשמרו");

                nameToUpdate.Text = string.Empty;
                addressToUpdate.Text = string.Empty;
                phoneToUpdate.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
