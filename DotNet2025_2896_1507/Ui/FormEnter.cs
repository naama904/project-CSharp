namespace Ui
{
    public partial class formEnter : Form
    {
        public formEnter()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonShopkeeper_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.ShowDialog();
        }

        private void buttonManagger_Click(object sender, EventArgs e)
        {
            FormManagerMenu mm = new FormManagerMenu();
            mm.ShowDialog();
            //FormProduct product = new FormProduct();
            //product.ShowDialog();
        }
    }
}
