namespace webapi.Models
{
    public class Book
    {
        public string? AaName { get; set; }
        public string? Author { get; set; }
        public string? Series { get; set; }
        public List<Trope>? Tropes { get; set; }
        public bool OwnedOrWish { get; set; }
        public List<Genre>? Genres { get; set; }
        public Status Status { get; set; }
        public Score Score { get; set; }
        public string? Comment { get; set; }
    }
    public enum Status
    {
        NotStarted,
        CurrentlyReading,
        Read,
        WantToReadSoon
    }
    public enum Score
    {
        One,
        Two,
        Three,
        Four,
        Five
    }
}
