﻿using Abis.Mbs.Business.Abstract;
using Abis.Mbs.DataAccess.Concrete.EntityFramework;
using Abis.Mbs.Entities.Concrete;
using Abis.Mbs.MvcWebUI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
<<<<<<< HEAD
using System.Collections.Generic;
=======
using System.IO;
using static System.Net.Mime.MediaTypeNames;
>>>>>>> 9fbbd0e066d8447d4951cf1fe3deb4c14e322113

namespace Abis.Mbs.MvcWebUI.Controllers
{
    //[Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private IAnnouncementService _announcementService;
        // Add Job Announcement Service
        private IJobService _jobService;
        // Addd job application form
        private IJobFormService _jobformService;
        

        public AdminController(IAnnouncementService announcementService,
                            ICategoryService categoryService,
                            IJobService jobService,
                            IJobFormService jobformService)
        {
            _announcementService = announcementService;
            _jobService = jobService;
            _jobformService = jobformService;
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

                TempData["addjobmessage"] = "Job has been added sucessfully";
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

                TempData["updatejobmessage"] = "Job has been updated sucessfully";
            }
            return RedirectToAction("JobIndex");
        }

        public ActionResult DeleteJob(int JobId)
        {
            _jobService.Delete(JobId);

            TempData["deletejobmessage"] = "Job has been deleted sucessfully";
            return RedirectToAction("JobIndex");
        }

        //End Job

        // Announcement

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
        //,IFormFile image1
        [HttpPost]
        public ActionResult Add(Announcement announcement)
        {
            //var db = new MbsContext();
            //if(image1!=null)
            //{
            //    announcement.APhoto = new byte[image1.Length];
            //    BinaryReader reader = new BinaryReader(image1.OpenReadStream());
            //    announcement.APhoto = reader.ReadBytes((int)image1.Length);
            //}
            //db.Announcements.Add(announcement);
            //db.SaveChanges();
           
            //if (ModelState.IsValid && image1!=null)
            //{
            //    announcement.APhoto = new byte[image1.Length];
            //    BinaryReader reader = new BinaryReader(image1.OpenReadStream());
            //    announcement.APhoto = reader.ReadBytes((int)image1.Length);
            //    _announcementService.Add(announcement);

            //    TempData.Add("message", "Announcement was successfully added");
            //}
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

        // End Announcement

        // Job Form Application

        public ActionResult AddJobForm()
        {
            var model = new JobFormAddViewModel
            {
                JobForm = new JobForm(),
            };
            return View(model);
        }

        [HttpPost]
        public ActionResult AddJobForm(JobForm jobform)
        {
            if (ModelState.IsValid)
            {
                _jobformService.Add(jobform);

                TempData["applicationMessage"] = "Your application has been sent sucessfully";
            }
            return RedirectToAction("JobFormIndex");
        }

        // Job Form Index
        public ActionResult JobFormIndex()
        {
            var jobFormListViewModel = new JobFormListViewModel
            {
                JobForms = _jobformService.GetAll()
            };
            return View(jobFormListViewModel);
        }

        // End JobForm

        //public ActionResult FormIndex(int page = 1)
        //{
        //    // Use LINQ to get list of genres.


        //    var jobforms = _jobformService.GetAll();

        //    JobFormListViewModel model = new JobFormListViewModel
        //    {
        //        JobForms = jobforms
        //    };
        //    return View(model);
        //}



        //public ActionResult FormDetails(int id)
        //{
        //    var jobforms = _jobformService.GetById(id);
        //    JobFormViewModel model = new JobFormViewModel
        //    {
        //        JobForm = jobforms
        //    };
        //    return View(model);
        //}

    }
}
