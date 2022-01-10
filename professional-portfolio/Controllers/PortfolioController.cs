using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using professional_portfolio.Data;
using professional_portfolio.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace professional_portfolio.Controllers
{
    public class PortfolioController : Controller
    {
        private PortfolioItemRepository _portfolioItemRepository = null;

        public PortfolioController()
        {
            _portfolioItemRepository = new PortfolioItemRepository();
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var portfolio = _portfolioItemRepository.GetPortfolioItems();

            return View(portfolio);
        }

        public IActionResult Item(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var portfolioItem = _portfolioItemRepository.GetPortfolioItem((int)id);

            return View(portfolioItem);
        }
    }
}
