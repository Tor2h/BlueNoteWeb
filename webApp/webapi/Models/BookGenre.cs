using Newtonsoft.Json;

namespace webapi.Models
{
    public class BookGenre
    {
        public Guid ID { get; set; }
        public Guid BookID { get; set; }
        public Guid GenreID { get; set; }
        [JsonIgnore]
        public virtual Book? Book { get; set; }
        [JsonIgnore]
        public virtual Genre? Genre { get; set; }
    }
}
