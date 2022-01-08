using System;
namespace professional_portfolio.Models
{
    public class Image
    {
        public int Id { get; set; }
        public string FilePath { get; set; }
        public string Title { get; set; }
        public string Alt { get; set; }

        public Image()
        {
        }
    }
}
