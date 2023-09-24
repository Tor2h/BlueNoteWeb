namespace webapi.Models
{
    public class BookGenre
    {
        public Guid ID { get; set; }
        public Guid BookID { get; set; }
        public Guid GenreID { get; set; }
        public virtual Book? Book { get; set; }
        public virtual Genre? Genre { get; set; }
    }
}
