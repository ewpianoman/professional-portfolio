using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace professional_portfolio.Controllers
{
    public class AboutController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewBag.PageTitle = "About";
            ViewBag.PageDescription = "<p>This is the About page.</p>";
            ViewBag.Degrees = new string[]
            {
                "BA in Music Education",
                "MS in Music Technology"
            };

            return View();
        }
    }
}
