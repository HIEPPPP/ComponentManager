using ComponentManager.Models;
using ComponentManager.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentManager.Services
{
    public class LevelServices
    {
        private readonly ILevelRepository levelRepository;

        public LevelServices(ILevelRepository levelRepository)
        {
            this.levelRepository = levelRepository;
        }

        public List<ImportanceLevels> GetListLevels()
        {
            return levelRepository.GetAll();
        }
    }
}
