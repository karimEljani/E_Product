using System.ComponentModel.DataAnnotations;

namespace TP_Product.ViewModels
{
    public class EditViewModel
    {
        public int ProductId { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 5)]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Prix en dinar :")]
        public float Price { get; set; }

        [Required]
        [Display(Name = "Quantité en unité :")]
        public int QteStock { get; set; }

        public int CategoryId { get; set; }

        // Facultative : si null, l'image existante est conservée
        [Display(Name = "Image :")]
        public IFormFile ImagePath { get; set; }

        public string ExistingImagePath { get; set; }
    }
}
