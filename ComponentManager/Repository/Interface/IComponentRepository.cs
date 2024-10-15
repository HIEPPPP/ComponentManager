using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComponentManager.Models;
using ComponentManager.Models.DTO;

namespace ComponentManager.Repository.Interface
{
    public interface IComponentRepository
    {
        List<Component> GetAll();
        Component GetById(int id);
        Component Create(Component component);
        Component Update(int id, Component component);
        Component UpdateAmount(int id, Component component);
        Component Delete(int id);

    }
}
