using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using WebNext.Data.ContentTypes;

namespace WebNext.Data.Pages
{
    public class Standard
    {
        public int ID { get; set; }
        
        [MaxLength(255)]
        public string Title { get; set; }

        [MaxLength(30)]
        public string ShortTitle { get; set; }

        [MaxLength(255)]
        public string Description { get; set; }

        public string Content { get; set; }

        public List<SiteImage> Images { get; set; }

        public List<SiteDocument> Documents { get; set; }
    }
}
