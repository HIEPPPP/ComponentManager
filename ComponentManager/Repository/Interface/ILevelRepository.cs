using ComponentManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentManager.Repository.Interface
{
    public interface ILevelRepository
    {
        List<ImportanceLevels> GetAll();
        ImportanceLevels Create(ImportanceLevels importanceLevels);
        ImportanceLevels Update(int id, ImportanceLevels importanceLevels); 
        ImportanceLevels Delete(int id);
    }
}
