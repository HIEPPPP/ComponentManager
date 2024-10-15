using ComponentManager.Models;
using ComponentManager.Models.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentManager.Repository.Interface
{
    public interface IComponentInHisRepository
    {
        List<ComponentInDTO> GetAll();
    }
}
