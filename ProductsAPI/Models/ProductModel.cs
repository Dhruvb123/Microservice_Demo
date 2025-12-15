using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductsAPI.Models
{
    public class ProductModel
    {
        [Key]
        public Guid ProductId { get; set; }

        [Required]
        [MaxLength(200)]
        public string Name { get; set; }

        [MaxLength(500)]
        public string ShortDescription { get; set; }

        public string Description { get; set; }

        [Required]
        [MaxLength(100)]
        public string Category { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal? DiscountPrice { get; set; }

        public int StockQuantity { get; set; }

        public bool IsInStock => StockQuantity > 0;

        public bool IsActive { get; set; }

        public bool ShowOnHomepage { get; set; }

        [Required]
        public string MainImageUrl { get; set; }

        public List<ProductImage> Images { get; set; } = new();

        public List<ProductSpecification> Specifications { get; set; } = new();

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime? UpdatedAt { get; set; }

    }
}
