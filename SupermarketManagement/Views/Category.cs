
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MySql.Data.MySqlClient;
using SupermarketManagement.Config;
using SupermarketManagement.Models;
using SupermarketManagement.Presenters;
using SupermarketManagement.Repositories;
using SupermarketManagement.Views;

namespace SupermarketManagement
{
    public partial class Category : Form, ICategoryView
    {
        private CategoryPresenter presenter;

        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataReader reader;
        //int i = 0;

        dbConnection dbconn = new dbConnection();

        public Category()
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
        //private void LoadRecord()
        //{
        //    dataGridView1.Rows.Clear();
        //    conn.Open();
        //    cmd = new MySqlCommand("SELECT * FROM `category`", conn);
        //    reader = cmd.ExecuteReader();
        //    while (reader.Read())
        //    {
        //        dataGridView1.Rows.Add(reader["category_id"].ToString(), reader["name"].ToString());
        //    }
        //    reader.Close();
        //    conn.Close();
        //}

        //public void clear()
        //{
        //    txt_id.Clear();
        //    txt_name.Clear();
        //}
        public void ClearFields()
        {
            txt_id.Clear();
            txt_name.Clear();
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            //if ((txt_id.Text == string.Empty) || (txt_name.Text == string.Empty))
            //{
            //    MessageBox.Show("Please fill both the ID and Name fields!", "Add Category", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            //else
            //{
            //    conn.Open();
            //    cmd = new MySqlCommand("INSERT INTO `category`(`category_id`, `name`) VALUES (@category_id, @name)", conn);
            //    cmd.Parameters.Clear();
            //    cmd.Parameters.AddWithValue("@category_id", txt_id.Text);
            //    cmd.Parameters.AddWithValue("@name", txt_name.Text);
            //    int i = cmd.ExecuteNonQuery();
            //    if (i > 0)
            //    {
            //        MessageBox.Show("Record saved successfully!", "Add Category", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //    else
            //    {
            //        MessageBox.Show("Record save failed!", "Add Category", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    }

            //    conn.Close();
            //    LoadRecord();
            //    clear();
            //}

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
            //conn.Open();
            //cmd = new MySqlCommand("UPDATE `category` SET `name`=@name WHERE `category_id`=@category_id", conn);
            //cmd.Parameters.Clear();

            //cmd.Parameters.AddWithValue("@category_id", txt_id.Text);
            //cmd.Parameters.AddWithValue("@name", txt_name.Text);

            //int i = cmd.ExecuteNonQuery();
            //if (i > 0)
            //{
            //    MessageBox.Show("Record updated successfully!", "Edit Category", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else
            //{
            //    MessageBox.Show("Record update failed!", "Edit Category", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}

            //conn.Close();
            ////LoadRecord();
            //clear();

            presenter.UpdateCategory();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            //conn.Open();
            //cmd = new MySqlCommand("DELETE FROM `category` WHERE `category_id`=@category_id", conn);
            //cmd.Parameters.Clear();

            //cmd.Parameters.AddWithValue("@category_id", txt_id.Text);

            //int i = cmd.ExecuteNonQuery();
            //if (i > 0)
            //{
            //    MessageBox.Show("Record deleted successfully!", "Delete Category", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else
            //{
            //    MessageBox.Show("Record delete failed!", "Delete Category", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}

            //conn.Close();
            ////LoadRecord();
            //clear();

            presenter.DeleteCategory();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //txt_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            //txt_name.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();

            presenter.SelectCategory(e.RowIndex, dataGridView1);
        }
    }
}
