using Seatech.Domain.Common;
using System.ComponentModel.DataAnnotations;

namespace Seatech.Domain.Entities
{
    public class Category : EntityBase
    {
        [Key]
        public int CategoryId { get; set; }
        public string Title { get; set; }
        public int Order { get; set; }
        public Category? Parent { get; set; }
        public List<Category> SubCategories { get; set; }
        public ICollection<Product> Products { get; set; }


    }
}
