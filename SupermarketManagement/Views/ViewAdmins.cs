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

        public event EventHandler AddEvent;
        public event EventHandler ViewEvent;
        public event EventHandler EditEvent;



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
    }
}