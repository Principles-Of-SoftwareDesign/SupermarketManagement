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
    public partial class Invoice : Form, IInvoiceView
    {
        private InvoicePresenter presenter;
        public string code => discountTxt.Text;

        public Invoice()
        {
            InitializeComponent();
            presenter=new InvoicePresenter(this);
        }

        public Invoice(InvoicePresenter presenter)
        {
            this.presenter = presenter;
        }

        public void SetPresenter(InvoicePresenter presenter)
        {
            this.presenter = presenter ?? throw new ArgumentNullException(nameof(presenter));
        }


        public void ShowDiscountApplied(string discountMessage)
        {
            MessageBox.Show(discountMessage);
        }

        public void ShowErrorMessage(string message)
        {
            MessageBox.Show($"Error: {message}");
        }
        private void discountBtn_Click(object sender, EventArgs e)
        {

            presenter.ApplyDiscount(code);

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
} 
