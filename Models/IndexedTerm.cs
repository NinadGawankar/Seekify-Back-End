namespace Models
{
    public class IndexedTerm
    {
        public int TermID { get; set; }
        public required string Term { get; set; }
        public int PageID { get; set; }
        public int Frequency { get; set; }
    }
}