using System.ComponentModel.DataAnnotations;

namespace ProductsAPI.Models
{
    public class ProductImage
    {
        [Key]
        public Guid ImgId { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        public int DisplayOrder { get; set; }  

        // FK
        public Guid ProductId { get; set; }
        public ProductModel Product { get; set; }
    }

}
