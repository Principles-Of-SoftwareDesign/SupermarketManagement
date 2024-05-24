using MySql.Data.MySqlClient;
using SupermarketManagement.Views;
using SupermarketManagement.Presenters;

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
            dataGridView1.DataSource = adminsList;
        }

        private void ViewAdmins_Load(object sender, EventArgs e)
        {
            //LoadAllList();
        }
    }
}