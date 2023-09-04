using System.ComponentModel.DataAnnotations;

namespace webapi.Models
{
    public class Trope
    {
        [Key]
        public int ID { get; set; }
        public string? Name { get; set; }
    }
}
