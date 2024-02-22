using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class WebPage
    {
        [Key]
        public int PageID { get; set; }
        public required string URL { get; set; }
        public required string Title { get; set; }
        public required string Content { get; set; }
        public DateTime LastCrawledDate { get; set; }
    }
}