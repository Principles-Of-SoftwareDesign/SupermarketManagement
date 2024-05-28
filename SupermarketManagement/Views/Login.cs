using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SupermarketManagement.Config;
using Org.BouncyCastle.Crypto.Generators;
using SupermarketManagement.Views;
using SupermarketManagement.Presenters;


namespace SupermarketManagement
{
    public partial class login : Form, ILoginView
    {
        private LoginPresenter presenter;
        private Hashing hashing;

        public string Email => txtUserName.Text;
        public string Password => txtpassword.Text;

        public login()
        {
            InitializeComponent();
            presenter = new LoginPresenter(this);
            //txtpassword.PasswordChar = '●';
            this.hashing = new Hashing();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            presenter.Login();

        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        public void OpenAdminView()
        {
            AddAdminView adminView = new AddAdminView();
            adminView.Show();
            this.Hide();
        }

        public void OpenCategoryView()
        {
            Category categoryView = new Category();
            categoryView.Show();
            this.Hide();
        }

        public void ClearForm()
        {
            txtUserName.Clear();
            txtpassword.Clear();
            txtUserName.Focus();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
