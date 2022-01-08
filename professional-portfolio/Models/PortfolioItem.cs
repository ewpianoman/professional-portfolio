using System;

namespace professional_portfolio.Models
{
    public class PortfolioItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool Featured { get; set; }
        public Image[] Images { get; set; }
        public PortfolioItem[] RelatedProjects { get; set; }

        // title-cover.jpg
        public string CoverImageFileName
        {
            get
            {
                return Title.Replace(" ", "-")
                    .ToLower() + "-cover.jpg";
            }
        }

        public PortfolioItem()
        {
        }
    }
}
