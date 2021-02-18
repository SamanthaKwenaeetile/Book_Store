using System;

namespace ClassLibrary
{
    public class clsStock
    {
        public long BookID { get; set; }
        public string BookName { get; set; }
        public bool InStock { get; set; }
        public int NumberAvailable { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}