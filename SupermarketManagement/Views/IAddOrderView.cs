﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagement.Views
{
    public interface IAddOrderView
    {
        string ProductName { get; }
        string Amount { get; }

        void ShowMessage(string message, string title);
        void CloseForm();
    }
}
