using Seatech.Domain.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Seatech.Domain.Entities
{
    public class Product : EntityBase
    {
        [Key]
        public int ProductId { get; set; }
        public string Name { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        public Category Category { get; set; }

    }
}
