using MySql.Data.MySqlClient;
using SupermarketManagement.Config;
using SupermarketManagement.Presenters;
using SupermarketManagement.Views;
using System.Windows.Forms;

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
            passwordTxt.PasswordChar = '*';
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

        //hide password + make validations////
        private void addAdminBtn_Click(object sender, EventArgs e)
        {
            presenter.addAdmin();
        }

        
    }
}
