using System;
using professional_portfolio.Models;

namespace professional_portfolio.Data
{
    public class PortfolioItemRepository
    {
        private static PortfolioItem[] _portfolioItems = new PortfolioItem[]
        {
            new PortfolioItem()
            {
                Title = "School of Piano Improv",
                Category = "Website",
                Description = "A website built on WordPress using the Divi Theme.",
                Featured = true,
                Id = 1
            },
            new PortfolioItem()
            {
                Title = "Address Book",
                Category = "Console Application",
                Description = "A console application built with C#.",
                Featured = false,
                Id = 2
            },
            new PortfolioItem()
            {
                Title = "Collabra",
                Category = "Website",
                Description = "A website built on WordPress using the Divi Theme.",
                Featured = false,
                Id = 3
            }
    };

        public PortfolioItem GetPortfolioItem(int id)
        {
            PortfolioItem portfolioItemToReturn = null;

            foreach(var portfolioItem in _portfolioItems)
            {
                if (portfolioItem.Id == id)
                {
                    portfolioItemToReturn = portfolioItem;

                    break;
                }
            }

            return portfolioItemToReturn;
        }

        public PortfolioItemRepository()
        {
        }
    }
}
