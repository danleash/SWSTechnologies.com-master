using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SWSTechnologies1.Models;
using Microsoft.EntityFrameworkCore;
using System.Web;
using Microsoft.Extensions.Configuration;

namespace SWSTechnologies.Controllers
{
    public class HomeController : Controller
    {
        private readonly SWSTechDBContext sWSTechDBContext;
        public HomeController(SWSTechDBContext sWSTechDBContext)
        {
            this.sWSTechDBContext = sWSTechDBContext;
        }
        public ViewResult Index()
        {
            return View("HomePage");
        }
        
        public ViewResult About()
        {
            return View("About");
        }
        public ViewResult Testimonials()
        {
            return View("Testimonials");
        }
        public ViewResult ContactClientForm()
        {
            ViewBag.Message = "How can we help you?";
            return View("ContactClientForm");
        }


    }
}
