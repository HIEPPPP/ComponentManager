using ComponentManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentManager.Repository.Interface
{
    public interface INotiRepository
    {
        Noti Get();
        Noti Create(Noti noti);
        Noti Update(int id, Noti noti);
    }
}
