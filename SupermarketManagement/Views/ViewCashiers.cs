using MySql.Data.MySqlClient;
using SupermarketManagement.Views;
using SupermarketManagement.Presenters;
using System.Windows.Forms;

namespace SupermarketManagement.Views
{
    public partial class ViewCashiers : Form, IViewCashiers
    {
        public ViewCashiers()
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

        public void setCashiersList(BindingSource cashiersList)
        {

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns.Clear();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "Id", DataPropertyName = "Id", HeaderText = "ID#" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "Name", DataPropertyName = "Name", HeaderText = "Name" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "Email", DataPropertyName = "Email", HeaderText = "Email" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "PhoneNumber", DataPropertyName = "PhoneNumber", HeaderText = "Phone Number" });

            dataGridView1.DataSource = cashiersList;
        }

        private void ViewCashiers_Load(object sender, EventArgs e)
        {
            //LoadAllList();
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
    }
}

