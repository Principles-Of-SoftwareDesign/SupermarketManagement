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
    public partial class addOrder : Form , IAddOrderView
    {
        private AddOrderPresenter presenter;
        private IAddOrderView viewAdmins;


        public addOrder()
        {
            InitializeComponent();
            presenter = new AddOrderPresenter(this);
        }

        public string Name => txtname.Text;
        public string amount => txtquantity.Text;
        public string price => txtprice.Text;

        public void CloseForm()
        {
            txtname.Text = string.Empty;
            txtquantity.Text = string.Empty;
            txtprice.Text = string.Empty;
        }

        public void ShowMessage(string message, string title)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //hide password + make validations////
        private void addAdminBtn_Click(object sender, EventArgs e)
        {
            presenter.addOrder();
        }

    }
}
