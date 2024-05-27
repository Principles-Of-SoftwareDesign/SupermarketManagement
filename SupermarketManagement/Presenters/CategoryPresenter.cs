using SupermarketManagement.Repositories;
using SupermarketManagement.Views;
using SupermarketManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagement.Presenters
{
    public class CategoryPresenter
    {
        private readonly ICategoryView view;
        private readonly ICategoryRepository repository;

        public CategoryPresenter(ICategoryView view, ICategoryRepository repository)
        {
            this.view = view;
            this.repository = repository;
        }
        public void LoadCategories()
        {
            var categories = repository.GetAllCategories();
            view.DisplayCategories(categories);
        }

        public void AddCategory()
        {
            if (string.IsNullOrEmpty(view.CategoryId) || string.IsNullOrEmpty(view.CategoryName))
            {
                view.ShowMessage("Please fill both the ID and Name fields!", "Add Category");
                return;
            }

            var category = new CategoryModel
            {
                CategoryID = int.Parse(view.CategoryId),
                Name = view.CategoryName
            };

            if (repository.AddCategory(category))
            {
                view.ShowMessage("Record saved successfully!", "Add Category");
                LoadCategories();
            }
            else
            {
                view.ShowMessage("Record save failed!", "Add Category");
            }
        }

    }
}
