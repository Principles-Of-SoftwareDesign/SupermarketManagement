using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagement.Models
{
    public class CategoryModel
    {
        private int id;
        private int category_id;
        private string name;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public int CategoryID
        {
            get { return category_id; }
            set { category_id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
