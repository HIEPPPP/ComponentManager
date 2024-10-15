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
    public class LevelRepository : ILevelRepository
    {
        private readonly ComponentContext context;

        public LevelRepository(ComponentContext context)
        {
            this.context = context;
        }
        public ImportanceLevels Create(ImportanceLevels importanceLevels)
        {
            throw new NotImplementedException();
        }

        public ImportanceLevels Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<ImportanceLevels> GetAll()
        {
            return context.ImportanceLevels.AsNoTracking().ToList();    
        }

        public ImportanceLevels Update(int id, ImportanceLevels importanceLevels)
        {
            throw new NotImplementedException();
        }
    }
}
