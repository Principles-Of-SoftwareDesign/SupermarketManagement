using MySql.Data.MySqlClient;
using SupermarketManagement.Models;
using SupermarketManagement.Presenters;
using SupermarketManagement.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SupermarketManagement.Config;
using SupermarketManagement.Models;
using SupermarketManagement.Presenters;
using SupermarketManagement.Repositories;
using SupermarketManagement.Views;

namespace SupermarketManagement.Views
{
    public partial class CategoryCashier : Form, ICategoryView
    {
        private CategoryPresenter presenter;

        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataReader reader;
        //int i = 0;

        dbConnection dbconn = new dbConnection();

        public CategoryCashier()
        {
            InitializeComponent();
            string connectionString = new dbConnection().connect();
            ICategoryRepository repository = new CategoryRepository();
            presenter = new CategoryPresenter(this, repository);

            //to display all categories when the form loads
            this.Load += new System.EventHandler(this.Category_Load);
            dataGridView1.CellClick += new DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            btn_add.Click += new System.EventHandler(this.btn_add_Click);
            btn_update.Click += new System.EventHandler(this.btn_update_Click);
            btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
        }

        private void Category_Load(object sender, EventArgs e)
        {
            presenter.LoadCategories();
        }
        public void DisplayCategories(IEnumerable<CategoryModel> categories)
        {
            dataGridView1.Rows.Clear();
            foreach (var category in categories)
            {
                dataGridView1.Rows.Add(category.CategoryID, category.Name);
            }
        }
        public void ShowMessage(string message, string title)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public string CategoryId
        {
            get => txt_id.Text;
            set => txt_id.Text = value;
        }

        public string CategoryName
        {
            get => txt_name.Text;
            set => txt_name.Text = value;
        }

        public void ClearFields()
        {
            txt_id.Clear();
            txt_name.Clear();
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            presenter.AddCategory();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_update_Click(object sender, EventArgs e)
        {

            presenter.UpdateCategory();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

            presenter.DeleteCategory();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            presenter.SelectCategory(e.RowIndex, dataGridView1);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_Click_1(object sender, EventArgs e)
        {
            presenter.AddCategory();
        }

        private void btn_update_Click_1(object sender, EventArgs e)
        {
            presenter.UpdateCategory();
        }

        private void btn_delete_Click_1(object sender, EventArgs e)
        {
            presenter.DeleteCategory();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            presenter.SelectCategory(e.RowIndex, dataGridView1);
        }
    }
}
