using Abis.Mbs.Business.Abstract;
using Abis.Mbs.MvcWebUI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abis.Mbs.MvcWebUI.Controllers
{
    public class AnnouncementController : Controller
    {
        private IAnnouncementService _announcementService;
        public AnnouncementController(IAnnouncementService announcementService)
        {
            _announcementService = announcementService;
        }
        public ActionResult Index(int page = 1)
        {

            var announcements = _announcementService.GetAll();
            AnnouncementListViewModel model = new AnnouncementListViewModel
            {
                Announcements = announcements
            };
            return View(model);
        }
    }
}
