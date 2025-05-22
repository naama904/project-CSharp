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

            selectSaleToDeleteSale.DataSource = s_bl.Sale.ReadAll().ToList();
            selectSaleToDeleteSale.DisplayMember = "IdSale"; // מה שמוצג למשתמש
            selectSaleToDeleteSale.ValueMember = "IdSale";// המזהה הפנימי

            selectSaleToUpdate.DataSource = s_bl.Sale.ReadAll().ToList();
            selectSaleToUpdate.DisplayMember = "IdSale";
            selectSaleToUpdate.ValueMember = "IdSale";
        }
        private void refreshComboBoxes()
        {
            var salse = s_bl.Sale.ReadAll().ToList();
            selectSaleToDeleteSale.DataSource = salse;
            selectSaleToUpdate.DataSource = salse;
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

                selectProductToSale.Text = string.Empty;
                amountToGetSale.Text = string.Empty;
                priceInSale.Text = string.Empty;
                //saleAllCustomer.Value = 0;
                dateStart.Value = DateTime.Now;
                dateEnd.Value = DateTime.Now;
                refreshComboBoxes();

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

                listSale.DataSource = null;
                List<Sale> sales = new List<Sale>();
                sales = s_bl.Sale.ReadAll();
                listSale.Items.Clear();
                listSale.DataSource = sales.SelectMany(c => c.ToString().Split("\n")).ToList();
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
                listSale.DataSource = null;
                int idProduct = int.Parse(selectProductReadSale.SelectedValue.ToString());
                List<Sale> sales = s_bl.Sale.ReadAll();
                Sale s = sales.FirstOrDefault(i => i.IdProductOfSale == idProduct);
                if (s != null)
                {
                    List<string> salesDetail = new List<string>
                        {
                          "idSale  :" + s.IdSale,
                          "name :" + s.IdProductOfSale,
                          "address :" + s.AmountToGetSale,
                          "sumPrice :" + s.SumPrice,
                          "isForAllCustomer :" + s.IsForAllCustomers,
                          "startSale :" + s.StartSale,
                          "endSale :" + s.EndSale
                        };
                    listSale.DataSource = salesDetail;
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
                int id = int.Parse(selectSaleToDeleteSale.SelectedValue.ToString());
                //List<Sale> sales = new List<Sale>();
                //sales = s_bl.Sale.ReadAll();
                //Sale s = sales.FirstOrDefault(i => i.IdSale == id);
                s_bl.Sale.Delete(id);

                MessageBox.Show("deleted succsessfully");

                selectSaleToDeleteSale.SelectedItem = null;
                refreshComboBoxes();
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
                listSale.DataSource = null;
                List<Sale> sales = new List<Sale>();
                sales = s_bl.Sale.ReadAll(i => i.IsForAllCustomers);
                listSale.Items.Clear();
                listSale.DataSource = sales.SelectMany(s => s.ToString().Split("\n")).ToList();
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
                acountToGetSale.Value = (decimal)sale.AmountToGetSale;
                sumPriceSale.Value = (decimal)sale.SumPrice;
                saleAllCustomer.Checked = sale.IsForAllCustomers;
                saleClubCustomer.Checked = sale.IsForAllCustomers;
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
            try
            {
                int id = int.Parse(selectSaleToUpdate.SelectedValue.ToString());
                Sale s = s_bl.Sale.Read(id);

                s.IdProductOfSale = int.Parse(productToSale.Text);
                s.AmountToGetSale = (int)acountToGetSale.Value;
                s.SumPrice = (double)sumPriceSale.Value;
                s.IsForAllCustomers = saleAllCustomer.Checked;
                s.StartSale = dateStart.Value;
                s.EndSale = dateEnd.Value;
                s_bl.Sale.Update(s);

                MessageBox.Show("השינווים נשמרו");

                productToSale.Text = string.Empty;
                acountToGetSale.Value = 0;
                sumPriceSale.Value = 0;
                //saleAllCustomer.Value = 0;
                dateStart.Value = DateTime.Now;
                dateEnd.Value = DateTime.Now;
                refreshComboBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void listSale_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void priceInSale_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
