using ComponentManager.Data;
using ComponentManager.Models;
using ComponentManager.Models.DTO;
using ComponentManager.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentManager.Repository.Implementation
{
    public class ComponentOutRepository : IComponentOutRepository
    {
        private readonly ComponentContext context;

        public ComponentOutRepository(ComponentContext context)
        {
            this.context = context;
        }

        public ComponentOut Create(ComponentOut componentOut)
        {
            context.ComponentsOut.Add(componentOut);
            context.SaveChanges();
            return componentOut;
        }
    }
}
