﻿using MySql.Data.MySqlClient;
using SupermarketManagement.Views;
using SupermarketManagement.Presenters;
using System.Windows.Forms;

namespace SupermarketManagement
{
    public partial class ViewAdmins : Form, IViewAdmins
    {

        public ViewAdmins()
        {
            InitializeComponent();
        }

        public int Id
        {
            get { return Id; }
            set { Id = value; }
        }
        public string Email
        {
            get { return Email.ToString(); }
            set { Email = value; }
        }
        public string Password
        {
            get { return Password.ToString(); }
            set { Password = value; }
        }
        public string PhoneNumber
        {
            get { return PhoneNumber.ToString(); }
            set { PhoneNumber = value; }
        }

        public void setAdminsList(BindingSource adminsList)
        {

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "Id", DataPropertyName = "Id", HeaderText = "ID#" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "Name", DataPropertyName = "Name", HeaderText = "Name" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "Email", DataPropertyName = "Email", HeaderText = "Email" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "PhoneNumber", DataPropertyName = "PhoneNumber", HeaderText = "Phone Number" });

            dataGridView1.DataSource = adminsList;
        }

        private void ViewAdmins_Load(object sender, EventArgs e)
        {
            //LoadAllList();
        }

        private void addAdminLabel_Click(object sender, EventArgs e)
        {

        }

        private void viewAdminsLabel_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            ViewProduct viewProduct = new ViewProduct();
            viewProduct.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            ViewCashiers casheir = new ViewCashiers();
            casheir.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            ViewAdmins viewAdmins = new ViewAdmins();
            viewAdmins.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();
            this.Hide();
        }
    }
}