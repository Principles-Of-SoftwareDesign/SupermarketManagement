using System;
using System.Windows.Forms;
using SupermarketManagement.Presenters;
using System.ComponentModel;

namespace SupermarketManagement.Views
{
    public partial class ViewProduct : Form, IProductView
    {
        private ViewProductPresenter presenter;

        public ViewProduct()
        {
            InitializeComponent();
            presenter = new ViewProductPresenter(this);
            Load += ViewProducts_Load;
        }

        public void DisplayProducts(BindingSource productsList)
        {
            dataGridViewProduct.AutoGenerateColumns = false;
            dataGridViewProduct.DataSource = productsList;
            ConfigureColumns();
        }

        private void ConfigureColumns()
        {
            dataGridViewProduct.Columns.Clear();
            dataGridViewProduct.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "ID", DataPropertyName = "Id" });
            dataGridViewProduct.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Name", DataPropertyName = "Name" });
            dataGridViewProduct.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Category", DataPropertyName = "Category" });
            dataGridViewProduct.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Price", DataPropertyName = "Price" });
            dataGridViewProduct.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Quantity", DataPropertyName = "Quantity" });
        }

        public void ShowMessage(string message, string title)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ViewProducts_Load(object sender, EventArgs e)
        {
            presenter.LoadProducts();
        }
    }

}
