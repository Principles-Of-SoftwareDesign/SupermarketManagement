using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagement.Models
{
    public class AdminModel:UserModel
    {
        public AdminModel()
        {
            Role = 1; // Set the role to "admin"
        }

        private List<CategoryModel> categories = new List<CategoryModel>();

        public List<CategoryModel> Categories
        {
            get { return categories; }
            set { categories = value; }
        }
    }
}
