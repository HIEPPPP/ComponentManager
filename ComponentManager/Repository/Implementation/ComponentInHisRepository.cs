using ComponentManager.Data;
using ComponentManager.Models;
using ComponentManager.Models.DTO;
using ComponentManager.Repository.Interface;
using DevExpress.Data.Helpers;
using DevExpress.Utils.Animation;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentManager.Repository.Implementation
{
    public class ComponentInHisRepository : IComponentInHisRepository
    {
        private readonly ComponentContext context;

        public ComponentInHisRepository(ComponentContext context)
        {
            this.context = context;
        }

        public List<ComponentInDTO> GetAll()
        {
            //var data = from c in context.Components
            //           join cIn in context.ComponentsIn on c.Model equals cIn.Model into componentGroup
            //           from cg in componentGroup.DefaultIfEmpty()
            //           select new ComponentInDTO
            //           {                           
            //               Model = c.Model,
            //               Quantity = cg != null ? cg.Quantity : 0,
            //               NgayNhap = cg != null ? cg.NgayNhap : DateTime.Today,
            //               Provider = c.Provider,
            //               Price = cg != null ? cg.Price : 0,
            //               Note = cg != null ? cg.Note : "",
            //               Name = c.Name,
            //               Category = c.Category,
            //               Amount = cg != null ? cg.Amount : 0,
            //           };

            var data = from c in context.Components
                       join cIn in context.ComponentsIn on c.Model equals cIn.Model 
                       select new ComponentInDTO
                       {
                           Model = c.Model,
                           Quantity = cIn != null ? cIn.Quantity : 0,
                           NgayNhap = cIn != null ? cIn.NgayNhap : DateTime.Today,
                           Provider = c.Provider,
                           Price = cIn != null ? cIn.Price : 0,
                           Note = cIn != null ? cIn.Note : "",
                           Name = c.Name,
                           Category = c.Category,
                           Amount = cIn != null ? cIn.Amount : 0,
                       };
            return data.ToList();            
        }


    }
}
