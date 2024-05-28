using SupermarketManagement.Presenters;
using SupermarketManagement.Views;

namespace SupermarketManagement
{
    public partial class AddAdminView : Form, IAddAdminView
    {
        private AddAdminPresenter presenter;
        private IViewAdmins viewAdmins;


        public AddAdminView()
        {
            InitializeComponent();
            presenter = new AddAdminPresenter(this);
        }

        public string Name => nameTxt.Text;
        public string Email => emailTxt.Text;
        public string PhoneNumber => numberTxt.Text;
        public string Password => passwordTxt.Text;

        public void CloseForm()
        {
            nameTxt.Text = string.Empty;
            nameTxt.Text = string.Empty;
            emailTxt.Text = string.Empty;
            numberTxt.Text = string.Empty;
            passwordTxt.Text = string.Empty;
        }

        public void ShowMessage(string message, string title)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // make validations////
        private void addAdminBtn_Click(object sender, EventArgs e)
        {
            presenter.addAdmin();

        }

        private void label4_Click_1(object sender, EventArgs e)
        {
            Category category = new Category();
            category.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            ViewProduct product = new ViewProduct();
            product.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            ViewCashiers casheir = new ViewCashiers();
            casheir.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            ViewAdmins admins = new ViewAdmins();
            admins.Show();
            this.Hide();
        }
    }
}
