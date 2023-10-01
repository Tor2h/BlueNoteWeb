using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace webapi.Models
{
    public class Genre
    {
        public Guid ID { get; set; }
        public string? Name { get; set; }
    }
}