using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SupermarketManagement.Models;
using SupermarketManagement.Presenters;
using SupermarketManagement.Repositories;
using SupermarketManagement.Views;

namespace SupermarketManagement
{
    public partial class ViewProduct : Form, IProductView
    {
        private ViewProductPresenter presenter;

        public ViewProduct()
        {
            InitializeComponent();
            IProductRepository repository = new ProductRepository();
            presenter = new ViewProductPresenter(this, repository);

            this.Load += new EventHandler(ViewProduct_Load);
            dataGridView1.CellClick += new DataGridViewCellEventHandler(dataGridView1_CellClick);
            btn_add.Click += new EventHandler(btn_add_Click);
            btn_update.Click += new EventHandler(btn_update_Click);
            btn_delete.Click += new EventHandler(btn_delete_Click);
        }

        private void ViewProduct_Load(object sender, EventArgs e)
        {
            presenter.LoadProducts();
        }

        public void DisplayProducts(IEnumerable<ProductModel> products)
        {
            dataGridView1.Rows.Clear();
            foreach (var product in products)
            {
                 dataGridView1.Rows.Add(product.Id, product.Name, product.Category, product.Price, product.Quantity);
            }
        }

        public void ShowMessage(string message, string title)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public string ProductId
        {
            get => txt_id.Text;
            set => txt_id.Text = value;
        }

        public string ProductName
        {
            get => txt_name.Text;
            set => txt_name.Text = value;
        }

        public string ProductCategory
        {
            get => txt_category.Text;
            set => txt_category.Text = value;
        }

        public double ProductPrice
        {
            get => double.TryParse(txt_price.Text, out var price) ? price : 0;
            set => txt_price.Text = value.ToString();
        }

        public int ProductQuantity
        {
            get => int.TryParse(txt_quantity.Text, out var quantity) ? quantity : 0;
            set => txt_quantity.Text = value.ToString();
        }

        public void ClearFields()
        {
            txt_id.Clear();
            txt_name.Clear();
            txt_category.Clear();
            txt_price.Clear();
            txt_quantity.Clear();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            presenter.AddProduct();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            presenter.UpdateProduct();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            presenter.DeleteProduct();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            presenter.SelectProduct(e.RowIndex, dataGridView1);
        }
    }
}
