
namespace Models
{
    public class SearchQuery
    {
        public int QueryID { get; set; }
        public string Query { get; set; }
        public DateTime SearchDate { get; set; }
        public int UserID { get; set; }
    }
}