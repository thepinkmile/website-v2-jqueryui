using System;
using System.ComponentModel.DataAnnotations;

namespace WebNext.Data.ContentTypes
{
    public class SiteDocument
    {
        public int ID { get; set; }

        [MaxLength(255)]
        public string Name { get; set; }

        public string Description { get; set; }

        [MaxLength(100)]
        public string MimeType { get; set; }

        [MaxLength(255)]
        public string FileName { get; set; }

        public Guid FileReference { get; set; }
    }
}
