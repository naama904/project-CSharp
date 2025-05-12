using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using BO;



namespace Ui
{
    public partial class FormSale : Form
    {
        private static BlApi.IBl s_bl = BlApi.Factory.Get();
        public FormSale()
        {
            InitializeComponent();

            selectProductToSale.DataSource = s_bl.Product.ReadAll().ToList();
            selectProductToSale.DisplayMember = "ProductName"; // מה שמוצג למשתמש
            selectProductToSale.ValueMember = "IdProduct";// המזהה הפנימי

            selectProductReadSale.DataSource = s_bl.Product.ReadAll().ToList();
            selectProductReadSale.DisplayMember = "ProductName"; // מה שמוצג למשתמש
            selectProductReadSale.ValueMember = "IdProduct";// המזהה הפנימי

            selectProductToDeleteSale.DataSource = s_bl.Product.ReadAll().ToList();
            selectProductToDeleteSale.DisplayMember = "ProductName"; // מה שמוצג למשתמש
            selectProductToDeleteSale.ValueMember = "IdProduct";// המזהה הפנימי

            selectSaleToUpdate.DataSource = s_bl.Sale.ReadAll().ToList();
            selectSaleToUpdate.DisplayMember = "IdSale";
            selectSaleToUpdate.ValueMember = "IdSale";
        }

        private void buttonSaveSale_Click(object sender, EventArgs e)
        {
            try
            {
                bool flag = false;
                if (allCustomer.Checked)
                {
                    flag = true;
                }

                Sale sale = new Sale();
                sale.IdProductOfSale = int.Parse(selectProductToSale.SelectedValue.ToString());
                sale.AmountToGetSale = int.Parse(amountToGetSale.Text);
                sale.SumPrice = double.Parse(priceInSale.Text);
                sale.IsForAllCustomers = flag;
                sale.StartSale = dateStart.Value;
                sale.EndSale = dateEnd.Value;

                s_bl.Sale.Create(sale);

                MessageBox.Show("the sale added successfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonReadAllS_Click(object sender, EventArgs e)
        {
            try
            {
                listSale.Items.Clear();
                List<Sale> sales = new List<Sale>();
                sales = s_bl.Sale.ReadAll();
                foreach (Sale sale in sales)
                {
                    listSale.Items.Add(sale);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonReadOneS_Click(object sender, EventArgs e)
        {
            try
            {
                listSale.Items.Clear();
                int idProduct = int.Parse(selectProductReadSale.SelectedValue.ToString());
                List<Sale> sales = new List<Sale>();
                sales = s_bl.Sale.ReadAll();
                Sale s = sales.FirstOrDefault(i => i.IdProductOfSale == idProduct);

                if (s != null)
                {
                    listSale.Items.Add(s);
                }
                else
                {
                    MessageBox.Show("לא קיים מבצע למוצר זה");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonDeleteD_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(selectProductToDeleteSale.SelectedValue.ToString());
                List<Sale> sales = new List<Sale>();
                sales = s_bl.Sale.ReadAll();
                Sale s = sales.FirstOrDefault(i => i.IdProductOfSale == id);
                s_bl.Sale.Delete(s.IdSale);

                MessageBox.Show("deleted succsessfully");

                selectProductToDeleteSale.SelectedItem = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonReadByParamS_Click(object sender, EventArgs e)
        {
            try
            {
                listSale.Items.Clear();
                List<Sale> sales = new List<Sale>();
                sales = s_bl.Sale.ReadAll(i => i.IsForAllCustomers);
                foreach (Sale sale in sales)
                {
                    listSale.Items.Add(sale);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       private void selectSaleToUpdate_SelectedIndexChanged(object sender, EventArgs e)
{
    if (selectSaleToUpdate.SelectedValue == null)
    {
        MessageBox.Show("לא נבחר מבצע.");
        return;
    }

    int id;
    if (!int.TryParse(selectSaleToUpdate.SelectedValue.ToString(), out id))
    {
        MessageBox.Show("בחרת מבצעים");
        return;
    }

    Sale sale = s_bl.Sale.Read(id);
    if (sale != null)
    {
        productToSale.Text = sale.IdProductOfSale.ToString();
        acountToGetSale.Value = sale.AmountToGetSale;
        saleAllCustomer.Checked = sale.IsForAllCustomers;
        saleClubCustomer.Checked = !sale.IsForAllCustomers;
        dateTimePickerStart.Value = sale.StartSale ?? DateTime.Now;
        dateTimePickerEnd.Value = sale.EndSale ?? DateTime.Now;
    }
    else
    {
        MessageBox.Show("מבצע לא נמצא");
    }
}

        private void buttonSaveS_Click(object sender, EventArgs e)
        {

        }

        private void listSale_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
