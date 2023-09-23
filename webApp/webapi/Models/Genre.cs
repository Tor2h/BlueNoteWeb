using System.ComponentModel.DataAnnotations;

namespace webapi.Models
{
    public class Genre
    {
        [Key]
        public int ID { get; set; }
        public string? Name { get; set; }
    }
}