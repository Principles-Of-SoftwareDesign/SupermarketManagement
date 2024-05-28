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

        private void passwordTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
