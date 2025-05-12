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
    public partial class FormManagerMenu : Form
    {
        public FormManagerMenu()
        {
            InitializeComponent();
        }

        private void buttonProduct_Click(object sender, EventArgs e)
        {
            FormProduct product = new FormProduct();
            product.ShowDialog();
        }

        private void buttoCustomer_Click(object sender, EventArgs e)
        {
            FormCustomer customer = new FormCustomer();
            customer.ShowDialog();
        }

        private void buttonSales_Click(object sender, EventArgs e)
        {
            FormSale salse = new FormSale();
            salse.ShowDialog();
        }
    }
}
