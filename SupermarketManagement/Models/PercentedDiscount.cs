﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagement.Models
{
    public class PercentedDiscount: IDiscount
    {
        public double DiscountAmount { get; private set; }

        public PercentedDiscount(double discountAmount)
        {
            this.DiscountAmount = discountAmount;
        }

        public void CalcDiscount()
        {
            MessageBox.Show($"Percentage discount applied: 10%");
        }
    }
}
