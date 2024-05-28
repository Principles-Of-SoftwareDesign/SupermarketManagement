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
        private readonly IInvoicePresenter presenter;
        public string Code => discountTxt.Text;

        public Invoice()
        {
            InitializeComponent();
        }

        public Invoice(IInvoicePresenter presenter)
        {
            this.presenter = presenter;
        }

        public void ShowTotalPrice(double totalPrice)
        {
            Console.WriteLine($"Total Price: {totalPrice}");
        }

        public void ShowDiscountApplied(string discountMessage)
        {
            Console.WriteLine(discountMessage);
        }

        public void ShowErrorMessage(string message)
        {
            Console.WriteLine($"Error: {message}");
        }
        private void discountBtn_Click(object sender, EventArgs e)
        {

            presenter.ApplyDiscount(Code);

        }
    }
} 
