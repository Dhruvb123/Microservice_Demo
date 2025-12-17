using ProductsAPI.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductsAPI.DTO
{
    public class ProductDTO
    {
        public Guid ProductId { get; set; }

        public string Name { get; set; }

        public string ShortDescription { get; set; }

        public string Description { get; set; }

        public string Category { get; set; }

        public decimal Price { get; set; }

        public decimal? DiscountPrice { get; set; }

        public bool IsInStock { get; set; }

        public bool ShowOnHomepage { get; set; }

        public List<ProductImage> Images { get; set; } = new();

        public List<ProductSpecification> Specifications { get; set; } = new();
    }
}
