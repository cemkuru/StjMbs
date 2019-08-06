using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abis.Mbs.Business.Abstract;
using Abis.Mbs.MvcWebUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace Abis.Mbs.MvcWebUI.Controllers
{
    public class JobController : Controller
    {
        private IJobService _jobService;
        public JobController(IJobService jobService)
        {
            _jobService = jobService;
        }

        public ActionResult Index(string searchingString)
        {
            JobListViewModel model = new JobListViewModel();
            var jobs = from m in _jobService.GetAll() select m;
            if (!string.IsNullOrEmpty(searchingString))
            {
                
                jobs = jobs.Where(x => x.Area.Contains(searchingString));
            }
            return View(jobs.ToList());
        }
        // public async Task<ActionResult> Index( string searchString)
        //{
        //    var jobs = from m in _jobService.GetAll() select m;
        //    if (!string.IsNullOrEmpty(searchString))
        //    {
        //        jobs = jobs.Where(s => s.Area.Contains(searchString));

        //    }
        //    return View(jobs.ToList());
        //}

        public ActionResult Details(int id)
        {
            var jobs = _jobService.GetById(id);
            JobViewModel model = new JobViewModel
            {
                Job = jobs
            };
            return View(model);
        }
       

    }
}