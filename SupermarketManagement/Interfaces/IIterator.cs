﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagement.Interfaces
{
    public interface IIterator
    {
        bool HasNext();
        object Next();
    }
}