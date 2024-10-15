using ComponentManager.Models;
using ComponentManager.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentManager.Services
{
    public class ComponentOutServices
    {
        private readonly IComponentOutRepository componentOutRepository;

        public ComponentOutServices(IComponentOutRepository componentOutRepository)
        {
            this.componentOutRepository = componentOutRepository;
        }

        public ComponentOut CreateComponentOut(ComponentOut componentOut)
        {
            return componentOutRepository.Create(componentOut);
        }
    }
}
