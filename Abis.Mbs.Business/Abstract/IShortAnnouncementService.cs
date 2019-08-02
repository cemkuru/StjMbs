using Abis.Mbs.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abis.Mbs.Business.Abstract
{
   public  interface IShortAnnouncementService
    {
        List<ShortAnnouncement> GetAll();
        List<ShortAnnouncement> GetByCategory(int ID); 
        void Add(ShortAnnouncement shortAnnouncement);
        void Update(ShortAnnouncement shortAnnouncement);
        void Delete(int ID);
        ShortAnnouncement GetById(int ID);

    }
}
