using BlApi;
using BO;
using DalApi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ui
{
    public partial class FormProduct : Form
    {
        private static BlApi.IBl s_bl = BlApi.Factory.Get();
        public FormProduct()
        {
            InitializeComponent();
            selectedProduct.DataSource = s_bl.Product.ReadAll().ToList();
            selectedProduct.DisplayMember = "ProductName"; // מה שמוצג למשתמש
            selectedProduct.ValueMember = "IdProduct";// המזהה הפנימי

            readOneProduct.DataSource = s_bl.Product.ReadAll().ToList();
            readOneProduct.DisplayMember = "ProductName";
            readOneProduct.ValueMember = "IdProduct";

            selectNameProduct.DataSource = s_bl.Product.ReadAll().ToList();
            selectNameProduct.DisplayMember = "ProductName";
            selectNameProduct.ValueMember = "IdProduct";
        }
        private void refreshComboBoxes()
        {
            var products = s_bl.Product.ReadAll().ToList();
            selectedProduct.DataSource = products;
            readOneProduct.DataSource = products;
            selectNameProduct.DataSource = products;
        }

        private void buttonKeep_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(name.Text) ||
                category.SelectedItem == null ||
                price.Value <= 0 ||
                quentity.Value <= 0)
            {
                MessageBox.Show("נא למלא את כל השדות החיוניים.");
                return;
            }

            try
            {
                Product p = new Product();
                p.ProductName = name.Text;
                p.Category = (Categories)Enum.Parse(typeof(Categories), category.SelectedItem.ToString());
                p.Price = (int)price.Value;
                p.AmountInStock = (int)quentity.Value;

                s_bl.Product.Create(p);

                MessageBox.Show("המוצר נוסף בהצלחה");

                name.Text = string.Empty;
                category.SelectedItem = null;
                price.Value = 0;
                quentity.Value = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                refreshComboBoxes();
                int id = int.Parse(selectedProduct.SelectedValue.ToString());
                s_bl.Product.Delete(id);
                MessageBox.Show("deleted successfully");
                selectedProduct.SelectedItem = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(selectNameProduct.SelectedValue.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonReadAll_Click(object sender, EventArgs e)
        {
            try
            {
                refreshComboBoxes();
                listProduct.Items.Clear();
                List<Product> products = new List<Product>();
                products = s_bl.Product.ReadAll();
                foreach (Product product in products)
                {
                    //listProduct.Items.Add(product);
                    listProduct.Items.Add(product);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void buttonReadByParam_Click(object sender, EventArgs e)
        {
            try
            {
                refreshComboBoxes();
                listProduct.Items.Clear();
                List<Product> products = new List<Product>();
                products = s_bl.Product.ReadAll(i => i.Price < 100);
                foreach (Product product in products)
                {
                    listProduct.Items.Add(product);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonReadOne_Click(object sender, EventArgs e)
        {
            try
            {
                refreshComboBoxes();
                listProduct.Items.Clear();
                int id = int.Parse(selectedProduct.SelectedValue.ToString());
                Product product = new Product();
                product = s_bl.Product.Read(id);
                listProduct.Items.Add(product);
                selectedProduct.SelectedItem = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
