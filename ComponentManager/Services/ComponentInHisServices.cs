using ComponentManager.Models;
using ComponentManager.Models.DTO;
using ComponentManager.Repository.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentManager.Services
{
    public class ComponentInHisServices
    {
        private readonly ComponentInHisRepository componentInRepository;

        public ComponentInHisServices(ComponentInHisRepository componentInRepository)
        {
            this.componentInRepository = componentInRepository;
        }
        public List<ComponentInDTO> GetListComponentIn()
        {
            return componentInRepository.GetAll();
        }
    }
}
