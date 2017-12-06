using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TechJobs.Models;
using System;

namespace TechJobs.Controllers
{
    public class SearchController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.columns = ListController.columnChoices;
            ViewBag.title = "Search";
            return View();
        }

        public IActionResult Results(string searchTerm, string searchType)
        {
            if (searchType == "all")
            {
                var jobs = JobData.FindByValue(searchTerm);
                ViewBag.columns = ListController.columnChoices;
                ViewBag.jobs = jobs;
                return View("Index");

            }
            else
            {
                var jobs = JobData.FindByColumnAndValue(searchType, searchTerm);
                ViewBag.columns = ListController.columnChoices;
                ViewBag.jobs = jobs;
                return View("Index");
            }
                
        }

    }
}
