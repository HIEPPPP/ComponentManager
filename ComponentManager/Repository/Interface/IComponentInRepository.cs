using ComponentManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentManager.Repository.Interface
{
    public interface IComponentInRepository
    {
        ComponentIn Create(ComponentIn componentIn);
    }
}
