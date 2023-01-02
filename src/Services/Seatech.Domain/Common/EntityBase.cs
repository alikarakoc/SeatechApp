using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Seatech.Domain.Common
{
    public abstract class EntityBase
    {
     
        [MaxLength(32)]
        [Column(TypeName = "nvarchar(32)")]
        public string CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        [MaxLength(32)]
        [Column(TypeName = "nvarchar(32)")]
        public string ModifiedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        public bool Deleted { get; set; } = false;
        public bool Passive { get; set; } = false;
    }
}
