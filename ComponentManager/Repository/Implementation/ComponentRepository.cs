using ComponentManager.Repository.Interface;
using System;
using System.Collections.Generic;
using ComponentManager.Models;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComponentManager.Data;
using ComponentManager.Models.DTO;
using System.Data.Entity;
using DevExpress.Utils;

namespace ComponentManager.Repository.Implementation
{
    public class ComponentRepository : IComponentRepository
    {
        private readonly ComponentContext context;

        public ComponentRepository(ComponentContext context)
        {
            this.context = context;
        }
        public Component Create(Component component)
        {
            context.Components.Add(component);
            context.SaveChanges();  
            return component;
        }

        public Component Delete(int id)
        {
            var existComponent = context.Components.FirstOrDefault(x => x.Id == id);
            if (existComponent == null)
            {
                return null;
            }
            context.Components.Remove(existComponent);
            context.SaveChanges();
            return existComponent;
        }

        public List<Component> GetAll()
        {           
            return context.Components.AsNoTracking().ToList();
        }

        public Component GetById(int id)
        {
            var existComponent = context.Components.FirstOrDefault(x => x.Id == id);    
            if(existComponent == null)
            {
                return null;    
            }
            return existComponent;
        }

        public Component Update(int id, Component component)
        {
            var existComponent = context.Components.FirstOrDefault(x => x.Id == id);
            if (existComponent == null)
            {
                return null;
            }
            existComponent.Name = component.Name;
            existComponent.Provider = component.Provider;   
            existComponent.Level = component.Level; 
            existComponent.Model = component.Model; 
            existComponent.Secssion = component.Secssion;   
            existComponent.Category = component.Category;
            existComponent.Min = component.Min;
            //existComponent.Amount = component.Amount;

            context.SaveChanges();
            return existComponent;
        }

        public Component UpdateAmount(int id, Component component)
        {
            var existComponent = context.Components.FirstOrDefault(x => x.Id == id);
            if (existComponent == null)
            {
                return null;
            }           
            existComponent.Amount = component.Amount;
            context.SaveChanges();
            return existComponent;
        }


    }
}
