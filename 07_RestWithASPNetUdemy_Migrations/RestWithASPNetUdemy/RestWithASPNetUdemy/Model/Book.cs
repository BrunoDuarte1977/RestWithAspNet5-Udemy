using System.ComponentModel.DataAnnotations.Schema;

namespace RestWithASPNetUdemy.Model
{
    [Table("books")]
    public class Book
    {
        [Column("id")]
        public long Id { get; set; }

        [Column("author")]
        public string Author { get; set; }

        [Column("launch_date")]
        public DateTime LaunchDate { get; set; }

        [Column("price")]
        public Decimal Price { get; set; }

        [Column("title")]
        public string Title { get; set; }
    }
}
