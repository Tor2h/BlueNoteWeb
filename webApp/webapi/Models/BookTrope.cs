namespace webapi.Models
{
    public class BookTrope
    {
        public Guid ID { get; set; }
        public Guid BookID { get; set; }
        public Guid TropeID { get; set; }
        public virtual Book? Book { get; set; }
        public virtual Trope? Trope { get; set; }
    }
}
