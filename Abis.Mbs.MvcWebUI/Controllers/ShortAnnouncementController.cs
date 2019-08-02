using Abis.Mbs.Business.Abstract;
using Abis.Mbs.MvcWebUI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abis.Mbs.MvcWebUI.Controllers
{
    public class ShortAnnouncementController:Controller
    {
        private IShortAnnouncementService _shortAnnouncementService;

        public ShortAnnouncementController(IShortAnnouncementService shortAnnouncementService)
        {
            _shortAnnouncementService = shortAnnouncementService;
        }
        public ActionResult Index()
        {
          var shortAnnouncements= _shortAnnouncementService.GetAll();
            ShortAnnouncementListViewModel model = new ShortAnnouncementListViewModel
            {
                ShortAnnouncement = shortAnnouncements
            };
            return View(model);
        }
    }
}
