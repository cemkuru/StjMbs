using Abis.Mbs.Business.Abstract;
using Abis.Mbs.Entities.Concrete;
using Abis.Mbs.MvcWebUI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Abis.Mbs.MvcWebUI.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private IAnnouncementService _announcementService;
        // Add Job Announcement Service
        private IJobService _jobService;
        

        public AdminController(IAnnouncementService announcementService, ICategoryService categoryService, IJobService jobService)
        {
            _announcementService = announcementService;
            _jobService = jobService;
        }
        //Job Index
        public ActionResult JobIndex()
        {
            var jobListViewModel = new JobListViewModel
            {
                Jobs = _jobService.GetAll()
            };
            return View(jobListViewModel);
        }
       

        //Add Job
        public ActionResult AddJob()
        {
            var model = new JobAddViewModel
            {
                Job = new Job(),
            };
            return View(model);
        }


        // POST/Add Job
        [HttpPost]
        public ActionResult AddJob(Job job)
        {
            if (ModelState.IsValid)
            {
                _jobService.Add(job);
                TempData.Add("message", "Job has been added sucessfully");
            }
            return RedirectToAction("JobIndex");
        }

        // Update Job
        public ActionResult UpdateJob(int JobId)
        {
            var model = new JobUpdateViewModel
            {
                Job = _jobService.GetById(JobId),
            };
            return View(model);
        }

        // POST/Update Job
        [HttpPost]
        public ActionResult UpdateJob(Job job)
        {
            if (ModelState.IsValid)
            {
                _jobService.Update(job);

                TempData.Add("message", "Job was successfully updated");
            }

            return RedirectToAction("JobIndex");
        }



        public ActionResult DeleteJob(int JobId)
        {
            _jobService.Delete(JobId);

            TempData.Add("message", "Job was successfully deleted");
            return RedirectToAction("JobIndex");
        }

        // Anouncement
        public ActionResult Index()
        {
            var announcementListViewModel = new AnnouncementListViewModel
            {
                Announcements = _announcementService.GetAll()
            };
            return View(announcementListViewModel);
        }

        public ActionResult Add()
        {
            var model = new AnnouncementAddViewModel
            {
                Announcement = new Announcement(),
                
            }; 
            return View(model);
        }

        [HttpPost]
        public ActionResult Add(Announcement announcement)
        {
            if (ModelState.IsValid)
            {
                _announcementService.Add(announcement);

                TempData.Add("message", "Announcement was successfully added");
            }

            return RedirectToAction("Index");
        }

        public ActionResult Update(int announcementId)
        {
            var model = new AnnouncementUpdateViewModel
            {
                Announcement = _announcementService.GetById(announcementId),
                
            };

            return View(model);

        }

        [HttpPost]
        public ActionResult Update(Announcement announcement)
        {
            if (ModelState.IsValid)
            {
                _announcementService.Update(announcement);
                TempData.Add("message", "Announcement was successfully updated");
            }

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int announcementId)
        {
            _announcementService.Delete(announcementId);
            TempData.Add("message", "Announcement was successfully deleted");
            return RedirectToAction("Index");
        }

    }
}
