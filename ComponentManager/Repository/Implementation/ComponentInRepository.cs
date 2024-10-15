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
    public class ComponentInRepository : IComponentInRepository
    {
        private readonly ComponentContext context;
        private readonly IComponentRepository componentRepository;

        public ComponentInRepository(ComponentContext context, IComponentRepository componentRepository)
        {
            this.context = context;
            this.componentRepository = componentRepository;
        }
        public ComponentIn Create(ComponentIn componentIn)
        {
            context.ComponentsIn.Add(componentIn);
            context.SaveChanges();
            return componentIn;
        }
    }
}
