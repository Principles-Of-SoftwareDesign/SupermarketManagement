using MySql.Data.MySqlClient;
using SupermarketManagement.Views;
using SupermarketManagement.Presenters;
using System.Windows.Forms;
using SupermarketManagement.Config;
using SupermarketManagement.Repositories;
using SupermarketManagement.Models;

namespace SupermarketManagement.Views
{
    public partial class ViewCashiers : Form, IViewCashiers
    {
        private ViewCashierPresenter presenter;
        //MySqlConnection conn;
        //MySqlCommand cmd;
        //MySqlDataReader reader;
        //dbConnection dbconn = new dbConnection();
        public ViewCashiers()
        {
            InitializeComponent();
            //string connectionString = new dbConnection().connect();
            ICashierRepository repository = new CashierRepository();
            presenter = new ViewCashierPresenter(this, repository);

            //to display all categories when the form loads
            this.Load += new System.EventHandler(this.ViewCashiers_Load);

            dataGridView1.CellClick += new DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            //btn_add.Click += new System.EventHandler(this.btn_add_Click);
            //btn_update.Click += new System.EventHandler(this.btn_update_Click);
            //btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
        }

        public string Name
        {
            get => nameTxt.Text;
            set => nameTxt.Text = value;
        }
        public string Email
        {

            get => emailTxt.Text;
            set => emailTxt.Text = value;
        }
        public string Password
        {

            get => passwordTxt.Text;
            set => passwordTxt.Text = value;
        }
        public string PhoneNumber
        {

            get => numberTxt.Text;
            set => numberTxt.Text = value;
        }

        public void setCashiersList(BindingSource cashiersList)
        {

            //dataGridView1.AutoGenerateColumns = false;
            //dataGridView1.Columns.Clear();
            //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "Id", DataPropertyName = "Id", HeaderText = "ID#" });
            //dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "Name", DataPropertyName = "Name", HeaderText = "Name" });
            //dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "Email", DataPropertyName = "Email", HeaderText = "Email" });
            //dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "PhoneNumber", DataPropertyName = "PhoneNumber", HeaderText = "Phone Number" });

            //dataGridView1.DataSource = cashiersList;
        }
        public void DisplayCashiers(IEnumerable<CashierModel> cashiers)
        {
            dataGridView1.Rows.Clear();
            foreach (var cashier in cashiers)
            {
                dataGridView1.Rows.Add(cashier.Name, cashier.Email, cashier.PhoneNumber, cashier.Password);
            }
        }
        public void CloseForm()
        {
            nameTxt.Clear();
            emailTxt.Clear();
            passwordTxt.Clear();
            numberTxt.Clear();
            //this.Hide();
            //new AddCashier();
        }
        public void ShowMessage(string message, string title)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ViewCashiers_Load(object sender, EventArgs e)
        {
            presenter.LoadAllList();
        }

        private void addCashierLabel_Click(object sender, EventArgs e)
        {


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void viewCashierLabel_Click(object sender, EventArgs e)
        {

        }


        private void addCashierLabel_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            presenter.DeleteCashier();
        }

        private void addAdminBtn_Click(object sender, EventArgs e)
        {
            presenter.UpdateCashier();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            presenter.addCashier();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            presenter.SelectCashier(e.RowIndex, dataGridView1);
        }

        private void numberLabel_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            presenter.addCashier();

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            presenter.UpdateCashier();

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            presenter.DeleteCashier();

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.Show();
            this.Hide();
        }
    }
}

