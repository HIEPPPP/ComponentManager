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
    public class ComponentOutHisRepository : IComponentOutHisRepository
    {
        private readonly ComponentContext context;

        public ComponentOutHisRepository(ComponentContext context)
        {
            this.context = context;
        }
        public List<Models.DTO.ComponentOutDTO> GetList()
        {
            var query = @"select c.Model as Model, ISNULL(cOut.Quantity, 0) as Quantity, cOut.UsageDate as UsageDate, cOut.Reason as Reason, cOut.RequestBy as RequestBy, ISNULL(cOut.Amount, 0) as Amount, c.Name as Name, c.Provider as Provider, c.Category as Category from Component as c
                        join ComponentOut as cOut on c.Model = cOut.Model";
            var data = context.Database.SqlQuery<ComponentOutDTO>(query);
            return data.ToList();
        }       
    }
}
