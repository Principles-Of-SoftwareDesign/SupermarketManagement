using SupermarketManagement.Presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupermarketManagement.Views
{
    public partial class AddCashier : Form, IAddCashierView
    {
        private AddCashierPresenter presenter;
        private IViewCashiers viewCashiers;
        public AddCashier()
        {
            InitializeComponent();
            presenter = new AddCashierPresenter(this);
        }

        public string Name => nameTxt.Text;
        public string Email => emailTxt.Text;
        public string PhoneNumber => numberTxt.Text;
        public string Password => passwordTxt.Text;

        public void CloseForm()
        {
            this.Hide();
            new AddCashier();
        }

        public void ShowMessage(string message, string title)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void addAdminBtn_Click(object sender, EventArgs e)
        {
            presenter.addCashier();
        }
    }
}
