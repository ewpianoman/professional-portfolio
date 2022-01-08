using System;

namespace professional_portfolio.Models
{
    public class PortfolioItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string[] ImageURLs { get; set; }
        public bool Featured { get; set; }
        public Image[] Images { get; set; }

        public PortfolioItem()
        {
        }
    }
}
