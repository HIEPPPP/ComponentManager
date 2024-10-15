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
    public class NotiRepository : INotiRepository
    {
        private readonly ComponentContext context;

        public NotiRepository(ComponentContext context)
        {
            this.context = context;
        }
        public Noti Create(Noti noti)
        {
            context.Notis.Add(noti);
            context.SaveChanges();
            return noti;
        }

        public Noti Get()
        {
            var noti = context.Notis.Where(n => n.IsHandled == false).FirstOrDefault();
            return noti;
        }

        public Noti Update(int id, Noti noti)
        {
            var existNoti = context.Notis.Where(x => x.Id == id).FirstOrDefault();
            if (existNoti == null) return null;
            existNoti.IsHandled = true;
            context.SaveChanges();
            return existNoti;
        }
    }
}
