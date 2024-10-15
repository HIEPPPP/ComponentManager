using ComponentManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentManager.Repository.Interface
{
    public interface ICategoryRepository
    {
        List<Category> GetAll();
        Category Create(Category category);

        Category Update(int id, Category category);
        Category Delete(int id);
    }
}
