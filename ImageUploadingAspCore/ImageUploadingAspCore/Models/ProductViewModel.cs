using System.ComponentModel.DataAnnotations;

namespace ImageUploadingAspCore.Models
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        [Required]

        public string Name { get; set; } = null!;
        [Required]

        public int Price { get; set; }
        [Required]

        public IFormFile Photo { get; set; } = null!;

    }
}
