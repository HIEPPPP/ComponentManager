using ComponentManager.Models;
using ComponentManager.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentManager.Services
{
    public class ComponentInServices
    {
        private readonly IComponentInRepository componentInRepository;

        public ComponentInServices(IComponentInRepository componentInRepository)
        {
            this.componentInRepository = componentInRepository;
        }

        public ComponentIn CreateComponentIn(ComponentIn componentIn)
        {
            return componentInRepository.Create(componentIn);
        }
    }
}
