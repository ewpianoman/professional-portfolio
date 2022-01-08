using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using professional_portfolio.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace professional_portfolio.Controllers
{
    public class PortfolioController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            var portfolioItem = new PortfolioItem()
            {
                Title = "School of Piano Improv",
                Category = "Website",
                Description = "A website built on WordPress using the Divi Theme."
            };

            return View(portfolioItem);
        }
    }
}
