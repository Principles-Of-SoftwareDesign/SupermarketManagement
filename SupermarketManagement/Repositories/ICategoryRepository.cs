﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SupermarketManagement.Models;

namespace SupermarketManagement.Repositories
{
    public interface ICategoryRepository
    {

        bool AddCategory(CategoryModel category);
    }
}
