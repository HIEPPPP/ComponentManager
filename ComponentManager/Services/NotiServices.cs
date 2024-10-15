using ComponentManager.Models;
using ComponentManager.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ComponentManager.Services
{
    public class NotiServices
    {
        private readonly INotiRepository notiRepository;

        public NotiServices(INotiRepository notiRepository)
        {
            this.notiRepository = notiRepository;
        }

        public Noti GetNoti()
        {
            return notiRepository.Get();
        }

        public Noti CreateNoti(Noti noti)
        {
            return notiRepository.Create(noti);
        }

        public Noti UpdateNoti(int id, Noti noti) 
        {
            var existNoti = notiRepository.Update(id, noti);
            if (existNoti == null) return null;
            return existNoti;
        }
    }
}
