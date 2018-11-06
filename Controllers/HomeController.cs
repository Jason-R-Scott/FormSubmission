using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using FormSubmission.Models;

namespace FormSubmission.Controllers
{
    public class HomeController : Controller
    {
        // GET: /Home/
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet ("Create")]
        public IActionResult Success ()
        {
            return View("Create");
        }

        [HttpPost ("Create")]
        public IActionResult Create (User user)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("Create");
            }
            else
            {
                return View ("Index");
            }
        }
    }
}
