using System.ComponentModel.DataAnnotations;

namespace webapi.Models
{
    public class Book
    {
        public Guid ID { get; set; }
        public string? AaName { get; set; }
        public string? Author { get; set; }
        public string? Series { get; set; }
        public bool OwnedOrWish { get; set; }
        public Status Status { get; set; }
        public Score Score { get; set; }
        public string? Comment { get; set; }
        public virtual List<BookTrope>? BookTropes { get; set; }
        public virtual List<BookGenre>? BookGenres { get; set; }
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
