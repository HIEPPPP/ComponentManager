using ComponentManager.Models;
using ComponentManager.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentManager.Services
{
    public class CategoryServices
    {
        private readonly ICategoryRepository categoryRepository;

        public CategoryServices(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        public Category CreateCategory(Category category)
        {
            return categoryRepository.Create(category);
        }

        public List<Category> GetAllCategories()
        {
            return categoryRepository.GetAll();
        }

    }
}
