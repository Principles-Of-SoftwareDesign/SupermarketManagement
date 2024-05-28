using SupermarketManagement.Presenters;
using SupermarketManagement.Repositories;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SupermarketManagement.Views
{
    public partial class addOrder : Form, IAddOrderView
    {
        private readonly AddOrderPresenter presenter;
        private Dictionary<string, decimal> products;

        public addOrder()
        {
            InitializeComponent();
            presenter = new AddOrderPresenter(this);
            LoadProducts();

        }

        public string ProductName => cmbProduct.SelectedItem?.ToString() ?? string.Empty;
        public string Amount => txtQuantity.Text;


        public void CloseForm()
        {
            cmbProduct.SelectedIndex = -1;
            txtQuantity.Text = string.Empty;
        }

        public void ShowMessage(string message, string title)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LoadProducts()
        {
            var repository = new OrderRepository();
            var productList = repository.LoadProducts();
            products = new Dictionary<string, decimal>();

            cmbProduct.Items.Clear();
            foreach (var product in productList)
            {
                products.Add(product.Name, Convert.ToDecimal(product.Price));
                cmbProduct.Items.Add(product.Name);
            }
        }


        private void addorderBtn_Click_1(object sender, EventArgs e)
        {
            presenter.addOrder();
        }
        public void ShowOrderConfirmation(string productName, string quantity, decimal totalPrice)
        {
            // Display the order confirmation message box
            MessageBox.Show($"Order added for {productName}, Quantity: {quantity}, Total Price: {totalPrice}",
                            "Order Confirmation",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

    }
}
