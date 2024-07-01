using System.ComponentModel.DataAnnotations.Schema;

namespace RestWithASPNetUdemy.Model.Base
{
    public class BaseEntity
    {
        [Column("id")]
        public long Id { get; set; }
    }
}
