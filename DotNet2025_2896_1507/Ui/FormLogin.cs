namespace Ui;

public partial class FormLogin : Form
{
    public FormLogin()
    {
        InitializeComponent();
    }

    private void startOrder_Click(object sender, EventArgs e)
    {
        try
        {
            FormOrder order = new FormOrder(int.Parse(identity.Text));
            order.ShowDialog();
            identity.Text = string.Empty;
        }
        catch (Exception ex)
        {
            MessageBox.Show("תז לא תקינה");
        }

    }
}
