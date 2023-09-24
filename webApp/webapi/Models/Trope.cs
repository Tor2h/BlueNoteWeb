using System.ComponentModel.DataAnnotations;

namespace webapi.Models
{
    public class Trope
    {
        public Guid ID { get; set; }
        public string? Name { get; set; }
        public virtual List<BookTrope> BookTropes { get; set; } = new();
    }
}
