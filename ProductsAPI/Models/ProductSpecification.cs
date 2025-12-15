using System.ComponentModel.DataAnnotations;

namespace ProductsAPI.Models
{
    public class ProductSpecification
    {
        [Key]
        public Guid SpecId { get; set; }

        [Required]
        [MaxLength(100)]
        public string SpecKey { get; set; }  

        [Required]
        [MaxLength(200)]
        public string SpecValue { get; set; } 

        // FK
        public Guid ProductId { get; set; }
        public ProductModel Product { get; set; }
    }

}
