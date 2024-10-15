using ComponentManager.Models;
using ComponentManager.Models.DTO;
using ComponentManager.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentManager.Services
{
    public class ComponentServices
    {
        private readonly IComponentRepository componentRepository;

        public ComponentServices(IComponentRepository componentRepository)
        {
            this.componentRepository = componentRepository;
        }

        public List<Component> GetListComponent()
        {
            return componentRepository.GetAll();
        }

        public Component GetComponent(int id)
        {
            var component = componentRepository.GetById(id);
            if (component == null)
            {
                return null;
            }
            return component;
        }

        public Component CreateComponent(Component component)
        {
            return componentRepository.Create(component);
        }

        public Component DeleteComponent(int id)
        {
            var component = componentRepository.Delete(id);
            if (component == null)
            {
                return null;
            }
            return component;
        }

        public Component UpdateComponent(int id, Component component)
        {
            var existComponent = componentRepository.Update(id, component);
            if (existComponent == null)
            {
                return null;
            }
            return existComponent;
        }

        public Component UpdateAmount(int id, Component component)
        {
            var existComponent = componentRepository.UpdateAmount(id, component);
            if (existComponent == null)
            {
                return null;
            }
            return existComponent;
        }

    }
}
