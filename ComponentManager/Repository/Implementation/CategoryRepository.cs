using ComponentManager.Data;
using ComponentManager.Models;
using ComponentManager.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentManager.Repository.Implementation
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ComponentContext context;

        public CategoryRepository(ComponentContext context)
        {
            this.context = context;
        }

        public Category Create(Category category)
        {
            throw new NotImplementedException();
        }

        public Category Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAll()
        {
            return context.Categories.AsNoTracking().ToList();
        }

        public Category Update(int id, Category category)
        {
            throw new NotImplementedException();
        }
    }
}
