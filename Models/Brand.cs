using System.ComponentModel.DataAnnotations;

namespace Appala_poo.com.Models
{
    public class Brand
    {
        [Key]
        public Guid Id { get; set; }


        [Required]
        public string Name { get; set; }

        [Display(Name="Manufacturing Date")]
        public int ManufacturingDate { get; set; }

        [Display(Name = "Expired Date")]
        public int ExpiredDate {  get; set; }

        [Display(Name = "Brand Image")]
        public string BrandImage {  get; set; } 

    }
}
