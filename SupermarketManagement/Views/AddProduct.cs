using System;
using System.Windows.Forms;
using SupermarketManagement.Presenters;
using SupermarketManagement.Views;

namespace SupermarketManagement.Views
{
    public partial class AddProduct : Form, IAddProductView
    {
        private AddProductPresenter presenter;

        public AddProduct()
        {
            InitializeComponent();
            presenter = new AddProductPresenter(this);
        }

        public string Name => nameTxt.Text;
        public string Category => categoryTxt.Text;
        public double Price => double.TryParse(priceTxt.Text, out double price) ? price : 0;
        public int Quantity => int.TryParse(quantityTxt.Text, out int quantity) ? quantity : 0;

        public void CloseForm()
        {
            this.Close();
        }

        public void ShowMessage(string message, string title)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            presenter.AddProduct();
        }
    }
}
